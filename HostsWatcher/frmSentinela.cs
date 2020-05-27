﻿using DataLayer;
using HostsWatcher.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Security.Principal;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace HostsWatcher {
    public partial class frmSentinela : Form {
        private int _alteracoes = -1;
        private readonly string _logFile = $"{Path.GetDirectoryName(Application.ExecutablePath)}\\log.txt";

        public static bool IsAdministrator =>
            new WindowsPrincipal(WindowsIdentity.GetCurrent())
                .IsInRole(WindowsBuiltInRole.Administrator);

        public frmSentinela() {
            InitializeComponent();
            Run();
        }

        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        private void Run() {
            if (!IsAdministrator) {
                MessageBox.Show("Programa não está sendo executado como 'Administrador'" +
                    "\n\nAlterações não serão feitas.",
                    "Sentinela", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBoxMode.Image = Resources.Non_Administrator_icon96;
                toolTip.SetToolTip(pictureBoxMode, "Não administrador - não poderá fazer alterações");
            }
            Log("Iniciando", Color.White, true);

            // Create a new FileSystemWatcher and set its properties.
            FSW_Hosts.Path = HostsManager.HostsLocation;
            FSW_Hosts.Filter = "hosts";

            // Watch for changes in LastAccess and LastWrite times, and
            // the renaming of files or directories.
            FSW_Hosts.NotifyFilter =
                NotifyFilters.LastAccess | NotifyFilters.LastWrite |
                NotifyFilters.FileName | NotifyFilters.DirectoryName;

            FSW_License.Path = @"C:\Program Files (x86)\Common Files\IObit\Advanced SystemCare";
            FSW_License.NotifyFilter =
                NotifyFilters.LastAccess | NotifyFilters.LastWrite |
                NotifyFilters.FileName | NotifyFilters.DirectoryName;

            CheckNow();

            // Begin watching.
            //FSW_Hosts.EnableRaisingEvents = true;
            //FSW_License.EnableRaisingEvents = true;
        }

        #region FORM ---------------------
        private void Form_Shown(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;

            //to hide from taskbar
            this.Hide();
        }

        private void Form_FormClosing(object sender, FormClosingEventArgs e) {
            Log("Encerrando", Color.Aqua, true);
            Log("", Color.Aqua);
        }

        private void Form_Resize(object sender, EventArgs e) {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState != FormWindowState.Minimized) {
                return;
            }

            Hide();
            notifyIcon.Visible = true;
        }
        #endregion FORM ---------------------

        // Define the event handlers.
        private void OnChanged(object source, FileSystemEventArgs e) {
            // Specify what is done when a file is changed, created, or deleted.
            Log($"{e.ChangeType}", Color.LightBlue, true);
            CheckNow();
        }

        private void CheckNow() {
            CheckHosts();
            CheckLicense();
        }

        private void CheckLicense() {
            FSW_License.EnableRaisingEvents = false;

            var licenças = Directory.GetFiles($"{Application.StartupPath}\\licença").Select(f => new FileInfo(f)).ToArray();

            var issues = new List<string>();
            foreach (var licença in licenças) {
                var arquivo = Directory.GetFiles(FSW_License.Path, licença.Name)
                    .Select(f => new FileInfo(f)).FirstOrDefault();
                if (arquivo != null && arquivo.LastWriteTime <= licença.LastWriteTime) {
                    Log($"Arquivo {licença.Name} OK.", Color.LightBlue);
                    continue;
                }
                if (arquivo == null) {
                    var issue = $"Arquivo {licença.Name} não encontrado.";
                    Log(issue, Color.Orange);
                    issues.Add(issue);
                }
                else {
                    var issue = $"Arquivo {licença.Name} alterado.";
                    File.Delete(arquivo.FullName);
                    Log(issue, Color.Yellow);
                    issues.Add(issue);
                }

                File.Copy(licença.FullName, $"{FSW_License.Path}\\{licença.Name}");
                Log($"Arquivo {licença.Name} restaurado do backup.", Color.LightCoral);
            }
            if (issues.Any()) {
                ShowPopup(string.Join("Arquivos restaurados do backup:\n\n", issues.ToArray()));
            }

            FSW_License.EnableRaisingEvents = true;
        }

        private void CheckHosts() {
            FSW_Hosts.EnableRaisingEvents = false;
            var hm = new HostsManager();
            if (!hm.Read(out var message)) {
                Log(message, Color.LightCoral);
                FSW_Hosts.EnableRaisingEvents = true;
                return;
            }

            hm.Test();

            if (hm.SitesFound.Any()) {
                Log($"{hm.SitesFound.Count()} site(s) encontrados.", Color.LightGreen);
            }

            if (hm.SitesMissing.Any()) {
                Log($"{hm.SitesMissing.Count()} site(s) faltando.", Color.LightCoral);
            }

            if (IsAdministrator) {
                try {
                    hm.Write(out var message2);
                    Log($"{message2}", Color.LightBlue);
                    ShowPopup(message2);
                }
                catch (Exception ex) {
                    Log($"Erro ao gravar arquivo hosts: {ex.Message}", Color.Yellow);
                    Log("Possível causa: este programa precisa ser executado como 'Administrador'.",
                        Color.White);
                }
            }

            FSW_Hosts.EnableRaisingEvents = true;
        }

        private void ShowPopup(string mensagem) {
            var popup = new PopupNotifier {
                TitleText = "SENTINELA",
                ContentText = mensagem,
                Image = Resources.Police_icon_24,
                TitleFont = new Font("Segoe UI", 18),
                ContentFont = new Font("Segoe UI", 12)
            };
            popup.Popup();
        }

        private void OnRenamed(object source, RenamedEventArgs e) =>
            // Specify what is done when a file is renamed.
            Log($"Renomeado como {e.FullPath}", Color.LightBlue);

        private void OnDeleted(object sender, FileSystemEventArgs e) {
            Log($"Arquivo deletado", Color.LightBlue);
        }

        private void Log(string text, Color color, bool includeTime = false) {
            notifyIcon.BalloonTipText = $"{++_alteracoes} alterações";

            text = includeTime ? $"{DateTime.Now:G} {text}" : $"\t{text}";

            RTB.SelectionFont = new Font("Segoe UI", 12);
            RTB.SelectionColor = color;
            RTB.AppendText(text);
            RTB.AppendText("\n");

            try {
                using (var w = File.AppendText(_logFile)) {
                    w.WriteLine(text, w);
                }
            }
            catch (Exception) {
            }
        }

        #region NOTIFY ICON ---------------------
        private void notifyIcon_DoubleClick(object sender, EventArgs e) {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void notifyIcon_Click(object sender, EventArgs e) {
            //notifyIcon.ShowBalloonTip(1000);
        }

        private void toolStripMenuItemOnOff_Click(object sender, EventArgs e) {
            checkBoxOnOff.Checked = !checkBoxOnOff.Checked;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        #endregion NOTIFY ICON ---------------------

        private void checkBoxOnOff_CheckedChanged(object sender, EventArgs e) {
            FSW_Hosts.EnableRaisingEvents = checkBoxOnOff.Checked;
            if (checkBoxOnOff.Checked) {
                checkBoxOnOff.Image = Resources.switch_on_icon64;
                toolStripMenuItemOnOff.Image = Resources.switch_off_icon32;
                toolStripMenuItemOnOff.Text = "Desligar";
                Log("Ligado", Color.DarkKhaki, true);
            }
            else {
                checkBoxOnOff.Image = Resources.switch_off_icon64;
                toolStripMenuItemOnOff.Image = Resources.switch_on_icon32;
                toolStripMenuItemOnOff.Text = "Ligar";
                Log("Desligado", Color.DarkKhaki, true);
            }
        }

        private void buttonCheckNow_Click(object sender, EventArgs e) {
            Log($"Checagem manual", Color.LightBlue, true);
            CheckNow();
        }

        private void buttonEdit_Click(object sender, EventArgs e) {
            FSW_Hosts.EnableRaisingEvents = false;
            var frm = new frmEditor() { AllowSave = IsAdministrator, FullName = HostsManager.Hostsfile };
            frm.ShowDialog();
            FSW_Hosts.EnableRaisingEvents = true;
        }

        private void buttonEditLog_Click(object sender, EventArgs e) {
            var frm = new frmEditor() { AllowSave = true, FullName = _logFile };
            frm.ShowDialog();
        }
    }
}
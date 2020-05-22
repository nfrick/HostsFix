using DataLayer;
using System;
using System.IO;
using System.Windows.Forms;

namespace HostsWatcher {
    public partial class frmEditor : Form {
        private bool MustSave;
        public bool AllowSave { get; set; }
        public string FullName { get; set; }

        private string _fileName;

        public frmEditor() {
            InitializeComponent();
        }


        private void frmEditor_Load(object sender, EventArgs e) {
            toolStripButtonSave.Visible = AllowSave;
            _fileName = Path.GetFileName(FullName);
            this.Text = $"Editor {_fileName}";
            ReadFile();
        }

        private bool ReadFile() {
            try {
                using (var sr = new StreamReader(FullName)) {
                    textBoxEditor.Text = sr.ReadToEnd();
                }
                textBoxEditor.SelectionStart = 0;
                MustSave = true;
                return true;
            }
            catch (Exception) {
                return false;
            }
        }

        private void WriteFile() {
            try {
                using (var sw = new StreamWriter(FullName)) {
                    sw.Write(textBoxEditor.Text);
                }
                MustSave = false;
            }
            catch (Exception ex) {
                var message = $"Erro ao gravar arquivo {_fileName}: {ex.Message}";
                MessageBox.Show(message, "Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBoxEditor_TextChanged(object sender, System.EventArgs e) {
            MustSave = true;
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e) {
            WriteFile();
        }

        private void toolStripButtonRead_Click(object sender, EventArgs e) {
            if (AllowSave && MustSave && MessageBox.Show($"Alterações em  {_fileName} serão perdidas. Confirma?",
                    $"Reler arquivo {_fileName}", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No) {
                return;
            }
            ReadFile();
        }

        private void frmEditor_FormClosing(object sender, FormClosingEventArgs e) {
            if (!AllowSave || !MustSave || MessageBox.Show($"Salvar alterações em  {_fileName}?",
                    "Editor", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes) {
                return;
            }

            WriteFile();
        }
    }
}

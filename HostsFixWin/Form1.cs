using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;


namespace HostsFixWin {
    public partial class Form1 : Form {
        private int number = 0;
        Assembly thisExe;
        private string[] instrucoes;
        const string serial = "55377-C3F35-752FA-1A4D6";

        public Form1() {
            InitializeComponent();
            thisExe = Assembly.GetExecutingAssembly();

            // Como listar os nomes dos resources 
            instrucoes = thisExe.GetManifestResourceNames().Where(r => r.EndsWith("PNG")).OrderBy(r => r).ToArray();
        }

        private void button_Click(object sender, EventArgs e) {
            var btn = (Control) sender;

            switch (btn.Name) {
                case "buttonFirst":
                    number = 0;
                    break;
                case "buttonPrevious":
                    number--;
                    break;
                case "buttonNext":
                    number++;
                    break;
                case "buttonLast":
                    number = instrucoes.Length - 1;
                    break;
            }
            ShowImage();
        }

        private void ShowImage() {
            //var image = $"HostsFixWin.Instruções.Instruções {number}.PNG";
            var file = thisExe.GetManifestResourceStream(instrucoes[number]);
            this.pictureBox1.Image = Image.FromStream(file);
            label1.Text = $"{number + 1} de {instrucoes.Length}";
            buttonFirst.Enabled = buttonPrevious.Enabled = number > 0;
            buttonNext.Enabled = buttonLast.Enabled = number < instrucoes.Length - 1;
        }

        private void Form1_Load(object sender, EventArgs e) {
            const string hostfile = @"c:\Windows\System32\drivers\etc\hosts";
            
            var sites = new[] {
                new Site("asc.iobit.com"),
                new Site("asc55.iobit.com"),
                new Site("idb.iobit.com"),
                new Site("is360.iobit.com"),
                new Site("iunins.iobit.com"),
                new Site("pf.iobit.com")
            };

            string text;

            try {
                using (var sr = new StreamReader(hostfile)) {
                    text = sr.ReadToEnd().Replace("\r\n\r\n\r\n", "\r\n");
                }
            }
            catch (Exception ex) {
                WriteInColor($"Erro ao abrir arquivo hosts: {ex.Message}", Color.LightCoral);
                return;
            }

            foreach (var site in sites) {
                site.IsMissing = !text.Contains(site.Url);
                WriteInColor($"Testando {site.Url}... ", Color.LightSkyBlue);
                if (site.IsMissing)
                    WriteInColor("û\n", Color.LightCoral, true);
                else
                    WriteInColor("ü\n", Color.LawnGreen, true);
            }

            if (sites.Any(s => s.IsMissing)) {
                try {
                    using (var sw = new StreamWriter(hostfile)) {
                        sw.Write(text);
                        foreach (var site in sites.Where(s => s.IsMissing)) {
                            WriteInColor("\nAcrescentando ", Color.White);
                            WriteInColor($"{site.Url}", Color.LightSkyBlue);
                            sw.WriteLine($"{site.Line}");
                        }
                        WriteInColor("\n\nO serial number ", Color.White);
                        WriteInColor(serial, Color.LawnGreen);
                        WriteInColor(" foi copiado para o Clipboard, veja nas instruções como colá-lo no Systemcare.", Color.White);
                        Clipboard.SetText(serial);
                        textBox1.Text = serial;
                        ShowImage();
                    }
                }
                catch (Exception ex) {
                    WriteInColor($"\nErro ao gravar arquivo: {ex.Message}", Color.Yellow);
                    WriteInColor("\n\nPossível causa: este programa precisa ser executado como 'Administrador'.", Color.White);
                    tabControl1.TabPages.Remove(tabInstrucoes);
                    Height /= 2;
                }
            }
            else {
                tabControl1.TabPages.Remove(tabInstrucoes);
                WriteInColor("\nArquivo hosts está OK, nada a acrescentar.", Color.LawnGreen);
                Height /= 2;
            }
        }

        private void WriteInColor(string text, Color color, bool wingding = false) {
            richTextBox1.SelectionFont = wingding ? new Font("Wingdings", 14) : new Font("Segoe UI", 14);
            richTextBox1.SelectionColor = color;
            richTextBox1.AppendText(text);
        }

        private void buttonCopiar_Click(object sender, EventArgs e) {
            Clipboard.SetText(serial);
        }
    }

    public class Site {
        public string Url { get; }
        public bool IsMissing { get; set; }
        public string Line => $"127.0.0.1\t{Url}";

        public Site(string u) {
            Url = u;
        }
    }
}

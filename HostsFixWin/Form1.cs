using DataLayer;
using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;


namespace HostsFixWin {
    public partial class Form1 : Form {
        private int number;
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
            var btn = (Control)sender;

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
            var file = thisExe.GetManifestResourceStream(instrucoes[number]);
            this.pictureBox1.Image = Image.FromStream(file);
            label1.Text = $"{number + 1} de {instrucoes.Length}";
            buttonFirst.Enabled = buttonPrevious.Enabled = number > 0;
            buttonNext.Enabled = buttonLast.Enabled = number < instrucoes.Length - 1;
        }

        private void Form1_Load(object sender, EventArgs e) {
            var hm = new HostsManager();
            if (!hm.Read(out var text)) {
                Log(text, Color.LightCoral);
                return;
            }

            hm.Test();
            foreach (var site in hm.Sites) {
                Log($"Testando {site.Url}... ", Color.LightSkyBlue);
                if (site.Found) {
                    Log("ü\n", Color.LawnGreen, true);
                }
                else {
                    Log("û\n", Color.LightCoral, true);
                }
            }

            try {
                if (hm.Write(out var message)) {  // true if file was changed
                    Log($"\n{message}", Color.LightCoral);
                    textBox1.Text = serial;
                    ShowImage();
                }
                else {
                    tabControl1.TabPages.Remove(tabInstrucoes);
                    Log($"\n{message}", Color.LawnGreen);
                    Height /= 2;
                }
                Log("\n\nO serial number ", Color.White);
                Log(serial, Color.LightSkyBlue);
                Log(" foi copiado para o Clipboard.", Color.White);
                Clipboard.SetText(serial);
            }
            catch (Exception ex) {
                Log($"\nErro ao gravar arquivo: {ex.Message}", Color.Yellow);
                Log("\n\nPossível causa: este programa precisa ser executado como 'Administrador'.",
                    Color.White);
                tabControl1.TabPages.Remove(tabInstrucoes);
                Height /= 2;
            }
        }

        private void Log(string text, Color color, bool wingding = false) {
            richTextBox1.SelectionFont = wingding ? new Font("Wingdings", 14) : new Font("Segoe UI", 14);
            richTextBox1.SelectionColor = color;
            richTextBox1.AppendText(text);
        }

        private void buttonCopiar_Click(object sender, EventArgs e) {
            Clipboard.SetText(serial);
        }
    }
}

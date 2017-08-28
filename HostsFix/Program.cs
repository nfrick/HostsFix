using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HostsFix {
    internal class Program {

        [STAThread]
        public static void Main(string[] args) {

            const string hostfile = @"c:\Windows\System32\drivers\etc\hosts";
            const string serial = "55377-C3F35-752FA-1A4D6";

            var sites = new[] {
                new Site("asc.iobit.com"),
                new Site("asc55.iobit.com"),
                new Site("idb.iobit.com"),
                new Site("is360.iobit.com"),
                new Site("iunins.iobit.com"),
                new Site("pf.iobit.com")
            };

            var text = string.Empty;

            WriteInColor(" ┌──────────────────────┐\n", ConsoleColor.Yellow);
            WriteInColor(" │ HOSTS FIX            │\n", ConsoleColor.Yellow);
            WriteInColor(" │ by Nelson Frick 2017 │\n", ConsoleColor.Yellow);
            WriteInColor(" └──────────────────────┘", ConsoleColor.Yellow);

            try {
                using (var sr = new StreamReader(hostfile)) {
                    text = sr.ReadToEnd();
                }
            }
            catch (Exception e) {
                WriteInColor($"\n Erro ao abrir arquivo hosts: {e.Message}", ConsoleColor.Red);
            }

            foreach (var s in sites) {
                s.IsMissing = !text.Contains(s.Url);
            }

            if (sites.Any(s => s.IsMissing)) {
                try {
                    using (var sw = new StreamWriter(hostfile)) {
                        sw.Write(text);
                        foreach (var site in sites.Where(s => s.IsMissing)) {
                            WriteInColor("\n Acrescentando ", ConsoleColor.White);
                            WriteInColor($"{site.Url}", ConsoleColor.Cyan);
                            sw.WriteLine(site.Line);
                        }
                        WriteInColor("\n\n O serial number ", ConsoleColor.White);
                        WriteInColor(serial, ConsoleColor.Green);
                        WriteInColor(" foi copiado para o Clipboard, não se esqueça de colá-lo no Systemcare.", ConsoleColor.White);
                        Clipboard.SetText(serial);
                    }
                }
                catch (Exception e) {
                    WriteInColor($"\n Erro ao gravar arquivo: {e.Message}", ConsoleColor.Red);
                }
            }
            else {
                WriteInColor("\n Arquivo hosts está OK, nada a acrescentar.", ConsoleColor.Green);
            }

            WriteInColor("\n\n Atualização terminada, aperte Enter. ", ConsoleColor.White);
            Console.ReadLine();
        }

        private static void WriteInColor(string text, ConsoleColor color) {
            Console.ForegroundColor = color;
            Console.Write(text);
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

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace DataLayer {

    public static class SitesFactory {
        public static Site[] GetSites() => new[] {
            new Site("98.129.229.186"),
            new Site("asc.iobit.com"),
            new Site("asc55.iobit.com"),
            new Site("iana.org"),
            new Site("idb.iobit.com"),
            new Site("is360.iobit.com"),
            //new Site("iunins.iobit.com"),
            new Site("pf.iobit.com"),
            new Site("www.iana.org")
        };
    }

    public class Site {
        public string Url { get; }
        public bool Found { get; set; }
        public string Line => $"127.0.0.1\t{Url}";

        public Site(string u) {
            Url = u;
        }

        public void FindInFile(string text) {
            Found = text.Contains(Url);
        }

        public bool Missing => !Found;
    }

    public class HostsManager {
        public const string Hostsfile = @"c:\Windows\System32\drivers\etc\hosts";
        //private const string Hostsfile = @"d:\teste\hosts";

        public static string HostsLocation => @"c:\Windows\System32\drivers\etc";

        public Site[] Sites;

        public string[] HostsText { get; private set; }

        public HostsManager() {
            Sites = SitesFactory.GetSites();
        }

        public bool Read(out string message) {
            try {
                using (var sr = new StreamReader(Hostsfile)) {
                    var text = sr.ReadToEnd().Replace("\r\n\r\n\r\n", "\r\n");
                    HostsText = Regex.Split(text, "\r\n|\r|\n");
                    message = string.Empty;
                    return true;
                }
            }
            catch (Exception ex) {
                message = $"Erro ao abrir arquivo hosts: {ex.Message}";
                return false;
            }
        }

        public void Test() {
            var text = string.Join("\r\n",
                HostsText.SkipWhile(l => !l.StartsWith("# iobit begin")).Skip(1)
                .TakeWhile(l => !l.StartsWith("# iobit end")));

            foreach (var site in Sites) {
                site.FindInFile(text);
            }
        }

        public IEnumerable<Site> SitesFound => Sites.Where(s => s.Found);
        public IEnumerable<Site> SitesMissing => Sites.Where(s => s.Missing);

        public bool Write(out string message) {
            if (!SitesMissing.Any()) {
                message = "Arquivo hosts está OK, nada a acrescentar.";
                return false;
            }

            using (var sw = new StreamWriter(Hostsfile)) {
                sw.Write(string.Join("\r\n", HostsText.TakeWhile(l => !l.StartsWith("# iobit begin"))));

                sw.WriteLine($"\r\n# iobit begin - {Sites.Length} itens");
                foreach (var site in Sites) {
                    sw.WriteLine($"{site.Line}");
                }

                sw.Write(string.Join("\r\n", HostsText.SkipWhile(l => !l.StartsWith("# iobit end"))));
            }

            var missing = string.Join(", ", SitesMissing.Select(s => s.Url));
            message = $"Sites acrescentados: {missing}";
            return true;
        }
    }
}
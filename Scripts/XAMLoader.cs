using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace OrganiZer {
    public class XAMLoader {
        private static ParserContext pc;

        private static void Init() {
            pc = new ParserContext();
            pc.XmlnsDictionary.Add("", "http://schemas.microsoft.com/winfx/2006/xaml/presentation");
            pc.XmlnsDictionary.Add("x", "http://schemas.microsoft.com/winfx/2006/xaml");
        }

        public static object Load(string x) {
            if (pc == null)
                Init();
            try {
                using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(x)))
                    return XamlReader.Load(ms, pc);
            } catch(Exception e) {
                return null;
            }
        }
    }
}

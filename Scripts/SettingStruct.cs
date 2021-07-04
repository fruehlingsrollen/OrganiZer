using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganiZer {
    public struct SettingStruct {
        private static readonly string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Organizer";

        public static string GetFolderPath() => folderPath;
        public SettingStruct Clone() => this;
        public void Set(SettingStruct a) => this = a;
    }
}

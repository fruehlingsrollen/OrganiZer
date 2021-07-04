using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganiZer {
    public class NoteManager {
        private static readonly string noteSavePath = SettingStruct.GetFolderPath() + @"\notes.txt";

        public string GetNotePath() => noteSavePath;


    }
}

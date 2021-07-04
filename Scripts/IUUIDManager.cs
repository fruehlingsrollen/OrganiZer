using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganiZer {
    public abstract class IUUIDManager {

        private string uuid;

        public string GetUUID() => uuid;

        public void GenerateUUID() {
            if (!string.IsNullOrEmpty(uuid))
                uuid = Guid.NewGuid().ToString();
        }

        public void RegenerateUUID() {
            uuid = null;
            GenerateUUID();
        }
    }
}

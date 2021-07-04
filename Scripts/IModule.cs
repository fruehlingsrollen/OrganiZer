using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganiZer {
    public abstract class IModule : IUUIDManager {

        private string xamlSerialized;

        public abstract string title { get; set; }

        public Point position;

        public Point scale;

        public int transparency;

        public abstract void Reload();

        public abstract string GetXAMLSerialized();
    }
}

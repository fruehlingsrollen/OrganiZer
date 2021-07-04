using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OrganiZer {
    /// <summary>
    /// Interaction logic for NoteDetailEnter.xaml
    /// </summary>
    public partial class NoteDetailEnter : Window {

        private string overhang;

        private string description;

        public string GetDescriptionText() => description;

        public string GetOverhangText() => overhang;

        public NoteDetailEnter() {
            InitializeComponent();
            NoteOverhang.KeyDown += (s, e) => { if (e.Key == Key.Enter) { NoteDescription.Focus(); } };
            NoteDescription.KeyDown += (s, e) => {
                if (e.Key == Key.Enter) {
                    overhang = NoteOverhang.Text;
                    description = NoteDescription.Text;
                    this.Close();
                }
            };
        }
    }
}

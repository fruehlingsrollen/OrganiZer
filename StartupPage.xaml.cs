using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFFolderBrowser;
using System.Windows.Markup;
using System.Xml;

namespace OrganiZer {
    /// <summary>
    /// Interaction logic for StartupPage.xaml
    /// </summary>
    public partial class StartupPage : Page {
        public StartupPage() {
            InitializeComponent();
        }

        private void NewNote(object sender, RoutedEventArgs e) {
            Note note = new Note("Unnamed Note", "Unnamed Note");
            NoteDetailEnter nde = new NoteDetailEnter();
            


            nde.ShowDialog();

            note.ChangeText(nde.GetOverhangText(), nde.GetDescriptionText());

            NotePanel.Children.Add(note.GetElement());
        }
    }
}

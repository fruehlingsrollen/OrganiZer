using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace OrganiZer {
    public class Note : IUUIDManager {

        public Note(string overhangText, string description) {
            ChangeText(overhangText, description);
        }

        private static readonly string xamlSerialized = @"<Border Height=""80"" VerticalAlignment=""Top"" Margin=""20,15,20,0"" CornerRadius=""8"" Background=""Black""><Grid Margin=""5"" Background=""Black""><Grid.RowDefinitions><RowDefinition Height=""0.8*""/><RowDefinition/></Grid.RowDefinitions><TextBlock Foreground=""#dfdfdf"" Margin=""4,0,0,0"" FontSize=""18""/><Separator Background=""#101010"" Grid.Column=""0"" VerticalAlignment=""Bottom"" Height=""2"" Style=""{StaticResource {x:Static ToolBar.SeparatorStyleKey}}""/><TextBlock Grid.Row=""1"" Margin=""4,3,0,0"" TextWrapping=""WrapWithOverflow"" Foreground=""#dfdfdf""/></Grid></Border>";

        private UIElement element = (UIElement)XAMLoader.Load(GetXAMLSerialized());

        public string overhangText;

        public string description;

        private List<IModule> modules;

        public UIElement GetElement() => element;

        public static UIElement GetStaticElement() => (UIElement)XAMLoader.Load(GetXAMLSerialized());

        public static string GetXAMLSerialized() => xamlSerialized;

        public static void ChangeText(UIElement e, string overhangText, string description) {
            UIElementCollection children = ((Grid)((Border)e).Child).Children; //main element is border, child of that is grid, grid then 3 children, two of them are textblocks (first one is overhang)

            TextBlock overhangTb = (TextBlock)children[0];
            TextBlock descriptionTb = (TextBlock)children[2];

            if(!string.IsNullOrEmpty(overhangText) || !string.IsNullOrEmpty(description)) {
                overhangTb.Text = overhangText;
                descriptionTb.Text = description;
            }
        }

        public void SetModules(params IModule[] modules) {

        }

        public void ChangeText(string overhangText, string description) => ChangeText(element, overhangText, description);
    }
}

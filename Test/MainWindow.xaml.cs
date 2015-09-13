using System.Windows;
using System.Windows.Controls;

namespace Test
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var tb = XamlQuery.XamlQuery.Search(this, "TextBlock");
            tb.ForEach(i => ((TextBlock)i).FontSize = 34);
            tb.Style("Text: hello world").Animate(WidthProperty, 5000, 10, 500);
            tb.SlideDown(5000);
        }
    }
}
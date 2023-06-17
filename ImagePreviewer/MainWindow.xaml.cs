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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace ImagePreviewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string[]? strImageFiles;

        private void btnGetFiles_Click(object sender, RoutedEventArgs e)
        {
            strImageFiles = Directory.GetFiles(@"c:/temp/Images", "*.jp??");
            tbImageFiles.Text = string.Join("\r\n", strImageFiles);

//            var imageFiles2 = Directory.EnumerateFiles(@"c:/temp/Images", "*.jp??");
            var imageFiles2 = Directory.EnumerateFiles(@"c:/temp/Images", "*.*", SearchOption.TopDirectoryOnly)
            .Where(s => s.EndsWith(".jpg") || s.EndsWith(".jpeg") || s.EndsWith(".bmp") || s.EndsWith(".gif") || s.EndsWith(".tiff") || s.EndsWith(".png"));
            foreach (string currentFile in imageFiles2)
            {
                tbImageFiles2.Text += currentFile + "\r\n";
            }


        }
    }
}

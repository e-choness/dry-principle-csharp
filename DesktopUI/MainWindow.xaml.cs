using System.Windows;
using DryFrameworkLibrary.Services;

namespace DesktopUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent(); 
        }

        private void BtnGenerateId_OnClick(object sender, RoutedEventArgs e)
        {
            var processor = new ProductProcessor();
        }

        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTitle.Text) && !lsTitles.Items.Contains(txtTitle.Text))
            {
                lsTitles.Items.Add(txtTitle.Text);
                txtTitle.Clear();
            }
        }
    }
}
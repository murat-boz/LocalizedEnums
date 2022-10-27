using System.Collections.Generic;
using System.Globalization;
using System.Windows;

namespace LocalizedEnums.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.UpdateSource();
        }

        private void Turkish_Click(object sender, RoutedEventArgs e)
        {
            var info = new CultureInfo("tr-TR");

            CultureInfo.DefaultThreadCurrentCulture   = info;
            CultureInfo.DefaultThreadCurrentUICulture = info;

            this.UpdateSource();
        }

        private void English_Click(object sender, RoutedEventArgs e)
        {
            var info = new CultureInfo("en-US");

            CultureInfo.DefaultThreadCurrentCulture   = info;
            CultureInfo.DefaultThreadCurrentUICulture = info;

            this.UpdateSource();
        }

        private void UpdateSource()
        {
            this.ComboBox.SelectedItem = null;
            this.ComboBox.ItemsSource  = new List<Status> { Status.Bad, Status.Good };
        }
    }
}

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M01Ex008
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

        private async void btnSortear_Click(object sender, RoutedEventArgs e)
        {
            int start;
            int.TryParse(txtStart.Text, out start);
            int end;
            int.TryParse(txtEnd.Text, out end);
            Random gerador = new Random();
            int n = gerador.Next(start, end+1);

            lblAnswer.Content = $"Sorteando entre {start} e {end}.";
            await Task.Delay(1000);
            lblAnswer.Content = $"Sorteando entre {start} e {end}..";
            await Task.Delay(1000);
            lblAnswer.Content = $"Sorteando entre {start} e {end}...";
            await Task.Delay(1500);
            lblAnswer.Content = $"Sorteei o número: {n}.";
        }
    }
}
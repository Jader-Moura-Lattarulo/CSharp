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

namespace M01Ex006
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

        private void btn01_Click(object sender, RoutedEventArgs e)
        {
            int atual = DateTime.Now.Year;
            int nasc;
            int.TryParse(txtAno.Text, out nasc);
            int idade = atual - nasc;
            ans01.Content = $"Estamos no ano de {atual}.";
            ans02.Content = $"Quem nasceu em {nasc:D} vai ter {idade:D} anos.";
            panResult.Visibility = Visibility.Visible;
        }
    }
}
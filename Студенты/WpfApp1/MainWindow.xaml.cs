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
using WpfApp1.Class;
using static WpfApp1.Class.Class1;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Class1> Inf_data = new List<Class1>();
        public MainWindow()
        {
            InitializeComponent();
Inf_data.Add(item: new Class1() { name = "Иванова И.И.", num_name = "И-12345", grupp = "ЭИ - 18", pay = "не оплатил", vupusk = " не выпустился" });
            Baby.ItemsSource = Inf_data;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Inf_data[0].name = ИФО.Text;
            Inf_data[0].num_name = Spiderman.Text;
            Inf_data[0].grupp = KylieJenner.Text;
            Inf_data[0].pay = AX.Text;
            Inf_data[0].vupusk = OX.Text;
        }

        private void Baby_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}

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

namespace Microcalculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Dictionary<int, string> interestByDay = new Dictionary<int, string>(35);
            interestByDay.Add(1, "Russia");
            interestByDay.Add(3, "Great Britain");
            interestByDay.Add(2, "USA");
            interestByDay.Add(4, "France");
            interestByDay.Add(5, "China");
        }

    }
}

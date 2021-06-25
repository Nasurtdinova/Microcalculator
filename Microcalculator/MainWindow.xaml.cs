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
          

        }
        public void GetpProcessing()
        {
            string s = tbInterest.Text;
            string[] new_array = s.Split(';');

            
            string day = new_array[0].Split(':')[0];
            string processing = new_array[0].Split(':')[1];
            if (day == tbSrok.Text)
            {

            }
            MessageBox.Show(day);
            MessageBox.Show(processing);
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            GetpProcessing();
        }
    }
}

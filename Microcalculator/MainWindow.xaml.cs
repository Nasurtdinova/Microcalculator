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
            string[] new_array = new string[25];
            for (int i = 0; i < s.Length; i++)
            {
                new_array = s.Split(';');
                
            }
            string[] array2 = new string[25];
            for (int j = 0; j < new_array.Length-1; j++)
            {
                string processing = new_array[j].Split(':')[1];
                array2[j] = processing;
                MessageBox.Show(processing);
            }
            int sumProcessing = 0;
            for (int k = 1; k < array2.Length + 1; k++)
            {
                
                sumProcessing = Convert.ToInt32(array2[k]) * 100 + sumProcessing;
                //if (k == Convert.ToInt32(tbSrok.Text))
                //{
                //    tbSumProcessing.Text = Convert.ToString(sumProcessing);
                //}

            }





            //string day = new_array[0].Split(':')[0];
            //string processing = new_array[0].Split(':')[1];
            //if (day == tbSrok.Text)
            //{
            //    int r = Convert.ToInt32(tbSumProcessing.Text);
            //    r = Convert.ToInt32(tbSum.Text) * Convert.ToInt32(processing);
            //}

        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            GetpProcessing();
        }
    }
}

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
            List <double> processings = new List<double>();
            double[] array2 = new double[26];
            for (int j = 0; j < new_array.Length-1; j++)
            {
                string processing = new_array[j].Split(':')[1];
                array2[j] = Convert.ToDouble(processing);
                processings.Add(Convert.ToDouble(processing));
                    
                MessageBox.Show(processing);
            }
            double sumProcessing = 0;
            double obSum = 0;
          
            foreach (int i in processings)
            {
                double toDoub = Convert.ToDouble(array2[i]);
                sumProcessing = toDoub * 100 + sumProcessing;
                obSum = sumProcessing + Convert.ToDouble(tbSum.Text);
                if (i == Convert.ToInt32(tbSrok.Text))
                {
                    tbSumProcessing.Text = Convert.ToString(sumProcessing);
                    tbObSum.Text = Convert.ToString(obSum);
                }
                
            }
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            GetpProcessing();
        }
    }
}

using Microsoft.Win32;
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
            double[] new_array2 = new double[26];
            for (int j = 0; j < new_array.Length-1; j++)
            {
                string processing = new_array[j].Split(':')[1];
                new_array2[j] = Convert.ToDouble(processing);
                processings.Add(Convert.ToDouble(processing));

            }
            double sumProcessing = 0;
            double obSum = 0;
            double effect = 0;
            for (int i = 0; i < Convert.ToInt32(tbSrok.Text)+1; i++)
            {
                double toDoub = Convert.ToDouble(new_array2[i]);
                sumProcessing = toDoub * 100 + sumProcessing;
                obSum = sumProcessing + Convert.ToDouble(tbSum.Text);
                tbSumProcessing.Text = Convert.ToString(sumProcessing);
                tbObSum.Text = Convert.ToString(obSum);
 
            }
            lbScore.Items.Add(Convert.ToString(sumProcessing));
            lbScore.Items.Add(Convert.ToString(obSum));
            effect = sumProcessing / Convert.ToDouble(tbSum.Text) / Convert.ToInt32(tbSrok.Text);
            tbEffective.Text = Convert.ToString(effect);
            lbScore.Items.Add(Convert.ToString(effect));
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            GetpProcessing();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:\Users\201914\Desktop\calc\save.txt"))
            {
                for (int i = 0; i < lbScore.Items.Count; i++)
                    sw.WriteLine(lbScore.Items[i].ToString());
            }
        }

        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {
            using (System.IO.StreamReader sw = new System.IO.StreamReader(@"C:\Users\201914\Desktop\calc\load.txt"))
            {
                tbInterest.Text = sw.ReadLine();
            }
        }
    }
}

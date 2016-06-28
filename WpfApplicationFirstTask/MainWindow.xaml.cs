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
using System.IO;

namespace WpfApplicationFirstTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double xCoordinate;
        double yCoordinate;


        public MainWindow()
        {
            InitializeComponent();
            StreamReader streamReader = File.OpenText(@"K:\Epam C Sharp dot net\textFile.txt");
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                string[] doubles = line.Split(' ');
                for (int j = 0; j < doubles.Length; j++)
                {
                    if (j % 2 != 0)
                    {
                        yCoordinate = double.Parse(doubles[j]);
                        xCoordinate = double.Parse(doubles[j - 1]);
                    }
                }
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            xCoordinate = double.Parse(textBox.Text);
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            yCoordinate = double.Parse(textBox1.Text);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Text = "X: " + xCoordinate + " Y: " + yCoordinate;
        }
    }
}

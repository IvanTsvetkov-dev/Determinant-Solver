using MethodGauss;
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

namespace DeterminantSolver
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double[,] completedMatrix = FetchCooeficents();

            double solved = Gauss.SolveDeterminant(completedMatrix);

            result.Content = "det(A)=" + solved.ToString();
        }

        private double[,] FetchCooeficents()
        {
            double[,] res = new double[Gauss.sizeMatrix, Gauss.sizeMatrix];
            res[0, 0] = double.Parse(a00.Text);
            res[0, 1] = double.Parse(a01.Text);
            res[0, 2] = double.Parse(a02.Text);
            res[0, 3] = double.Parse(a03.Text);

            res[1, 0] = double.Parse(a10.Text);
            res[1, 1] = double.Parse(a11.Text);
            res[1, 2] = double.Parse(a12.Text);
            res[1, 3] = double.Parse(a13.Text);

            res[2, 0] = double.Parse(a20.Text);
            res[2, 1] = double.Parse(a21.Text);
            res[2, 2] = double.Parse(a22.Text);
            res[2, 3] = double.Parse(a23.Text);

            res[3, 0] = double.Parse(a30.Text);
            res[3, 1] = double.Parse(a31.Text);
            res[3, 2] = double.Parse(a32.Text);
            res[3, 3] = double.Parse(a33.Text);

            return res;
        }

    }
}

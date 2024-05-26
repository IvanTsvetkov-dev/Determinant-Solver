using MethodGauss;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

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

            double[,] completedMatrix = Fetch_Cooeficents();

            double solved = Gauss.SolveDeterminant(completedMatrix);

            determinantMatrixA.Content = "det(A)=" + solved.ToString();
        }

        private double[,] Fetch_Cooeficents()
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

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Устанавливаем свойства диалогового окна
            openFileDialog.Filter = "(.txt)|*.txt";
            openFileDialog.Multiselect = false;

            // Открываем диалоговое окно при нажатии клавиши
            bool? result = openFileDialog.ShowDialog();

            if (result == true)
            {
                string[] content = MatrixFileOperation.ReadMatrix(openFileDialog);

                Insert_Elements_Matrix(content);
            }
        }

        private void Insert_Elements_Matrix(string[] elementsMatrix)
        {
            try
            {
                a00.Text = elementsMatrix[0];
                a01.Text = elementsMatrix[1];
                a02.Text = elementsMatrix[2];
                a03.Text = elementsMatrix[3];

                a10.Text = elementsMatrix[4];
                a11.Text = elementsMatrix[5];
                a12.Text = elementsMatrix[6];
                a13.Text = elementsMatrix[7];

                a20.Text = elementsMatrix[8];
                a21.Text = elementsMatrix[9];
                a22.Text = elementsMatrix[10];
                a23.Text = elementsMatrix[11];

                a30.Text = elementsMatrix[12];
                a31.Text = elementsMatrix[13];
                a32.Text = elementsMatrix[14];
                a33.Text = elementsMatrix[15];
            } 
            catch(IndexOutOfRangeException)
            {
                return;
            }
        }

        private void Clear_Elements_Matrix()
        {
            a00.Clear();
            a01.Clear();
            a02.Clear();
            a03.Clear();

            a10.Clear();
            a11.Clear();
            a12.Clear();
            a13.Clear();

            a20.Clear();
            a21.Clear();
            a22.Clear();
            a23.Clear();

            a30.Clear();
            a31.Clear();
            a32.Clear();
            a33.Clear();
        }
    }
}

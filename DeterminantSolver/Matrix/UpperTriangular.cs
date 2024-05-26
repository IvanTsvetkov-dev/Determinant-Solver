using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeterminantSolver.Matrix
{
    public class UpperTriangular : Matrix
    {
        public UpperTriangular(double[,] coefficents) : base(coefficents) { }

        //Метод, проверяющий, что матрица является верхне-треугольной
        public bool IsUpperTriangular() //возможно требуется переписать
        {
            if (coefficents[1, 0] == 0 && coefficents[2, 0] == 0 && coefficents[3, 0] == 0 && coefficents[2, 1] == 0 && coefficents[3, 1] == 0 && coefficents[3, 2] == 0) {
                return true;
            }
            return false;

        }

        public double SolveDeterminant()
        {
            double result = coefficents[0, 0];
            for(int i = 1; i < coefficents.GetLength(0); i++)
            {
                result += coefficents[i, i] * result;
            }
            return result;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace MethodGauss
{
    public static class Gauss
    {
        public const int sizeMatrix = 4;

        private static bool oddPermutation = false;

        public static double SolveDeterminant(double[,] coefficents)
        {
            for (int i = 0; i < sizeMatrix - 1; i++) //Решить проблему с делеинем на 0
            {
                for (int j = i + 1; j < sizeMatrix; j++)
                {
                    if (coefficents[i, i] == 0)
                    {
                        coefficents = SwitchRows(coefficents, i);
                        oddPermutation = !oddPermutation;
                    }

                    double k = coefficents[j, i] / coefficents[i, i];

                    if (double.IsNaN(k))
                    {
                        return 0.0;
                    }

                    for (int w = 0; w < sizeMatrix; w++)
                    {
                        coefficents[j, w] = coefficents[j, w] - k * coefficents[i, w];
                    }
                }
            }
            //Результат
            double result = coefficents[0, 0];

            for (int i = 1; i < sizeMatrix; i++)
            {
                result = result * coefficents[i, i];
            }

            if (oddPermutation)
            {
                return -result;
            }
            return result;
        }
        private static double[,] SwitchRows(double[,] coefficents, int index)
        {
            for (int i = sizeMatrix - index - 1; i < sizeMatrix; i++)
            {
                if (coefficents[i, index] != 0)
                {
                    for (int j = 0; j < sizeMatrix; j++)
                    {
                        double tmp = coefficents[i, j];
                        coefficents[i, j] = coefficents[index, j];
                        coefficents[index, j] = tmp;
                    }
                    break;
                }
            }
            return coefficents;
        }
    }
}

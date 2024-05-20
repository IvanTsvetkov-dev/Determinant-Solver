using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodGauss
{
    public static class Gauss
    {
        public const int sizeMatrix = 4;

        public static double SolveDeterminant(double[,] coefficents)
        {
            double result;
            for (int i = 0; i < sizeMatrix - 1; i++) //Решить проблему с делеинем на 0
            {
                for (int j = i + 1; j < sizeMatrix; j++)
                {
                    double k = coefficents[j, i] / coefficents[i, i];
                    for (int w = 0; w < sizeMatrix; w++)
                    {
                        coefficents[j, w] = coefficents[j, w] - k * coefficents[i, w];
                    } 
                }
            }
            result = coefficents[0, 0];
            for (int i = 1; i < sizeMatrix; i++)
            {
                result = result * coefficents[i, i];
            }
            return result;
        }
    }
}

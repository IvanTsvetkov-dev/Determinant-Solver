using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeterminantSolver.Matrix
{
    public class HavingNullRowOrColumn : Matrix
    {
        public HavingNullRowOrColumn(double[,] coefficents) : base(coefficents) { }

        public bool HaveNullRowOrColumn() {
            return true;
        
        }
        public double SolveDeterminant() { return 0.0; }

    }
}

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DeterminantSolver
{
    class MatrixFileOperation
    {
        public static string[] ReadMatrix(OpenFileDialog openFileDialog)
        {
            var fileStream = openFileDialog.OpenFile();

            StringBuilder fileContent = new StringBuilder();

            StreamReader reader = new StreamReader(fileStream);
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    fileContent.AppendLine(line.TrimEnd());
                }
            }

            string[] formattedMatrix = FormatFileMatrix(fileContent).Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            return formattedMatrix;
        }

        private static string FormatFileMatrix(StringBuilder fileContent)
        {
            string textWithoutNewlines = fileContent.ToString().Replace(Environment.NewLine, " ");

            return textWithoutNewlines;
        }
    }
}

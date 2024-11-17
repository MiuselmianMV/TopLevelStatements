using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopLevelStatements
{
    public class Matrix
    {
        private int Rows { get; set; }
        private int Columns { get; set; }
        private int[,] IntsMatrix { get; set; }


        public Matrix(int Rows, int Columns)
        {
            this.Rows = Rows;
            this.Columns = Columns;
            IntsMatrix = new int[Rows, Columns];
        }

        public void FillValues()
        {
            Random rnd = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for (int w = 0; w < Columns; w++)
                {
                    IntsMatrix[i, w] = rnd.Next(0, 9);
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < Rows; i++)
            {
                Console.WriteLine();
                for (int w = 0; w < Columns; w++)
                {
                    Console.Write(IntsMatrix[i, w] + "\t");
                }
            }
        }

    }
}

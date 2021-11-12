using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Matrix
    {
        private class Date
        {
            int _Day { get; set; }
            int _Month { get; set; }
            public Date(int Day, int Month)
            {
                _Day = Day;
                _Month = Month;
            }

        }
        private int _cols;
        public int Cols
        {
            get
            {
                return _cols;
            }
            set
            {
                if (value > 0)
                    _cols = value;
                else
                    _cols = 1;
            }
        }
        private int _rows;
        public int _Rows
        {
            get
            {
                return _rows;
            }
            set
            {
                if (value > 0)
                    _rows = value;
                else
                    _rows = 1;
            }
        }
        RowsInMatrix[] Rows;
        private Owner owner = new Owner("Kirill", "BelSTU");
        public Matrix(int rows, int cols)
        {
            Cols = cols;
            _Rows = rows;
            Rows = new RowsInMatrix[rows];
        }
        public void WriteMatrix()
        {
            for(int i=0;i<this._Rows;i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    Console.Write($"{this[i].Val[j]} ");
                }
                Console.WriteLine();
            }
        }
        public int Sumgl()
        {
            int sum = 0;
            for(int i=0;i<this._Rows;i++)
            {
                for(int j=0;j<this.Cols;j++)
                {
                    if(i==j)
                    {
                        sum = sum + this[i].Val[j];
                    }
                }
            }
            return sum;
        }
        public int[] SearchNum(int row)
        {
            int[] num = new int[12];
            int c = 0;
            if(this.Cols>=12)
            {
                for(int i=0;i<this._Rows;i++)
                {
                    for (int j = 0; j < this.Cols; j++)
                    {
                        if(((this[i].Val[j]==3)&& (this[i].Val[j+1] == 7)&& (this[i].Val[j+2] == 5)) &&(this.Cols-(j+1)>=9)&&(this[i].Row==row))
                        {
                            for(int k=j;c<12;k++)
                            {
                                num[c] = this[i].Val[k];
                                c++;
                            }
                        }
                    }
                }
            }
            return num;
        }
        public void Create(int rows, int cols)
        {
            for(int i=0;i<rows;i++)
            {
                this[i] = new RowsInMatrix(i + 1, cols);
            }
        }
        public void Create(int row, int cols, int[] val)
        {
                this[row-1] = new RowsInMatrix(row, cols, val);
        }
        public RowsInMatrix this[int index]
        {
            get
            {
                return Rows[index];
            }
            set
            {
                Rows[index] = value;
            }
        }
        public static Matrix operator -(Matrix matrix, int row)
        {
            if(row<=matrix._Rows)
            {
                for(int i=0;i<matrix._Rows;i++)
                {
                    if(matrix[i].Row==row)
                    {
                        for (int j = matrix[i].Row - 1; j < matrix._Rows; j++)
                        {
                            if (j < matrix._Rows - 1) matrix[j] = matrix[j + 1];
                            else matrix._Rows--;
                        }
                    }
                }
            }
            return matrix;
        }
        public static bool operator >(Matrix matrix1, Matrix matrix2)
        {
            bool rc = false;
            if ((matrix1._Rows == matrix2._Rows) && (matrix1.Cols == matrix2.Cols))
            {
                for(int i=0;i<matrix1._Rows;i++)
                {
                    for(int j=0;j<matrix1.Cols;j++)
                    {
                        if(Math.Abs(matrix1[i].Val[j])>Math.Abs(matrix2[i].Val[j]))
                        {
                            rc = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return rc;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(Matrix matrix1, Matrix matrix2)
        {
            bool rc = false;
            if ((matrix1._Rows == matrix2._Rows) && (matrix1.Cols == matrix2.Cols))
            {
                for (int i = 0; i < matrix1._Rows; i++)
                {
                    for (int j = 0; j < matrix1.Cols; j++)
                    {
                        if (Math.Abs(matrix1[i].Val[j]) < Math.Abs(matrix2[i].Val[j]))
                        {
                            rc = true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                return rc;
            }
            else
            {
                return false;
            }
        }
        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            Matrix newmatrix = new Matrix(matrix1.Cols, matrix1._Rows);
            if ((matrix1._Rows == matrix2._Rows) && (matrix1.Cols == matrix2.Cols))
            {
                int[] val = new int[newmatrix.Cols];
                for (int j = 0; j < matrix1._Rows; j++)
                {
                    for (int k = 0; k < matrix2._Rows; k++)
                    {
                        if (matrix1[j].Row == matrix2[k].Row)
                        {
                            for (int i = 0; i < newmatrix.Cols; i++)
                            {
                                val[i] = matrix1[j].Val[i] + matrix2[k].Val[i];
                            }
                            break;
                        }
                    }
                    newmatrix.Create(matrix1[j].Row, newmatrix.Cols, val);
                }
                return newmatrix;
            }
            else
            {
                Console.WriteLine("Ошибка: размеры матриц должны быть одинаковыми");
                return newmatrix;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
namespace LogicLayer
{
    public class Matrix
    {
        /* Dimension represents the order of the matrix
         Key = Rows , Value = Columns */
        private KeyValuePair<int, int> dimension = new KeyValuePair<int, int>();
        // A two dimensional array
        double[,] matrix = new double[0, 0];
        // Rows and columns of the matrix
        int rows;
        int cols;
        public Matrix()
        {
            // Initialzing Dimensio with rows and columns
            Dimension = new KeyValuePair<int, int>(Rows, Cols);
            // Setting the size of the 2-D Array
            matrix = new double[Dimension.Key,Dimension.Value];
            // Random function to fill the array from any number between 0 and 9
            randomGenerate();
        }
        // Overloaded constructor to return identity matrix
        public Matrix(bool identityFlag,int Rows,int Cols)
        {
            Dimension = new KeyValuePair<int, int>(Rows, Cols);
            matrix = new double[Dimension.Key, Dimension.Value];

            if (identityFlag == true)
            {
                for (int row = 0; row < Dimension.Key; row++)
                {
                    for (int col = 0; col < Dimension.Value; col++)
                    {
                        // Diagonal entries are 1 in identity matrix
                        if (row == col)
                        {
                            MatrixP.SetValue(1, row, col);
                        }
                        // Non diagonal entries are 0 in identity matrix
                        else
                        {
                            MatrixP.SetValue(0, row, col);
                        }
                    }
                }
            }
        }
        // Overriding the tostring function to print matrix in tabular form
        public override string ToString()
        {
            string table="";
            for (int i = 0; i < Dimension.Key; i++) 
            {
                for (int x = 0; x < Dimension.Value; x++) 
                {
                    table += (matrix.GetValue(i,x).ToString())+" ";

                }
                /* Concatinating the values in a string while inserting a 
                new line at the end of each row */
                table += Environment.NewLine;
            }
            return table;
        }
        // Overloading the * operator to multiply  matrices
        public static Matrix operator *(Matrix obj1, Matrix obj2)
        {
            double sum = 0;
            // Multiplication result will be stores in this matrix 
            Matrix temp = new Matrix();
            temp.Dimension = new KeyValuePair<int, int>(obj1.Dimension.Key, obj2.Dimension.Value);
            temp.matrix = new double[obj1.Dimension.Key, obj2.Dimension.Value];
            // Checking order of matrices if it is eligible for Multiplication
            if (obj1.Dimension.Value == obj2.Dimension.Key)
            {
                for (int row = 0; row < obj1.Dimension.Key; row++)
                {
                    for (int col = 0; col < obj2.Dimension.Value; col++)
                    {
                        /* Initialzing each entry of temp matrix with zero 
                         before filling it*/
                        temp.MatrixP.SetValue(0,row, col);
                        /* Multiplying the values of the first matrix with each
                         enetry in the second matrix column*/
                        for (int frow = 0; frow < obj1.Dimension.Key; frow++)    
                        {
                            for (int scol = 0; scol < obj2.Dimension.Value; scol++)    
                            {
                                // Adding the reuslts of multiplication at each index
                                sum = 0;
                                for (int index = 0; index < obj1.Dimension.Value; index++)
                                {
                                    sum = sum + (double.Parse(obj1.MatrixP.GetValue(frow, index).ToString()) * double.Parse(obj2.MatrixP.GetValue(index, scol).ToString()));
                                }
                                temp.matrix.SetValue(sum, frow, scol);
                            }
                        }
                    }
                }
            }
            return temp;

        }
        // Overloading the + operator to add two matrix objects
        public static Matrix operator +(Matrix obj1, Matrix obj2)
        {
            // Checking order of matrices if it is eligible for addition
            if (obj1.Dimension.Key==obj2.Dimension.Key&&obj1.Dimension.Value==obj2.Dimension.Value)
            {
                for(int row=0;row< obj1.Dimension.Key;row++)
                {
                    for(int col=0;col<obj1.Dimension.Value;col++)
                    {
                        // Adding values at the same indexs and stroing them in 1st matrix
                        obj1.MatrixP.SetValue
                        ((double.Parse((obj1.MatrixP.GetValue(row, col).ToString()))
                        + double.Parse((obj2.MatrixP.GetValue(row, col).ToString()))), row, col);
                    }
                }
            }
            return obj1;

        }
        // Generating Random numbers between 1 and 9
        private void randomGenerate()
        {
            Random random = new Random();
            int randomNumber;
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Cols; col++)
                {
                    randomNumber = random.Next(1, 9);
                    MatrixP.SetValue(randomNumber, row, col);
                }
            }
        }
        // Taking Transpose of the matrix objectS
        public Matrix transpose()
        {
            Matrix temp = new Matrix();
            // Rows and columns are shuffled due to transpose
            temp.Dimension = new KeyValuePair<int, int>(Cols, Rows);
            temp.matrix = new double[Cols, Rows];

            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Cols; col++)
                {

                    temp.MatrixP.SetValue(MatrixP.GetValue(row, col), col, row);

                }
            }
            return temp;
        }
        // To get the inverse of matrices
        public Matrix Inverse()
        {
            int determinent;
            // Only Square matrices can be invertible
            if (Rows == Cols)
            {
                // For 2x2 Matrix
                if (Rows == 2)
                {
                    determinent = calculateDeteminant2x2();
                    if (determinent != 0)
                    {
                        // Making 2x2 matrix to store result
                        Matrix temp = new Matrix();
                        temp.Dimension = new KeyValuePair<int, int>(2, 2);
                        temp.matrix = new double[2, 2];
                        // Taking adjoint
                        adjoint_2D(temp);
                        for (int row = 0; row < 2; row++)
                        {
                            for (int col = 0; col < 2; col++)
                            {
                                // Dividing each entry by the determinant and storing the result in temp
                                double value = (double.Parse(MatrixP.GetValue(row, col).ToString()) / determinent);
                                temp.MatrixP.SetValue(value, row, col);

                            }
                        }
                        return temp;
                    }
                    else
                    {
                        return null;
                    }
                }
                //For Higher Order Matrices
                else
                {
                    // Checking if the matrix in invertible
                    if (invertible_Check())
                    {
                        // Getting the determinant 
                        determinent = getDeterminant();
                        // Making the cofactor matrix 
                        Matrix cofactor = cofactorMatrix();
                        // Initializing rows and cols of the cofactor matrix with the orignal order
                        cofactor.Rows = Rows;
                        cofactor.Cols = Cols;
                        // Taking Transpose
                        cofactor=cofactor.transpose();
                        // Dividing each entry by the determinant and storing the result
                        for (int row = 0; row < cofactor.Dimension.Key; row++)
                        {
                            for (int col = 0; col < cofactor.Dimension.Value; col++)
                            {
                                double value = (double.Parse(cofactor.MatrixP.GetValue(row, col).ToString()) / determinent);
                                cofactor.MatrixP.SetValue(value, row, col);

                            }
                        }
                        return cofactor;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            else
            {
                return null;
            }
        }
        // To make cofactor matrix for higher order matrices
        public Matrix cofactorMatrix()
        {
            /* Making a temp matrix to store the minor matrix 
             At each entry of orignal matrix*/
            Matrix temp = new Matrix();
            temp.Dimension = new KeyValuePair<int, int>(Rows - 1, Cols - 1);
            temp.matrix = new double[Rows - 1, Cols - 1];
            //To store the cofactor matrix
            Matrix main_temp = new Matrix();
            main_temp.Dimension = new KeyValuePair<int, int>(Rows, Cols);
            main_temp.matrix = new double[Rows, Cols];
            /* To count which indexs will have negative values in the cofactor matrix */
            int counter = 0;
            // Variable to control the iteration of cloumns of the minor matrix at each index
            int tempCols = 0;
            // Variable to control the iteration of cloumns & rows of the cofactor matrix
            int mainCol = 0;
            int mainRow = 0;
            // This loop will run for each entry in the orignal matrix
            for (int cofac = 0; cofac < Rows * Rows; cofac++)
            {
                // Variable to control the iteration of rows of the minor matrix at each index
                /* Resetting the at the end of each cofac because 
                 we have to go through each row to calculate cofactor at each index*/
                int tempRows = 0;
                /* rows and cols will get us to the value of which we have to 
                 find the cofactor matrix*/ 
                for (int rows = 0; rows < Rows; rows++)
                {
                    for (int cols = 0; cols < Cols; cols++)
                    {
                        /*loop and loop2 will get the minor matrix at each index
                         of orignal matrix*/
                        for (int loop=0;loop <Rows;loop++)
                        {
                            for (int loop2=0;loop2<Cols;loop2++)
                            {
                                /* Skipping the row and the colum of the orignal matrix
                                 to narrow down the minor matrix*/
                                if(loop!=rows && loop2!=cols)
                                {
                                    // Adding values in the minor matrix
                                    temp.MatrixP.SetValue(MatrixP.GetValue(loop, loop2), tempRows, tempCols);
                                    tempCols++;
                                    /* At the end of the columns increment to the next row
                                    of cofactor matrix*/
                                    if (tempCols == temp.Dimension.Value)
                                    {
                                        // Incrementing the row at the end of previous row
                                        tempRows++;
                                        //Checking if the minor matrix is filled
                                        if (tempCols == temp.Dimension.Value && tempRows == temp.Dimension.Key)
                                        {
                                            // If the orignal matrix was of 3x3
                                            if (temp.Dimension.Key < 3)
                                            {
                                                // +ve cofactor on even entries
                                                if (counter % 2 == 0)
                                                {
                                                    int dereminant = temp.calculateDeteminant2x2();
                                                    main_temp.MatrixP.SetValue(dereminant, mainRow, mainCol);
                                                    // incrementing cofactor matrix column
                                                    mainCol++;
                                                    /* If the previous row of cofactor matrix is filled reset the
                                                    iterators*/
                                                    if (mainCol == main_temp.Dimension.Value)
                                                    {
                                                        mainCol = 0;
                                                        // increment to the next row
                                                        mainRow++;
                                                        // if the matrix is filled then resetting the row
                                                        if (mainRow == main_temp.Dimension.Value)
                                                        {
                                                            mainRow = 0;
                                                        }

                                                    }
                                                    counter++;
                                                }
                                                // -ve cofactor on odd entries
                                                else
                                                {
                                                    int dereminant = temp.calculateDeteminant2x2();
                                                    main_temp.MatrixP.SetValue(-1*dereminant, mainRow, mainCol);
                                                    // incrementing cofactor matrix column
                                                    mainCol++;
                                                    /* If the previous row of cofactor matrix is filled reset the
                                                    iterators*/
                                                    if (mainCol == main_temp.Dimension.Value)
                                                    {
                                                        mainCol = 0;
                                                        mainRow++;
                                                        if (mainRow == main_temp.Dimension.Value)
                                                        {
                                                            mainRow = 0;
                                                        }

                                                    }
                                                    counter++;

                                                }

                                            }
                                            // For higher order matrices
                                            else
                                            {
                                                //+ve cofactor on even entries
                                                if (counter % 2 == 0)
                                                {
                                                    /* Calling the getDeterminant function to calculate 
                                                       Determinant of higher order matrices*/
                                                    int dereminant = temp.getDeterminant();
                                                    main_temp.MatrixP.SetValue(dereminant, mainRow, mainCol);
                                                    // incrementing cofactor matrix column
                                                    mainCol++;
                                                    /* If the previous row of cofactor matrix is filled reset the
                                                       iterators*/
                                                    if (mainCol == main_temp.Dimension.Value)
                                                    {
                                                        mainCol = 0;
                                                        mainRow++;
                                                        if (mainRow == main_temp.Dimension.Value)
                                                        {
                                                            mainRow = 0;
                                                        }
                                                    }
                                                    counter++;

                                                }
                                                //-ve cofactors on odd entries
                                                else
                                                {
                                                    /* Calling the getDeterminant function to calculate 
                                                     Determinant of higher order matrices*/
                                                    int dereminant = temp.getDeterminant();
                                                    main_temp.MatrixP.SetValue(-1*dereminant, mainRow, mainCol);
                                                    // incrementing cofactor matrix column
                                                    mainCol++;
                                                    /* If the previous row of cofactor matrix is filled reset the
                                                       iterators*/
                                                    if (mainCol == main_temp.Dimension.Value)
                                                    {
                                                        mainCol = 0;
                                                        mainRow++;
                                                        if (mainRow == main_temp.Dimension.Value)
                                                        {
                                                            mainRow = 0;
                                                        }

                                                    }
                                                    counter++;

                                                }
                                            }
                                        }
                                        // Resetting the iterators for minor matrices before calculating next cofac
                                        if (tempRows == temp.Dimension.Value)
                                        {
                                            tempRows = 0;
                                        }
                                        tempCols = 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return main_temp;
        }
        // To calculate determinant of higher order matrices
        public int getDeterminant()
        {
            int determinant;
            List<int> leftDiagonal = new List<int>();
            List<int> rightDiagonal = new List<int>();
            // Coulums are augmented at the end of orignal matric hence change in size
            Matrix temp = new Matrix();
            temp.Dimension = new KeyValuePair<int, int>(Rows, Cols + (Cols - 1));
            temp.matrix = new double[Rows, Cols + (Cols - 1)];
            // Getting the augmented matrix
            augmented_Matrix(temp);
            // To traverse the left digonal
            for (int diag = 0; diag < temp.Dimension.Key; diag++)
            {
                // To get the value at the diagonal
                for (int row = 0; row < temp.Dimension.Key; row++)
                {
                    for (int col = 0; col < temp.Dimension.Value; col++)
                    {
                        if (row + diag == col)
                        {
                            // Adding in left diagonal
                            leftDiagonal.Add(int.Parse(temp.MatrixP.GetValue(row, col).ToString()));
                            break;
                        }
                    }
                }
            }

            int index = 0;
            int colIndex = 0;
            // To traverse the right digonal
            for (int diag = 0; diag < temp.Dimension.Key; diag++)
            {
                index = colIndex;
                // Starting from the first index of the last row
                for (int row = temp.Dimension.Key - 1; row >= 0; row--)
                {
                    // Following the pattern (20 11 02) , (21 12 03) , (22 13 04)
                    if (index < temp.Dimension.Value)
                    {
                        rightDiagonal.Add(int.Parse(temp.MatrixP.GetValue(row, index).ToString()));
                    }
                    index++;

                }
                colIndex++;
            }
            // Caculating the determinant from left and right diagonal products
            determinant = calculateDeteminant(leftDiagonal, rightDiagonal);
            return determinant;

        }
        // To calculate 2x2 Determinant
        public int calculateDeteminant2x2()
        {
            int left = int.Parse(MatrixP.GetValue(0, 0).ToString()) * int.Parse(MatrixP.GetValue(1, 1).ToString());
            int right = int.Parse(MatrixP.GetValue(0, 1).ToString()) * int.Parse(MatrixP.GetValue(1, 0).ToString());
            int determinent = left - right;
            return determinent;
        }
        // To calculate higher order Determinant 
        public int calculateDeteminant(List<int> leftDiagonal, List<int> rightDiagonal)
        {
            List<int> LeftResult = new List<int>();
            List<int> RightResult = new List<int>();
            // Stroing the first value of both diagonals for futher multiplication
            int leftResult = leftDiagonal[0];
            int rightResult = rightDiagonal[0];
            // This loop will run till the end of both diagonals
            for (int value = 1; value <= leftDiagonal.Count; value++)
            {
                // If loop not at the dividing index e.g 3 in 9 keep on multiplying
                if (value % Rows != 0)
                {
                    leftResult *= leftDiagonal[value];
                    rightResult *= rightDiagonal[value];
                }
                // Add the resucts to get the products
                else
                {
                    LeftResult.Add(leftResult);
                    RightResult.Add(rightResult);
                    // At last index of the list break
                    if (value == leftDiagonal.Count)
                    {
                        break;
                    }
                    /* Initialize the varaibes with the value at dividing index
                    which is to be multipled on the next iteration*/
                    leftResult = leftDiagonal[value];
                    rightResult = rightDiagonal[value];

                }
            }
            // Calculate result
            int determinant = LeftResult.Sum() - RightResult.Sum();
            return determinant;
        }
        public void augmented_Matrix(Matrix temp)
        {
            for (int rows = 0; rows < temp.Dimension.Key; rows++)
            {
                for (int cols = 0; cols < temp.Dimension.Value; cols++)
                {
                    // fill the matrix till orignal number of columns
                    if (cols <= Cols - 1)
                    {
                        temp.MatrixP.SetValue(MatrixP.GetValue(rows, cols), rows, cols);
                    }
                    // augmente the matrix with the coulums at the start
                    else
                    {
                        int tempCols = cols;
                        int origCols = 0;
                        for (int augmentCol = 0; augmentCol < Cols - 1; augmentCol++)
                        {
                            temp.MatrixP.SetValue(MatrixP.GetValue(rows, origCols), rows, tempCols);
                            tempCols++;
                            origCols++;
                        }
                        break;
                    }
                }
            }
        }
        public bool invertible_Check()
        {
            bool row_flag = true;
            List<bool> col_flag = new List<bool>();
            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Cols; col++)
                {
                    // checking for the zero entries at each roe
                    if (double.Parse(MatrixP.GetValue(row, col).ToString()) == 0)
                    {
                        col_flag.Add(true);
                    }
                }
                // if the whole row is zero matrix is not invertible
                if (col_flag.Count == Cols)
                {
                    return row_flag = false;
                }
                else
                {
                    col_flag.Clear();
                }
            }
            return row_flag;
        }
        // Adjoing of a 2D Matrix
        public void adjoint_2D(Matrix temp)
        {
            temp.matrix = matrix;
            double temp_Swap;
            temp_Swap = double.Parse(temp.MatrixP.GetValue(0, 0).ToString());
            temp.MatrixP.SetValue(temp.MatrixP.GetValue(1, 1), 0, 0);
            temp.MatrixP.SetValue(temp_Swap, 1, 1);
            temp.MatrixP.SetValue(double.Parse(temp.MatrixP.GetValue(0, 1).ToString()) * -1, 0, 1);
            temp.MatrixP.SetValue(double.Parse(temp.MatrixP.GetValue(1, 0).ToString()) * -1, 1, 0);
        }
        // Get Set Properties
        public KeyValuePair<int, int> Dimension
        {
            get => dimension;
            set => dimension = value;
        }
        public double[,] MatrixP
        {
            get => matrix;
            set => matrix = value;
        }
        public int Rows
        {
            get => rows;
            set => rows = value;
        }
        public int Cols
        {
            get => cols;
            set => cols = value;
        }
    }

}


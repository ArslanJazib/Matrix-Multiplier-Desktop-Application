using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using LogicLayer;
namespace VPAssignment4
{
    public partial class MatrixForm : Form
    {
        // Flags to verify if the order of the matrix is correct
        static bool additionFlag = false;
        static bool multiplicationFlag = false;
        // Flag to be passed to overloaded constructor for identity matrix
        bool identityFlag = false;
        Matrix matrix = new Matrix();
        Matrix second = new Matrix();
        public MatrixForm()
        {
            InitializeComponent();
        }

        public Matrix Matrix
        {
            get => default(Matrix);
            set
            {
            }
        }

        private void Matrix_Load(object sender, EventArgs e)
        {

        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            // Regular expression to accept only numeric values for rows & cols
            string number_pattern = @"(^[0-9]+$)";
            // If the user clicked the addition button on the toolbar
            if (mode_lbl.Text == "Addition")
            {
                // Comparing input with regular expression
                Match checkRow = Regex.Match(row_tbox.Text, number_pattern);
                Match checkCol = Regex.Match(col_tbox.Text, number_pattern);
                Match checkRow2 = Regex.Match(row2_tbox.Text, number_pattern);
                Match checkCol2 = Regex.Match(col2_tbox.Text, number_pattern);
                if (checkRow.Success && checkCol.Success && checkRow2.Success && checkCol2.Success)
                {
                    // Setting the values of rows , cols in all data members
                    matrix.Rows = int.Parse(row_tbox.Text);
                    matrix.Cols = int.Parse(col_tbox.Text);
                    matrix.Dimension = new KeyValuePair<int, int>(matrix.Rows, matrix.Cols);
                    matrix.MatrixP = new double[int.Parse(row_tbox.Text), int.Parse(col_tbox.Text)];
                    second.Rows= int.Parse(row2_tbox.Text);
                    second.Cols = int.Parse(col2_tbox.Text);
                    second.Dimension = new KeyValuePair<int, int>(second.Rows, second.Cols);
                    second.MatrixP = new double[int.Parse(row2_tbox.Text), int.Parse(col2_tbox.Text)];
                    // Calling user defined fuction
                    additionMode(matrix, second);
                }
                else
                {
                    MessageBox.Show("Incorrect Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // If the user clicked the multiplication button on the toolbar
            if (mode_lbl.Text == "Multiplication")
            {
                // Comparing input with regular expression
                Match checkRow = Regex.Match(row_tbox.Text, number_pattern);
                Match checkCol = Regex.Match(col_tbox.Text, number_pattern);
                Match checkRow2 = Regex.Match(row2_tbox.Text, number_pattern);
                Match checkCol2 = Regex.Match(col2_tbox.Text, number_pattern);
                if (checkRow.Success && checkCol.Success && checkRow2.Success && checkCol2.Success)
                {
                    // Setting the values of rows , cols in all data members
                    matrix.Rows = int.Parse(row_tbox.Text);
                    matrix.Cols = int.Parse(col_tbox.Text);
                    matrix.Dimension = new KeyValuePair<int, int>(matrix.Rows, matrix.Cols);
                    matrix.MatrixP = new double[int.Parse(row_tbox.Text), int.Parse(col_tbox.Text)];
                    second.Rows = int.Parse(row2_tbox.Text);
                    second.Cols = int.Parse(col2_tbox.Text);
                    second.Dimension = new KeyValuePair<int, int>(second.Rows, second.Cols);
                    second.MatrixP = new double[int.Parse(row2_tbox.Text), int.Parse(col2_tbox.Text)];
                    // Calling user defined fuction
                    MultiplicationMode(matrix, second);
                }
                else
                {
                    MessageBox.Show("Incorrect Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // If the user clicked the inverse button on the toolbar
            if (mode_lbl.Text == "Inverse")
            {
                // Comparing input with regular expression
                Match checkRow = Regex.Match(row_tbox.Text, number_pattern);
                Match checkCol = Regex.Match(col_tbox.Text, number_pattern);
                if (checkRow.Success && checkCol.Success)
                {
                    // Setting the values of rows , cols in all data members
                    matrix.Rows = int.Parse(row_tbox.Text);
                    matrix.Cols = int.Parse(col_tbox.Text);
                    matrix.Dimension = new KeyValuePair<int, int>(matrix.Rows, matrix.Cols);
                    matrix.MatrixP = new double[int.Parse(row_tbox.Text), int.Parse(col_tbox.Text)];
                    // Calling user defined fuction
                    UniaryMode(matrix);

                }
                else
                {
                    MessageBox.Show("Incorrect Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // If the user clicked the transpose button on the toolbar
            if (mode_lbl.Text == "Transpose")
            {
                // Comparing input with regular expression
                Match checkRow = Regex.Match(row_tbox.Text, number_pattern);
                Match checkCol = Regex.Match(col_tbox.Text, number_pattern);
                if (checkRow.Success && checkCol.Success)
                {
                    // Setting the values of rows , cols in all data members
                    matrix.Rows = int.Parse(row_tbox.Text);
                    matrix.Cols = int.Parse(col_tbox.Text);
                    matrix.Dimension = new KeyValuePair<int, int>(matrix.Rows, matrix.Cols);
                    matrix.MatrixP = new double[int.Parse(row_tbox.Text), int.Parse(col_tbox.Text)];
                    // Calling user defined fuction
                    UniaryMode(matrix);

                }
                else
                {
                    MessageBox.Show("Incorrect Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // If the user clicked the identity button on the toolbar
            if (mode_lbl.Text == "Identity")
            {
                // Comparing input with regular expression
                Match checkRow = Regex.Match(row_tbox.Text, number_pattern);
                Match checkCol = Regex.Match(col_tbox.Text, number_pattern);
                if (checkRow.Success && checkCol.Success)
                {
                    /* Passing total number of rows and columns along with the flag
                       to the parameterized constructor*/
                    identityFlag = true;
                    int r = int.Parse(row_tbox.Text);
                    int c = int.Parse(col_tbox.Text);
                    Matrix matrix = new Matrix(identityFlag,r,c);
                    MessageBox.Show(matrix.ToString(), "Output", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Incorrect Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // If the user clicked the submit button without choosing a mode first
            else
            {
                MessageBox.Show("Choose a mode from toolbar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Making datatable on the datagrid for inverse & tranpose
        public void UniaryMode(Matrix matrix)
        {
            DataTable dt = new DataTable();
            /* Filling the datatable with cells according to the 
             Columns entered by the user*/ 
            for (int x = 0; x < matrix.Cols; x++)
            {
                dt.Columns.Add();
            }
            /* Filling the datatable with rows according to the 
            Rows entered by the user*/
            for (int i = 0; i < matrix.Rows; i++)
            {
                var row = dt.NewRow();

                dt.Rows.Add(row);
            }
            // Adding the datatable as the source of the datagrid    
            matrix_dataGridView1.DataSource = dt;
            // Setting the visiblity of the revelant controls
            matrix_dataGridView1.Visible = true;
            mulOperator.Visible = false;
            plusOperator.Visible = false;
            
        }
        // Making datatables on the datagrids for multiplication
        public void MultiplicationMode(Matrix matrix,Matrix second)
        {
            // Checking if both matrices can be multiplied or not
            if (matrix.Dimension.Value == second.Dimension.Key)
            {
                DataTable dt = new DataTable();
                /* Filling the datatable for matrix 1 with cells according to the 
                Columns entered by the user*/
                for (int x = 0; x < matrix.Cols; x++)
                {
                    dt.Columns.Add();
                }
                /* Filling the datatable for matrix 1 with rows according to the 
                 Rows entered by the user*/
                for (int i = 0; i < matrix.Rows; i++)
                {
                    var row = dt.NewRow();

                    dt.Rows.Add(row);
                }
                DataTable dt2 = new DataTable();
                /* Filling the datatable for matrix 2 with cells according to the 
                Columns entered by the user*/
                for (int x = 0; x < second.Cols; x++)
                {
                    dt2.Columns.Add();
                }
                /* Filling the datatable for matrix 2 with rows according to the 
                Rows entered by the user*/
                for (int i = 0; i < second.Rows; i++)
                {
                    var row = dt2.NewRow();

                    dt2.Rows.Add(row);
                }
                // Adding the datatable as the source of the datagrid for matrix 1
                matrix_dataGridView1.DataSource = dt;
                // Adding the datatable as the source of the datagrid for matrix 2
                // Setting the visiblity of the revelant controls
                matrix_dataGridView1.Visible = true;
                matrix_dataGridView2.DataSource = dt2;
                matrix_dataGridView2.Visible = true;
                mulOperator.Visible = true;
                plusOperator.Visible = false;
                multiplicationFlag = true;
            }
            // If the user entered the wrong order of rows and cols for mutiplication
            else
            {
                MessageBox.Show("Incorrect Order of Matrices", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        // Making datatables on the datagrids for multiplication
        public void additionMode(Matrix matrix,Matrix second)
        {
            // Checking if both matrices can be added or not
            if (matrix.Dimension.Key == second.Dimension.Key && matrix.Dimension.Value == second.Dimension.Value)
            {
                DataTable dt = new DataTable();
                /* Filling the datatable for matrix 1 with rows according to the 
                Rows entered by the user*/
                for (int x = 0; x < matrix.Cols; x++)
                {
                    dt.Columns.Add();
                }
                /* Filling the datatable for matrix 1 with rows according to the 
                Rows entered by the user*/
                for (int i = 0; i < matrix.Rows; i++)
                {
                    var row = dt.NewRow();

                    dt.Rows.Add(row);
                }
                DataTable dt2 = new DataTable();
                /* Filling the datatable for matrix 2 with cells according to the 
                Columns entered by the user*/
                for (int x = 0; x < second.Cols; x++)
                {
                    dt2.Columns.Add();
                }
                /* Filling the datatable for matrix 2 with rows according to the 
                Rows entered by the user*/
                for (int i = 0; i < second.Rows; i++)
                {
                    var row = dt2.NewRow();

                    dt2.Rows.Add(row);
                }
                // Adding the datatable as the source of the datagrid for matrix 1
                matrix_dataGridView1.DataSource = dt;
                // Adding the datatable as the source of the datagrid for matrix 2
                matrix_dataGridView2.DataSource = dt2;
                // Setting the visiblity of the revelant controls
                matrix_dataGridView1.Visible = true;
                matrix_dataGridView2.Visible = true;
                plusOperator.Visible = true;
                mulOperator.Visible = false;
                additionFlag = true;
            }
            // If the user entered the wrong order of rows and cols for mutiplication
            else
            {
                MessageBox.Show("Incorrect Order of Matrices", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        // If the user clicks the add button show the second matrix gird and change mode label
        private void addition_btn_Click(object sender, EventArgs e)
        {
            mode_lbl.Text = addition_btn.Text;
            matrix2.Visible = true;
        }
        // If the user clicks the multiplication button show the second matrix gird and change mode label
        private void multiplication_btn_Click(object sender, EventArgs e)
        {
            mode_lbl.Text = multiplication_btn.Text;
            matrix2.Visible = true;

        }
        // If the user clicks the inverse button hide 2nd matrix gird and change mode label
        private void inverse_btn_Click(object sender, EventArgs e)
        {
            mode_lbl.Text = inverse_btn.Text;
            matrix2.Visible = false;
            plusOperator.Visible = false;
            mulOperator.Visible = false;
            matrix_dataGridView2.Visible = false;
        }
        // If the user clicks the transpose button hide 2nd matrix gird and change mode label
        private void transpose_btn_Click(object sender, EventArgs e)
        {
            mode_lbl.Text = transpose_btn.Text;
            matrix2.Visible = false;
            plusOperator.Visible = false;
            mulOperator.Visible = false;
            matrix_dataGridView2.Visible = false;
        }
        // If the user clicks the identity button hide both matrix gird and change mode label
        private void identity_Click(object sender, EventArgs e)
        {
            mode_lbl.Text = identity.Text;
            matrix2.Visible = false;
            plusOperator.Visible = false;
            mulOperator.Visible = false;
            matrix_dataGridView2.Visible = false;
            matrix_dataGridView1.Visible = false;

        }
        private void Calculate_Click(object sender, EventArgs e)
        {
            // If additionFlag was true and the current mode is addition
            if (mode_lbl.Text == "Addition" && additionFlag == true)
            {
                // Getting the values entered by the user in the first data grid and storing them in the first matrix object
                foreach (DataGridViewRow row in matrix_dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        matrix.MatrixP.SetValue(double.Parse(row.Cells[cell.ColumnIndex].Value.ToString()), row.Index, cell.ColumnIndex);

                    }

                }
                // Getting the values entered by the user in the second data grid and storing them in the second matrix object
                foreach (DataGridViewRow row in matrix_dataGridView2.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        second.MatrixP.SetValue(double.Parse(row.Cells[cell.ColumnIndex].Value.ToString()), row.Index, cell.ColumnIndex);

                    }

                }
                //Adding both matrices and displaying output
                Matrix result = matrix + second;
                MessageBox.Show(result.ToString(), "Output", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // If multiplicationFlag was true and the current mode is multiplication
            if (mode_lbl.Text == "Multiplication" && multiplicationFlag == true)
            {
                // Getting the values entered by the user in the first data grid and storing them in the first matrix object
                foreach (DataGridViewRow row in matrix_dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        matrix.MatrixP.SetValue(double.Parse(row.Cells[cell.ColumnIndex].Value.ToString()), row.Index, cell.ColumnIndex);

                    }

                }
                // Getting the values entered by the user in the second data grid and storing them in the second matrix object
                foreach (DataGridViewRow row in matrix_dataGridView2.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        second.MatrixP.SetValue(double.Parse(row.Cells[cell.ColumnIndex].Value.ToString()), row.Index, cell.ColumnIndex);

                    }

                }
                Matrix result = matrix * second;
                MessageBox.Show(result.ToString(), "Output", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // If the current mode is inverse
            if (mode_lbl.Text == "Inverse")
            {
                // Getting the values entered by the user in the data grid and storing them in the matrix object
                foreach (DataGridViewRow row in matrix_dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        matrix.MatrixP.SetValue
                        (double.Parse(row.Cells[cell.ColumnIndex].Value.ToString())
                        , row.Index, cell.ColumnIndex);
                    }
                }
                // Calling the inverse function
                matrix = matrix.Inverse();
                // If matrix was invertible then show inverse
                if (matrix != null)
                {
                    MessageBox.Show(matrix.ToString(), "Output", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Matrix is not invertible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (mode_lbl.Text == "Transpose")
            {
                // Getting the values entered by the user in the data grid and storing them in the matrix object
                foreach (DataGridViewRow row in matrix_dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        matrix.MatrixP.SetValue
                        (double.Parse(row.Cells[cell.ColumnIndex].Value.ToString())
                        , row.Index, cell.ColumnIndex);
                    }
                }
                // Calling the transpose function
                matrix = matrix.transpose();
                if (matrix != null)
                {
                    MessageBox.Show(matrix.ToString(), "Output", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Matrix is not invertible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void mulOperators_Click(object sender, EventArgs e)
        {

        }
        private void plusOperator_Click(object sender, EventArgs e)
        {

        }
    }
}


using System;
using System.Data;
using System.Windows.Forms;

namespace comb_alg_13a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n = 0, m = 0;
        int[][] matrix;

        private void tbRows_TextChanged(object sender, EventArgs e)
        {
            try
            {
                m = int.Parse(tbRows.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат ввода количества строк матрицы!");
                tbRows.Focus();
                tbRows.SelectAll();
                return;
            }
            if (m < 1)
            {
                MessageBox.Show("Количество строк не может быть меньше 1!");
                tbRows.Focus();
                tbRows.SelectAll();
            }
        }

        private void tbCols_TextChanged(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(tbCols.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат ввода количества столбцов матрицы!");
                tbCols.Focus();
                tbCols.SelectAll();
                return;
            }
            if (n < 1) 
            {
                MessageBox.Show("Количество столбцов не корректно!");
                tbCols.Focus();
                tbCols.SelectAll();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (tbRows.Text == "")
            {
                MessageBox.Show("Количество строк не корректно!");
                tbRows.Focus();
                tbRows.SelectAll();
                return;
            }
            if (tbCols.Text == "")
            {
                MessageBox.Show("Количество столбцов не корректно!");
                tbCols.Focus();
                tbCols.SelectAll();
                return;
            }
            
            CreateGrid(dgvInput, n, m);
            tbCols.Enabled = false;
            tbRows.Enabled = false;
            btnCreate.Enabled = false;
        }

        private void CreateGrid(DataGridView dgv, int cnt_cols, int cnt_rows)
        {
            DataTable matr = new DataTable("matr");
            DataColumn[] cols = new DataColumn[cnt_cols];

            for (int i = 0; i < cnt_cols; i++)
            {
                cols[i] = new DataColumn(i.ToString());
                matr.Columns.Add(cols[i]);
            }

            for (int i = 0; i < cnt_rows; i++)
            {
                DataRow newRow;
                newRow = matr.NewRow();
                matr.Rows.Add(newRow);
            }

            dgv.DataSource = matr;
            dgv.AutoResizeColumns();
        }

        private int[][] GridToMatrix(DataGridView dgv, int cnt_cols, int cnt_rows)
        {
            int[][] matr = new int [cnt_rows][];
            for (int i = 0; i < cnt_rows; i++)
                matr[i] = new int[cnt_cols];

            DataGridViewCell txtCell;
            for (int i = 0; i < cnt_rows; i++)
            {
                for (int j = 0; j < cnt_cols; j++)
                {
                    txtCell = dgv.Rows[i].Cells[j];
                    string s = txtCell.Value.ToString();
                    if (s == "")
                    {   //незапомлненные ячейки заполняем нулями
                        matr[i][j] = 0;
                        dgv.Rows[i].Cells[j].Value = "0"; //и отображаем нули на dgv
                    }
                    else
                        matr[i][j] = Int32.Parse(s);
                }
            }
            return matr;
        }

        private void MatrixToGrid(DataGridView dgv, int[][] matr, int cnt_cols, int cnt_rows)
        {
            for (int i = 0; i < cnt_rows; i++)
            {
                for (int j = 0; j < cnt_cols; j++)
                {
                    dgv.Rows[i].Cells[j].Value = matr[i][j].ToString();
                }
            }
        }

        private void dgvInput_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex,
                col = e.ColumnIndex;
            try
            {
                string str = dgvInput.Rows[row].Cells[col].Value.ToString();
                int value = Int32.Parse(str);
            }
            catch (Exception)
            {
                MessageBox.Show("Некорректно задано значение ячейки "+"("+row+","+col+").\nБудет заменено на 0.");
                dgvInput.Rows[row].Cells[col].Value = 0;
               // dgvInput.CurrentCell = dgvInput.Rows[row].Cells[col];
               // dgvInput.CurrentCell.Selected = true;
               // dgvInput.BeginEdit(true);
                return;
            }

        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            matrix = GridToMatrix(dgvInput, n, m); //наша исходная матрица

            MaxSubMatr maxSubMatr = new MaxSubMatr(matrix);

            maxSubMatr.maxSubMatrix();
            int[][] sub_matr = maxSubMatr.getSubMatr();
            tbRes.Text = maxSubMatr.MaxSum.ToString();

            CreateGrid(dgvRes, maxSubMatr.n, maxSubMatr.m);
            MatrixToGrid(dgvRes, sub_matr, maxSubMatr.n, maxSubMatr.m);

            tbCols.Enabled = true;
            tbRows.Enabled = true;
            btnCreate.Enabled = true;
        }
    }
}

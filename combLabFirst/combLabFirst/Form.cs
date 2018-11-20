using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace combLabFirst
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        int n; //число гостей
        int[,] relations;

        private void initMatrix()
        {
            relations = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    relations[i, j] = 0;
                }
        }

        private void txtBoxAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                n = int.Parse(txtBoxAmount.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный формат ввода количества гостей!");
                txtBoxAmount.Focus();
                txtBoxAmount.SelectAll();
                return;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (n < 2)
            {
                MessageBox.Show("Число гостей должно быть больше 1!");
                txtBoxAmount.Focus();
                txtBoxAmount.SelectAll();
            }
            else
            {
                initMatrix();
                btnStart.Enabled = true;
                txtBoxAmount.ReadOnly = true;
                btnOk.Enabled = false;

                CreateGrid(dgvRelations);
                FillGrid(dgvRelations);
                dgvRelations.ReadOnly = false;
            }
        
    }

        private void CreateGrid(DataGridView dgv)
        {
            int i;

            DataGridViewComboBoxColumn newCol;
            for (i = 0; i < n; i++)
            {
                newCol = new DataGridViewComboBoxColumn();
                dgv.Columns.Add(newCol);
            }

            DataGridViewRow newRow;
            for (i = 0; i < n; i++)
            {
                newRow = new DataGridViewRow();
                dgv.Rows.Add(newRow);
            }

            for (i = 0; i < n; i++)
            {
                dgv.Rows[i].HeaderCell.Value = i.ToString();
                dgv.Columns[i].HeaderCell.Value = i.ToString();
                dgv[i, i].ReadOnly = true;
            }

        }

        string[] valuesCell = { "Без разницы", "Хочет", "Не хочет"};

        private void FillGrid(DataGridView dgv)
        {
            DataGridViewComboBoxCell cell;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    cell = (DataGridViewComboBoxCell)dgv.Rows[i].Cells[j];
                    cell.Items.AddRange(valuesCell);
                    cell.Value = valuesCell[0];
                }
            }
            dgv.AutoResizeColumns();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            dgvRelations.ReadOnly = true;

            Guests guests = new Guests(relations);

            List<int[]> list = guests.DoTask();
            if (list.Count == 0)
                MessageBox.Show("Нет вариантов рассадки");
            else
                foreach (var el in list)
                {
                    txtBoxRes.Text += Perm.PermToString(el) + Environment.NewLine;
                }
            txtBoxCntRes.Text = list.Count + " различных вариантов";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxAmount.ReadOnly = false;
            btnOk.Enabled = true;
            btnStart.Enabled = false;
            dgvRelations.Columns.Clear();

            txtBoxRes.Clear();
            txtBoxCntRes.Clear();

            txtBoxAmount.Focus();
            txtBoxAmount.SelectAll();
        }
      
        private void dgvRelations_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int n_col = e.ColumnIndex,
                    n_row = e.RowIndex;
                var value = dgvRelations[n_col, n_row].Value;
                if (relations[n_row, n_col] == 2) //если есть отношение что кто-то из этих чел не хочет сидеть рядом
                {
                    relations[n_col, n_row] = 2;
                    dgvRelations[n_col, n_row].Value = valuesCell[2];
                }
                else
                {
                    if (value.ToString() == valuesCell[1])
                    {
                        relations[n_col, n_row] = 1;
                        relations[n_row, n_col] = 1;
                    }
                    else if (value.ToString() == valuesCell[2])
                    {
                        relations[n_col, n_row] = 2;
                        relations[n_row, n_col] = 2;
                    }

                    dgvRelations[n_row, n_col].Value = value;
                }
            }
            catch (Exception) { } 

        }

       
    }
}

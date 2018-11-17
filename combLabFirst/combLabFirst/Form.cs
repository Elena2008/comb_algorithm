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

        private void setAccess(bool b)
        {
            //txtBoxAmount.ReadOnly = b;
            
            cmbBoxFirst.Enabled = b;
            cmbBoxSecond.Enabled = b;
            cmbBoxThird.Enabled = b;
            cmbBoxForth.Enabled = b;
            btnAddRelation.Enabled = b;
            addWantRelation.Enabled = b;
            btnStart.Enabled = b;

            cmbBoxFirst.Items.Clear();
            cmbBoxSecond.Items.Clear();
            cmbBoxThird.Items.Clear();
            cmbBoxForth.Items.Clear();
            cmbBoxFirst.Text = "0";
            cmbBoxSecond.Text = "0";
            cmbBoxThird.Text = "0";
            cmbBoxForth.Text = "0";
        }

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
            if (n < 2)
            {
                MessageBox.Show("Число гостей должно быть больше 1!");
                txtBoxAmount.Focus();
                txtBoxAmount.SelectAll();

            }
            else
            {
                initMatrix();
                setAccess(true);
                txtBoxAmount.ReadOnly = true;
                for (int i = 0; i < n; i++)
                {
                    cmbBoxFirst.Items.Add(i);
                    cmbBoxSecond.Items.Add(i);
                    cmbBoxThird.Items.Add(i);
                    cmbBoxForth.Items.Add(i);
                }
                              
            }
        }

        private void btnAddRelation_Click(object sender, EventArgs e)
        {
            int first = Convert.ToInt32(cmbBoxFirst.Text),
                second = Convert.ToInt32(cmbBoxSecond.Text);
            if (first != second)
            {
                relations[first, second] = -1;
                relations[second, first] = -1;
                MessageBox.Show("Отношение добавлено!");
                cmbBoxFirst.Focus();
            }
            else
            {
                MessageBox.Show("Вы выбрали одного и того же человека!");
                cmbBoxFirst.Focus();
            }
        }

        private void CreateGrid(DataGridView dgv)
        {
            int i;
            DataTable matr = new DataTable("relations");
            DataColumn[] cols = new DataColumn[n];
            for (i = 0; i < n; i++)
            {
                cols[i] = new DataColumn(i.ToString());
                matr.Columns.Add(cols[i]);
            }
            DataRow newRow;
            for (i = 0; i < n; i++)
            {
                newRow = matr.NewRow();
                matr.Rows.Add(newRow);
            }
            dgv.DataSource = matr;

            for (i = 0; i < n; i++)
            {
                dgv.Rows[i].HeaderCell.Value = i.ToString();
            }

            dgv.AutoResizeColumns();
            dgv.AutoResizeRows();
        }

        private void FillGrid(DataGridView dgv)
        {
            DataGridViewCell txtCell;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    txtCell = dgv.Rows[i].Cells[j];
                    txtCell.Value = relations[i, j].ToString();
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            /*
            cmbBoxFirst.Enabled = false;
            cmbBoxSecond.Enabled = false;
            btnAddRelation.Enabled = false;
            cmbBoxThird.Enabled = false;
            cmbBoxForth.Enabled = false;
            addWantRelation.Enabled = false;*/
            setAccess(false); 
            txtBoxRes.Clear();

            CreateGrid(dgvRelations);
            FillGrid(dgvRelations);
            dgvRelations.Show();

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
            setAccess(false);
            txtBoxAmount.ReadOnly = false;
            n = 0;
            dgvRelations.Hide();
            txtBoxRes.Clear();
            txtBoxCntRes.Clear();
            txtBoxAmount.Focus();
            txtBoxAmount.SelectAll();
        }

        private void cmbBoxFirst_TextChanged(object sender, EventArgs e)
        {
            int first;
            try
            {
                first = int.Parse(cmbBoxFirst.Text);
                
            }
            catch (Exception)
            {
                MessageBox.Show("Неверно задано значение в первом ComboBox!");
                cmbBoxFirst.Focus();
                return;
            }
            if (first < 0 || first > n-1)
            {
                MessageBox.Show("Значение в первом ComboBox должны быть от 0 до "+ (n-1));
                cmbBoxFirst.Focus();
                return;
            }
        }

        private void cmbBoxSecond_TextChanged(object sender, EventArgs e)
        {
            int second;
            try
            {
                second = int.Parse(cmbBoxSecond.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Неверно задано значение во втором ComboBox!");
                cmbBoxSecond.Focus();
                return;
            }
            if (second < 0 || second > n-1)
            {
                MessageBox.Show("Значение во втором ComboBox должны быть от 0 до " + (n-1));
                cmbBoxSecond.Focus();
                return;
            }
        }

        private void cmbBoxThird_TextChanged(object sender, EventArgs e)
        {
            int third;
            try
            {
                third = int.Parse(cmbBoxThird.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Неверно задано значение в ComboBox!");
                cmbBoxThird.Focus();
                return;
            }
            if (third < 0 || third > n - 1)
            {
                MessageBox.Show("Значение в ComboBox должны быть от 0 до " + (n - 1));
                cmbBoxThird.Focus();
                return;
            }
        }

        private void cmbBoxForth_TextChanged(object sender, EventArgs e)
        {
            int forth;
            try
            {
                forth = int.Parse(cmbBoxForth.Text);

            }
            catch (Exception)
            {
                MessageBox.Show("Неверно задано значение в ComboBox!");
                cmbBoxForth.Focus();
                return;
            }
            if (forth < 0 || forth > n - 1)
            {
                MessageBox.Show("Значение в ComboBox должны быть от 0 до " + (n - 1));
                cmbBoxForth.Focus();
                return;
            }
        }

        private void addWantRelation_Click(object sender, EventArgs e)
        {
            int third = Convert.ToInt32(cmbBoxThird.Text),
                forth = Convert.ToInt32(cmbBoxForth.Text);
            if (third != forth)
            {
                relations[third, forth] = 1;
                relations[forth, third] = 1;
                MessageBox.Show("Отношение добавлено!");
                cmbBoxThird.Focus();
            }
            else
            {
                MessageBox.Show("Вы выбрали одного и того же человека!");
                cmbBoxThird.Focus();
            }
        }
    }
}

namespace comb_alg_13a
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvInput = new System.Windows.Forms.DataGridView();
            this.dgvRes = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRes = new System.Windows.Forms.TextBox();
            this.btnRes = new System.Windows.Forms.Button();
            this.lblCols = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.tbRows = new System.Windows.Forms.TextBox();
            this.tbCols = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 246);
            this.panel1.TabIndex = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvRes);
            this.splitContainer1.Size = new System.Drawing.Size(662, 246);
            this.splitContainer1.SplitterDistance = 329;
            this.splitContainer1.TabIndex = 1;
            // 
            // dgvInput
            // 
            this.dgvInput.AllowUserToAddRows = false;
            this.dgvInput.AllowUserToDeleteRows = false;
            this.dgvInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInput.Location = new System.Drawing.Point(0, 0);
            this.dgvInput.Name = "dgvInput";
            this.dgvInput.Size = new System.Drawing.Size(329, 246);
            this.dgvInput.TabIndex = 1;
            this.dgvInput.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInput_CellValueChanged);
            // 
            // dgvRes
            // 
            this.dgvRes.AllowUserToAddRows = false;
            this.dgvRes.AllowUserToDeleteRows = false;
            this.dgvRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRes.Location = new System.Drawing.Point(0, 0);
            this.dgvRes.Name = "dgvRes";
            this.dgvRes.ReadOnly = true;
            this.dgvRes.Size = new System.Drawing.Size(329, 246);
            this.dgvRes.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnGenerate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbRes);
            this.panel2.Controls.Add(this.btnRes);
            this.panel2.Controls.Add(this.lblCols);
            this.panel2.Controls.Add(this.lblRows);
            this.panel2.Controls.Add(this.tbRows);
            this.panel2.Controls.Add(this.tbCols);
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(662, 78);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Максимальная сумма";
            // 
            // tbRes
            // 
            this.tbRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbRes.Location = new System.Drawing.Point(533, 37);
            this.tbRes.Name = "tbRes";
            this.tbRes.ReadOnly = true;
            this.tbRes.Size = new System.Drawing.Size(117, 20);
            this.tbRes.TabIndex = 16;
            // 
            // btnRes
            // 
            this.btnRes.Location = new System.Drawing.Point(333, 8);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(92, 23);
            this.btnRes.TabIndex = 15;
            this.btnRes.Text = "Результат";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.btnRes_Click);
            // 
            // lblCols
            // 
            this.lblCols.AutoSize = true;
            this.lblCols.Location = new System.Drawing.Point(91, 21);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(91, 13);
            this.lblCols.TabIndex = 10;
            this.lblCols.Text = "Кол-во столбцов";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(12, 21);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(73, 13);
            this.lblRows.TabIndex = 11;
            this.lblRows.Text = "Кол-во строк";
            // 
            // tbRows
            // 
            this.tbRows.Location = new System.Drawing.Point(15, 37);
            this.tbRows.Name = "tbRows";
            this.tbRows.Size = new System.Drawing.Size(60, 20);
            this.tbRows.TabIndex = 12;
            this.tbRows.TextChanged += new System.EventHandler(this.tbRows_TextChanged);
            // 
            // tbCols
            // 
            this.tbCols.Location = new System.Drawing.Point(94, 37);
            this.tbCols.Name = "tbCols";
            this.tbCols.Size = new System.Drawing.Size(60, 20);
            this.tbCols.TabIndex = 13;
            this.tbCols.TextChanged += new System.EventHandler(this.tbCols_TextChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(210, 8);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(92, 23);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Заполнить";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(210, 37);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(92, 23);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "Сгенерировать";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(333, 37);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 324);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvInput;
        private System.Windows.Forms.DataGridView dgvRes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRes;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Label lblCols;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.TextBox tbRows;
        private System.Windows.Forms.TextBox tbCols;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGenerate;
    }
}


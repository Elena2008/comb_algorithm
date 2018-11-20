namespace combLabFirst
{
    partial class Form
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
            this.txtBoxAmount = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.dgvRelations = new System.Windows.Forms.DataGridView();
            this.labelRelations = new System.Windows.Forms.Label();
            this.txtBoxRes = new System.Windows.Forms.TextBox();
            this.labelComb = new System.Windows.Forms.Label();
            this.txtBoxCntRes = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelations)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxAmount
            // 
            this.txtBoxAmount.Location = new System.Drawing.Point(15, 36);
            this.txtBoxAmount.Name = "txtBoxAmount";
            this.txtBoxAmount.Size = new System.Drawing.Size(69, 20);
            this.txtBoxAmount.TabIndex = 1;
            this.txtBoxAmount.TextChanged += new System.EventHandler(this.txtBoxAmount_TextChanged);
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(12, 20);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(150, 13);
            this.labelNumber.TabIndex = 0;
            this.labelNumber.Text = "Введите количество гостей:";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(15, 178);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 47);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Показать возможные рассадки";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dgvRelations
            // 
            this.dgvRelations.AllowUserToAddRows = false;
            this.dgvRelations.AllowUserToDeleteRows = false;
            this.dgvRelations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRelations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelations.Location = new System.Drawing.Point(308, 36);
            this.dgvRelations.MultiSelect = false;
            this.dgvRelations.Name = "dgvRelations";
            this.dgvRelations.RowHeadersWidth = 45;
            this.dgvRelations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRelations.Size = new System.Drawing.Size(254, 189);
            this.dgvRelations.TabIndex = 8;
            this.dgvRelations.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRelations_CellValueChanged);
            // 
            // labelRelations
            // 
            this.labelRelations.AutoSize = true;
            this.labelRelations.Location = new System.Drawing.Point(305, 20);
            this.labelRelations.Name = "labelRelations";
            this.labelRelations.Size = new System.Drawing.Size(148, 13);
            this.labelRelations.TabIndex = 9;
            this.labelRelations.Text = "Отношения между гостями:";
            // 
            // txtBoxRes
            // 
            this.txtBoxRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxRes.Location = new System.Drawing.Point(611, 67);
            this.txtBoxRes.Multiline = true;
            this.txtBoxRes.Name = "txtBoxRes";
            this.txtBoxRes.ReadOnly = true;
            this.txtBoxRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxRes.Size = new System.Drawing.Size(164, 158);
            this.txtBoxRes.TabIndex = 10;
            // 
            // labelComb
            // 
            this.labelComb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelComb.AutoSize = true;
            this.labelComb.Location = new System.Drawing.Point(608, 20);
            this.labelComb.Name = "labelComb";
            this.labelComb.Size = new System.Drawing.Size(111, 13);
            this.labelComb.TabIndex = 11;
            this.labelComb.Text = "Варианты рассадки:";
            // 
            // txtBoxCntRes
            // 
            this.txtBoxCntRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxCntRes.Location = new System.Drawing.Point(611, 36);
            this.txtBoxCntRes.Name = "txtBoxCntRes";
            this.txtBoxCntRes.ReadOnly = true;
            this.txtBoxCntRes.Size = new System.Drawing.Size(164, 20);
            this.txtBoxCntRes.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.Location = new System.Drawing.Point(96, 178);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 47);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Сбросить данные";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Location = new System.Drawing.Point(177, 178);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 47);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(177, 33);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 257);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBoxCntRes);
            this.Controls.Add(this.labelComb);
            this.Controls.Add(this.txtBoxRes);
            this.Controls.Add(this.labelRelations);
            this.Controls.Add(this.dgvRelations);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.txtBoxAmount);
            this.Name = "Form";
            this.Text = "Гости";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxAmount;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dgvRelations;
        private System.Windows.Forms.Label labelRelations;
        private System.Windows.Forms.TextBox txtBoxRes;
        private System.Windows.Forms.Label labelComb;
        private System.Windows.Forms.TextBox txtBoxCntRes;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOk;
    }
}


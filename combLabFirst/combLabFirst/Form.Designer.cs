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
            this.btnAddRelation = new System.Windows.Forms.Button();
            this.cmbBoxFirst = new System.Windows.Forms.ComboBox();
            this.txtBoxAmount = new System.Windows.Forms.TextBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblAnd = new System.Windows.Forms.Label();
            this.cmbBoxSecond = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.dgvRelations = new System.Windows.Forms.DataGridView();
            this.labelRelations = new System.Windows.Forms.Label();
            this.txtBoxRes = new System.Windows.Forms.TextBox();
            this.labelComb = new System.Windows.Forms.Label();
            this.txtBoxCntRes = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbBoxForth = new System.Windows.Forms.ComboBox();
            this.lblAnd2 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.addWantRelation = new System.Windows.Forms.Button();
            this.cmbBoxThird = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddRelation
            // 
            this.btnAddRelation.Enabled = false;
            this.btnAddRelation.Location = new System.Drawing.Point(174, 93);
            this.btnAddRelation.Name = "btnAddRelation";
            this.btnAddRelation.Size = new System.Drawing.Size(65, 23);
            this.btnAddRelation.TabIndex = 4;
            this.btnAddRelation.Text = "Добавить ";
            this.btnAddRelation.UseVisualStyleBackColor = true;
            this.btnAddRelation.Click += new System.EventHandler(this.btnAddRelation_Click);
            // 
            // cmbBoxFirst
            // 
            this.cmbBoxFirst.Enabled = false;
            this.cmbBoxFirst.FormatString = "N0";
            this.cmbBoxFirst.FormattingEnabled = true;
            this.cmbBoxFirst.Location = new System.Drawing.Point(12, 95);
            this.cmbBoxFirst.Name = "cmbBoxFirst";
            this.cmbBoxFirst.Size = new System.Drawing.Size(52, 21);
            this.cmbBoxFirst.TabIndex = 2;
            this.cmbBoxFirst.TextChanged += new System.EventHandler(this.cmbBoxFirst_TextChanged);
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
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 79);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(129, 13);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Не хотят сидеть вместе";
            // 
            // lblAnd
            // 
            this.lblAnd.AutoSize = true;
            this.lblAnd.Location = new System.Drawing.Point(70, 98);
            this.lblAnd.Name = "lblAnd";
            this.lblAnd.Size = new System.Drawing.Size(13, 13);
            this.lblAnd.TabIndex = 6;
            this.lblAnd.Text = "и";
            // 
            // cmbBoxSecond
            // 
            this.cmbBoxSecond.Enabled = false;
            this.cmbBoxSecond.FormattingEnabled = true;
            this.cmbBoxSecond.Location = new System.Drawing.Point(89, 95);
            this.cmbBoxSecond.Name = "cmbBoxSecond";
            this.cmbBoxSecond.Size = new System.Drawing.Size(52, 21);
            this.cmbBoxSecond.TabIndex = 3;
            this.cmbBoxSecond.TextChanged += new System.EventHandler(this.cmbBoxSecond_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(12, 190);
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
            this.dgvRelations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelations.Location = new System.Drawing.Point(308, 48);
            this.dgvRelations.Name = "dgvRelations";
            this.dgvRelations.ReadOnly = true;
            this.dgvRelations.Size = new System.Drawing.Size(254, 189);
            this.dgvRelations.TabIndex = 8;
            // 
            // labelRelations
            // 
            this.labelRelations.AutoSize = true;
            this.labelRelations.Location = new System.Drawing.Point(305, 20);
            this.labelRelations.Name = "labelRelations";
            this.labelRelations.Size = new System.Drawing.Size(292, 26);
            this.labelRelations.TabIndex = 9;
            this.labelRelations.Text = "Отношения между гостями (-1 - не хотят сидеть вместе,\r\n0 - им все равно, 1 - хотя" +
    "т сидеть рядом):";
            // 
            // txtBoxRes
            // 
            this.txtBoxRes.Location = new System.Drawing.Point(611, 67);
            this.txtBoxRes.Multiline = true;
            this.txtBoxRes.Name = "txtBoxRes";
            this.txtBoxRes.ReadOnly = true;
            this.txtBoxRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxRes.Size = new System.Drawing.Size(164, 170);
            this.txtBoxRes.TabIndex = 10;
            // 
            // labelComb
            // 
            this.labelComb.AutoSize = true;
            this.labelComb.Location = new System.Drawing.Point(608, 20);
            this.labelComb.Name = "labelComb";
            this.labelComb.Size = new System.Drawing.Size(111, 13);
            this.labelComb.TabIndex = 11;
            this.labelComb.Text = "Варианты рассадки:";
            // 
            // txtBoxCntRes
            // 
            this.txtBoxCntRes.Location = new System.Drawing.Point(611, 36);
            this.txtBoxCntRes.Name = "txtBoxCntRes";
            this.txtBoxCntRes.ReadOnly = true;
            this.txtBoxCntRes.Size = new System.Drawing.Size(164, 20);
            this.txtBoxCntRes.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(93, 190);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 47);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Сбросить данные";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(174, 190);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 47);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbBoxForth
            // 
            this.cmbBoxForth.Enabled = false;
            this.cmbBoxForth.FormattingEnabled = true;
            this.cmbBoxForth.Location = new System.Drawing.Point(89, 152);
            this.cmbBoxForth.Name = "cmbBoxForth";
            this.cmbBoxForth.Size = new System.Drawing.Size(52, 21);
            this.cmbBoxForth.TabIndex = 16;
            this.cmbBoxForth.TextChanged += new System.EventHandler(this.cmbBoxForth_TextChanged);
            // 
            // lblAnd2
            // 
            this.lblAnd2.AutoSize = true;
            this.lblAnd2.Location = new System.Drawing.Point(70, 155);
            this.lblAnd2.Name = "lblAnd2";
            this.lblAnd2.Size = new System.Drawing.Size(13, 13);
            this.lblAnd2.TabIndex = 19;
            this.lblAnd2.Text = "и";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(12, 136);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(114, 13);
            this.lbl2.TabIndex = 18;
            this.lbl2.Text = "Хотят сидеть вместе";
            // 
            // addWantRelation
            // 
            this.addWantRelation.Enabled = false;
            this.addWantRelation.Location = new System.Drawing.Point(174, 150);
            this.addWantRelation.Name = "addWantRelation";
            this.addWantRelation.Size = new System.Drawing.Size(65, 23);
            this.addWantRelation.TabIndex = 17;
            this.addWantRelation.Text = "Добавить ";
            this.addWantRelation.UseVisualStyleBackColor = true;
            this.addWantRelation.Click += new System.EventHandler(this.addWantRelation_Click);
            // 
            // cmbBoxThird
            // 
            this.cmbBoxThird.Enabled = false;
            this.cmbBoxThird.FormatString = "N0";
            this.cmbBoxThird.FormattingEnabled = true;
            this.cmbBoxThird.Location = new System.Drawing.Point(12, 152);
            this.cmbBoxThird.Name = "cmbBoxThird";
            this.cmbBoxThird.Size = new System.Drawing.Size(52, 21);
            this.cmbBoxThird.TabIndex = 15;
            this.cmbBoxThird.TextChanged += new System.EventHandler(this.cmbBoxThird_TextChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 257);
            this.Controls.Add(this.cmbBoxForth);
            this.Controls.Add(this.lblAnd2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.addWantRelation);
            this.Controls.Add(this.cmbBoxThird);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtBoxCntRes);
            this.Controls.Add(this.labelComb);
            this.Controls.Add(this.txtBoxRes);
            this.Controls.Add(this.labelRelations);
            this.Controls.Add(this.dgvRelations);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbBoxSecond);
            this.Controls.Add(this.lblAnd);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.txtBoxAmount);
            this.Controls.Add(this.btnAddRelation);
            this.Controls.Add(this.cmbBoxFirst);
            this.Name = "Form";
            this.Text = "Гости";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddRelation;
        private System.Windows.Forms.ComboBox cmbBoxFirst;
        private System.Windows.Forms.TextBox txtBoxAmount;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblAnd;
        private System.Windows.Forms.ComboBox cmbBoxSecond;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dgvRelations;
        private System.Windows.Forms.Label labelRelations;
        private System.Windows.Forms.TextBox txtBoxRes;
        private System.Windows.Forms.Label labelComb;
        private System.Windows.Forms.TextBox txtBoxCntRes;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbBoxForth;
        private System.Windows.Forms.Label lblAnd2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button addWantRelation;
        private System.Windows.Forms.ComboBox cmbBoxThird;
    }
}


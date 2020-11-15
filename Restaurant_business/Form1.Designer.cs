namespace Restaurant_business
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.Tabls = new System.Windows.Forms.ComboBox();
            this.delButton = new System.Windows.Forms.Button();
            this.numericUpDownMain = new System.Windows.Forms.NumericUpDown();
            this.toolStripZag = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.labelZag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMain)).BeginInit();
            this.toolStripZag.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 350);
            this.dataGridView1.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.White;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addButton.Location = new System.Drawing.Point(15, 40);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(211, 27);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавление / изменение";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tabls
            // 
            this.Tabls.BackColor = System.Drawing.Color.White;
            this.Tabls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tabls.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.Tabls.ForeColor = System.Drawing.Color.Black;
            this.Tabls.FormattingEnabled = true;
            this.Tabls.Items.AddRange(new object[] {
            "Агент",
            "Компания",
            "Заказ",
            "Продукт"});
            this.Tabls.Location = new System.Drawing.Point(232, 42);
            this.Tabls.Name = "Tabls";
            this.Tabls.Size = new System.Drawing.Size(121, 25);
            this.Tabls.TabIndex = 3;
            this.Tabls.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.Color.White;
            this.delButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.delButton.Location = new System.Drawing.Point(535, 38);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(127, 28);
            this.delButton.TabIndex = 4;
            this.delButton.Text = "Удаление";
            this.delButton.UseVisualStyleBackColor = false;
            this.delButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // numericUpDownMain
            // 
            this.numericUpDownMain.BackColor = System.Drawing.Color.White;
            this.numericUpDownMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDownMain.Location = new System.Drawing.Point(460, 39);
            this.numericUpDownMain.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownMain.Name = "numericUpDownMain";
            this.numericUpDownMain.Size = new System.Drawing.Size(69, 26);
            this.numericUpDownMain.TabIndex = 5;
            // 
            // toolStripZag
            // 
            this.toolStripZag.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripZag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2});
            this.toolStripZag.Location = new System.Drawing.Point(0, 425);
            this.toolStripZag.Name = "toolStripZag";
            this.toolStripZag.Size = new System.Drawing.Size(671, 25);
            this.toolStripZag.TabIndex = 6;
            this.toolStripZag.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(72, 22);
            this.toolStripLabel1.Text = "Минаев Г.В.";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel2.Text = "ПКсп-117";
            // 
            // labelZag
            // 
            this.labelZag.AutoSize = true;
            this.labelZag.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelZag.Location = new System.Drawing.Point(227, 9);
            this.labelZag.Name = "labelZag";
            this.labelZag.Size = new System.Drawing.Size(227, 26);
            this.labelZag.TabIndex = 7;
            this.labelZag.Text = "Ресторанный бизнес";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(671, 450);
            this.Controls.Add(this.labelZag);
            this.Controls.Add(this.toolStripZag);
            this.Controls.Add(this.numericUpDownMain);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.Tabls);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMain)).EndInit();
            this.toolStripZag.ResumeLayout(false);
            this.toolStripZag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox Tabls;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.NumericUpDown numericUpDownMain;
        private System.Windows.Forms.ToolStrip toolStripZag;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Label labelZag;
    }
}


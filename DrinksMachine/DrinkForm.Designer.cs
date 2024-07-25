namespace DrinksMachine
{
    partial class DrinkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboCoffee = new System.Windows.Forms.ComboBox();
            this.comboCocoa = new System.Windows.Forms.ComboBox();
            this.comboSugar = new System.Windows.Forms.ComboBox();
            this.comboMilk = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdat = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(73, 111);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(154, 22);
            this.numericUpDown1.TabIndex = 41;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(677, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "סוג שתייה חדש";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "מחיר";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(487, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(167, 22);
            this.textBox2.TabIndex = 38;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "חלב";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "קפה";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(703, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "סוכר";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(573, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "קקאו";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(345, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "מכונת קפה ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboCoffee
            // 
            this.comboCoffee.FormattingEnabled = true;
            this.comboCoffee.Items.AddRange(new object[] {
            "0",
            "0.1",
            "1",
            "1.5",
            "2"});
            this.comboCoffee.Location = new System.Drawing.Point(406, 155);
            this.comboCoffee.Name = "comboCoffee";
            this.comboCoffee.Size = new System.Drawing.Size(121, 24);
            this.comboCoffee.TabIndex = 29;
            this.comboCoffee.SelectedIndexChanged += new System.EventHandler(this.comboCoffee_SelectedIndexChanged);
            // 
            // comboCocoa
            // 
            this.comboCocoa.FormattingEnabled = true;
            this.comboCocoa.Items.AddRange(new object[] {
            "0",
            "0.1",
            "1",
            "1.5",
            "2"});
            this.comboCocoa.Location = new System.Drawing.Point(533, 155);
            this.comboCocoa.Name = "comboCocoa";
            this.comboCocoa.Size = new System.Drawing.Size(121, 24);
            this.comboCocoa.TabIndex = 28;
            this.comboCocoa.SelectedIndexChanged += new System.EventHandler(this.comboCocoa_SelectedIndexChanged);
            // 
            // comboSugar
            // 
            this.comboSugar.FormattingEnabled = true;
            this.comboSugar.Items.AddRange(new object[] {
            "0",
            "0.1",
            "1",
            "1.5",
            "2"});
            this.comboSugar.Location = new System.Drawing.Point(660, 155);
            this.comboSugar.Name = "comboSugar";
            this.comboSugar.Size = new System.Drawing.Size(121, 24);
            this.comboSugar.TabIndex = 27;
            this.comboSugar.SelectedIndexChanged += new System.EventHandler(this.comboSugar_SelectedIndexChanged);
            // 
            // comboMilk
            // 
            this.comboMilk.FormattingEnabled = true;
            this.comboMilk.Items.AddRange(new object[] {
            "0",
            "0.1",
            "1",
            "1.5",
            "2"});
            this.comboMilk.Location = new System.Drawing.Point(279, 155);
            this.comboMilk.Name = "comboMilk";
            this.comboMilk.Size = new System.Drawing.Size(121, 24);
            this.comboMilk.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(215, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(555, 218);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 54);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "שמירה";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(20, 316);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 52);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "מחיקה";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdat
            // 
            this.btnUpdat.Location = new System.Drawing.Point(20, 262);
            this.btnUpdat.Name = "btnUpdat";
            this.btnUpdat.Size = new System.Drawing.Size(126, 48);
            this.btnUpdat.TabIndex = 22;
            this.btnUpdat.Text = "עדכן";
            this.btnUpdat.UseVisualStyleBackColor = true;
            this.btnUpdat.Click += new System.EventHandler(this.btnUpdat_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdd.Location = new System.Drawing.Point(20, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 46);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "הוספת סוג שתייה ";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // DrinkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboCoffee);
            this.Controls.Add(this.comboCocoa);
            this.Controls.Add(this.comboSugar);
            this.Controls.Add(this.comboMilk);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdat);
            this.Controls.Add(this.btnAdd);
            this.Name = "DrinkForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboCoffee;
        private System.Windows.Forms.ComboBox comboCocoa;
        private System.Windows.Forms.ComboBox comboSugar;
        private System.Windows.Forms.ComboBox comboMilk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdat;
        private System.Windows.Forms.Button btnAdd;
    }
}


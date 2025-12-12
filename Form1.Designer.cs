namespace ResponsiJunpro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            gbDev = new GroupBox();
            cbKontak = new ComboBox();
            cbProyek = new ComboBox();
            tbNameDev = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            gbKinerja = new GroupBox();
            label10 = new Label();
            label9 = new Label();
            tbBug = new TextBox();
            tbFitur = new TextBox();
            label8 = new Label();
            label7 = new Label();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            gbData = new GroupBox();
            dataGridView1 = new DataGridView();
            label11 = new Label();
            gbDev.SuspendLayout();
            gbKinerja.SuspendLayout();
            gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 21);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "LOGO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(294, 21);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 1;
            label2.Text = "Responsi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(220, 42);
            label3.Name = "label3";
            label3.Size = new Size(222, 17);
            label3.TabIndex = 2;
            label3.Text = "Developer Team Perfomance Tracker";
            // 
            // gbDev
            // 
            gbDev.Controls.Add(cbKontak);
            gbDev.Controls.Add(cbProyek);
            gbDev.Controls.Add(tbNameDev);
            gbDev.Controls.Add(label6);
            gbDev.Controls.Add(label5);
            gbDev.Controls.Add(label4);
            gbDev.Location = new Point(12, 83);
            gbDev.Name = "gbDev";
            gbDev.Size = new Size(605, 126);
            gbDev.TabIndex = 3;
            gbDev.TabStop = false;
            gbDev.Text = "DATA DEVELOPER";
            gbDev.Enter += groupBox1_Enter;
            // 
            // cbKontak
            // 
            cbKontak.FormattingEnabled = true;
            cbKontak.Location = new Point(139, 87);
            cbKontak.Name = "cbKontak";
            cbKontak.Size = new Size(185, 23);
            cbKontak.TabIndex = 5;
            // 
            // cbProyek
            // 
            cbProyek.FormattingEnabled = true;
            cbProyek.Location = new Point(139, 56);
            cbProyek.Name = "cbProyek";
            cbProyek.Size = new Size(185, 23);
            cbProyek.TabIndex = 4;
            // 
            // tbNameDev
            // 
            tbNameDev.Location = new Point(139, 25);
            tbNameDev.Name = "tbNameDev";
            tbNameDev.Size = new Size(185, 23);
            tbNameDev.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 90);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 2;
            label6.Text = "Status Kontak :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 59);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 1;
            label5.Text = "Pilih Proyek :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 28);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 0;
            label4.Text = "Nama Developer :";
            // 
            // gbKinerja
            // 
            gbKinerja.Controls.Add(label10);
            gbKinerja.Controls.Add(label9);
            gbKinerja.Controls.Add(tbBug);
            gbKinerja.Controls.Add(tbFitur);
            gbKinerja.Controls.Add(label8);
            gbKinerja.Controls.Add(label7);
            gbKinerja.Location = new Point(12, 226);
            gbKinerja.Name = "gbKinerja";
            gbKinerja.Size = new Size(605, 119);
            gbKinerja.TabIndex = 4;
            gbKinerja.TabStop = false;
            gbKinerja.Text = "DATA KINERJA";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(339, 73);
            label10.Name = "label10";
            label10.Size = new Size(166, 15);
            label10.TabIndex = 8;
            label10.Text = "(Jumlah bug yang ditemukan)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(339, 29);
            label9.Name = "label9";
            label9.Size = new Size(164, 15);
            label9.TabIndex = 7;
            label9.Text = "(Jumlah fitur yang dikerjakan)";
            label9.Click += label9_Click;
            // 
            // tbBug
            // 
            tbBug.Location = new Point(139, 70);
            tbBug.Name = "tbBug";
            tbBug.Size = new Size(185, 23);
            tbBug.TabIndex = 6;
            // 
            // tbFitur
            // 
            tbFitur.Location = new Point(139, 26);
            tbFitur.Name = "tbFitur";
            tbFitur.Size = new Size(185, 23);
            tbFitur.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 73);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 4;
            label8.Text = "Jumlah Bug :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 34);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 3;
            label7.Text = "Fitur Selesai :";
            // 
            // btnInsert
            // 
            btnInsert.BackColor = SystemColors.GradientActiveCaption;
            btnInsert.Location = new Point(44, 365);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(137, 38);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.GradientActiveCaption;
            btnUpdate.Location = new Point(235, 365);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(137, 38);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.GradientActiveCaption;
            btnDelete.Location = new Point(428, 365);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 38);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // gbData
            // 
            gbData.Controls.Add(dataGridView1);
            gbData.Location = new Point(12, 419);
            gbData.Name = "gbData";
            gbData.Size = new Size(605, 154);
            gbData.TabIndex = 5;
            gbData.TabStop = false;
            gbData.Text = "DAFTAR PERFORMA TIM";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(605, 126);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(491, 9);
            label11.Name = "label11";
            label11.Size = new Size(126, 17);
            label11.TabIndex = 8;
            label11.Text = "Amira Syafika Pohan";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 585);
            Controls.Add(label11);
            Controls.Add(gbData);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(gbKinerja);
            Controls.Add(gbDev);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            gbDev.ResumeLayout(false);
            gbDev.PerformLayout();
            gbKinerja.ResumeLayout(false);
            gbKinerja.PerformLayout();
            gbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox gbDev;
        private GroupBox gbKinerja;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private GroupBox gbData;
        private ComboBox cbKontak;
        private ComboBox cbProyek;
        private TextBox tbNameDev;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label10;
        private Label label9;
        private TextBox tbBug;
        private TextBox tbFitur;
        private Label label8;
        private Label label7;
        private DataGridView dataGridView1;
        private Label label11;
    }
}

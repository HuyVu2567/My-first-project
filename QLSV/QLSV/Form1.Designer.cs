namespace QLSV
{
    partial class Form1
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaSVV = new System.Windows.Forms.TextBox();
            this.txtTenSvv = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtNamSinhh = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDiaChii = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewSinhVien = new System.Windows.Forms.DataGridView();
            this.Idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSVV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSVV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamSinhh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(309, 234);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 49);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaSVV
            // 
            this.txtMaSVV.Location = new System.Drawing.Point(125, 12);
            this.txtMaSVV.Multiline = true;
            this.txtMaSVV.Name = "txtMaSVV";
            this.txtMaSVV.Size = new System.Drawing.Size(151, 25);
            this.txtMaSVV.TabIndex = 1;
            // 
            // txtTenSvv
            // 
            this.txtTenSvv.Location = new System.Drawing.Point(125, 54);
            this.txtTenSvv.Multiline = true;
            this.txtTenSvv.Name = "txtTenSvv";
            this.txtTenSvv.Size = new System.Drawing.Size(151, 29);
            this.txtTenSvv.TabIndex = 4;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(201, 234);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 49);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtNamSinhh
            // 
            this.txtNamSinhh.Location = new System.Drawing.Point(125, 102);
            this.txtNamSinhh.Multiline = true;
            this.txtNamSinhh.Name = "txtNamSinhh";
            this.txtNamSinhh.Size = new System.Drawing.Size(100, 31);
            this.txtNamSinhh.TabIndex = 6;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(94, 234);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 51);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDiaChii
            // 
            this.txtDiaChii.Location = new System.Drawing.Point(125, 149);
            this.txtDiaChii.Multiline = true;
            this.txtDiaChii.Name = "txtDiaChii";
            this.txtDiaChii.Size = new System.Drawing.Size(235, 33);
            this.txtDiaChii.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 9;
            this.label5.Tag = "Mã sinh viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tên sinh viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(63, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Năm sinh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(63, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Địa chỉ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Mã sinh viên";
            // 
            // dataGridViewSinhVien
            // 
            this.dataGridViewSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idd,
            this.MaSVV,
            this.TenSVV,
            this.NamSinhh,
            this.DiaChii});
            this.dataGridViewSinhVien.Location = new System.Drawing.Point(12, 382);
            this.dataGridViewSinhVien.Name = "dataGridViewSinhVien";
            this.dataGridViewSinhVien.Size = new System.Drawing.Size(807, 178);
            this.dataGridViewSinhVien.TabIndex = 14;
            this.dataGridViewSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSinhVien_CellClick);
            // 
            // Idd
            // 
            this.Idd.DataPropertyName = "Idd";
            this.Idd.HeaderText = "Id";
            this.Idd.Name = "Idd";
            this.Idd.Visible = false;
            // 
            // MaSVV
            // 
            this.MaSVV.DataPropertyName = "MaSVV";
            this.MaSVV.HeaderText = "Mã Sinh Viên";
            this.MaSVV.Name = "MaSVV";
            // 
            // TenSVV
            // 
            this.TenSVV.DataPropertyName = "TenSVV";
            this.TenSVV.HeaderText = "Tên Sinh Viên";
            this.TenSVV.Name = "TenSVV";
            this.TenSVV.Width = 200;
            // 
            // NamSinhh
            // 
            this.NamSinhh.DataPropertyName = "NamSinhh";
            this.NamSinhh.HeaderText = "Năm Sinh";
            this.NamSinhh.Name = "NamSinhh";
            // 
            // DiaChii
            // 
            this.DiaChii.DataPropertyName = "DiaChii";
            this.DiaChii.HeaderText = "Địa Chỉ";
            this.DiaChii.Name = "DiaChii";
            this.DiaChii.Width = 400;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(826, 572);
            this.Controls.Add(this.dataGridViewSinhVien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiaChii);
            this.Controls.Add(this.txtNamSinhh);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenSvv);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtMaSVV);
            this.Controls.Add(this.btnXoa);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMaSVV;
        private System.Windows.Forms.TextBox txtTenSvv;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtNamSinhh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDiaChii;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idd;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSVV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSVV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamSinhh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChii;
    }
}


namespace BaiThucHanh9
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
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblMaSinhVien = new System.Windows.Forms.Label();
            this.lblDiemLan1 = new System.Windows.Forms.Label();
            this.lblDiemLan2 = new System.Windows.Forms.Label();
            this.lblMonHoc = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMaSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMonHoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDiemLan1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDiemLan2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDiemLan1 = new System.Windows.Forms.TextBox();
            this.txtDiemLan2 = new System.Windows.Forms.TextBox();
            this.cmbMaSinhVien = new System.Windows.Forms.ComboBox();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.Location = new System.Drawing.Point(124, 9);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(297, 22);
            this.lblTittle.TabIndex = 0;
            this.lblTittle.Text = "CẬP NHẬT KẾT QUẢ HỌC TẬP";
            // 
            // lblMaSinhVien
            // 
            this.lblMaSinhVien.AutoSize = true;
            this.lblMaSinhVien.Location = new System.Drawing.Point(33, 57);
            this.lblMaSinhVien.Name = "lblMaSinhVien";
            this.lblMaSinhVien.Size = new System.Drawing.Size(67, 13);
            this.lblMaSinhVien.TabIndex = 1;
            this.lblMaSinhVien.Text = "Mã sinh viên";
            // 
            // lblDiemLan1
            // 
            this.lblDiemLan1.AutoSize = true;
            this.lblDiemLan1.Location = new System.Drawing.Point(42, 104);
            this.lblDiemLan1.Name = "lblDiemLan1";
            this.lblDiemLan1.Size = new System.Drawing.Size(57, 13);
            this.lblDiemLan1.TabIndex = 2;
            this.lblDiemLan1.Text = "Điểm lần 1";
            // 
            // lblDiemLan2
            // 
            this.lblDiemLan2.AutoSize = true;
            this.lblDiemLan2.Location = new System.Drawing.Point(286, 104);
            this.lblDiemLan2.Name = "lblDiemLan2";
            this.lblDiemLan2.Size = new System.Drawing.Size(57, 13);
            this.lblDiemLan2.TabIndex = 3;
            this.lblDiemLan2.Text = "Điểm lần 2";
            // 
            // lblMonHoc
            // 
            this.lblMonHoc.AutoSize = true;
            this.lblMonHoc.Location = new System.Drawing.Point(293, 57);
            this.lblMonHoc.Name = "lblMonHoc";
            this.lblMonHoc.Size = new System.Drawing.Size(49, 13);
            this.lblMonHoc.TabIndex = 4;
            this.lblMonHoc.Text = "Môn học";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(92, 145);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(193, 145);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(289, 145);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(387, 145);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmSTT,
            this.clmMaSV,
            this.clmMonHoc,
            this.clmDiemLan1,
            this.clmDiemLan2});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 186);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(510, 179);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // clmSTT
            // 
            this.clmSTT.Text = "STT";
            // 
            // clmMaSV
            // 
            this.clmMaSV.Text = "Mã SV";
            this.clmMaSV.Width = 160;
            // 
            // clmMonHoc
            // 
            this.clmMonHoc.Text = "Môn Học";
            this.clmMonHoc.Width = 147;
            // 
            // clmDiemLan1
            // 
            this.clmDiemLan1.Text = "Điểm Lần 1";
            this.clmDiemLan1.Width = 70;
            // 
            // clmDiemLan2
            // 
            this.clmDiemLan2.Text = "Điểm Lần 2";
            this.clmDiemLan2.Width = 69;
            // 
            // txtDiemLan1
            // 
            this.txtDiemLan1.Location = new System.Drawing.Point(105, 101);
            this.txtDiemLan1.Name = "txtDiemLan1";
            this.txtDiemLan1.Size = new System.Drawing.Size(141, 20);
            this.txtDiemLan1.TabIndex = 10;
            // 
            // txtDiemLan2
            // 
            this.txtDiemLan2.Location = new System.Drawing.Point(348, 101);
            this.txtDiemLan2.Name = "txtDiemLan2";
            this.txtDiemLan2.Size = new System.Drawing.Size(141, 20);
            this.txtDiemLan2.TabIndex = 11;
            // 
            // cmbMaSinhVien
            // 
            this.cmbMaSinhVien.FormattingEnabled = true;
            this.cmbMaSinhVien.Location = new System.Drawing.Point(105, 54);
            this.cmbMaSinhVien.Name = "cmbMaSinhVien";
            this.cmbMaSinhVien.Size = new System.Drawing.Size(141, 21);
            this.cmbMaSinhVien.TabIndex = 12;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(348, 54);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(141, 21);
            this.cmbMonHoc.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 375);
            this.Controls.Add(this.cmbMonHoc);
            this.Controls.Add(this.cmbMaSinhVien);
            this.Controls.Add(this.txtDiemLan2);
            this.Controls.Add(this.txtDiemLan1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblMonHoc);
            this.Controls.Add(this.lblDiemLan2);
            this.Controls.Add(this.lblDiemLan1);
            this.Controls.Add(this.lblMaSinhVien);
            this.Controls.Add(this.lblTittle);
            this.Name = "Form1";
            this.Text = "Kết quả học tập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label lblMaSinhVien;
        private System.Windows.Forms.Label lblDiemLan1;
        private System.Windows.Forms.Label lblDiemLan2;
        private System.Windows.Forms.Label lblMonHoc;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader clmSTT;
        private System.Windows.Forms.ColumnHeader clmMaSV;
        private System.Windows.Forms.ColumnHeader clmMonHoc;
        private System.Windows.Forms.ColumnHeader clmDiemLan1;
        private System.Windows.Forms.ColumnHeader clmDiemLan2;
        private System.Windows.Forms.TextBox txtDiemLan1;
        private System.Windows.Forms.TextBox txtDiemLan2;
        private System.Windows.Forms.ComboBox cmbMaSinhVien;
        private System.Windows.Forms.ComboBox cmbMonHoc;
    }
}


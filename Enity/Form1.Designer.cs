namespace Enity
{
    partial class frmQLSV
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSInhVien = new System.Windows.Forms.GroupBox();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.clMssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpSInhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Thông Tin Sinh Viên";
            // 
            // grpSInhVien
            // 
            this.grpSInhVien.Controls.Add(this.cmbFaculty);
            this.grpSInhVien.Controls.Add(this.txtAverageScore);
            this.grpSInhVien.Controls.Add(this.txtFullname);
            this.grpSInhVien.Controls.Add(this.txtStudentId);
            this.grpSInhVien.Controls.Add(this.label5);
            this.grpSInhVien.Controls.Add(this.label4);
            this.grpSInhVien.Controls.Add(this.label3);
            this.grpSInhVien.Controls.Add(this.label2);
            this.grpSInhVien.Location = new System.Drawing.Point(177, 71);
            this.grpSInhVien.Name = "grpSInhVien";
            this.grpSInhVien.Size = new System.Drawing.Size(388, 246);
            this.grpSInhVien.TabIndex = 1;
            this.grpSInhVien.TabStop = false;
            this.grpSInhVien.Text = "Thông Tin Sinh Viên";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(97, 139);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(226, 24);
            this.cmbFaculty.TabIndex = 8;
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Location = new System.Drawing.Point(97, 190);
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.Size = new System.Drawing.Size(226, 22);
            this.txtAverageScore.TabIndex = 7;
            // 
            // txtFullname
            // 
            this.txtFullname.Location = new System.Drawing.Point(97, 85);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(226, 22);
            this.txtFullname.TabIndex = 6;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(97, 37);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(226, 22);
            this.txtStudentId.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Điểm TB:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Khoa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "MSSV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ Tên:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(230, 340);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(342, 340);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(448, 340);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMssv,
            this.clFullname,
            this.clFaculty,
            this.clDiemTB});
            this.dgvStudent.Location = new System.Drawing.Point(606, 84);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(646, 279);
            this.dgvStudent.TabIndex = 5;
            // 
            // clMssv
            // 
            this.clMssv.HeaderText = "Mã Số SV";
            this.clMssv.MinimumWidth = 6;
            this.clMssv.Name = "clMssv";
            // 
            // clFullname
            // 
            this.clFullname.HeaderText = "Họ Tên";
            this.clFullname.MinimumWidth = 6;
            this.clFullname.Name = "clFullname";
            // 
            // clFaculty
            // 
            this.clFaculty.HeaderText = "Khoa";
            this.clFaculty.MinimumWidth = 6;
            this.clFaculty.Name = "clFaculty";
            // 
            // clDiemTB
            // 
            this.clDiemTB.HeaderText = "Điểm Trung Bình";
            this.clDiemTB.MinimumWidth = 6;
            this.clDiemTB.Name = "clDiemTB";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1177, 395);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpSInhVien);
            this.Controls.Add(this.label1);
            this.Name = "frmQLSV";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.frmQLSV_Load);
            this.grpSInhVien.ResumeLayout(false);
            this.grpSInhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSInhVien;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.TextBox txtFullname;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiemTB;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}


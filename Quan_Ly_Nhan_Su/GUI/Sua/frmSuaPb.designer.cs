namespace Quan_Ly_Nhan_Su.GUI.Sua
{
    partial class frmSuaPB
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTruongPhongMoi = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTenMoi = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtViTriCu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTruongPhongCu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenCu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtViTriMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtViTriMoi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbTruongPhongMoi);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtTenMoi);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(462, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 240);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mới";
            // 
            // cbTruongPhongMoi
            // 
            this.cbTruongPhongMoi.FormattingEnabled = true;
            this.cbTruongPhongMoi.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbTruongPhongMoi.Location = new System.Drawing.Point(118, 93);
            this.cbTruongPhongMoi.Name = "cbTruongPhongMoi";
            this.cbTruongPhongMoi.Size = new System.Drawing.Size(210, 24);
            this.cbTruongPhongMoi.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(7, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 23);
            this.label13.TabIndex = 2;
            this.label13.Text = "Trưởng Phòng:";
            // 
            // txtTenMoi
            // 
            this.txtTenMoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMoi.Location = new System.Drawing.Point(118, 33);
            this.txtTenMoi.Name = "txtTenMoi";
            this.txtTenMoi.Size = new System.Drawing.Size(210, 27);
            this.txtTenMoi.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(7, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 23);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tên Phòng:";
            // 
            // btnDong
            // 
            this.btnDong.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDong.Location = new System.Drawing.Point(501, 354);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(111, 51);
            this.btnDong.TabIndex = 20;
            this.btnDong.Text = "Hủy";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(259, 354);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(111, 51);
            this.btnXacNhan.TabIndex = 21;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtViTriCu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTruongPhongCu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenCu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 240);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiện Tại";
            // 
            // txtViTriCu
            // 
            this.txtViTriCu.Enabled = false;
            this.txtViTriCu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViTriCu.Location = new System.Drawing.Point(122, 157);
            this.txtViTriCu.Name = "txtViTriCu";
            this.txtViTriCu.Size = new System.Drawing.Size(206, 27);
            this.txtViTriCu.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Vị Trí:";
            // 
            // txtTruongPhongCu
            // 
            this.txtTruongPhongCu.Enabled = false;
            this.txtTruongPhongCu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTruongPhongCu.Location = new System.Drawing.Point(122, 94);
            this.txtTruongPhongCu.Name = "txtTruongPhongCu";
            this.txtTruongPhongCu.Size = new System.Drawing.Size(206, 27);
            this.txtTruongPhongCu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trưởng Phòng:";
            // 
            // txtTenCu
            // 
            this.txtTenCu.Enabled = false;
            this.txtTenCu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCu.Location = new System.Drawing.Point(122, 33);
            this.txtTenCu.Name = "txtTenCu";
            this.txtTenCu.Size = new System.Drawing.Size(206, 27);
            this.txtTenCu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Phòng:";
            // 
            // txtViTriMoi
            // 
            this.txtViTriMoi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViTriMoi.Location = new System.Drawing.Point(118, 157);
            this.txtViTriMoi.Name = "txtViTriMoi";
            this.txtViTriMoi.Size = new System.Drawing.Size(210, 27);
            this.txtViTriMoi.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Vị Trí:";
            // 
            // frmSuaPB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 467);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSuaPB";
            this.Text = "frmSuaHS";
            this.Load += new System.EventHandler(this.frmSuaPB_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbTruongPhongMoi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTenMoi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtViTriCu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTruongPhongCu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenCu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtViTriMoi;
        private System.Windows.Forms.Label label3;
    }
}
namespace _20T1020657
{
    partial class frmtimkiemhoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmtimkiemhoadon));
            panel3 = new Panel();
            btndong = new Button();
            btntimlai = new Button();
            btntimkiem = new Button();
            panel1 = new Panel();
            txttongtien = new TextBox();
            txtmanhanvien = new TextBox();
            txtthang = new TextBox();
            txtnam = new TextBox();
            txtmakhach = new TextBox();
            txtmaHD = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvtkhoadon = new DataGridView();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvtkhoadon).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(btndong);
            panel3.Controls.Add(btntimlai);
            panel3.Controls.Add(btntimkiem);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 440);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 51);
            panel3.TabIndex = 7;
            // 
            // btndong
            // 
            btndong.BackColor = Color.Red;
            btndong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btndong.ForeColor = SystemColors.ActiveCaptionText;
            btndong.Image = (Image)resources.GetObject("btndong.Image");
            btndong.ImageAlign = ContentAlignment.MiddleLeft;
            btndong.Location = new Point(502, 8);
            btndong.Name = "btndong";
            btndong.Size = new Size(150, 34);
            btndong.TabIndex = 5;
            btndong.Text = "Đóng";
            btndong.UseVisualStyleBackColor = false;
            btndong.Click += btndong_Click;
            // 
            // btntimlai
            // 
            btntimlai.BackColor = Color.Lime;
            btntimlai.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btntimlai.ForeColor = Color.Black;
            btntimlai.Image = (Image)resources.GetObject("btntimlai.Image");
            btntimlai.ImageAlign = ContentAlignment.MiddleLeft;
            btntimlai.Location = new Point(310, 8);
            btntimlai.Name = "btntimlai";
            btntimlai.Size = new Size(147, 34);
            btntimlai.TabIndex = 4;
            btntimlai.Text = "Tìm lại";
            btntimlai.UseVisualStyleBackColor = false;
            btntimlai.Click += btntimlai_Click;
            // 
            // btntimkiem
            // 
            btntimkiem.BackColor = Color.Lime;
            btntimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btntimkiem.ForeColor = Color.Black;
            btntimkiem.Image = (Image)resources.GetObject("btntimkiem.Image");
            btntimkiem.ImageAlign = ContentAlignment.MiddleLeft;
            btntimkiem.Location = new Point(102, 8);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(162, 34);
            btntimkiem.TabIndex = 3;
            btntimkiem.Text = "Tìm kiếm";
            btntimkiem.UseVisualStyleBackColor = false;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txttongtien);
            panel1.Controls.Add(txtmanhanvien);
            panel1.Controls.Add(txtthang);
            panel1.Controls.Add(txtnam);
            panel1.Controls.Add(txtmakhach);
            panel1.Controls.Add(txtmaHD);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 132);
            panel1.TabIndex = 8;
            // 
            // txttongtien
            // 
            txttongtien.Location = new Point(560, 63);
            txttongtien.Name = "txttongtien";
            txttongtien.Size = new Size(237, 31);
            txttongtien.TabIndex = 12;
            txttongtien.KeyPress += txttongtien_KeyPress;
            // 
            // txtmanhanvien
            // 
            txtmanhanvien.Location = new Point(171, 100);
            txtmanhanvien.Name = "txtmanhanvien";
            txtmanhanvien.Size = new Size(223, 31);
            txtmanhanvien.TabIndex = 11;
            // 
            // txtthang
            // 
            txtthang.Location = new Point(109, 60);
            txtthang.Name = "txtthang";
            txtthang.Size = new Size(93, 31);
            txtthang.TabIndex = 10;
            // 
            // txtnam
            // 
            txtnam.Location = new Point(282, 60);
            txtnam.Name = "txtnam";
            txtnam.Size = new Size(112, 31);
            txtnam.TabIndex = 9;
            // 
            // txtmakhach
            // 
            txtmakhach.Location = new Point(560, 19);
            txtmakhach.Name = "txtmakhach";
            txtmakhach.Size = new Size(237, 31);
            txtmakhach.TabIndex = 8;
            // 
            // txtmaHD
            // 
            txtmaHD.Location = new Point(157, 19);
            txtmaHD.Name = "txtmaHD";
            txtmaHD.Size = new Size(237, 31);
            txtmaHD.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.OrangeRed;
            label6.Location = new Point(413, 60);
            label6.Name = "label6";
            label6.Size = new Size(99, 25);
            label6.TabIndex = 6;
            label6.Text = "Tổng tiền:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.OrangeRed;
            label5.Location = new Point(32, 104);
            label5.Name = "label5";
            label5.Size = new Size(133, 25);
            label5.TabIndex = 5;
            label5.Text = "Mã nhân viên:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(219, 63);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 4;
            label4.Text = "Năm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(32, 60);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 3;
            label3.Text = "Tháng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(32, 19);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 2;
            label2.Text = "Mã hóa đơn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(413, 19);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 1;
            label1.Text = "Mã khách hàng:";
            // 
            // dgvtkhoadon
            // 
            dgvtkhoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvtkhoadon.Dock = DockStyle.Fill;
            dgvtkhoadon.Location = new Point(0, 132);
            dgvtkhoadon.Name = "dgvtkhoadon";
            dgvtkhoadon.RowHeadersWidth = 62;
            dgvtkhoadon.RowTemplate.Height = 33;
            dgvtkhoadon.Size = new Size(800, 308);
            dgvtkhoadon.TabIndex = 9;
            dgvtkhoadon.DoubleClick += dgvtkhoadon_DoubleClick;
            // 
            // frmtimkiemhoadon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 491);
            Controls.Add(dgvtkhoadon);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "frmtimkiemhoadon";
            Text = "Tìm kiếm hóa đơn";
            Load += frmtimkiemhoadon_Load;
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvtkhoadon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button btndong;
        private Button btntimlai;
        private Button btntimkiem;
        private Panel panel1;
        private DataGridView dgvtkhoadon;
        private TextBox txttongtien;
        private TextBox txtmanhanvien;
        private TextBox txtthang;
        private TextBox txtnam;
        private TextBox txtmakhach;
        private TextBox txtmaHD;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
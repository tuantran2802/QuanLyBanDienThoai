namespace _20T1020657
{
    partial class frmhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhang));
            panel1 = new Panel();
            btnmo = new Button();
            picanh = new PictureBox();
            txtghichu = new TextBox();
            label9 = new Label();
            txtanh = new TextBox();
            label8 = new Label();
            cbomaloai = new ComboBox();
            txtgiaban = new TextBox();
            txtgianhap = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtsoluong = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txttenhang = new TextBox();
            txtmahang = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dgvhang = new DataGridView();
            panel3 = new Panel();
            btndong = new Button();
            btnluu = new Button();
            btnsua = new Button();
            btnxoa = new Button();
            btnthem = new Button();
            btntimkiem = new Button();
            btnhienthids = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picanh).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhang).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnmo);
            panel1.Controls.Add(picanh);
            panel1.Controls.Add(txtghichu);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtanh);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cbomaloai);
            panel1.Controls.Add(txtgiaban);
            panel1.Controls.Add(txtgianhap);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txtsoluong);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txttenhang);
            panel1.Controls.Add(txtmahang);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1207, 326);
            panel1.TabIndex = 1;
            // 
            // btnmo
            // 
            btnmo.Location = new Point(800, 72);
            btnmo.Name = "btnmo";
            btnmo.Size = new Size(73, 34);
            btnmo.TabIndex = 23;
            btnmo.Text = "Mở";
            btnmo.UseVisualStyleBackColor = true;
            btnmo.Click += btnmo_Click;
            // 
            // picanh
            // 
            picanh.Location = new Point(899, 43);
            picanh.Name = "picanh";
            picanh.Size = new Size(305, 241);
            picanh.TabIndex = 22;
            picanh.TabStop = false;
            // 
            // txtghichu
            // 
            txtghichu.Location = new Point(519, 187);
            txtghichu.Multiline = true;
            txtghichu.Name = "txtghichu";
            txtghichu.Size = new Size(275, 97);
            txtghichu.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.OrangeRed;
            label9.Location = new Point(431, 187);
            label9.Name = "label9";
            label9.Size = new Size(82, 25);
            label9.TabIndex = 20;
            label9.Text = "Ghi chú:";
            // 
            // txtanh
            // 
            txtanh.Location = new Point(519, 44);
            txtanh.Multiline = true;
            txtanh.Name = "txtanh";
            txtanh.Size = new Size(275, 115);
            txtanh.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.OrangeRed;
            label8.Location = new Point(431, 44);
            label8.Name = "label8";
            label8.Size = new Size(52, 25);
            label8.TabIndex = 18;
            label8.Text = "Ảnh:";
            // 
            // cbomaloai
            // 
            cbomaloai.FormattingEnabled = true;
            cbomaloai.Location = new Point(141, 143);
            cbomaloai.Name = "cbomaloai";
            cbomaloai.Size = new Size(258, 33);
            cbomaloai.TabIndex = 17;
            // 
            // txtgiaban
            // 
            txtgiaban.Location = new Point(141, 288);
            txtgiaban.Name = "txtgiaban";
            txtgiaban.Size = new Size(258, 31);
            txtgiaban.TabIndex = 16;
            // 
            // txtgianhap
            // 
            txtgianhap.Location = new Point(141, 239);
            txtgianhap.Name = "txtgianhap";
            txtgianhap.Size = new Size(258, 31);
            txtgianhap.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.OrangeRed;
            label7.Location = new Point(28, 239);
            label7.Name = "label7";
            label7.Size = new Size(93, 25);
            label7.TabIndex = 14;
            label7.Text = "Giá nhập:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.OrangeRed;
            label6.Location = new Point(28, 291);
            label6.Name = "label6";
            label6.Size = new Size(82, 25);
            label6.TabIndex = 13;
            label6.Text = "Giá bán:";
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(141, 187);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(258, 31);
            txtsoluong.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.OrangeRed;
            label5.Location = new Point(25, 187);
            label5.Name = "label5";
            label5.Size = new Size(93, 25);
            label5.TabIndex = 11;
            label5.Text = "Số lượng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(25, 140);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 9;
            label4.Text = "Mã loại:";
            // 
            // txttenhang
            // 
            txttenhang.Location = new Point(141, 93);
            txttenhang.Name = "txttenhang";
            txttenhang.Size = new Size(258, 31);
            txttenhang.TabIndex = 8;
            // 
            // txtmahang
            // 
            txtmahang.Location = new Point(141, 44);
            txtmahang.Name = "txtmahang";
            txtmahang.Size = new Size(258, 31);
            txtmahang.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(25, 93);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 2;
            label3.Text = "Tên hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(28, 44);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 1;
            label2.Text = "Mã hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(410, 0);
            label1.Name = "label1";
            label1.Size = new Size(410, 36);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC HÀNG HÓA";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvhang);
            panel2.Location = new Point(45, 337);
            panel2.Name = "panel2";
            panel2.Size = new Size(1109, 319);
            panel2.TabIndex = 2;
            // 
            // dgvhang
            // 
            dgvhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhang.Location = new Point(0, 0);
            dgvhang.Name = "dgvhang";
            dgvhang.RowHeadersWidth = 62;
            dgvhang.RowTemplate.Height = 33;
            dgvhang.Size = new Size(1109, 319);
            dgvhang.TabIndex = 0;
            dgvhang.Click += dgvhang_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btndong);
            panel3.Controls.Add(btnluu);
            panel3.Controls.Add(btnsua);
            panel3.Controls.Add(btnxoa);
            panel3.Controls.Add(btnthem);
            panel3.Controls.Add(btntimkiem);
            panel3.Controls.Add(btnhienthids);
            panel3.Location = new Point(45, 674);
            panel3.Name = "panel3";
            panel3.Size = new Size(1109, 51);
            panel3.TabIndex = 6;
            // 
            // btndong
            // 
            btndong.BackColor = Color.Red;
            btndong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btndong.ForeColor = Color.Black;
            btndong.Image = (Image)resources.GetObject("btndong.Image");
            btndong.ImageAlign = ContentAlignment.MiddleLeft;
            btndong.Location = new Point(981, 8);
            btndong.Name = "btndong";
            btndong.Size = new Size(125, 34);
            btndong.TabIndex = 13;
            btndong.Text = "Đóng";
            btndong.UseVisualStyleBackColor = false;
            btndong.Click += btndong_Click;
            // 
            // btnluu
            // 
            btnluu.BackColor = Color.Lime;
            btnluu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnluu.ForeColor = Color.Black;
            btnluu.Image = (Image)resources.GetObject("btnluu.Image");
            btnluu.ImageAlign = ContentAlignment.MiddleLeft;
            btnluu.Location = new Point(462, 8);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(123, 34);
            btnluu.TabIndex = 12;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = false;
            btnluu.Click += btnluu_Click;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.Lime;
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnsua.ForeColor = Color.Black;
            btnsua.Image = (Image)resources.GetObject("btnsua.Image");
            btnsua.ImageAlign = ContentAlignment.MiddleLeft;
            btnsua.Location = new Point(313, 8);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(128, 34);
            btnsua.TabIndex = 11;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = false;
            btnsua.Click += btnsua_Click;
            // 
            // btnxoa
            // 
            btnxoa.BackColor = Color.Red;
            btnxoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnxoa.ForeColor = Color.Black;
            btnxoa.Image = (Image)resources.GetObject("btnxoa.Image");
            btnxoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnxoa.Location = new Point(169, 8);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(122, 34);
            btnxoa.TabIndex = 10;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = false;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.Lime;
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnthem.ForeColor = Color.Black;
            btnthem.Image = (Image)resources.GetObject("btnthem.Image");
            btnthem.ImageAlign = ContentAlignment.MiddleLeft;
            btnthem.Location = new Point(19, 8);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(128, 34);
            btnthem.TabIndex = 9;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            btnthem.Click += btnthem_Click;
            // 
            // btntimkiem
            // 
            btntimkiem.BackColor = Color.Lime;
            btntimkiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btntimkiem.ForeColor = Color.Black;
            btntimkiem.Image = (Image)resources.GetObject("btntimkiem.Image");
            btntimkiem.ImageAlign = ContentAlignment.MiddleLeft;
            btntimkiem.Location = new Point(608, 8);
            btntimkiem.Name = "btntimkiem";
            btntimkiem.Size = new Size(153, 34);
            btntimkiem.TabIndex = 7;
            btntimkiem.Text = "Tìm kiếm ";
            btntimkiem.UseVisualStyleBackColor = false;
            btntimkiem.Click += btntimkiem_Click;
            // 
            // btnhienthids
            // 
            btnhienthids.BackColor = Color.Lime;
            btnhienthids.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnhienthids.ForeColor = Color.Black;
            btnhienthids.Image = (Image)resources.GetObject("btnhienthids.Image");
            btnhienthids.ImageAlign = ContentAlignment.MiddleLeft;
            btnhienthids.Location = new Point(787, 8);
            btnhienthids.Name = "btnhienthids";
            btnhienthids.Size = new Size(175, 34);
            btnhienthids.TabIndex = 6;
            btnhienthids.Text = "Hiển thị DS";
            btnhienthids.UseVisualStyleBackColor = false;
            btnhienthids.Click += btnhienthids_Click;
            // 
            // frmhang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1223, 737);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmhang";
            Text = "frmhang";
            Load += frmhang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picanh).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvhang).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private TextBox txttenhang;
        private TextBox txtmahang;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtgiaban;
        private TextBox txtgianhap;
        private Label label7;
        private Label label6;
        private TextBox txtsoluong;
        private Label label5;
        private TextBox txtghichu;
        private Label label9;
        private TextBox txtanh;
        private Label label8;
        private ComboBox cbomaloai;
        private Button btnmo;
        private PictureBox picanh;
        private Panel panel2;
        private DataGridView dgvhang;
        private Panel panel3;
        private Button btnhienthids;
        private Button btntimkiem;
        private Button btnsua;
        private Button btnxoa;
        private Button btnthem;
        private Button btndong;
        private Button btnluu;
    }
}
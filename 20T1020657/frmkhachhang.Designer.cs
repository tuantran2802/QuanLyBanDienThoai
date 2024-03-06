namespace _20T1020657
{
    partial class frmkhachhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmkhachhang));
            panel1 = new Panel();
            mtbdienthoai = new MaskedTextBox();
            label4 = new Label();
            txtdiachi = new TextBox();
            txttenkhachhang = new TextBox();
            txtmakhachhang = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dgvkhachhang = new DataGridView();
            panel3 = new Panel();
            btndong = new Button();
            btnluu = new Button();
            btnsua = new Button();
            btnxoa = new Button();
            btnthem = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvkhachhang).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(mtbdienthoai);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtdiachi);
            panel1.Controls.Add(txttenkhachhang);
            panel1.Controls.Add(txtmakhachhang);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 139);
            panel1.TabIndex = 1;
            // 
            // mtbdienthoai
            // 
            mtbdienthoai.Location = new Point(562, 93);
            mtbdienthoai.Mask = "(999) 000-0000";
            mtbdienthoai.Name = "mtbdienthoai";
            mtbdienthoai.Size = new Size(281, 31);
            mtbdienthoai.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(21, 95);
            label4.Name = "label4";
            label4.Size = new Size(151, 25);
            label4.TabIndex = 12;
            label4.Text = "Tên khách hàng:";
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(562, 46);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(281, 31);
            txtdiachi.TabIndex = 9;
            txtdiachi.KeyUp += txtdiachi_KeyUp;
            // 
            // txttenkhachhang
            // 
            txttenkhachhang.Location = new Point(175, 93);
            txttenkhachhang.Name = "txttenkhachhang";
            txttenkhachhang.Size = new Size(258, 31);
            txttenkhachhang.TabIndex = 8;
            txttenkhachhang.KeyUp += txttenkhachhang_KeyUp;
            // 
            // txtmakhachhang
            // 
            txtmakhachhang.Location = new Point(175, 46);
            txtmakhachhang.Name = "txtmakhachhang";
            txtmakhachhang.Size = new Size(258, 31);
            txtmakhachhang.TabIndex = 7;
            txtmakhachhang.KeyUp += txtmakhachhang_KeyUp;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.OrangeRed;
            label6.Location = new Point(445, 96);
            label6.Name = "label6";
            label6.Size = new Size(105, 25);
            label6.TabIndex = 5;
            label6.Text = "Điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.OrangeRed;
            label5.Location = new Point(448, 44);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 4;
            label5.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(28, 93);
            label3.Name = "label3";
            label3.Size = new Size(17, 25);
            label3.TabIndex = 2;
            label3.Text = " ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(21, 44);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 1;
            label2.Text = "Mã khách hàng:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(175, 0);
            label1.Name = "label1";
            label1.Size = new Size(459, 36);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC KHÁCH HÀNG";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvkhachhang);
            panel2.Location = new Point(34, 152);
            panel2.Name = "panel2";
            panel2.Size = new Size(804, 337);
            panel2.TabIndex = 2;
            // 
            // dgvkhachhang
            // 
            dgvkhachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvkhachhang.Location = new Point(-2, -1);
            dgvkhachhang.Name = "dgvkhachhang";
            dgvkhachhang.RowHeadersWidth = 62;
            dgvkhachhang.RowTemplate.Height = 33;
            dgvkhachhang.Size = new Size(806, 338);
            dgvkhachhang.TabIndex = 0;
            dgvkhachhang.Click += dgvkhachhang_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btndong);
            panel3.Controls.Add(btnluu);
            panel3.Controls.Add(btnsua);
            panel3.Controls.Add(btnxoa);
            panel3.Controls.Add(btnthem);
            panel3.Location = new Point(32, 498);
            panel3.Name = "panel3";
            panel3.Size = new Size(806, 51);
            panel3.TabIndex = 6;
            // 
            // btndong
            // 
            btndong.BackColor = Color.Red;
            btndong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btndong.ForeColor = Color.Black;
            btndong.Image = (Image)resources.GetObject("btndong.Image");
            btndong.ImageAlign = ContentAlignment.MiddleLeft;
            btndong.Location = new Point(643, 10);
            btndong.Name = "btndong";
            btndong.Size = new Size(127, 34);
            btndong.TabIndex = 5;
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
            btnluu.Location = new Point(490, 10);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(127, 34);
            btnluu.TabIndex = 3;
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
            btnsua.Location = new Point(337, 10);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(127, 34);
            btnsua.TabIndex = 2;
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
            btnxoa.Location = new Point(184, 10);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(127, 34);
            btnxoa.TabIndex = 1;
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
            btnthem.Location = new Point(31, 10);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(127, 34);
            btnthem.TabIndex = 0;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            btnthem.Click += btnthem_Click;
            // 
            // frmkhachhang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(867, 561);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmkhachhang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmkhachhang";
            Load += frmkhachhang_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvkhachhang).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private TextBox txtdiachi;
        private TextBox txttenkhachhang;
        private TextBox txtmakhachhang;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private DataGridView dgvkhachhang;
        private Panel panel3;
        private Button btndong;
        private Button btnluu;
        private Button btnsua;
        private Button btnxoa;
        private Button btnthem;
        private MaskedTextBox mtbdienthoai;
    }
}
namespace _20T1020657
{
    partial class frmnhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmnhanvien));
            panel1 = new Panel();
            btndong = new Button();
            btnluu = new Button();
            btnsua = new Button();
            btnxoa = new Button();
            btnthem = new Button();
            panel2 = new Panel();
            dtpngaysinh = new DateTimePicker();
            mtbdienthoai = new MaskedTextBox();
            txtdiachi = new TextBox();
            chkgioitinh = new CheckBox();
            txttennhanvien = new TextBox();
            txtmanhanvien = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvnhanvien = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvnhanvien).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btndong);
            panel1.Controls.Add(btnluu);
            panel1.Controls.Add(btnsua);
            panel1.Controls.Add(btnxoa);
            panel1.Controls.Add(btnthem);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 529);
            panel1.Name = "panel1";
            panel1.Size = new Size(828, 63);
            panel1.TabIndex = 0;
            // 
            // btndong
            // 
            btndong.BackColor = Color.Red;
            btndong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btndong.ForeColor = Color.Black;
            btndong.Image = (Image)resources.GetObject("btndong.Image");
            btndong.ImageAlign = ContentAlignment.MiddleLeft;
            btndong.Location = new Point(678, 17);
            btndong.Name = "btndong";
            btndong.Size = new Size(137, 34);
            btndong.TabIndex = 19;
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
            btnluu.Location = new Point(502, 18);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(137, 34);
            btnluu.TabIndex = 18;
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
            btnsua.Location = new Point(343, 17);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(137, 34);
            btnsua.TabIndex = 17;
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
            btnxoa.Location = new Point(175, 18);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(137, 34);
            btnxoa.TabIndex = 16;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = false;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.Lime;
            btnthem.BackgroundImageLayout = ImageLayout.Stretch;
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnthem.ForeColor = Color.Black;
            btnthem.Image = (Image)resources.GetObject("btnthem.Image");
            btnthem.ImageAlign = ContentAlignment.MiddleLeft;
            btnthem.Location = new Point(12, 18);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(137, 34);
            btnthem.TabIndex = 15;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            btnthem.Click += btnthem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtpngaysinh);
            panel2.Controls.Add(mtbdienthoai);
            panel2.Controls.Add(txtdiachi);
            panel2.Controls.Add(chkgioitinh);
            panel2.Controls.Add(txttennhanvien);
            panel2.Controls.Add(txtmanhanvien);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(828, 175);
            panel2.TabIndex = 1;
            // 
            // dtpngaysinh
            // 
            dtpngaysinh.Format = DateTimePickerFormat.Short;
            dtpngaysinh.Location = new Point(587, 138);
            dtpngaysinh.Name = "dtpngaysinh";
            dtpngaysinh.Size = new Size(228, 31);
            dtpngaysinh.TabIndex = 13;
            dtpngaysinh.KeyUp += dtpngaysinh_KeyUp;
            // 
            // mtbdienthoai
            // 
            mtbdienthoai.Location = new Point(587, 96);
            mtbdienthoai.Mask = "(999) 000-0000";
            mtbdienthoai.Name = "mtbdienthoai";
            mtbdienthoai.Size = new Size(228, 31);
            mtbdienthoai.TabIndex = 12;
            mtbdienthoai.KeyUp += mtbdienthoai_KeyUp;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(587, 56);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.Size = new Size(229, 31);
            txtdiachi.TabIndex = 11;
            txtdiachi.KeyUp += txtdiachi_KeyUp;
            // 
            // chkgioitinh
            // 
            chkgioitinh.AutoSize = true;
            chkgioitinh.Checked = true;
            chkgioitinh.CheckState = CheckState.Checked;
            chkgioitinh.Location = new Point(211, 146);
            chkgioitinh.Name = "chkgioitinh";
            chkgioitinh.Size = new Size(76, 29);
            chkgioitinh.TabIndex = 10;
            chkgioitinh.Text = "Nam";
            chkgioitinh.UseVisualStyleBackColor = true;
            // 
            // txttennhanvien
            // 
            txttennhanvien.Location = new Point(211, 99);
            txttennhanvien.Name = "txttennhanvien";
            txttennhanvien.Size = new Size(222, 31);
            txttennhanvien.TabIndex = 9;
            txttennhanvien.KeyUp += txttennhanvien_KeyUp;
            // 
            // txtmanhanvien
            // 
            txtmanhanvien.Location = new Point(211, 60);
            txtmanhanvien.Name = "txtmanhanvien";
            txtmanhanvien.Size = new Size(222, 31);
            txtmanhanvien.TabIndex = 8;
            txtmanhanvien.KeyUp += txtmanhanvien_KeyUp;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.OrangeRed;
            label7.Location = new Point(461, 144);
            label7.Name = "label7";
            label7.Size = new Size(118, 28);
            label7.TabIndex = 7;
            label7.Text = "Ngày sinh: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.OrangeRed;
            label6.Location = new Point(461, 99);
            label6.Name = "label6";
            label6.Size = new Size(122, 28);
            label6.TabIndex = 6;
            label6.Text = "Điện thoại: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.OrangeRed;
            label5.Location = new Point(461, 52);
            label5.Name = "label5";
            label5.Size = new Size(89, 28);
            label5.TabIndex = 5;
            label5.Text = "Địa chỉ: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(45, 52);
            label4.Name = "label4";
            label4.Size = new Size(152, 28);
            label4.TabIndex = 4;
            label4.Text = "Mã nhân viên: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(45, 99);
            label3.Name = "label3";
            label3.Size = new Size(155, 28);
            label3.TabIndex = 3;
            label3.Text = "Tên nhân viên: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(45, 144);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 2;
            label2.Text = "Giới tính: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(199, 9);
            label1.Name = "label1";
            label1.Size = new Size(439, 36);
            label1.TabIndex = 1;
            label1.Text = "DANH MỤC NHÂN VIÊN ";
            // 
            // dgvnhanvien
            // 
            dgvnhanvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvnhanvien.Dock = DockStyle.Fill;
            dgvnhanvien.Location = new Point(0, 175);
            dgvnhanvien.Name = "dgvnhanvien";
            dgvnhanvien.RowHeadersWidth = 62;
            dgvnhanvien.RowTemplate.Height = 33;
            dgvnhanvien.Size = new Size(828, 354);
            dgvnhanvien.TabIndex = 2;
            dgvnhanvien.Click += dgvnhanvien_Click;
            // 
            // frmnhanvien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(828, 592);
            Controls.Add(dgvnhanvien);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmnhanvien";
            Text = "Danh mục nhân viên  ";
            Load += frmnhanvien_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvnhanvien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgvnhanvien;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private MaskedTextBox mtbdienthoai;
        private TextBox txtdiachi;
        private CheckBox chkgioitinh;
        private TextBox txttennhanvien;
        private TextBox txtmanhanvien;
        private DateTimePicker dtpngaysinh;
        private Button btndong;
        private Button btnluu;
        private Button btnsua;
        private Button btnxoa;
        private Button btnthem;
    }
}
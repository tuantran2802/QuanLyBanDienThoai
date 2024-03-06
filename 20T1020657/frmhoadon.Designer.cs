namespace _20T1020657
{
    partial class frmhoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhoadon));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            dtpngayban = new DateTimePicker();
            mtbsodienthoai = new MaskedTextBox();
            txtdiachi = new TextBox();
            txttenkhachhang = new TextBox();
            cbomakhachhang = new ComboBox();
            txttennhanvien = new TextBox();
            cbomanhanvien = new ComboBox();
            txtmahoadon = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            btntimkiemhoadon = new Button();
            cbomahoadon = new ComboBox();
            label19 = new Label();
            groupBox2 = new GroupBox();
            panel6 = new Panel();
            btndonghoadon = new Button();
            btnxoahoadon = new Button();
            btnluuhoadon = new Button();
            btnthemhoadon = new Button();
            panel5 = new Panel();
            txttongtien = new TextBox();
            label18 = new Label();
            lblbangchu = new Label();
            label17 = new Label();
            dgvhoadon = new DataGridView();
            panel3 = new Panel();
            txtthanhtien = new TextBox();
            txtgiamgia = new TextBox();
            txtsoluong = new TextBox();
            txtgiaban = new TextBox();
            txttenhang = new TextBox();
            cbomahang = new ComboBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhoadon).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 784);
            panel1.Name = "panel1";
            panel1.Size = new Size(989, 55);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(23, 16);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(293, 0);
            label2.Name = "label2";
            label2.Size = new Size(379, 36);
            label2.TabIndex = 2;
            label2.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // panel4
            // 
            panel4.Controls.Add(splitContainer1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(989, 832);
            panel4.TabIndex = 3;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(label2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(989, 832);
            splitContainer1.SplitterDistance = 269;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpngayban);
            groupBox1.Controls.Add(mtbsodienthoai);
            groupBox1.Controls.Add(txtdiachi);
            groupBox1.Controls.Add(txttenkhachhang);
            groupBox1.Controls.Add(cbomakhachhang);
            groupBox1.Controls.Add(txttennhanvien);
            groupBox1.Controls.Add(cbomanhanvien);
            groupBox1.Controls.Add(txtmahoadon);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(-1, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(986, 237);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin chung";
            // 
            // dtpngayban
            // 
            dtpngayban.Format = DateTimePickerFormat.Short;
            dtpngayban.Location = new Point(218, 86);
            dtpngayban.Name = "dtpngayban";
            dtpngayban.Size = new Size(242, 31);
            dtpngayban.TabIndex = 21;
            // 
            // mtbsodienthoai
            // 
            mtbsodienthoai.Location = new Point(709, 171);
            mtbsodienthoai.Mask = "(999) 000-0000";
            mtbsodienthoai.Name = "mtbsodienthoai";
            mtbsodienthoai.ReadOnly = true;
            mtbsodienthoai.Size = new Size(270, 31);
            mtbsodienthoai.TabIndex = 20;
            // 
            // txtdiachi
            // 
            txtdiachi.Location = new Point(708, 131);
            txtdiachi.Name = "txtdiachi";
            txtdiachi.ReadOnly = true;
            txtdiachi.Size = new Size(271, 31);
            txtdiachi.TabIndex = 19;
            // 
            // txttenkhachhang
            // 
            txttenkhachhang.Location = new Point(708, 88);
            txttenkhachhang.Name = "txttenkhachhang";
            txttenkhachhang.ReadOnly = true;
            txttenkhachhang.Size = new Size(272, 31);
            txttenkhachhang.TabIndex = 18;
            // 
            // cbomakhachhang
            // 
            cbomakhachhang.FormattingEnabled = true;
            cbomakhachhang.Location = new Point(707, 44);
            cbomakhachhang.Name = "cbomakhachhang";
            cbomakhachhang.Size = new Size(273, 33);
            cbomakhachhang.TabIndex = 17;
            cbomakhachhang.SelectedIndexChanged += cbomakhachhang_SelectedIndexChanged;
            // 
            // txttennhanvien
            // 
            txttennhanvien.Location = new Point(214, 173);
            txttennhanvien.Name = "txttennhanvien";
            txttennhanvien.ReadOnly = true;
            txttennhanvien.Size = new Size(246, 31);
            txttennhanvien.TabIndex = 16;
            // 
            // cbomanhanvien
            // 
            cbomanhanvien.FormattingEnabled = true;
            cbomanhanvien.Location = new Point(216, 129);
            cbomanhanvien.Name = "cbomanhanvien";
            cbomanhanvien.Size = new Size(244, 33);
            cbomanhanvien.TabIndex = 15;
            cbomanhanvien.SelectedIndexChanged += cbomanhanvien_SelectedIndexChanged;
            // 
            // txtmahoadon
            // 
            txtmahoadon.Location = new Point(218, 44);
            txtmahoadon.Name = "txtmahoadon";
            txtmahoadon.ReadOnly = true;
            txtmahoadon.Size = new Size(242, 31);
            txtmahoadon.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.OrangeRed;
            label10.Location = new Point(514, 44);
            label10.Name = "label10";
            label10.Size = new Size(168, 28);
            label10.TabIndex = 12;
            label10.Text = "Mã khách hàng: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.OrangeRed;
            label9.Location = new Point(514, 173);
            label9.Name = "label9";
            label9.Size = new Size(149, 28);
            label9.TabIndex = 11;
            label9.Text = "Số điện thoại: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.OrangeRed;
            label8.Location = new Point(514, 135);
            label8.Name = "label8";
            label8.Size = new Size(89, 28);
            label8.TabIndex = 10;
            label8.Text = "Địa chỉ: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.OrangeRed;
            label7.Location = new Point(514, 88);
            label7.Name = "label7";
            label7.Size = new Size(171, 28);
            label7.TabIndex = 9;
            label7.Text = "Tên khách hàng: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.OrangeRed;
            label6.Location = new Point(56, 88);
            label6.Name = "label6";
            label6.Size = new Size(114, 28);
            label6.TabIndex = 8;
            label6.Text = "Ngày bán: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.OrangeRed;
            label5.Location = new Point(56, 134);
            label5.Name = "label5";
            label5.Size = new Size(152, 28);
            label5.TabIndex = 7;
            label5.Text = "Mã nhân viên: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(56, 175);
            label3.Name = "label3";
            label3.Size = new Size(155, 28);
            label3.TabIndex = 6;
            label3.Text = "Tên nhân viên: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.OrangeRed;
            label4.Location = new Point(56, 44);
            label4.Name = "label4";
            label4.Size = new Size(138, 28);
            label4.TabIndex = 5;
            label4.Text = "Mã hóa đơn: ";
            // 
            // panel2
            // 
            panel2.Controls.Add(btntimkiemhoadon);
            panel2.Controls.Add(cbomahoadon);
            panel2.Controls.Add(label19);
            panel2.Location = new Point(3, 506);
            panel2.Name = "panel2";
            panel2.Size = new Size(986, 53);
            panel2.TabIndex = 1;
            // 
            // btntimkiemhoadon
            // 
            btntimkiemhoadon.BackColor = Color.Lime;
            btntimkiemhoadon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btntimkiemhoadon.ForeColor = Color.Black;
            btntimkiemhoadon.Image = (Image)resources.GetObject("btntimkiemhoadon.Image");
            btntimkiemhoadon.ImageAlign = ContentAlignment.MiddleLeft;
            btntimkiemhoadon.Location = new Point(491, 12);
            btntimkiemhoadon.Name = "btntimkiemhoadon";
            btntimkiemhoadon.Size = new Size(253, 34);
            btntimkiemhoadon.TabIndex = 16;
            btntimkiemhoadon.Text = "Tìm kiếm hóa đơn";
            btntimkiemhoadon.UseVisualStyleBackColor = false;
            btntimkiemhoadon.Click += btntimkiemhoadon_Click;
            // 
            // cbomahoadon
            // 
            cbomahoadon.FormattingEnabled = true;
            cbomahoadon.Location = new Point(152, 13);
            cbomahoadon.Name = "cbomahoadon";
            cbomahoadon.Size = new Size(303, 33);
            cbomahoadon.TabIndex = 1;
            cbomahoadon.DropDown += cbomahoadon_DropDown;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.OrangeRed;
            label19.Location = new Point(33, 15);
            label19.Name = "label19";
            label19.Size = new Size(114, 25);
            label19.TabIndex = 0;
            label19.Text = "Mã hóa đơn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel6);
            groupBox2.Controls.Add(panel5);
            groupBox2.Controls.Add(dgvhoadon);
            groupBox2.Controls.Add(panel3);
            groupBox2.Location = new Point(0, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(989, 500);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin mặt hàng";
            // 
            // panel6
            // 
            panel6.Controls.Add(btndonghoadon);
            panel6.Controls.Add(btnxoahoadon);
            panel6.Controls.Add(btnluuhoadon);
            panel6.Controls.Add(btnthemhoadon);
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(3, 453);
            panel6.Name = "panel6";
            panel6.Size = new Size(983, 44);
            panel6.TabIndex = 5;
            // 
            // btndonghoadon
            // 
            btndonghoadon.BackColor = Color.Red;
            btndonghoadon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btndonghoadon.ForeColor = Color.Black;
            btndonghoadon.Image = (Image)resources.GetObject("btndonghoadon.Image");
            btndonghoadon.ImageAlign = ContentAlignment.MiddleLeft;
            btndonghoadon.Location = new Point(752, 6);
            btndonghoadon.Name = "btndonghoadon";
            btndonghoadon.Size = new Size(143, 34);
            btndonghoadon.TabIndex = 15;
            btndonghoadon.Text = "Đóng";
            btndonghoadon.UseVisualStyleBackColor = false;
            btndonghoadon.Click += btndonghoadon_Click;
            // 
            // btnxoahoadon
            // 
            btnxoahoadon.BackColor = Color.Red;
            btnxoahoadon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnxoahoadon.ForeColor = Color.Black;
            btnxoahoadon.Image = (Image)resources.GetObject("btnxoahoadon.Image");
            btnxoahoadon.ImageAlign = ContentAlignment.MiddleLeft;
            btnxoahoadon.Location = new Point(533, 6);
            btnxoahoadon.Name = "btnxoahoadon";
            btnxoahoadon.Size = new Size(196, 34);
            btnxoahoadon.TabIndex = 14;
            btnxoahoadon.Text = "Xóa hóa đơn";
            btnxoahoadon.UseVisualStyleBackColor = false;
            btnxoahoadon.Click += btnxoahoadon_Click;
            // 
            // btnluuhoadon
            // 
            btnluuhoadon.BackColor = Color.Lime;
            btnluuhoadon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnluuhoadon.ForeColor = Color.Black;
            btnluuhoadon.Image = (Image)resources.GetObject("btnluuhoadon.Image");
            btnluuhoadon.ImageAlign = ContentAlignment.MiddleLeft;
            btnluuhoadon.Location = new Point(316, 6);
            btnluuhoadon.Name = "btnluuhoadon";
            btnluuhoadon.Size = new Size(189, 34);
            btnluuhoadon.TabIndex = 13;
            btnluuhoadon.Text = "Lưu hóa đơn";
            btnluuhoadon.UseVisualStyleBackColor = false;
            btnluuhoadon.Click += btnluuhoadon_Click;
            // 
            // btnthemhoadon
            // 
            btnthemhoadon.BackColor = Color.Lime;
            btnthemhoadon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnthemhoadon.ForeColor = Color.Black;
            btnthemhoadon.Image = (Image)resources.GetObject("btnthemhoadon.Image");
            btnthemhoadon.ImageAlign = ContentAlignment.MiddleLeft;
            btnthemhoadon.Location = new Point(90, 6);
            btnthemhoadon.Name = "btnthemhoadon";
            btnthemhoadon.Size = new Size(208, 34);
            btnthemhoadon.TabIndex = 12;
            btnthemhoadon.Text = "Thêm hóa đơn";
            btnthemhoadon.UseVisualStyleBackColor = false;
            btnthemhoadon.Click += btnthemhoadon_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.Controls.Add(txttongtien);
            panel5.Controls.Add(label18);
            panel5.Controls.Add(lblbangchu);
            panel5.Controls.Add(label17);
            panel5.Location = new Point(3, 399);
            panel5.Name = "panel5";
            panel5.Size = new Size(983, 54);
            panel5.TabIndex = 4;
            // 
            // txttongtien
            // 
            txttongtien.Location = new Point(682, 11);
            txttongtien.Name = "txttongtien";
            txttongtien.Size = new Size(295, 31);
            txttongtien.TabIndex = 13;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.OrangeRed;
            label18.Location = new Point(547, 11);
            label18.Name = "label18";
            label18.Size = new Size(108, 28);
            label18.TabIndex = 12;
            label18.Text = "Tổng tiền:";
            // 
            // lblbangchu
            // 
            lblbangchu.AutoSize = true;
            lblbangchu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblbangchu.ForeColor = Color.OrangeRed;
            lblbangchu.Location = new Point(31, 26);
            lblbangchu.Name = "lblbangchu";
            lblbangchu.Size = new Size(98, 25);
            lblbangchu.TabIndex = 1;
            lblbangchu.Text = "Bằng chữ:";
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.None;
            label17.AutoSize = true;
            label17.ForeColor = Color.RoyalBlue;
            label17.Location = new Point(24, -6);
            label17.Name = "label17";
            label17.Size = new Size(235, 25);
            label17.TabIndex = 0;
            label17.Text = "Nhấn đúp một dòng để xóa";
            // 
            // dgvhoadon
            // 
            dgvhoadon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhoadon.Location = new Point(78, 137);
            dgvhoadon.Name = "dgvhoadon";
            dgvhoadon.RowHeadersWidth = 62;
            dgvhoadon.RowTemplate.Height = 33;
            dgvhoadon.Size = new Size(834, 257);
            dgvhoadon.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtthanhtien);
            panel3.Controls.Add(txtgiamgia);
            panel3.Controls.Add(txtsoluong);
            panel3.Controls.Add(txtgiaban);
            panel3.Controls.Add(txttenhang);
            panel3.Controls.Add(cbomahang);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(983, 104);
            panel3.TabIndex = 0;
            // 
            // txtthanhtien
            // 
            txtthanhtien.Location = new Point(809, 70);
            txtthanhtien.Name = "txtthanhtien";
            txtthanhtien.ReadOnly = true;
            txtthanhtien.Size = new Size(165, 31);
            txtthanhtien.TabIndex = 17;
            // 
            // txtgiamgia
            // 
            txtgiamgia.Location = new Point(466, 70);
            txtgiamgia.Name = "txtgiamgia";
            txtgiamgia.Size = new Size(216, 31);
            txtgiamgia.TabIndex = 16;
            txtgiamgia.TextChanged += txtgiamgia_TextChanged;
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(150, 70);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(188, 31);
            txtsoluong.TabIndex = 15;
            txtsoluong.TextChanged += txtsoluong_TextChanged;
            // 
            // txtgiaban
            // 
            txtgiaban.Location = new Point(809, 18);
            txtgiaban.Name = "txtgiaban";
            txtgiaban.ReadOnly = true;
            txtgiaban.Size = new Size(165, 31);
            txtgiaban.TabIndex = 14;
            // 
            // txttenhang
            // 
            txttenhang.Location = new Point(466, 18);
            txttenhang.Name = "txttenhang";
            txttenhang.ReadOnly = true;
            txttenhang.Size = new Size(216, 31);
            txttenhang.TabIndex = 13;
            // 
            // cbomahang
            // 
            cbomahang.FormattingEnabled = true;
            cbomahang.Location = new Point(152, 16);
            cbomahang.Name = "cbomahang";
            cbomahang.Size = new Size(186, 33);
            cbomahang.TabIndex = 12;
            cbomahang.SelectedIndexChanged += cbomahang_SelectedIndexChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.OrangeRed;
            label16.Location = new Point(689, 16);
            label16.Name = "label16";
            label16.Size = new Size(95, 28);
            label16.TabIndex = 11;
            label16.Text = "Giá bán: ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.OrangeRed;
            label15.Location = new Point(689, 66);
            label15.Name = "label15";
            label15.Size = new Size(119, 28);
            label15.TabIndex = 10;
            label15.Text = "Thành tiền:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.OrangeRed;
            label14.Location = new Point(351, 16);
            label14.Name = "label14";
            label14.Size = new Size(109, 28);
            label14.TabIndex = 9;
            label14.Text = "Tên hàng: ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.OrangeRed;
            label13.Location = new Point(351, 70);
            label13.Name = "label13";
            label13.Size = new Size(118, 28);
            label13.TabIndex = 8;
            label13.Text = "Giảm giá%:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.OrangeRed;
            label12.Location = new Point(44, 66);
            label12.Name = "label12";
            label12.Size = new Size(102, 28);
            label12.TabIndex = 7;
            label12.Text = "Số lượng:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.OrangeRed;
            label11.Location = new Point(44, 16);
            label11.Name = "label11";
            label11.Size = new Size(106, 28);
            label11.TabIndex = 6;
            label11.Text = "Mã hàng: ";
            // 
            // frmhoadon
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 832);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "frmhoadon";
            Text = "Hóa đơn ";
            Load += frmhoadon_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhoadon).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cbomahoadon;
        private Label label1;
        private Label label2;
        private Panel panel4;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private TextBox txttennhanvien;
        private ComboBox cbomanhanvien;
        private MaskedTextBox mtbngayban;
        private MaskedTextBox mtbsodienthoai;
        private TextBox txtdiachi;
        private TextBox txttenkhachhang;
        private ComboBox cbomakhachhang;
        private GroupBox groupBox2;
        private DataGridView dgvhoadon;
        private Panel panel3;
        private TextBox txtsoluong;
        private TextBox txtgiaban;
        private TextBox txttenhang;
        private ComboBox cbomahang;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox txtthanhtien;
        private TextBox txtgiamgia;
        private Panel panel5;
        private Label lbltongtien;
        private Label label17;
        private TextBox txttongtien;
        private Label label18;
        private Panel panel6;
        private Panel panel2;
        private Label label19;
        private Button btndonghoadon;
        private Button btnhuyhoadon;
        private Button btnluuhoadon;
        private Button btnthemhoadon;
        private Button btntimkiemhoadon;
        private DateTimePicker dtpngaysinh;
        private DateTimePicker dtpngayban;
        private Button btnxoahoadon;
        private Label lblbangchu;
        public TextBox txtmahoadon;
    }
}
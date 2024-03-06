namespace _20T1020657
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            menuStrip1 = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuthoat = new ToolStripMenuItem();
            mnudanhmuc = new ToolStripMenuItem();
            mnuloaihang = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            mnunhanvien = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnukhachhang = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            mnuhanghoa = new ToolStripMenuItem();
            mnuhoadon = new ToolStripMenuItem();
            mnuhoadonban = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            mnutimkiem = new ToolStripMenuItem();
            mnufindhoadon = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripSeparator();
            mnufindhang = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripSeparator();
            mnufindkhachhang = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripSeparator();
            mnubaocao = new ToolStripMenuItem();
            mnubchangton = new ToolStripMenuItem();
            toolStripMenuItem9 = new ToolStripSeparator();
            mnubcdoanhthu = new ToolStripMenuItem();
            mnutrogiup = new ToolStripMenuItem();
            mnuhientrogiup = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripSeparator();
            mnuvainet = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFile, mnudanhmuc, mnuhoadon, mnutimkiem, mnubaocao, mnutrogiup });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(851, 35);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuthoat });
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(87, 29);
            mnuFile.Text = "&Tệp tin ";
            // 
            // mnuthoat
            // 
            mnuthoat.Name = "mnuthoat";
            mnuthoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuthoat.Size = new Size(260, 34);
            mnuthoat.Text = "&Đăng xuất";
            mnuthoat.Click += mnuthoat_Click;
            // 
            // mnudanhmuc
            // 
            mnudanhmuc.DropDownItems.AddRange(new ToolStripItem[] { mnuloaihang, toolStripMenuItem2, mnunhanvien, toolStripMenuItem1, mnukhachhang, toolStripMenuItem3, mnuhanghoa });
            mnudanhmuc.Name = "mnudanhmuc";
            mnudanhmuc.Size = new Size(109, 29);
            mnudanhmuc.Text = "&Danh mục";
            // 
            // mnuloaihang
            // 
            mnuloaihang.Name = "mnuloaihang";
            mnuloaihang.ShortcutKeys = Keys.Control | Keys.A;
            mnuloaihang.Size = new Size(273, 34);
            mnuloaihang.Text = "&Loại hàng";
            mnuloaihang.Click += mnuloaihang_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(270, 6);
            // 
            // mnunhanvien
            // 
            mnunhanvien.Name = "mnunhanvien";
            mnunhanvien.ShortcutKeys = Keys.Control | Keys.B;
            mnunhanvien.Size = new Size(273, 34);
            mnunhanvien.Text = "&Nhân viên ";
            mnunhanvien.Click += mnunhanvien_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(270, 6);
            // 
            // mnukhachhang
            // 
            mnukhachhang.Name = "mnukhachhang";
            mnukhachhang.ShortcutKeys = Keys.Control | Keys.C;
            mnukhachhang.Size = new Size(273, 34);
            mnukhachhang.Text = "&Khách hàng ";
            mnukhachhang.Click += mnukhachhang_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(270, 6);
            // 
            // mnuhanghoa
            // 
            mnuhanghoa.Name = "mnuhanghoa";
            mnuhanghoa.ShortcutKeys = Keys.Control | Keys.D;
            mnuhanghoa.Size = new Size(273, 34);
            mnuhanghoa.Text = "&Hàng hóa ";
            mnuhanghoa.Click += mnuhanghoa_Click;
            // 
            // mnuhoadon
            // 
            mnuhoadon.DropDownItems.AddRange(new ToolStripItem[] { mnuhoadonban, toolStripMenuItem4 });
            mnuhoadon.Name = "mnuhoadon";
            mnuhoadon.Size = new Size(98, 29);
            mnuhoadon.Text = "&Hóa đơn";
            // 
            // mnuhoadonban
            // 
            mnuhoadonban.Name = "mnuhoadonban";
            mnuhoadonban.Size = new Size(219, 34);
            mnuhoadonban.Text = "&Hóa đơn bán";
            mnuhoadonban.Click += mnuhoadonban_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(216, 6);
            // 
            // mnutimkiem
            // 
            mnutimkiem.DropDownItems.AddRange(new ToolStripItem[] { mnufindhoadon, toolStripMenuItem5, mnufindhang, toolStripMenuItem6, mnufindkhachhang, toolStripMenuItem7 });
            mnutimkiem.Name = "mnutimkiem";
            mnutimkiem.Size = new Size(105, 29);
            mnutimkiem.Text = "&Tìm kiếm ";
            // 
            // mnufindhoadon
            // 
            mnufindhoadon.Name = "mnufindhoadon";
            mnufindhoadon.Size = new Size(206, 34);
            mnufindhoadon.Text = "&Hóa đơn";
            mnufindhoadon.Click += mnufindhoadon_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(203, 6);
            // 
            // mnufindhang
            // 
            mnufindhang.Name = "mnufindhang";
            mnufindhang.Size = new Size(206, 34);
            mnufindhang.Text = "&Hàng";
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(203, 6);
            // 
            // mnufindkhachhang
            // 
            mnufindkhachhang.Name = "mnufindkhachhang";
            mnufindkhachhang.Size = new Size(206, 34);
            mnufindkhachhang.Text = "&Khách hàng";
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(203, 6);
            // 
            // mnubaocao
            // 
            mnubaocao.DropDownItems.AddRange(new ToolStripItem[] { mnubchangton, toolStripMenuItem9, mnubcdoanhthu });
            mnubaocao.Name = "mnubaocao";
            mnubaocao.Size = new Size(91, 29);
            mnubaocao.Text = "&Báo cáo";
            // 
            // mnubchangton
            // 
            mnubchangton.Name = "mnubchangton";
            mnubchangton.Size = new Size(198, 34);
            mnubchangton.Text = "&Hàng tồn";
            // 
            // toolStripMenuItem9
            // 
            toolStripMenuItem9.Name = "toolStripMenuItem9";
            toolStripMenuItem9.Size = new Size(195, 6);
            // 
            // mnubcdoanhthu
            // 
            mnubcdoanhthu.Name = "mnubcdoanhthu";
            mnubcdoanhthu.Size = new Size(198, 34);
            mnubcdoanhthu.Text = "&Doanh thu";
            // 
            // mnutrogiup
            // 
            mnutrogiup.DropDownItems.AddRange(new ToolStripItem[] { mnuhientrogiup, toolStripMenuItem8, mnuvainet });
            mnutrogiup.Name = "mnutrogiup";
            mnutrogiup.Size = new Size(93, 29);
            mnutrogiup.Text = "&Trợ giúp";
            // 
            // mnuhientrogiup
            // 
            mnuhientrogiup.Name = "mnuhientrogiup";
            mnuhientrogiup.Size = new Size(179, 34);
            mnuhientrogiup.Text = "&Trợ giúp";
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(176, 6);
            // 
            // mnuvainet
            // 
            mnuvainet.Name = "mnuvainet";
            mnuvainet.Size = new Size(179, 34);
            mnuvainet.Text = "&Vài nét";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(851, 541);
            panel1.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 576);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "frmMain";
            Text = "Quản lý bán hàng ";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuthoat;
        private ToolStripMenuItem mnudanhmuc;
        private ToolStripMenuItem mnuloaihang;
        private ToolStripMenuItem mnunhanvien;
        private ToolStripMenuItem mnukhachhang;
        private ToolStripMenuItem mnuhanghoa;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem mnuhoadon;
        private ToolStripMenuItem mnuhoadonban;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem mnutimkiem;
        private ToolStripMenuItem mnufindhoadon;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem mnufindhang;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripMenuItem mnufindkhachhang;
        private ToolStripSeparator toolStripMenuItem7;
        private ToolStripMenuItem mnubaocao;
        private ToolStripMenuItem mnubchangton;
        private ToolStripSeparator toolStripMenuItem9;
        private ToolStripMenuItem mnubcdoanhthu;
        private ToolStripMenuItem mnutrogiup;
        private ToolStripMenuItem mnuhientrogiup;
        private ToolStripSeparator toolStripMenuItem8;
        private ToolStripMenuItem mnuvainet;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
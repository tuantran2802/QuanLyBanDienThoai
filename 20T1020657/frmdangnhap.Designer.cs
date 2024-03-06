namespace _20T1020657
{
    partial class frmdangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmdangnhap));
            label1 = new Label();
            panel1 = new Panel();
            btnthoat = new Button();
            btndangnhap = new Button();
            txtmatkhau = new TextBox();
            label3 = new Label();
            txttendangnhap = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(70, 41);
            label1.Name = "label1";
            label1.Size = new Size(562, 51);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO ISTORE";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnthoat);
            panel1.Controls.Add(btndangnhap);
            panel1.Controls.Add(txtmatkhau);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txttendangnhap);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(705, 397);
            panel1.TabIndex = 1;
            // 
            // btnthoat
            // 
            btnthoat.BackColor = Color.Red;
            btnthoat.Image = (Image)resources.GetObject("btnthoat.Image");
            btnthoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnthoat.Location = new Point(458, 300);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(183, 52);
            btnthoat.TabIndex = 8;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = false;
            btnthoat.Click += btnthoat_Click;
            // 
            // btndangnhap
            // 
            btndangnhap.BackColor = Color.Lime;
            btndangnhap.Image = (Image)resources.GetObject("btndangnhap.Image");
            btndangnhap.ImageAlign = ContentAlignment.MiddleLeft;
            btndangnhap.Location = new Point(211, 300);
            btndangnhap.Name = "btndangnhap";
            btndangnhap.Size = new Size(183, 52);
            btndangnhap.TabIndex = 7;
            btndangnhap.Text = "Đăng nhập";
            btndangnhap.UseVisualStyleBackColor = false;
            btndangnhap.Click += btndangnhap_Click;
            // 
            // txtmatkhau
            // 
            txtmatkhau.Location = new Point(222, 211);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(395, 31);
            txtmatkhau.TabIndex = 6;
            txtmatkhau.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(42, 211);
            label3.Name = "label3";
            label3.Size = new Size(107, 28);
            label3.TabIndex = 5;
            label3.Text = "Mật khẩu:";
            // 
            // txttendangnhap
            // 
            txttendangnhap.Location = new Point(222, 149);
            txttendangnhap.Name = "txttendangnhap";
            txttendangnhap.Size = new Size(395, 31);
            txttendangnhap.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(42, 149);
            label2.Name = "label2";
            label2.Size = new Size(157, 28);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập:";
            // 
            // frmdangnhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 397);
            Controls.Add(panel1);
            Name = "frmdangnhap";
            Text = "Đăng nhập ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label3;
        private TextBox txttendangnhap;
        private Label label2;
        private Button btnthoat;
        private Button btndangnhap;
        private TextBox txtmatkhau;
    }
}
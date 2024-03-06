namespace _20T1020657
{
    partial class frmloai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmloai));
            label1 = new Label();
            panel1 = new Panel();
            txttenloai = new TextBox();
            txtmaloai = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            dgvmathang = new DataGridView();
            btnthem = new Button();
            btnxoa = new Button();
            btnsua = new Button();
            btndong = new Button();
            panel3 = new Panel();
            btnluu = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvmathang).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.OrangeRed;
            label1.Location = new Point(150, 0);
            label1.Name = "label1";
            label1.Size = new Size(493, 36);
            label1.TabIndex = 0;
            label1.Text = "DANH MỤC CÁC MẶT HÀNG";
            // 
            // panel1
            // 
            panel1.Controls.Add(txttenloai);
            panel1.Controls.Add(txtmaloai);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(24, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(490, 88);
            panel1.TabIndex = 1;
            // 
            // txttenloai
            // 
            txttenloai.Location = new Point(126, 54);
            txttenloai.Name = "txttenloai";
            txttenloai.Size = new Size(358, 31);
            txttenloai.TabIndex = 3;
            // 
            // txtmaloai
            // 
            txtmaloai.Location = new Point(126, 3);
            txtmaloai.Name = "txtmaloai";
            txtmaloai.Size = new Size(358, 31);
            txtmaloai.TabIndex = 2;
            txtmaloai.KeyUp += txtmaloai_KeyUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.OrangeRed;
            label3.Location = new Point(12, 52);
            label3.Name = "label3";
            label3.Size = new Size(91, 28);
            label3.TabIndex = 1;
            label3.Text = "Tên loại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(12, 8);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 0;
            label2.Text = "Mã loại: ";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvmathang);
            panel2.Location = new Point(24, 156);
            panel2.Name = "panel2";
            panel2.Size = new Size(764, 403);
            panel2.TabIndex = 2;
            // 
            // dgvmathang
            // 
            dgvmathang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmathang.Location = new Point(0, 0);
            dgvmathang.Name = "dgvmathang";
            dgvmathang.RowHeadersWidth = 62;
            dgvmathang.RowTemplate.Height = 33;
            dgvmathang.Size = new Size(761, 400);
            dgvmathang.TabIndex = 0;
            dgvmathang.Click += dgvmathang_Click;
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.Lime;
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnthem.ForeColor = Color.Black;
            btnthem.Image = (Image)resources.GetObject("btnthem.Image");
            btnthem.ImageAlign = ContentAlignment.MiddleLeft;
            btnthem.Location = new Point(30, 8);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(131, 34);
            btnthem.TabIndex = 0;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            btnthem.Click += btnthem_Click;
            // 
            // btnxoa
            // 
            btnxoa.BackColor = Color.Red;
            btnxoa.BackgroundImageLayout = ImageLayout.Center;
            btnxoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnxoa.ForeColor = Color.Black;
            btnxoa.Image = (Image)resources.GetObject("btnxoa.Image");
            btnxoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnxoa.Location = new Point(172, 8);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(131, 34);
            btnxoa.TabIndex = 1;
            btnxoa.Text = "Xóa";
            btnxoa.UseVisualStyleBackColor = false;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.Lime;
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnsua.ForeColor = Color.Black;
            btnsua.Image = (Image)resources.GetObject("btnsua.Image");
            btnsua.ImageAlign = ContentAlignment.MiddleLeft;
            btnsua.Location = new Point(314, 8);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(131, 34);
            btnsua.TabIndex = 2;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = false;
            btnsua.Click += btnsua_Click;
            // 
            // btndong
            // 
            btndong.BackColor = Color.Red;
            btndong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btndong.ForeColor = Color.Black;
            btndong.Image = (Image)resources.GetObject("btndong.Image");
            btndong.ImageAlign = ContentAlignment.MiddleLeft;
            btndong.Location = new Point(598, 8);
            btndong.Name = "btndong";
            btndong.Size = new Size(131, 34);
            btndong.TabIndex = 5;
            btndong.Text = "Đóng";
            btndong.UseVisualStyleBackColor = false;
            btndong.Click += btndong_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnluu);
            panel3.Controls.Add(btndong);
            panel3.Controls.Add(btnsua);
            panel3.Controls.Add(btnxoa);
            panel3.Controls.Add(btnthem);
            panel3.Location = new Point(24, 562);
            panel3.Name = "panel3";
            panel3.Size = new Size(764, 51);
            panel3.TabIndex = 3;
            // 
            // btnluu
            // 
            btnluu.BackColor = Color.Lime;
            btnluu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnluu.ForeColor = Color.Black;
            btnluu.Image = (Image)resources.GetObject("btnluu.Image");
            btnluu.ImageAlign = ContentAlignment.MiddleLeft;
            btnluu.Location = new Point(456, 8);
            btnluu.Name = "btnluu";
            btnluu.Size = new Size(131, 34);
            btnluu.TabIndex = 6;
            btnluu.Text = "Lưu";
            btnluu.UseVisualStyleBackColor = false;
            btnluu.Click += btnluu_Click;
            // 
            // frmloai
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(798, 630);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "frmloai";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh mục các mặt hàng ";
            Load += frmloai_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvmathang).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TextBox txttenloai;
        private TextBox txtmaloai;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private DataGridView dgvmathang;
        private Button btnthem;
        private Button btnxoa;
        private Button btnsua;
        private Button btndong;
        private Panel panel3;
        private Button btnluu;
    }
}
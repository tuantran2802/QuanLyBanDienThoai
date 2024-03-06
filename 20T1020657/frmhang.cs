using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using _20T1020657.Class;
using Microsoft.EntityFrameworkCore;


namespace _20T1020657
{
    public partial class frmhang : Form
    {
        DataTable tblH;
        public frmhang()
        {
            InitializeComponent();
        }

        private void frmhang_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * from loaihang";
            txtmahang.Enabled = false;
            btnluu.Enabled = false;
            LoadDataGridView();
            Function.FillCombo(sql, cbomaloai, "maloai", "tenloai");
            cbomaloai.SelectedIndex = -1;
            ResetValues();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from hang";
            tblH = Function.GetDataToTable(sql);
            dgvhang.DataSource = tblH;
            dgvhang.Columns[0].HeaderText = "Mã hàng";
            dgvhang.Columns[1].HeaderText = "Tên hàng";
            dgvhang.Columns[2].HeaderText = "Mã loại";
            dgvhang.Columns[3].HeaderText = "Số lượng";
            dgvhang.Columns[4].HeaderText = "Giá nhập";
            dgvhang.Columns[5].HeaderText = "Giá bán";
            dgvhang.Columns[6].HeaderText = "Ảnh";
            dgvhang.Columns[7].HeaderText = "Ghi chú";
            dgvhang.Columns[0].Width = 150;
            dgvhang.Columns[1].Width = 200;
            dgvhang.Columns[2].Width = 150;
            dgvhang.Columns[3].Width = 180;
            dgvhang.Columns[4].Width = 180;
            dgvhang.Columns[5].Width = 180;
            dgvhang.Columns[6].Width = 250;
            dgvhang.Columns[7].Width = 150;
            dgvhang.AllowUserToAddRows = false;
            dgvhang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void ResetValues()
        {
            txtmahang.Text = "";
            txttenhang.Text = "";
            cbomaloai.Text = "";
            txtsoluong.Text = "0";
            txtgianhap.Text = "0";
            txtgiaban.Text = "0";
            txtsoluong.Enabled = true;
            txtgianhap.Enabled = false;
            txtgiaban.Enabled = false;
            txtanh.Text = "";
            picanh.Image = null;
            txtghichu.Text = "";
        }

        private void dgvhang_Click(object sender, EventArgs e)
        {
            string maloai;
            string sql;
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmahang.Focus();
                return;
            }
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmahang.Text = dgvhang.CurrentRow.Cells["MaHang"].Value.ToString();
            txttenhang.Text = dgvhang.CurrentRow.Cells["TenHang"].Value.ToString();
            maloai = dgvhang.CurrentRow.Cells["maloai"].Value.ToString();
            sql = "SELECT tenloai FROM loaihang WHERE maloai=N'" + maloai + "'";
            cbomaloai.Text = Function.GetFieldValues(sql);
            txtsoluong.Text = dgvhang.CurrentRow.Cells["soluong"].Value.ToString();
            txtgianhap.Text = dgvhang.CurrentRow.Cells["gianhap"].Value.ToString();
            txtgiaban.Text = dgvhang.CurrentRow.Cells["giaban"].Value.ToString();
            sql = "SELECT anh FROM hang WHERE mahang=N'" + txtmahang.Text + "'";
            txtanh.Text = Function.GetFieldValues(sql);
            picanh.Image = Image.FromFile(txtanh.Text);
            sql = "SELECT ghichu FROM hang WHERE mahang = N'" + txtmahang.Text + "'";
            txtghichu.Text = Function.GetFieldValues(sql);
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValues();
            txtmahang.Enabled = true;
            txtmahang.Focus();
            txtsoluong.Enabled = true;
            txtgianhap.Enabled = true;
            txtgiaban.Enabled = true;
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmahang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmahang.Focus();
                return;
            }
            if (txttenhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenhang.Focus();
                return;
            }
            if (cbomaloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbomaloai.Focus();
                return;
            }
            if (txtanh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnmo.Focus();
                return;
            }
            sql = "SELECT mahang FROM hang WHERE mahang=N'" + txtmahang.Text.Trim() + "'";
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã tồn tại, bạn phải chọn mã hàng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmahang.Focus();
                return;
            }
            sql = "INSERT INTO hang(mahang,tenhang,maloai,soluong,gianhap, giaban,anh,ghichu) VALUES(N'"
                + txtmahang.Text.Trim() + "',N'" + txttenhang.Text.Trim() +
                "',N'" + cbomaloai.SelectedValue.ToString() +
                "'," + txtsoluong.Text.Trim() + "," + txtgianhap.Text +
                "," + txtgiaban.Text + ",'" + txtanh.Text + "',N'" + txtghichu.Text.Trim() + "')";

            Function.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmahang.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmahang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmahang.Focus();
                return;
            }
            if (txttenhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenhang.Focus();
                return;
            }
            if (cbomaloai.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbomaloai.Focus();
                return;
            }
            if (txtanh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtanh.Focus();
                return;
            }
            sql = "UPDATE hang SET tenhang=N'" + txttenhang.Text.Trim().ToString() +
                "',maloai=N'" + cbomaloai.SelectedValue.ToString() +
                "',soluong=" + txtsoluong.Text +
                ",anh='" + txtanh.Text + "',ghichu=N'" + txtghichu.Text + "' WHERE mahang=N'" + txtmahang.Text + "'";
            Function.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmahang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE hang WHERE mahang=N'" + txtmahang.Text + "'";
                Function.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }


        private void btnmo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picanh.Image = Image.FromFile(dlgOpen.FileName);
                txtanh.Text = dlgOpen.FileName;
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtmahang.Text == "") && (txttenhang.Text == "") && (cbomaloai.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from hang WHERE 1=1";
            if (txtmahang.Text != "")
                sql += " AND mahang LIKE N'%" + txtmahang.Text + "%'";
            if (txttenhang.Text != "")
                sql += " AND tenhang LIKE N'%" + txttenhang.Text + "%'";
            if (cbomaloai.Text != "")
                sql += " AND maloai LIKE N'%" + cbomaloai.SelectedValue + "%'";
            tblH = Function.GetDataToTable(sql);
            if (tblH.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tblH.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvhang.DataSource = tblH;
            ResetValues();
        }

        private void btnhienthids_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * FROM hang";
            tblH = Function.GetDataToTable(sql);
            dgvhang.DataSource = tblH;
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

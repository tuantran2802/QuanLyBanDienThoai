using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _20T1020657.Class;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace _20T1020657
{
    public partial class frmkhachhang : Form
    {
         DataTable tblKH;
        public frmkhachhang()
        {
            InitializeComponent();
        }

        private void frmkhachhang_Load(object sender, EventArgs e)
        {
            txtmakhachhang.Enabled = false;
            btnluu.Enabled = false;
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * from khachhang";
            tblKH = Function.GetDataToTable(sql); //Lấy dữ liệu từ bảng
            dgvkhachhang.DataSource = tblKH; //Hiển thị vào dataGridView
            dgvkhachhang.Columns[0].HeaderText = "Mã khách";
            dgvkhachhang.Columns[1].HeaderText = "Tên khách";
            dgvkhachhang.Columns[2].HeaderText = "Địa chỉ";
            dgvkhachhang.Columns[3].HeaderText = "Điện thoại";
            dgvkhachhang.Columns[0].Width = 165;
            dgvkhachhang.Columns[1].Width = 280;
            dgvkhachhang.Columns[2].Width = 350;
            dgvkhachhang.Columns[3].Width = 220;
            dgvkhachhang.AllowUserToAddRows = false;
            dgvkhachhang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvkhachhang_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmakhachhang.Focus();
                return;
            }
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmakhachhang.Text = dgvkhachhang.CurrentRow.Cells["makhach"].Value.ToString();
            txttenkhachhang.Text = dgvkhachhang.CurrentRow.Cells["tenkhach"].Value.ToString();
            txtdiachi.Text = dgvkhachhang.CurrentRow.Cells["diachi"].Value.ToString();
            mtbdienthoai.Text = dgvkhachhang.CurrentRow.Cells["dienthoai"].Value.ToString();
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
            txtmakhachhang.Enabled = true;
            txtmakhachhang.Focus();
        }

        private void ResetValues()
        {
            txtmakhachhang.Text = "";
            txttenkhachhang.Text = "";
            txtdiachi.Text = "";
            mtbdienthoai.Text = "";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmakhachhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmakhachhang.Focus();
                return;
            }
            if (txttenkhachhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenkhachhang.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiachi.Focus();
                return;
            }
            if (mtbdienthoai.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbdienthoai.Focus();
                return;
            }
            //Kiểm tra đã tồn tại mã khách chưa
            sql = "SELECT makhach FROM khachhang WHERE MaKhach=N'" + txtmakhachhang.Text.Trim() + "'";
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("Mã khách này đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmakhachhang.Focus();
                return;
            }
            //Chèn thêm
            sql = "INSERT INTO khachhang VALUES (N'" + txtmakhachhang.Text.Trim() +
                "',N'" + txttenkhachhang.Text.Trim() + "',N'" + txtdiachi.Text.Trim() + "','" + mtbdienthoai.Text + "')";
            Function.RunSQL(sql);
            LoadDataGridView();
            ResetValues();

            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmakhachhang.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmakhachhang.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bản ghi cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttenkhachhang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenkhachhang.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdiachi.Focus();
                return;
            }
            if (mtbdienthoai.Text == "(  )    -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbdienthoai.Focus();
                return;
            }
            sql = "UPDATE khachhang SET tenkhach=N'" + txttenkhachhang.Text.Trim().ToString() + "',diachi=N'" +
                txtdiachi.Text.Trim().ToString() + "',dienthoai='" + mtbdienthoai.Text.ToString() +
                "' WHERE makhach=N'" + txtmakhachhang.Text + "'";
            Function.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmakhachhang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE khachhang WHERE makhach=N'" + txtmakhachhang.Text + "'";
                Function.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtmakhachhang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txttenkhachhang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtdiachi_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void mtbdienthoai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}

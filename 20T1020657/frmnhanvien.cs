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
    public partial class frmnhanvien : Form
    {
        public DataTable tblNV;
        public frmnhanvien()
        {
            InitializeComponent();
        }
        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
            txtmanhanvien.Enabled = false;
            btnluu.Enabled = false;

        }
        public void LoadDataGridView()
        {
            string sql;
            sql = "SELECT * FROM nhanvien";
            tblNV = Function.GetDataToTable(sql); //lấy dữ liệu
            dgvnhanvien.DataSource = tblNV;
            dgvnhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dgvnhanvien.Columns[1].HeaderText = "Tên nhân viên";
            dgvnhanvien.Columns[2].HeaderText = "Giới tính";
            dgvnhanvien.Columns[3].HeaderText = "Địa chỉ";
            dgvnhanvien.Columns[4].HeaderText = "Điện thoại";
            dgvnhanvien.Columns[5].HeaderText = "Ngày sinh";
            dgvnhanvien.Columns[0].Width = 250;
            dgvnhanvien.Columns[1].Width = 250;
            dgvnhanvien.Columns[2].Width = 180;
            dgvnhanvien.Columns[3].Width = 150;
            dgvnhanvien.Columns[4].Width = 180;
            dgvnhanvien.Columns[5].Width = 180;
            dgvnhanvien.AllowUserToAddRows = false;
            dgvnhanvien.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void dgvnhanvien_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmanhanvien.Focus();
                return;
            }
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmanhanvien.Text = dgvnhanvien.CurrentRow.Cells["manhanvien"].Value.ToString();
            txttennhanvien.Text = dgvnhanvien.CurrentRow.Cells["tennhanvien"].Value.ToString();
            if (dgvnhanvien.CurrentRow.Cells["gioitinh"].Value.ToString() == "Nam") chkgioitinh.Checked = true;
            else chkgioitinh.Checked = false;
            txtdiachi.Text = dgvnhanvien.CurrentRow.Cells["diachi"].Value.ToString();
            mtbdienthoai.Text = dgvnhanvien.CurrentRow.Cells["dienthoai"].Value.ToString();
            dtpngaysinh.Value = (DateTime)dgvnhanvien.CurrentRow.Cells["ngaysinh"].Value;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValues();
            txtmanhanvien.Enabled = true;
            txtmanhanvien.Focus();
        }

        private void ResetValues()
        {
            txtmanhanvien.Text = "";
            txttennhanvien.Text = "";
            chkgioitinh.Checked = false;
            txtdiachi.Text = "";
            dtpngaysinh.Value = DateTime.Now;
            mtbdienthoai.Text = "";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtmanhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanhanvien.Focus();
                return;
            }
            if (txttennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennhanvien.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (mtbdienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbdienthoai.Focus();
                return;
            }
            if (chkgioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "SELECT manhanvien FROM nhanvien WHERE manhanvien=N'" + txtmanhanvien.Text.Trim() + "'";
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("Mã nhân viên này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmanhanvien.Focus();
                txtmanhanvien.Text = "";
                return;
            }
            sql = "INSERT INTO nhanvien(manhanvien, tennhanvien,gioitinh, diachi,dienthoai, ngaysinh) VALUES (N'" + txtmanhanvien.Text.Trim() + "',N'" + txttennhanvien.Text.Trim() + "',N'" + gt + "',N'" + txtdiachi.Text.Trim() + "','" + mtbdienthoai.Text + "','" + dtpngaysinh.Value + "')";
            Function.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmanhanvien.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmanhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttennhanvien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttennhanvien.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdiachi.Focus();
                return;
            }
            if (mtbdienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbdienthoai.Focus();
                return;
            }
            /*if (dtpngaysinh.Text == "  /  /")
           {
               MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               dtpngaysinh.Focus();
               return;
           }
           if (!Function.IsDate(mskNgaySinh.Text))
           {
               MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               mskNgaySinh.Text = "";
               mskNgaySinh.Focus();
               return;
           }*/
            if (chkgioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
            sql = "UPDATE nhanvien SET  tennhanvien=N'" + txttennhanvien.Text.Trim().ToString() +
                    "',diachi=N'" + txtdiachi.Text.Trim().ToString() +
                    "',dienthoai='" + mtbdienthoai.Text.ToString() + "',GioiTinh=N'" + gt +
                    "',ngaysinh='" + dtpngaysinh.Value +
                    "' WHERE manhanvien=N'" + txtmanhanvien.Text + "'";
            Function.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmanhanvien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE nhanvien WHERE manhanvien=N'" + txtmanhanvien.Text + "'";
                Function.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtmanhanvien_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txttennhanvien_KeyUp(object sender, KeyEventArgs e)
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

        private void dtpngaysinh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

      
    }
}

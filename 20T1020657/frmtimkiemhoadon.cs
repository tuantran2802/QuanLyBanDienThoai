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
    public partial class frmtimkiemhoadon : Form
    {
        DataTable tblHDB; //Hoá đơn bán
        public frmtimkiemhoadon()
        {
            InitializeComponent();
        }

        private void frmtimkiemhoadon_Load(object sender, EventArgs e)
        {
            ResetValues();
            dgvtkhoadon.DataSource = null;
        }

        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtmaHD.Focus();
        }
        private void LoadDataGridView()
        {
            dgvtkhoadon.Columns[0].HeaderText = "Mã Hóa Đơn";
            dgvtkhoadon.Columns[1].HeaderText = "Mã nhân viên";
            dgvtkhoadon.Columns[2].HeaderText = "Ngày bán";
            dgvtkhoadon.Columns[3].HeaderText = "Mã khách";
            dgvtkhoadon.Columns[4].HeaderText = "Tổng tiền";
            dgvtkhoadon.Columns[0].Width = 200;
            dgvtkhoadon.Columns[1].Width = 200;
            dgvtkhoadon.Columns[2].Width = 180;
            dgvtkhoadon.Columns[3].Width = 180;
            dgvtkhoadon.Columns[4].Width = 180;
            dgvtkhoadon.AllowUserToAddRows = false;
            dgvtkhoadon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtmaHD.Text == "") && (txtthang.Text == "") && (txtnam.Text == "") &&
               (txtmanhanvien.Text == "") && (txtmakhach.Text == "") &&
               (txttongtien.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * FROM hoadon WHERE 1=1";
            if (txtmaHD.Text != "")
                sql = sql + " AND mahoadon Like N'%" + txtmaHD.Text + "%'";
            if (txtthang.Text != "")
                sql = sql + " AND MONTH(ngayban) =" + txtthang.Text;
            if (txtnam.Text != "")
                sql = sql + " AND YEAR(ngayban) =" + txtnam.Text;
            if (txtmanhanvien.Text != "")
                sql = sql + " AND manhanvien Like N'%" + txtmanhanvien.Text + "%'";
            if (txtmakhach.Text != "")
                sql = sql + " AND makhachhang Like N'%" + txtmakhach.Text + "%'";
            if (txttongtien.Text != "")
                sql = sql + " AND tongtien <=" + txttongtien.Text;
            tblHDB = Function.GetDataToTable(sql);
            if (tblHDB.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có " + tblHDB.Rows.Count + " bản ghi thỏa mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvtkhoadon.DataSource = tblHDB;
            LoadDataGridView();
        }

        private void btntimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            dgvtkhoadon.DataSource = null;
        }

        private void txttongtien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void dgvtkhoadon_DoubleClick(object sender, EventArgs e)
        {
            string mahd;
            if (MessageBox.Show("Bạn có muốn hiển thị thông tin chi tiết?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mahd = dgvtkhoadon.CurrentRow.Cells["mahoadon"].Value.ToString();
                frmhoadon frm = new frmhoadon();
                frm.txtmahoadon.Text = mahd;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

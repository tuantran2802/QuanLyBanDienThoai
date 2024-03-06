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



namespace _20T1020657
{
    public partial class frmloai : Form
    {

        public DataTable tblCl;
        public frmloai()
        {
            InitializeComponent();
        }



        private void frmloai_Load(object sender, EventArgs e)
        {
            txtmaloai.Enabled = false;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT maloai, tenloai FROM loaihang";
            tblCl = Function.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvmathang.DataSource = tblCl; //Nguồn dữ liệu            
            dgvmathang.Columns[0].HeaderText = "Mã loại ";
            dgvmathang.Columns[1].HeaderText = "Tên loại ";
            dgvmathang.Columns[0].Width = 300;
            dgvmathang.Columns[1].Width = 300;
            dgvmathang.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvmathang.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvmathang_Click(object sender, EventArgs e)
        {
            if (btnthem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmaloai.Focus();
                return;
            }
            if (tblCl.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtmaloai.Text = dgvmathang.CurrentRow.Cells["maloai"].Value.ToString();
            txttenloai.Text = dgvmathang.CurrentRow.Cells["tenloai"].Value.ToString();
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnluu.Enabled = true;
            btnthem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtmaloai.Enabled = true; //cho phép nhập mới
            txtmaloai.Focus();
        }

        private void ResetValue()
        {
            txtmaloai.Text = "";
            txttenloai.Text = "";
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtmaloai.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtmaloai.Focus();
                return;
            }
            if (txttenloai.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txttenloai.Focus();
                return;
            }
            sql = "Select maloai From loaihang where maloai=N'" + txtmaloai.Text.Trim() + "'";
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("Mã chất liệu này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmaloai.Focus();
                return;
            }

            sql = "INSERT INTO loaihang VALUES(N'" +
                txtmaloai.Text + "',N'" + txttenloai.Text + "')";
            Function.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnsua.Enabled = true;
            btnluu.Enabled = false;
            txtmaloai.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblCl.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmaloai.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txttenloai.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE loaihang SET tenloai=N'" +
                txttenloai.Text.ToString() +
                "' WHERE maloai=N'" + txtmaloai.Text + "'";
            Function.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCl.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtmaloai.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE loaihang WHERE maloai=N'" + txtmaloai.Text + "'";
                Function.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtmaloai_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}

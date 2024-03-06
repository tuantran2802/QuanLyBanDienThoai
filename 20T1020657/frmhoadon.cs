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
using COMExcel = Microsoft.Office.Interop.Excel;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace _20T1020657
{
    public partial class frmhoadon : Form
    {
        DataTable tblCTHDB; //Bảng chi tiết hoá đơn bán
        private SqlConnection connection;

        public frmhoadon()
        {
            InitializeComponent();
        }
        private void frmhoadon_Load(object sender, EventArgs e)
        {
            btnthemhoadon.Enabled = true;
            btnluuhoadon.Enabled = false;
            btnxoahoadon.Enabled = false;
            txtmahoadon.ReadOnly = true;
            txttennhanvien.ReadOnly = true;
            txttenkhachhang.ReadOnly = true;
            txtdiachi.ReadOnly = true;
            mtbsodienthoai.ReadOnly = true;
            txttenhang.ReadOnly = true;
            txtgiaban.ReadOnly = true;
            txtthanhtien.ReadOnly = true;
            txttongtien.ReadOnly = true;
            txtgiamgia.Text = "0";
            txttongtien.Text = "0";
            Function.FillCombo("SELECT makhach, tenkhach FROM khachhang", cbomakhachhang, "makhach", "tenkhach");
            cbomakhachhang.SelectedIndex = -1;
            Function.FillCombo("SELECT manhanvien, tennhanvien FROM nhanvien", cbomanhanvien, "manhanvien", "tennhanvien");
            cbomanhanvien.SelectedIndex = -1;
            Function.FillCombo("SELECT mahang, tenhang FROM hang", cbomahang, "mahang", "tenhang");
            cbomahang.SelectedIndex = -1;
            //Hiển thị thông tin của một hóa đơn được gọi từ form tìm kiếm
            if (txtmahoadon.Text != "")
            {
                LoadInfoHoaDon();
                btnxoahoadon.Enabled = true;
            }
            LoadDataGridView();

        }

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT a.mahang, b.tenhang, a.soluong, b.giaban, a.giamgia,a.thanhtien FROM chitiethoadon AS a, hang AS b WHERE a.mahoadon = N'" + txtmahoadon.Text + "' AND a.mahang=b.mahang";
            tblCTHDB = Function.GetDataToTable(sql);
            dgvhoadon.DataSource = tblCTHDB;
            dgvhoadon.Columns[0].HeaderText = "Mã hàng";
            dgvhoadon.Columns[1].HeaderText = "Tên hàng";
            dgvhoadon.Columns[2].HeaderText = "Số lượng";
            dgvhoadon.Columns[3].HeaderText = "Đơn giá";
            dgvhoadon.Columns[4].HeaderText = "Giảm giá %";
            dgvhoadon.Columns[5].HeaderText = "Thành tiền";
            dgvhoadon.Columns[0].Width = 150;
            dgvhoadon.Columns[1].Width = 180;
            dgvhoadon.Columns[2].Width = 200;
            dgvhoadon.Columns[3].Width = 150;
            dgvhoadon.Columns[4].Width = 180;
            dgvhoadon.Columns[5].Width = 250;
            dgvhoadon.AllowUserToAddRows = false;
            dgvhoadon.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void LoadInfoHoaDon()
        {
            string str;
            str = "SELECT ngayban FROM hoadon WHERE mahoadon = N'" + txtmahoadon.Text + "'";
            dtpngayban.Value = DateTime.Parse(Function.GetFieldValues(str));
            str = "SELECT manhanvien FROM hoadon WHERE mahoadon = N'" + txtmahoadon.Text + "'";
            cbomanhanvien.SelectedValue = Function.GetFieldValues(str);
            str = "SELECT makhach FROM hoadon WHERE mahoadon = N'" + txtmahoadon.Text + "'";
            cbomakhachhang.SelectedValue = Function.GetFieldValues(str);
            str = "SELECT tongtien FROM hoadon WHERE mahoadon = N'" + txtmahoadon.Text + "'";
            txttongtien.Text = Function.GetFieldValues(str);
            //.lblbangchu.Text = "Bằng chữ: " + Function.ChuyenSoSangChuoi(double.Parse(txttongtien.Text));
        }



        private void ResetValues()
        {
            txtmahoadon.Text = "";
            dtpngayban.Value = DateTime.Now;
            cbomanhanvien.Text = "";
            cbomakhachhang.Text = "";
            txttongtien.Text = "0";
            lblbangchu.Text = "Bằng chữ: ";
            cbomahang.Text = "";
            txtsoluong.Text = "";
            txtgiamgia.Text = "0";
            txtthanhtien.Text = "0";
        }



        private void ResetValuesHang()
        {
            cbomahang.Text = "";
            txtsoluong.Text = "";
            txtgiamgia.Text = "0";
            txtthanhtien.Text = "0";
        }

        private void cbomahang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomahang.Text == "")
            {
                txttenhang.Text = "";
                txtgiaban.Text = "";
            }
            // Khi chọn mã hàng thì các thông tin về hàng hiện ra
            str = "SELECT tenhang FROM hang WHERE mahang =N'" + cbomahang.SelectedValue + "'";
            txttenhang.Text = Function.GetFieldValues(str);
            str = "SELECT giaban FROM hang WHERE mahang =N'" + cbomahang.SelectedValue + "'";
            txtgiaban.Text = Function.GetFieldValues(str);
        }

        private void cbomakhachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomakhachhang.Text == "")
            {
                txttenkhachhang.Text = "";
                txtdiachi.Text = "";
                mtbsodienthoai.Text = "";
            }
            //Khi chọn Mã khách hàng thì các thông tin của khách hàng sẽ hiện ra
            str = "Select tenkhach from khachhang where makhach = N'" + cbomakhachhang.SelectedValue + "'";
            txttenkhachhang.Text = Function.GetFieldValues(str);
            str = "Select diachi from khachhang where makhach = N'" + cbomakhachhang.SelectedValue + "'";
            txtdiachi.Text = Function.GetFieldValues(str);
            str = "Select dienthoai from khachhang where makhach= N'" + cbomakhachhang.SelectedValue + "'";
            mtbsodienthoai.Text = Function.GetFieldValues(str);
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi số lượng thì thực hiện tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtsoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtsoluong.Text);
            if (txtgiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtgiamgia.Text);
            if (txtgiaban.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtgiaban.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtthanhtien.Text = tt.ToString();
        }

        private void txtgiamgia_TextChanged(object sender, EventArgs e)
        {
            //Khi thay đổi giảm giá thì tính lại thành tiền
            double tt, sl, dg, gg;
            if (txtsoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtsoluong.Text);
            if (txtgiamgia.Text == "")
                gg = 0;
            else
                gg = Convert.ToDouble(txtgiamgia.Text);
            if (txtgiaban.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtgiaban.Text);
            tt = sl * dg - sl * dg * gg / 100;
            txtthanhtien.Text = tt.ToString();
        }

        private void btnthemhoadon_Click(object sender, EventArgs e)
        {
            btnxoahoadon.Enabled = false;
            btnluuhoadon.Enabled = true;
            btnthemhoadon.Enabled = false;
            ResetValues();
            txtmahoadon.Text = Function.CreateKey("HDB");
            LoadDataGridView();
        }

        private void btnluuhoadon_Click(object sender, EventArgs e)
        {
            string sql;
            double sl, SLcon, tong, Tongmoi;
            sql = "SELECT mahoadon FROM hoadon WHERE mahoadon=N'" + txtmahoadon.Text + "'";
            if (!Function.CheckKey(sql))
            {
                // Mã hóa đơn chưa có, tiến hành lưu các thông tin chung
                // Mã HDBan được sinh tự động do đó không có trường hợp trùng khóa
                if (cbomanhanvien.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbomanhanvien.Focus();
                    return;
                }
                if (cbomakhachhang.Text.Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbomakhachhang.Focus();
                    return;
                }
                sql = "INSERT INTO hoadon(mahoadon,manhanvien, ngayban,  makhachhang, tongtien) VALUES (N'" + txtmahoadon.Text.Trim() + "',N'" + cbomanhanvien.SelectedValue +
                    "','" + dtpngayban.Value + "',N'" + cbomakhachhang.SelectedValue + "'," + txttongtien.Text + ")";
                Function.RunSQL(sql);
            }
            // Lưu thông tin của các mặt hàng
            if (cbomahang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbomahang.Focus();
                return;
            }
            if ((txtsoluong.Text.Trim().Length == 0) || (txtsoluong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluong.Text = "";
                txtsoluong.Focus();
                return;
            }
            if (txtgiamgia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtgiamgia.Focus();
                return;
            }
            sql = "SELECT mahang FROM chitiethoadon WHERE mahang=N'" + cbomahang.SelectedValue + "' AND mahoadon = N'" + txtmahoadon.Text.Trim() + "'";
            if (Function.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesHang();
                cbomahang.Focus();
                return;
            }
            // Kiểm tra xem số lượng hàng trong kho còn đủ để cung cấp không?
            sl = Convert.ToDouble(Function.GetFieldValues("SELECT soluong FROM hang WHERE mahang = N'" + cbomahang.SelectedValue + "'"));
            if (Convert.ToDouble(txtsoluong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn " + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluong.Text = "";
                txtsoluong.Focus();
                return;
            }
            sql = "INSERT INTO chitiethoadon(mahoadon,mahang,soluong,dongia, giamgia,thanhtien) VALUES(N'" +
               txtmahoadon.Text.Trim() + "',N'" + cbomahang.SelectedValue + "'," + txtsoluong.Text + "," + txtgiaban.Text + "," + txtgiamgia.Text + "," + txtthanhtien.Text + ")";

            Function.RunSQL(sql);
            LoadDataGridView();
            // Cập nhật lại số lượng của mặt hàng vào bảng tblHang
            SLcon = sl - Convert.ToDouble(txtsoluong.Text);
            sql = "UPDATE hang SET soluong =" + SLcon + " WHERE mahang= N'" + cbomahang.SelectedValue + "'";
            Function.RunSQL(sql);
            // Cập nhật lại tổng tiền cho hóa đơn bán
            tong = Convert.ToDouble(Function.GetFieldValues("SELECT tongtien FROM hoadon WHERE mahoadon = N'" + txtmahoadon.Text + "'"));
            Tongmoi = tong + Convert.ToDouble(txtthanhtien.Text);
            //lblbangchu.Text = "Bằng chữ: " + function.ChuyenSoSangChuoi(double.Parse(Tongmoi.ToString()));
            sql = "UPDATE hoadon SET tongtien =" + Tongmoi + " WHERE mahoadon = N'" + txtmahoadon.Text + "'";
            Function.RunSQL(sql);
            txttongtien.Text = Tongmoi.ToString();
            ResetValuesHang();
            btnxoahoadon.Enabled = true;
            btnthemhoadon.Enabled = true;
        }

        private void cbomanhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str;
            if (cbomanhanvien.Text == "")
                txttennhanvien.Text = "";
            // Khi chọn Mã nhân viên thì tên nhân viên tự động hiện ra
            str = "Select tennhanvien from nhanvien where manhanvien =N'" + cbomanhanvien.SelectedValue + "'";
            txttennhanvien.Text = Function.GetFieldValues(str);
        }

        private void cbomahoadon_DropDown(object sender, EventArgs e)
        {

            Function.FillCombo("SELECT mahoadon FROM hoadon", cbomahoadon, "mahoadon", "mahoadon");
            cbomahoadon.SelectedIndex = -1;
        }

        private void btnxoahoadon_Click(object sender, EventArgs e)
        {
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT mahang,soluong FROM chitiethoadon WHERE mahoadon = N'" + txtmahoadon.Text + "'";
                DataTable tblHang = Function.GetDataToTable(sql);
                for (int mahang = 0; mahang <= tblHang.Rows.Count - 1; mahang++)
                {
                    // Cập nhật lại số lượng cho các mặt hàng
                    sl = Convert.ToDouble(Function.GetFieldValues("SELECT soluong FROM hang WHERE mahang = N'" + tblHang.Rows[mahang][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(tblHang.Rows[mahang][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE hang SET soluong =" + slcon + " WHERE mahang= N'" + tblHang.Rows[mahang][0].ToString() + "'";
                    Function.RunSQL(sql);
                }

                //Xóa chi tiết hóa đơn
                sql = "DELETE chitiethoadon WHERE mahoadon=N'" + txtmahoadon.Text + "'";
                Function.RunSQL(sql);

                //Xóa hóa đơn
                sql = "DELETE hoadon WHERE mahoadon=N'" + txtmahoadon.Text + "'";
                Function.RunSQL(sql);
                ResetValues();
                LoadDataGridView();
                btnxoahoadon.Enabled = false;
            }
        }

        private void btntimkiemhoadon_Click(object sender, EventArgs e)
        {
            if (cbomahoadon.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbomahoadon.Focus();
                return;
            }
            txtmahoadon.Text = cbomahoadon.Text;
            LoadInfoHoaDon();
            LoadDataGridView();
            btnxoahoadon.Enabled = true;
            btnluuhoadon.Enabled = true;
            cbomahoadon.SelectedIndex = -1;
        }

        private void btndonghoadon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

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

namespace _20T1020657
{
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {

            SqlConnection Con = new SqlConnection();//Khởi tạo đối tượng
            Con.ConnectionString = @"Data Source=LAPTOP-6EIFMUG5;Initial Catalog=quanlybanhang;Integrated Security=True";
            try
            {
                Con.Open();
                string tendn = txttendangnhap.Text;
                string matkhau = txtmatkhau.Text;
                string sql = " SELECT * FROM TKdangnhap WHERE tendangnhap = '" +tendn+ "' and matkhau = '"+matkhau +"'";
                SqlCommand cmd = new SqlCommand(sql, Con);
                SqlDataReader data = cmd.ExecuteReader();
                if(data.Read() == true)
                {
                    MessageBox.Show("Dang nhap thanh cong","thong bao", MessageBoxButtons.OK,MessageBoxIcon.Information);
                      frmMain frm = new frmMain();
                     frm.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Dang nhap that bai", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("khong ket noi duoc");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20T1020657
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }



        private void mnuthoat_Click(object sender, EventArgs e)
        {
          frmdangnhap frm = new frmdangnhap();
            frm.ShowDialog();
        }

        private void mnuloaihang_Click(object sender, EventArgs e)
        {
            frmloai frm = new frmloai();
            
            frm.ShowDialog();
        }

        private void mnunhanvien_Click(object sender, EventArgs e)
        {
            frmnhanvien frmnv = new frmnhanvien();           
            frmnv.ShowDialog();
        }

        private void mnuhanghoa_Click(object sender, EventArgs e)
        {
            frmhang frm = new frmhang();
            frm.ShowDialog();
        }

        private void mnukhachhang_Click(object sender, EventArgs e)
        {
            frmkhachhang frm = new frmkhachhang();
            frm.ShowDialog();
        }

        private void mnuhoadonban_Click(object sender, EventArgs e)
        {
            frmhoadon frm = new frmhoadon();
            frm.ShowDialog();
        }

        private void mnufindhoadon_Click(object sender, EventArgs e)
        {
            frmtimkiemhoadon frm = new frmtimkiemhoadon();
            frm.ShowDialog();
        }
    }
}

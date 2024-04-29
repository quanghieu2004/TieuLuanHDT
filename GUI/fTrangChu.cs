using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fTrangChu : Form
    {
        private int childFormNumber = 0;

        public fTrangChu()
        {
            InitializeComponent();
        }

        private void đăngKíMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDangKiMonHoc fdk = new fDangKiMonHoc();
            fdk.MdiParent = this;
            fdk.Show();
        }

        private void nhậpĐiểmHọcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhapDiem fnd = new fNhapDiem();
            fnd.MdiParent = this;
            fnd.Show();
        }

        private void xemLịchGiảngDạyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLichGiangDay fl = new fLichGiangDay();
            fl.MdiParent = this;
            fl.Show();
        }

        private void xemLịchThiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           fLichThi ft = new fLichThi();
            ft.MdiParent = this;
            ft.Show();
        }

        private void xemĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fXemDiem fd = new fXemDiem();
            fd.MdiParent = this;
            fd.Show();
        }
    }
}

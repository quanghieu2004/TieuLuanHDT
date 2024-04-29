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
using System.Data;

namespace GUI
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection con =  new SqlConnection(@"Data Source=DESKTOP-7CR5S0P\SQLEXPRESS;Initial Catalog=QuanLiDaoTaoEdusoft;Integrated Security=True");
            try
            {
                con.Open();
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string sql = "select * from NguoiDung where txtTaiKhoan =  '" + tk + "' and MatKhau = '" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dta = cmd.ExecuteReader();
                if(dta.Read()==true)
                {
                    MessageBox.Show("Dang nhap thanh cong");
                    fTrangChu fh = new fTrangChu();
                }
                else
                {
                    MessageBox.Show("Dang nhap that bai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi");
            }
        }
        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

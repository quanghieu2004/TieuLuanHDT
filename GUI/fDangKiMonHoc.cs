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

namespace GUI
{
    public partial class fDangKiMonHoc : Form
    {
        private string connectionString;
        private object listViewMonHoc;

        public fDangKiMonHoc()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            string sql = "SELECT * FROM MonHoc";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string maMH = dr["MaMH"].ToString();
                            string tenMH = dr["TenMH"].ToString();
                            int soTC = int.Parse(dr["SoTC"].ToString());
                            string GVPhuTrach = dr["GVPhuTrach"].ToString();

                            ListViewItem item = new ListViewItem(new string[] { maMH, tenMH, soTC.ToString(), GVPhuTrach });
                           
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fDangKiMonHoc_Load(object sender, EventArgs e)
        {

        }
    }
}

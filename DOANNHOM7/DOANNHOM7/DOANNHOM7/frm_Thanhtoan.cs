using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANNHOM7
{
    public partial class frm_Thanhtoan : Form
    {
        LOPDUNGCHUNG dl = new LOPDUNGCHUNG();
        public frm_Thanhtoan()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadBanToComboBox();
           
            
        }
        public void LoadTongTien(string maBan)
        {
            string query = "SELECT SUM(TONGTIEN) FROM ORDERS WHERE MABAN = @MABAN";

            using (SqlConnection conn = dl.GetConnection())
            {
                
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MABAN", maBan);
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        txt_thanhtoan.Text = result.ToString();
                    }
                    else
                    {
                        txt_thanhtoan.Text = "0"; // Nếu không có đơn hàng nào
                    }
                }
                conn.Close();
            }
        }

        private void frm_Thanhtoan_Load(object sender, EventArgs e)
        {

        }
        private void LoadBanToComboBox()
        {
            string sql = "SELECT MABAN, TRANGTHAI FROM BAN";
            DataTable dt = dl.LoadDL(sql);

            cbb_ban.DisplayMember = "MABAN";
            cbb_ban.ValueMember = "MABAN";
            cbb_ban.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbb_ban_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTongTien(cbb_ban.SelectedValue.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công "+ txt_thanhtoan.Text+" VNĐ","Thông báo");
        }
    }
}

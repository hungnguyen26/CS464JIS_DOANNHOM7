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
    public partial class frm_orders : Form
    {
        LOPDUNGCHUNG dl = new LOPDUNGCHUNG();
        private DataTable dtOrder = new DataTable();
        public frm_orders()
        {
            InitializeComponent();
            LoadBanToComboBox();
            LoadMonToComboBox();
            tongtien();
            dtOrder.Columns.Add("MAMON"); 
            dtOrder.Columns.Add("Tên món");
            dtOrder.Columns.Add("Giá");
            dtOrder.Columns.Add("Số lượng");
            dtOrder.Columns.Add("Thành tiền");
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        private void tongtien()
        {
            if (int.TryParse(nud_soluong.Text, out int quantity) &&
                int.TryParse(txt_gia.Text, out int price))
            {
                int total = quantity * price;
                txt_thanhtien.Text = total.ToString(); 
            }
            
        }


        private void LoadBanToComboBox()
        {
            string sql = "SELECT MABAN, TRANGTHAI FROM BAN";
            DataTable dt = dl.LoadDL(sql);

            cbb_maban.DisplayMember = "MABAN";
            cbb_maban.ValueMember = "MABAN";
            cbb_maban.DataSource = dt;
        }
        private void LoadMonToComboBox()
        {
            string sql = "SELECT TENMON FROM MON";
            DataTable dt = dl.LoadDL(sql);
            cbb_tenmon.DisplayMember = "TENMON";
            cbb_tenmon.ValueMember = "TENMON";
            cbb_tenmon.DataSource = dt;           
        }
        private void LoadGiaMonAnToTextBox()
        {
            string tenMon = cbb_tenmon.SelectedValue.ToString();
            string sql = $"SELECT GIA FROM MON WHERE TENMON = '{tenMon}'";
            DataTable dt = dl.LoadDL(sql);

            if (dt.Rows.Count > 0)
            {
                txt_gia.Text = dt.Rows[0]["GIA"].ToString();
            }
        }


        private void cbb_tenmon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGiaMonAnToTextBox();
            tongtien();
        }

        private void nud_soluong_Click(object sender, EventArgs e)
        {
            tongtien();
        }

        private void frm_orders_Load(object sender, EventArgs e)
        {
            
        }

        private void cbb_maban_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public int GetMaMonByTenMon(string tenMon)
        {
            int maMon = -1; // Giá trị mặc định nếu không tìm thấy

            if (string.IsNullOrEmpty(tenMon))
            {
                MessageBox.Show("Tên món không hợp lệ!");
                return maMon;
            }

            string query = "SELECT MAMON FROM MON WHERE TENMON = @TENMON";

            using (SqlConnection conn = dl.GetConnection())
            {
                
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TENMON", tenMon);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        maMon = Convert.ToInt32(result);
                    }
                }
                conn.Close();
            }

            return maMon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string tenMon = cbb_tenmon.Text;
            int mamon = GetMaMonByTenMon(tenMon);
            decimal gia = decimal.Parse(txt_gia.Text);
            int soLuong = int.Parse(nud_soluong.Value.ToString());
            decimal thanhTien = gia * soLuong;

            dtOrder.Rows.Add(mamon,tenMon, gia, soLuong, thanhTien);
            dataGridView1.DataSource = dtOrder;
           
          

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void btn_order_Click(object sender, EventArgs e)
        {
                if (dtOrder.Rows.Count == 0)
                {
                    MessageBox.Show("Không có món nào trong đơn hàng!");
                    return;
                }

                try
                {
                    string ngayGio = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    string sqlInsertOrder = "INSERT INTO ORDERS (NGAYGIO, TONGTIEN, MABAN) OUTPUT INSERTED.MAORDERS VALUES (@NGAYGIO, @TONGTIEN, @MABAN)";
                    SqlCommand cmd = new SqlCommand(sqlInsertOrder, dl.GetConnection());
                    cmd.Parameters.AddWithValue("@NGAYGIO", ngayGio);
                    cmd.Parameters.AddWithValue("@TONGTIEN", txt_thanhtien.Text);
                    cmd.Parameters.AddWithValue("@MABAN", cbb_maban.SelectedValue);

                    dl.OpenConnection();
                    int maOrder = (int)cmd.ExecuteScalar(); // Lấy mã đơn hàng vừa tạo

                    foreach (DataRow row in dtOrder.Rows)
                    {
                        string sqlInsertMonOrder = "INSERT INTO MONORDERS (MAMON, MAORDERS, SOLUONG, TONG) VALUES (@MAMON, @MAORDERS, @SOLUONG, @TONG)";
                        SqlCommand cmdMon = new SqlCommand(sqlInsertMonOrder, dl.GetConnection());
                        cmdMon.Parameters.AddWithValue("@MAMON", row["MAMON"]);
                        cmdMon.Parameters.AddWithValue("@MAORDERS", maOrder);
                        cmdMon.Parameters.AddWithValue("@SOLUONG", row["Số lượng"]);
                        cmdMon.Parameters.AddWithValue("@TONG", row["Thành tiền"]);
                        cmdMon.ExecuteNonQuery();
                    }
                    MessageBox.Show("Lưu đơn hàng thành công!");
                    dl.CloseConnection();
            }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }

        }

        private void txt_gia_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    


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
    public partial class frm_home : Form
    {
        
        LOPDUNGCHUNG dl = new LOPDUNGCHUNG();
        int buttonCount = 0;
        private const int BUTTONS_PER_ROW = 4;
        public frm_home()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void LoadTC()
        {
            string sql = "Select * from MON";
            dataGridView1.DataSource = dl.LoadDL(sql);
            dataGridView1.DefaultCellStyle.Font = new Font(dataGridView1.Font.FontFamily, 10f);
            dataGridView1.Columns["MOTA"].Width = 300;
            dataGridView1.Columns["TENMON"].Width = 150;
            dataGridView1.Columns["MAMON"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        private void frm_orders_Load(object sender, EventArgs e)
        {
            LoadTC();
            LoadBans();
            LoadSoBanHienCo();
        }     
        public void LoadBans()
        {
            string sql = "SELECT MABAN, TRANGTHAI FROM BAN";
            DataTable dt = dl.LoadDL(sql);

            foreach (DataRow row in dt.Rows)
            {
                int banID = (int)row["MABAN"];
                string trangThai = row["TRANGTHAI"].ToString();

                Button newButton = new Button();
                newButton.Text = "Bàn " + banID;
                newButton.Tag = banID; // Lưu ID bàn vào Tag của nút
                newButton.Location = new System.Drawing.Point(15 + ((panel1.Controls.Count % BUTTONS_PER_ROW) * 110),10+ ((panel1.Controls.Count / BUTTONS_PER_ROW) * 110)); newButton.Size = new System.Drawing.Size(100, 100);
                newButton.Click += NewButton_Click;

                if (trangThai == "Trống")
                {
                    newButton.BackColor = Color.Green;
                }
                else
                {
                    newButton.BackColor = Color.Red;
                }

                panel1.Controls.Add(newButton);
                buttonCount++;
                LoadTC();
            }
        }
            private void NewButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadSoBanHienCo()
        {
            string sql = "SELECT COUNT(*) FROM BAN";
            object result = dl.LoadScalar(sql);

            if (result != null)
            {
                int soBanHienCo = Convert.ToInt32(result);
                txt_tongsoban.Text = soBanHienCo.ToString();
            }
            else
            {
                txt_tongsoban.Text = "0";
            }

        }
        private void mónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Menu mn = new frm_Menu();
            mn.FormClosed += new FormClosedEventHandler(mn_FormClosing);
            mn.Show();
            this.Hide();
        }
        private void mn_FormClosing(object sender, FormClosedEventArgs e)
        {
            this.LoadTC();        
            this.Show();
            
        }
        private void bànĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frn_Ban b = new frn_Ban();
            b.FormClosed += new FormClosedEventHandler(b_FormClosing);
            b.Show();
            this.Hide();
        }
        private void b_FormClosing(object sender, FormClosedEventArgs e)
        {
            panel1.Controls.Clear();          
            this.Show();
            this.LoadBans();
            this.LoadSoBanHienCo();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Dangnhap dn = new frm_Dangnhap();
            dn.Show();
        }

        private void thanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Thanhtoan tt = new frm_Thanhtoan();
            tt.Show();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_orders or = new frm_orders();
            or.Show();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            frm_orders or = new frm_orders();
            or.Show();
            this.Hide();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

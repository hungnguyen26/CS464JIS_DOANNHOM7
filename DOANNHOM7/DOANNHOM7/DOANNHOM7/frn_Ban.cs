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
    public partial class frn_Ban : Form
    {
        public frn_Ban()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        LOPDUNGCHUNG dl = new LOPDUNGCHUNG();
       
        public void LoadB()
        {           
            string sql = "Select * from BAN";
            dataGridView1.DataSource = dl.LoadDL(sql);
            dataGridView1.Columns["MABAN"].Width = 50;
        }

        private void frn_Ban_Load(object sender, EventArgs e)
        {
            LoadB();
        }

       

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_soban.Text = dataGridView1.CurrentRow.Cells["MABAN"].Value.ToString();
           
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string trangthai = "Trống"
;            string sql = "Insert into BAN values (N'" + trangthai + "')";
            int kq = dl.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Thêm bàn thành công");
            else MessageBox.Show("Thêm bàn thất bại");

            LoadB();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete BAN where MABAN = '" + txt_soban.Text + "'";
            int kq = dl.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Xóa bàn thành công");
            else MessageBox.Show("Xóa bàn thất bại");
            LoadB();
        }
    }
}

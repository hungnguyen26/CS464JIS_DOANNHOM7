using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANNHOM7
{
    public partial class frm_Menu : Form
    {
        LOPDUNGCHUNG dl = new LOPDUNGCHUNG();
        public frm_Menu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            

        }
        public void LoadMenu()
        {
            string sql = "Select * from MON";
            dtg_menu.DataSource = dl.LoadDL(sql);
            dtg_menu.DefaultCellStyle.Font = new Font(dtg_menu.Font.FontFamily, 10f);
            dtg_menu.Columns["MAMON"].Width = 50;
            dtg_menu.Columns["TENMON"].Width = 150;
            dtg_menu.Columns["MOTA"].Width = 250;
        }

        private void blt_them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into MON values (N'" + txt_tenmon.Text + "','" + txt_gia.Text + "',N'" + txt_mota.Text + "')";
            int kq = dl.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Thêm món thành công");
            else MessageBox.Show("Thêm món thất bại");
            LoadMenu();
            frm_home or = new frm_home();
            or.LoadTC();
        }

        private void txt_tenmon_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            LoadMenu();
        }

        

        private void blt_sua_Click(object sender, EventArgs e)
        {
            string sql = "update MON set TENMON =N'" + txt_tenmon.Text + "',GIA = '" + txt_gia.Text + "',MOTA= N'" + txt_mota.Text + "' where MAMON = '"+txt_mamon.Text+"'";
            int kq = dl.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Sửa món thành công");
            else MessageBox.Show("Sửa món thất bại");
            LoadMenu();
        }

        private void blt_xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete MON where MAMON = '" + txt_mamon.Text + "'";
            int kq = dl.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Xóa món thành công");
            else MessageBox.Show("Xóa món thất bại");
            LoadMenu();
        }

        private void dtg_menu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mamon.Text = dtg_menu.CurrentRow.Cells["MAMON"].Value.ToString();
            txt_tenmon.Text = dtg_menu.CurrentRow.Cells["TENMON"].Value.ToString();
            txt_gia.Text = dtg_menu.CurrentRow.Cells["GIA"].Value.ToString();
            txt_mota.Text = dtg_menu.CurrentRow.Cells["MOTA"].Value.ToString();
        }

        private void blt_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void dtg_menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

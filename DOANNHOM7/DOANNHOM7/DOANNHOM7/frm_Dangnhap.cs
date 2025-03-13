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
    public partial class frm_Dangnhap : MaterialSkin.Controls.MaterialForm 
    {
        public frm_Dangnhap()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        LOPDUNGCHUNG dl = new LOPDUNGCHUNG();
        private void blt_dangnhap_Click(object sender, EventArgs e)
        {
            string taikhoan = txt_tendangnhap.Text;
            string matkhau = txt_matkhau.Text;
            string sql = "SELECT COUNT(*) FROM TAIKHOAN WHERE TENDANGNHAP= '" + taikhoan + "' AND MATKHAU = '" + matkhau + "'";

            int count = (int)dl.DocGL(sql);

            if (count > 0)
            {
                MessageBox.Show("Đăng nhập thành công ");
                this.Hide();
                frm_home h = new frm_home();
                h.Show();
                
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng ");
            }

        
            
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {

        }

        private void materialSingleLineTextField2_Click(object sender, EventArgs e)
        {

        }

        private void frm_Dangnhap_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Bạn có muốn thoát không ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

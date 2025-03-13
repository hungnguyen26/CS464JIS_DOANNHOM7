namespace DOANNHOM7
{
    partial class frm_home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLíToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mónĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bànĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_tongsoban = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.btn_orders = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem,
            this.quảnLíToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhToánToolStripMenuItem,
            this.thanhToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.thanhToánToolStripMenuItem.Text = "Orders";
            this.thanhToánToolStripMenuItem.Click += new System.EventHandler(this.thanhToánToolStripMenuItem_Click);
            // 
            // thanhToolStripMenuItem
            // 
            this.thanhToolStripMenuItem.Name = "thanhToolStripMenuItem";
            this.thanhToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.thanhToolStripMenuItem.Text = "Thanh toán";
            this.thanhToolStripMenuItem.Click += new System.EventHandler(this.thanhToolStripMenuItem_Click);
            // 
            // quảnLíToolStripMenuItem
            // 
            this.quảnLíToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mónĂnToolStripMenuItem,
            this.bànĂnToolStripMenuItem});
            this.quảnLíToolStripMenuItem.Name = "quảnLíToolStripMenuItem";
            this.quảnLíToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.quảnLíToolStripMenuItem.Text = "Quản lí";
            // 
            // mónĂnToolStripMenuItem
            // 
            this.mónĂnToolStripMenuItem.Name = "mónĂnToolStripMenuItem";
            this.mónĂnToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.mónĂnToolStripMenuItem.Text = "Món ăn";
            this.mónĂnToolStripMenuItem.Click += new System.EventHandler(this.mónĂnToolStripMenuItem_Click);
            // 
            // bànĂnToolStripMenuItem
            // 
            this.bànĂnToolStripMenuItem.Name = "bànĂnToolStripMenuItem";
            this.bànĂnToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.bànĂnToolStripMenuItem.Text = "Bàn ăn";
            this.bànĂnToolStripMenuItem.Click += new System.EventHandler(this.bànĂnToolStripMenuItem_Click);
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất ";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(896, 295);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_tongsoban
            // 
            this.txt_tongsoban.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongsoban.Location = new System.Drawing.Point(819, 362);
            this.txt_tongsoban.Name = "txt_tongsoban";
            this.txt_tongsoban.Size = new System.Drawing.Size(79, 34);
            this.txt_tongsoban.TabIndex = 17;
            this.txt_tongsoban.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(632, 367);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tổng số bàn ";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 322);
            this.panel1.TabIndex = 24;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(675, 586);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(192, 54);
            this.btn_thoat.TabIndex = 26;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thanhtoan.Location = new System.Drawing.Point(675, 508);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(192, 54);
            this.btn_thanhtoan.TabIndex = 27;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            // 
            // btn_orders
            // 
            this.btn_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_orders.Location = new System.Drawing.Point(675, 428);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(192, 54);
            this.btn_orders.TabIndex = 28;
            this.btn_orders.Text = "Orders";
            this.btn_orders.UseVisualStyleBackColor = true;
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 675);
            this.Controls.Add(this.btn_orders);
            this.Controls.Add(this.btn_thanhtoan);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tongsoban);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_home";
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.frm_orders_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLíToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_tongsoban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mónĂnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bànĂnToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem thanhToolStripMenuItem;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.Button btn_orders;
    }
}
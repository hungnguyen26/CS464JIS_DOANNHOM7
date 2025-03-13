namespace DOANNHOM7
{
    partial class frm_Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mamon = new System.Windows.Forms.TextBox();
            this.txt_tenmon = new System.Windows.Forms.TextBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.dtg_menu = new System.Windows.Forms.DataGridView();
            this.blt_them = new System.Windows.Forms.Button();
            this.blt_sua = new System.Windows.Forms.Button();
            this.blt_xoa = new System.Windows.Forms.Button();
            this.blt_Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã món";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên món";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(416, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mô tả";
            // 
            // txt_mamon
            // 
            this.txt_mamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mamon.Location = new System.Drawing.Point(145, 41);
            this.txt_mamon.Name = "txt_mamon";
            this.txt_mamon.Size = new System.Drawing.Size(225, 34);
            this.txt_mamon.TabIndex = 5;
            // 
            // txt_tenmon
            // 
            this.txt_tenmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenmon.Location = new System.Drawing.Point(145, 101);
            this.txt_tenmon.Name = "txt_tenmon";
            this.txt_tenmon.Size = new System.Drawing.Size(225, 34);
            this.txt_tenmon.TabIndex = 6;
            this.txt_tenmon.TextChanged += new System.EventHandler(this.txt_tenmon_TextChanged);
            // 
            // txt_gia
            // 
            this.txt_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gia.Location = new System.Drawing.Point(145, 171);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.Size = new System.Drawing.Size(225, 34);
            this.txt_gia.TabIndex = 7;
            // 
            // txt_mota
            // 
            this.txt_mota.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mota.Location = new System.Drawing.Point(508, 46);
            this.txt_mota.Multiline = true;
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(258, 159);
            this.txt_mota.TabIndex = 8;
            // 
            // dtg_menu
            // 
            this.dtg_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_menu.Location = new System.Drawing.Point(12, 291);
            this.dtg_menu.Name = "dtg_menu";
            this.dtg_menu.RowTemplate.Height = 24;
            this.dtg_menu.Size = new System.Drawing.Size(776, 168);
            this.dtg_menu.TabIndex = 9;
            this.dtg_menu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_menu_CellClick);
            this.dtg_menu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_menu_CellContentClick);
            // 
            // blt_them
            // 
            this.blt_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blt_them.Location = new System.Drawing.Point(84, 236);
            this.blt_them.Name = "blt_them";
            this.blt_them.Size = new System.Drawing.Size(114, 36);
            this.blt_them.TabIndex = 10;
            this.blt_them.Text = "Thêm";
            this.blt_them.UseVisualStyleBackColor = true;
            this.blt_them.Click += new System.EventHandler(this.blt_them_Click);
            // 
            // blt_sua
            // 
            this.blt_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blt_sua.Location = new System.Drawing.Point(336, 236);
            this.blt_sua.Name = "blt_sua";
            this.blt_sua.Size = new System.Drawing.Size(114, 36);
            this.blt_sua.TabIndex = 11;
            this.blt_sua.Text = "Sửa";
            this.blt_sua.UseVisualStyleBackColor = true;
            this.blt_sua.Click += new System.EventHandler(this.blt_sua_Click);
            // 
            // blt_xoa
            // 
            this.blt_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blt_xoa.Location = new System.Drawing.Point(584, 236);
            this.blt_xoa.Name = "blt_xoa";
            this.blt_xoa.Size = new System.Drawing.Size(114, 36);
            this.blt_xoa.TabIndex = 12;
            this.blt_xoa.Text = "Xóa";
            this.blt_xoa.UseVisualStyleBackColor = true;
            this.blt_xoa.Click += new System.EventHandler(this.blt_xoa_Click);
            // 
            // blt_Thoat
            // 
            this.blt_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blt_Thoat.Location = new System.Drawing.Point(695, 481);
            this.blt_Thoat.Name = "blt_Thoat";
            this.blt_Thoat.Size = new System.Drawing.Size(93, 27);
            this.blt_Thoat.TabIndex = 13;
            this.blt_Thoat.Text = "THOÁT";
            this.blt_Thoat.UseVisualStyleBackColor = true;
            this.blt_Thoat.Click += new System.EventHandler(this.blt_Thoat_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.blt_Thoat);
            this.Controls.Add(this.blt_xoa);
            this.Controls.Add(this.blt_sua);
            this.Controls.Add(this.blt_them);
            this.Controls.Add(this.dtg_menu);
            this.Controls.Add(this.txt_mota);
            this.Controls.Add(this.txt_gia);
            this.Controls.Add(this.txt_tenmon);
            this.Controls.Add(this.txt_mamon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mamon;
        private System.Windows.Forms.TextBox txt_tenmon;
        private System.Windows.Forms.TextBox txt_gia;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.DataGridView dtg_menu;
        private System.Windows.Forms.Button blt_them;
        private System.Windows.Forms.Button blt_sua;
        private System.Windows.Forms.Button blt_xoa;
        private System.Windows.Forms.Button blt_Thoat;
    }
}
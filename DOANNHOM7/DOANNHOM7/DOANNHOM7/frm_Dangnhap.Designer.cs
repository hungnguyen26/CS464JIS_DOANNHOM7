namespace DOANNHOM7
{
    partial class frm_Dangnhap
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
            this.txt_tendangnhap = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txt_matkhau = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.blt_dangnhap = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // txt_tendangnhap
            // 
            this.txt_tendangnhap.Depth = 0;
            this.txt_tendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tendangnhap.Hint = "Gmail hoặc số điện thoại";
            this.txt_tendangnhap.Location = new System.Drawing.Point(34, 114);
            this.txt_tendangnhap.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_tendangnhap.Name = "txt_tendangnhap";
            this.txt_tendangnhap.PasswordChar = '\0';
            this.txt_tendangnhap.SelectedText = "";
            this.txt_tendangnhap.SelectionLength = 0;
            this.txt_tendangnhap.SelectionStart = 0;
            this.txt_tendangnhap.Size = new System.Drawing.Size(357, 28);
            this.txt_tendangnhap.TabIndex = 0;
            this.txt_tendangnhap.UseSystemPasswordChar = false;
            this.txt_tendangnhap.Click += new System.EventHandler(this.materialSingleLineTextField1_Click);
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Depth = 0;
            this.txt_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.Hint = "Mật khẩu";
            this.txt_matkhau.Location = new System.Drawing.Point(34, 168);
            this.txt_matkhau.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.SelectedText = "";
            this.txt_matkhau.SelectionLength = 0;
            this.txt_matkhau.SelectionStart = 0;
            this.txt_matkhau.Size = new System.Drawing.Size(357, 28);
            this.txt_matkhau.TabIndex = 1;
            this.txt_matkhau.UseSystemPasswordChar = false;
            this.txt_matkhau.Click += new System.EventHandler(this.materialSingleLineTextField2_Click);
            // 
            // blt_dangnhap
            // 
            this.blt_dangnhap.Depth = 0;
            this.blt_dangnhap.Location = new System.Drawing.Point(263, 224);
            this.blt_dangnhap.MouseState = MaterialSkin.MouseState.HOVER;
            this.blt_dangnhap.Name = "blt_dangnhap";
            this.blt_dangnhap.Primary = true;
            this.blt_dangnhap.Size = new System.Drawing.Size(128, 43);
            this.blt_dangnhap.TabIndex = 3;
            this.blt_dangnhap.Text = "Đăng nhập";
            this.blt_dangnhap.UseVisualStyleBackColor = true;
            this.blt_dangnhap.Click += new System.EventHandler(this.blt_dangnhap_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(34, 286);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(357, 2);
            this.materialDivider1.TabIndex = 4;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(30, 327);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(185, 24);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Bạn quên mật khẩu ?";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(313, 327);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(58, 24);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Thoát";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // frm_Dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(440, 385);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.blt_dangnhap);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_tendangnhap);
            this.Name = "frm_Dangnhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frm_Dangnhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txt_tendangnhap;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_matkhau;
        private MaterialSkin.Controls.MaterialRaisedButton blt_dangnhap;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}
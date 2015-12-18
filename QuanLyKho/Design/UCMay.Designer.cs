namespace QuanLyKho.Design
{
    partial class UCMay
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbLoi = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btTao = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaSo = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvNhomHang = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTenMay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbLoi
            // 
            this.lbLoi.AutoSize = true;
            this.lbLoi.BackColor = System.Drawing.SystemColors.Control;
            this.lbLoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLoi.ForeColor = System.Drawing.Color.Red;
            this.lbLoi.Location = new System.Drawing.Point(409, 51);
            this.lbLoi.Name = "lbLoi";
            this.lbLoi.Size = new System.Drawing.Size(0, 17);
            this.lbLoi.TabIndex = 17;
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.Location = new System.Drawing.Point(433, 243);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(106, 36);
            this.btXoa.TabIndex = 16;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Visible = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Location = new System.Drawing.Point(545, 243);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(106, 36);
            this.btThoat.TabIndex = 15;
            this.btThoat.Text = "Thoát sửa";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Visible = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btTao
            // 
            this.btTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTao.Location = new System.Drawing.Point(657, 243);
            this.btTao.Name = "btTao";
            this.btTao.Size = new System.Drawing.Size(106, 36);
            this.btTao.TabIndex = 14;
            this.btTao.Text = "Tạo ";
            this.btTao.UseVisualStyleBackColor = true;
            this.btTao.Click += new System.EventHandler(this.btTao_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(446, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã số : ";
            // 
            // tbMaSo
            // 
            this.tbMaSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbMaSo.Location = new System.Drawing.Point(516, 140);
            this.tbMaSo.Name = "tbMaSo";
            this.tbMaSo.Size = new System.Drawing.Size(226, 26);
            this.tbMaSo.TabIndex = 12;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSearch.Location = new System.Drawing.Point(104, 10);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(270, 26);
            this.tbSearch.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tìm kiếm : ";
            // 
            // lvNhomHang
            // 
            this.lvNhomHang.Location = new System.Drawing.Point(12, 51);
            this.lvNhomHang.Name = "lvNhomHang";
            this.lvNhomHang.Size = new System.Drawing.Size(362, 351);
            this.lvNhomHang.TabIndex = 9;
            this.lvNhomHang.UseCompatibleStateImageBehavior = false;
            this.lvNhomHang.SelectedIndexChanged += new System.EventHandler(this.lvNhomHang_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(429, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên máy : ";
            // 
            // tbTenMay
            // 
            this.tbTenMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTenMay.Location = new System.Drawing.Point(516, 187);
            this.tbTenMay.Name = "tbTenMay";
            this.tbTenMay.Size = new System.Drawing.Size(226, 26);
            this.tbTenMay.TabIndex = 18;
            // 
            // UCMay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTenMay);
            this.Controls.Add(this.lbLoi);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btTao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMaSo);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvNhomHang);
            this.Name = "UCMay";
            this.Size = new System.Drawing.Size(894, 424);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLoi;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btTao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaSo;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvNhomHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTenMay;
    }
}

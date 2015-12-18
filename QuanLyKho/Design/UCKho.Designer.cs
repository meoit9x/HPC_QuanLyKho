namespace QuanLyKho.Design
{
    partial class UCKho
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
            this.lvNhomHang = new System.Windows.Forms.ListView();
            this.tbNVT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btTao = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.lbLoi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvNhomHang
            // 
            this.lvNhomHang.Location = new System.Drawing.Point(12, 23);
            this.lvNhomHang.Name = "lvNhomHang";
            this.lvNhomHang.Size = new System.Drawing.Size(362, 381);
            this.lvNhomHang.TabIndex = 0;
            this.lvNhomHang.UseCompatibleStateImageBehavior = false;
            this.lvNhomHang.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvNhomHang_ItemSelectionChanged);
            // 
            // tbNVT
            // 
            this.tbNVT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbNVT.Location = new System.Drawing.Point(516, 142);
            this.tbNVT.Name = "tbNVT";
            this.tbNVT.Size = new System.Drawing.Size(226, 26);
            this.tbNVT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(432, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên kho : ";
            // 
            // btTao
            // 
            this.btTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTao.Location = new System.Drawing.Point(636, 199);
            this.btTao.Name = "btTao";
            this.btTao.Size = new System.Drawing.Size(106, 36);
            this.btTao.TabIndex = 5;
            this.btTao.Text = "Tạo ";
            this.btTao.UseVisualStyleBackColor = true;
            this.btTao.Click += new System.EventHandler(this.btTao_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThoat.Location = new System.Drawing.Point(524, 199);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(106, 36);
            this.btThoat.TabIndex = 6;
            this.btThoat.Text = "Thoát sửa";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Visible = false;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.Location = new System.Drawing.Point(412, 199);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(106, 36);
            this.btXoa.TabIndex = 7;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Visible = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // lbLoi
            // 
            this.lbLoi.AutoSize = true;
            this.lbLoi.BackColor = System.Drawing.SystemColors.Control;
            this.lbLoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLoi.ForeColor = System.Drawing.Color.Red;
            this.lbLoi.Location = new System.Drawing.Point(409, 53);
            this.lbLoi.Name = "lbLoi";
            this.lbLoi.Size = new System.Drawing.Size(0, 17);
            this.lbLoi.TabIndex = 8;
            // 
            // UCKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbLoi);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btTao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNVT);
            this.Controls.Add(this.lvNhomHang);
            this.Name = "UCKho";
            this.Size = new System.Drawing.Size(894, 424);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvNhomHang;
        private System.Windows.Forms.TextBox tbNVT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTao;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Label lbLoi;
    }
}

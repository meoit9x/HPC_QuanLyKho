namespace QuanLyKho.Design
{
    partial class UNXetDuyetNhuCau
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
            this.lvNhuCau = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVatTu = new System.Windows.Forms.TextBox();
            this.btXacNhan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDienGiai = new System.Windows.Forms.TextBox();
            this.btHuy = new System.Windows.Forms.Button();
            this.cbDateTime = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPhanHoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLoi
            // 
            this.lbLoi.AutoSize = true;
            this.lbLoi.BackColor = System.Drawing.SystemColors.Control;
            this.lbLoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLoi.ForeColor = System.Drawing.Color.Red;
            this.lbLoi.Location = new System.Drawing.Point(412, 14);
            this.lbLoi.Name = "lbLoi";
            this.lbLoi.Size = new System.Drawing.Size(0, 17);
            this.lbLoi.TabIndex = 17;
            // 
            // lvNhuCau
            // 
            this.lvNhuCau.Location = new System.Drawing.Point(13, 43);
            this.lvNhuCau.Name = "lvNhuCau";
            this.lvNhuCau.Size = new System.Drawing.Size(362, 363);
            this.lvNhuCau.TabIndex = 9;
            this.lvNhuCau.UseCompatibleStateImageBehavior = false;
            this.lvNhuCau.SelectedIndexChanged += new System.EventHandler(this.lvNhuCau_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(445, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "Số lượng : ";
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSoLuong.Location = new System.Drawing.Point(543, 98);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(226, 26);
            this.tbSoLuong.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(465, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Vật tư : ";
            // 
            // tbVatTu
            // 
            this.tbVatTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbVatTu.Location = new System.Drawing.Point(543, 54);
            this.tbVatTu.Name = "tbVatTu";
            this.tbVatTu.Size = new System.Drawing.Size(226, 26);
            this.tbVatTu.TabIndex = 40;
            // 
            // btXacNhan
            // 
            this.btXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXacNhan.Location = new System.Drawing.Point(528, 370);
            this.btXacNhan.Name = "btXacNhan";
            this.btXacNhan.Size = new System.Drawing.Size(106, 36);
            this.btXacNhan.TabIndex = 44;
            this.btXacNhan.Text = "Xác nhận";
            this.btXacNhan.UseVisualStyleBackColor = true;
            this.btXacNhan.Click += new System.EventHandler(this.btTao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(447, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 48;
            this.label1.Text = "Diễn giải : ";
            // 
            // tbDienGiai
            // 
            this.tbDienGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbDienGiai.Location = new System.Drawing.Point(543, 145);
            this.tbDienGiai.Multiline = true;
            this.tbDienGiai.Name = "tbDienGiai";
            this.tbDienGiai.Size = new System.Drawing.Size(226, 88);
            this.tbDienGiai.TabIndex = 49;
            // 
            // btHuy
            // 
            this.btHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHuy.Location = new System.Drawing.Point(663, 370);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(106, 36);
            this.btHuy.TabIndex = 50;
            this.btHuy.Text = "Hủy bỏ";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btSua_Click);
            // 
            // cbDateTime
            // 
            this.cbDateTime.FormattingEnabled = true;
            this.cbDateTime.Location = new System.Drawing.Point(254, 11);
            this.cbDateTime.Name = "cbDateTime";
            this.cbDateTime.Size = new System.Drawing.Size(121, 21);
            this.cbDateTime.TabIndex = 51;
            this.cbDateTime.SelectedIndexChanged += new System.EventHandler(this.cbDateTime_SelectedIndexChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbSearch.Location = new System.Drawing.Point(107, 11);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(133, 26);
            this.tbSearch.TabIndex = 53;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(10, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Tên vật tư : ";
            // 
            // tbPhanHoi
            // 
            this.tbPhanHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbPhanHoi.Location = new System.Drawing.Point(543, 255);
            this.tbPhanHoi.Multiline = true;
            this.tbPhanHoi.Name = "tbPhanHoi";
            this.tbPhanHoi.Size = new System.Drawing.Size(226, 88);
            this.tbPhanHoi.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(445, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Phản hồi : ";
            // 
            // UNXetDuyetNhuCau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbPhanHoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDateTime);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.tbDienGiai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXacNhan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVatTu);
            this.Controls.Add(this.lbLoi);
            this.Controls.Add(this.lvNhuCau);
            this.Name = "UNXetDuyetNhuCau";
            this.Size = new System.Drawing.Size(894, 424);
            this.Load += new System.EventHandler(this.UNNhapNhuCau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLoi;
        private System.Windows.Forms.ListView lvNhuCau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVatTu;
        private System.Windows.Forms.Button btXacNhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDienGiai;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.ComboBox cbDateTime;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPhanHoi;
        private System.Windows.Forms.Label label5;
    }
}

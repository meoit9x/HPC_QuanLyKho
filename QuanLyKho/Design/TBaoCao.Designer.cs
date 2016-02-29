namespace QuanLyKho.Design
{
    partial class TBaoCao
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
            this.cbMaySuDung = new System.Windows.Forms.ComboBox();
            this.lbMay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVatTu = new System.Windows.Forms.TextBox();
            this.btIn = new System.Windows.Forms.Button();
            this.btXem = new System.Windows.Forms.Button();
            this.cbBaoCao = new System.Windows.Forms.ComboBox();
            this.tbDenNgay = new System.Windows.Forms.MaskedTextBox();
            this.tbTuNgay = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMaySuDung
            // 
            this.cbMaySuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaySuDung.FormattingEnabled = true;
            this.cbMaySuDung.Location = new System.Drawing.Point(523, 183);
            this.cbMaySuDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMaySuDung.Name = "cbMaySuDung";
            this.cbMaySuDung.Size = new System.Drawing.Size(300, 33);
            this.cbMaySuDung.TabIndex = 129;
            // 
            // lbMay
            // 
            this.lbMay.AutoSize = true;
            this.lbMay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbMay.Location = new System.Drawing.Point(367, 186);
            this.lbMay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMay.Name = "lbMay";
            this.lbMay.Size = new System.Drawing.Size(141, 25);
            this.lbMay.TabIndex = 128;
            this.lbMay.Text = "Máy sử dụng : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(392, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 127;
            this.label2.Text = "Tên vật tư : ";
            // 
            // tbVatTu
            // 
            this.tbVatTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbVatTu.Location = new System.Drawing.Point(523, 238);
            this.tbVatTu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbVatTu.Name = "tbVatTu";
            this.tbVatTu.Size = new System.Drawing.Size(300, 30);
            this.tbVatTu.TabIndex = 126;
            // 
            // btIn
            // 
            this.btIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btIn.Location = new System.Drawing.Point(685, 347);
            this.btIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(141, 44);
            this.btIn.TabIndex = 125;
            this.btIn.Text = "In";
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // btXem
            // 
            this.btXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXem.Location = new System.Drawing.Point(523, 347);
            this.btXem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(141, 44);
            this.btXem.TabIndex = 124;
            this.btXem.Text = "Xem ";
            this.btXem.UseVisualStyleBackColor = true;
            // 
            // cbBaoCao
            // 
            this.cbBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbBaoCao.FormattingEnabled = true;
            this.cbBaoCao.Items.AddRange(new object[] {
            "báo cáo tồn vật tư",
            "báo cáo xuất vật tư",
            "báo cáo nhập vật tư",
            "báo cáo xuất nhập tồn vật tư",
            "báo cáo sử dụng vật tư",
            "nhật ký sửa chữa tài sản"});
            this.cbBaoCao.Location = new System.Drawing.Point(520, 131);
            this.cbBaoCao.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbBaoCao.Name = "cbBaoCao";
            this.cbBaoCao.Size = new System.Drawing.Size(303, 33);
            this.cbBaoCao.TabIndex = 123;
            this.cbBaoCao.Click += new System.EventHandler(this.cbBaoCao_SelectedIndexChanged);
            // 
            // tbDenNgay
            // 
            this.tbDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbDenNgay.Location = new System.Drawing.Point(711, 287);
            this.tbDenNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDenNgay.Mask = "00/00/0000";
            this.tbDenNgay.Name = "tbDenNgay";
            this.tbDenNgay.Size = new System.Drawing.Size(115, 30);
            this.tbDenNgay.TabIndex = 122;
            this.tbDenNgay.ValidatingType = typeof(System.DateTime);
            // 
            // tbTuNgay
            // 
            this.tbTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTuNgay.Location = new System.Drawing.Point(524, 287);
            this.tbTuNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTuNgay.Mask = "00/00/0000";
            this.tbTuNgay.Name = "tbTuNgay";
            this.tbTuNgay.Size = new System.Drawing.Size(115, 30);
            this.tbTuNgay.TabIndex = 121;
            this.tbTuNgay.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(655, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 25);
            this.label5.TabIndex = 120;
            this.label5.Text = "đến";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(405, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 119;
            this.label4.Text = "Từ ngày : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(367, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 118;
            this.label1.Text = "Tên báo cáo : ";
            // 
            // TBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbMaySuDung);
            this.Controls.Add(this.lbMay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbVatTu);
            this.Controls.Add(this.btIn);
            this.Controls.Add(this.btXem);
            this.Controls.Add(this.cbBaoCao);
            this.Controls.Add(this.tbDenNgay);
            this.Controls.Add(this.tbTuNgay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TBaoCao";
            this.Size = new System.Drawing.Size(1192, 522);
            this.Load += new System.EventHandler(this.TBaoCao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMaySuDung;
        private System.Windows.Forms.Label lbMay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVatTu;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Button btXem;
        private System.Windows.Forms.ComboBox cbBaoCao;
        private System.Windows.Forms.MaskedTextBox tbDenNgay;
        private System.Windows.Forms.MaskedTextBox tbTuNgay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;



    }
}

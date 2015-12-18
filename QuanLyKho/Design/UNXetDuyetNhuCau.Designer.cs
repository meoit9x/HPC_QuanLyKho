﻿namespace QuanLyKho.Design
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
            this.btHoanTat = new System.Windows.Forms.Button();
            this.tbDenNgay = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTuNgay = new System.Windows.Forms.MaskedTextBox();
            this.tbNgayHoaDon = new System.Windows.Forms.Label();
            this.lvPhieuNhap = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btHoanTat
            // 
            this.btHoanTat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btHoanTat.Location = new System.Drawing.Point(773, 12);
            this.btHoanTat.Name = "btHoanTat";
            this.btHoanTat.Size = new System.Drawing.Size(106, 33);
            this.btHoanTat.TabIndex = 101;
            this.btHoanTat.Text = "Tạo mới";
            this.btHoanTat.UseVisualStyleBackColor = true;
            // 
            // tbDenNgay
            // 
            this.tbDenNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbDenNgay.Location = new System.Drawing.Point(286, 15);
            this.tbDenNgay.Mask = "00/00/0000";
            this.tbDenNgay.Name = "tbDenNgay";
            this.tbDenNgay.Size = new System.Drawing.Size(87, 26);
            this.tbDenNgay.TabIndex = 100;
            this.tbDenNgay.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(191, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 99;
            this.label1.Text = "Đến ngày : ";
            // 
            // tbTuNgay
            // 
            this.tbTuNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTuNgay.Location = new System.Drawing.Point(98, 15);
            this.tbTuNgay.Mask = "00/00/0000";
            this.tbTuNgay.Name = "tbTuNgay";
            this.tbTuNgay.Size = new System.Drawing.Size(87, 26);
            this.tbTuNgay.TabIndex = 98;
            this.tbTuNgay.ValidatingType = typeof(System.DateTime);
            // 
            // tbNgayHoaDon
            // 
            this.tbNgayHoaDon.AutoSize = true;
            this.tbNgayHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbNgayHoaDon.Location = new System.Drawing.Point(15, 18);
            this.tbNgayHoaDon.Name = "tbNgayHoaDon";
            this.tbNgayHoaDon.Size = new System.Drawing.Size(77, 20);
            this.tbNgayHoaDon.TabIndex = 97;
            this.tbNgayHoaDon.Text = "Từ ngày : ";
            // 
            // lvPhieuNhap
            // 
            this.lvPhieuNhap.Location = new System.Drawing.Point(15, 51);
            this.lvPhieuNhap.Name = "lvPhieuNhap";
            this.lvPhieuNhap.Size = new System.Drawing.Size(864, 362);
            this.lvPhieuNhap.TabIndex = 96;
            this.lvPhieuNhap.UseCompatibleStateImageBehavior = false;
            // 
            // UNXetDuyetNhuCau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btHoanTat);
            this.Controls.Add(this.tbDenNgay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTuNgay);
            this.Controls.Add(this.tbNgayHoaDon);
            this.Controls.Add(this.lvPhieuNhap);
            this.Name = "UNXetDuyetNhuCau";
            this.Size = new System.Drawing.Size(894, 424);
            this.Load += new System.EventHandler(this.UNXetDuyetNhuCau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btHoanTat;
        private System.Windows.Forms.MaskedTextBox tbDenNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox tbTuNgay;
        private System.Windows.Forms.Label tbNgayHoaDon;
        private System.Windows.Forms.ListView lvPhieuNhap;
    }
}

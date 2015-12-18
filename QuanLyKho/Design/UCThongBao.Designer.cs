namespace QuanLyKho.Design
{
    partial class UCThongBao
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
            this.lvThongBao = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvThongBao
            // 
            this.lvThongBao.Location = new System.Drawing.Point(8, 8);
            this.lvThongBao.Name = "lvThongBao";
            this.lvThongBao.Size = new System.Drawing.Size(894, 424);
            this.lvThongBao.TabIndex = 1;
            this.lvThongBao.UseCompatibleStateImageBehavior = false;
            this.lvThongBao.SelectedIndexChanged += new System.EventHandler(this.lvThongBao_SelectedIndexChanged);
            // 
            // UCThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvThongBao);
            this.Name = "UCThongBao";
            this.Size = new System.Drawing.Size(894, 424);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvThongBao;
    }
}

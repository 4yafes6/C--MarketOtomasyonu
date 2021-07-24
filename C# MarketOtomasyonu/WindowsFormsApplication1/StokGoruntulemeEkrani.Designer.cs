namespace WindowsFormsApplication1
{
    partial class StokGoruntulemeEkrani
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
            this.dgStokListele = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgStokListele)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgStokListele
            // 
            this.dgStokListele.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgStokListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStokListele.Location = new System.Drawing.Point(115, 161);
            this.dgStokListele.Name = "dgStokListele";
            this.dgStokListele.Size = new System.Drawing.Size(446, 199);
            this.dgStokListele.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.YusufMarket;
            this.pictureBox2.Location = new System.Drawing.Point(181, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(301, 124);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // StokGoruntulemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(664, 387);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgStokListele);
            this.Name = "StokGoruntulemeEkrani";
            this.Text = "StokGoruntulemeEkrani";
            this.Load += new System.EventHandler(this.StokGoruntulemeEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgStokListele)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgStokListele;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
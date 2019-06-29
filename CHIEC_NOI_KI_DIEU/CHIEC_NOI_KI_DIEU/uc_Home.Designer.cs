namespace CHIEC_NOI_KI_DIEU
{
    partial class uc_Home
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
            this.pc_Hinh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pc_Hinh)).BeginInit();
            this.SuspendLayout();
            // 
            // pc_Hinh
            // 
            this.pc_Hinh.Location = new System.Drawing.Point(0, 0);
            this.pc_Hinh.Name = "pc_Hinh";
            this.pc_Hinh.Size = new System.Drawing.Size(892, 425);
            this.pc_Hinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pc_Hinh.TabIndex = 0;
            this.pc_Hinh.TabStop = false;
            // 
            // uc_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.pc_Hinh);
            this.Name = "uc_Home";
            this.Size = new System.Drawing.Size(892, 425);
            ((System.ComponentModel.ISupportInitialize)(this.pc_Hinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pc_Hinh;
    }
}

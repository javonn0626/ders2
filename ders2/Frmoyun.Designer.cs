namespace ders2
{
    partial class Frmoyun
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
            this.components = new System.ComponentModel.Container();
            this.tmrbutton = new System.Windows.Forms.Timer(this.components);
            this.pnlgosterge = new System.Windows.Forms.Panel();
            this.bşloyun = new System.Windows.Forms.Button();
            this.lblsure = new System.Windows.Forms.Label();
            this.lblskor = new System.Windows.Forms.Label();
            this.tmrsure = new System.Windows.Forms.Timer(this.components);
            this.pnlgosterge.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrbutton
            // 
            this.tmrbutton.Interval = 1000;
            this.tmrbutton.Tick += new System.EventHandler(this.tmrbutton_Tick);
            // 
            // pnlgosterge
            // 
            this.pnlgosterge.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlgosterge.Controls.Add(this.bşloyun);
            this.pnlgosterge.Controls.Add(this.lblsure);
            this.pnlgosterge.Controls.Add(this.lblskor);
            this.pnlgosterge.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlgosterge.Location = new System.Drawing.Point(663, 0);
            this.pnlgosterge.Name = "pnlgosterge";
            this.pnlgosterge.Size = new System.Drawing.Size(124, 446);
            this.pnlgosterge.TabIndex = 0;
            // 
            // bşloyun
            // 
            this.bşloyun.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.bşloyun.Location = new System.Drawing.Point(0, 148);
            this.bşloyun.Name = "bşloyun";
            this.bşloyun.Size = new System.Drawing.Size(126, 62);
            this.bşloyun.TabIndex = 2;
            this.bşloyun.Text = "Başlat";
            this.bşloyun.UseVisualStyleBackColor = false;
            this.bşloyun.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.Location = new System.Drawing.Point(42, 18);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(29, 13);
            this.lblsure.TabIndex = 1;
            this.lblsure.Text = "Süre";
            this.lblsure.Click += new System.EventHandler(this.lblsure_Click);
            // 
            // lblskor
            // 
            this.lblskor.AutoSize = true;
            this.lblskor.Location = new System.Drawing.Point(42, 86);
            this.lblskor.Name = "lblskor";
            this.lblskor.Size = new System.Drawing.Size(13, 13);
            this.lblskor.TabIndex = 0;
            this.lblskor.Text = "0";
            // 
            // tmrsure
            // 
            this.tmrsure.Interval = 1000;
            this.tmrsure.Tick += new System.EventHandler(this.tmrsure_Tick);
            // 
            // Frmoyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 446);
            this.Controls.Add(this.pnlgosterge);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "Frmoyun";
            this.Text = "Frmoyun";
            this.Load += new System.EventHandler(this.Frmoyun_Load);
            this.pnlgosterge.ResumeLayout(false);
            this.pnlgosterge.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmrbutton;
        private System.Windows.Forms.Panel pnlgosterge;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.Label lblskor;
        private System.Windows.Forms.Timer tmrsure;
        private System.Windows.Forms.Button bşloyun;
    }
}
namespace Tugas3._4
{
    partial class Form1
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
            this.btnKeluar = new System.Windows.Forms.Button();
            this.lblAnimasi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(766, 423);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(140, 63);
            this.btnKeluar.TabIndex = 1;
            this.btnKeluar.Text = "EXIT";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // lblAnimasi
            // 
            this.lblAnimasi.AutoSize = true;
            this.lblAnimasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAnimasi.Location = new System.Drawing.Point(362, 196);
            this.lblAnimasi.Name = "lblAnimasi";
            this.lblAnimasi.Size = new System.Drawing.Size(306, 46);
            this.lblAnimasi.TabIndex = 2;
            this.lblAnimasi.Text = "Tulisan Berjalan";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 587);
            this.Controls.Add(this.lblAnimasi);
            this.Controls.Add(this.btnKeluar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Label lblAnimasi;
        private System.Windows.Forms.Timer timer1;
    }
}


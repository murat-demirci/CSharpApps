namespace ApartmanOtomasyon
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
            this.btn_gelirler = new System.Windows.Forms.Button();
            this.btn_giderler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_gelirler
            // 
            this.btn_gelirler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gelirler.Location = new System.Drawing.Point(153, 65);
            this.btn_gelirler.Name = "btn_gelirler";
            this.btn_gelirler.Size = new System.Drawing.Size(132, 281);
            this.btn_gelirler.TabIndex = 0;
            this.btn_gelirler.Text = "Gelirler";
            this.btn_gelirler.UseVisualStyleBackColor = true;
            this.btn_gelirler.Click += new System.EventHandler(this.btn_gelirler_Click);
            // 
            // btn_giderler
            // 
            this.btn_giderler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giderler.Location = new System.Drawing.Point(548, 65);
            this.btn_giderler.Name = "btn_giderler";
            this.btn_giderler.Size = new System.Drawing.Size(132, 281);
            this.btn_giderler.TabIndex = 1;
            this.btn_giderler.Text = "Giderler";
            this.btn_giderler.UseVisualStyleBackColor = true;
            this.btn_giderler.Click += new System.EventHandler(this.btn_giderler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_giderler);
            this.Controls.Add(this.btn_gelirler);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_gelirler;
        private System.Windows.Forms.Button btn_giderler;
    }
}


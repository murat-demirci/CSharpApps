namespace GelismisArama
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
            this.btn_baglan = new System.Windows.Forms.Button();
            this.btn_tablogetir = new System.Windows.Forms.Button();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_baglan
            // 
            this.btn_baglan.BackColor = System.Drawing.Color.Transparent;
            this.btn_baglan.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_baglan.Location = new System.Drawing.Point(12, 71);
            this.btn_baglan.Name = "btn_baglan";
            this.btn_baglan.Size = new System.Drawing.Size(211, 76);
            this.btn_baglan.TabIndex = 0;
            this.btn_baglan.Text = "SQL` e Baglan";
            this.btn_baglan.UseVisualStyleBackColor = false;
            this.btn_baglan.Click += new System.EventHandler(this.btn_baglan_Click);
            // 
            // btn_tablogetir
            // 
            this.btn_tablogetir.BackColor = System.Drawing.Color.Transparent;
            this.btn_tablogetir.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tablogetir.Location = new System.Drawing.Point(305, 71);
            this.btn_tablogetir.Name = "btn_tablogetir";
            this.btn_tablogetir.Size = new System.Drawing.Size(211, 76);
            this.btn_tablogetir.TabIndex = 1;
            this.btn_tablogetir.Text = "Tablo Getir";
            this.btn_tablogetir.UseVisualStyleBackColor = false;
            this.btn_tablogetir.Click += new System.EventHandler(this.btn_tablogetir_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Transparent;
            this.btn_kapat.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kapat.Location = new System.Drawing.Point(619, 71);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(211, 76);
            this.btn_kapat.TabIndex = 2;
            this.btn_kapat.Text = "Baglantiyi Kapat";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(818, 401);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 618);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.btn_tablogetir);
            this.Controls.Add(this.btn_baglan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_baglan;
        private System.Windows.Forms.Button btn_tablogetir;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


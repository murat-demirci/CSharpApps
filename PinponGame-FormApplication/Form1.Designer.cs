namespace PinponGame_FormApplication
{
    partial class game_form
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
            this.playground = new System.Windows.Forms.Panel();
            this.rocket = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.points_label = new System.Windows.Forms.Label();
            this.gameover_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // playground
            // 
            this.playground.Controls.Add(this.gameover_lbl);
            this.playground.Controls.Add(this.points_label);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.rocket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(800, 450);
            this.playground.TabIndex = 0;
            // 
            // rocket
            // 
            this.rocket.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rocket.Location = new System.Drawing.Point(343, 427);
            this.rocket.Margin = new System.Windows.Forms.Padding(50);
            this.rocket.Name = "rocket";
            this.rocket.Size = new System.Drawing.Size(200, 20);
            this.rocket.TabIndex = 0;
            this.rocket.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(176, 251);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // points_label
            // 
            this.points_label.AutoSize = true;
            this.points_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.points_label.Location = new System.Drawing.Point(12, 9);
            this.points_label.Name = "points_label";
            this.points_label.Size = new System.Drawing.Size(51, 55);
            this.points_label.TabIndex = 3;
            this.points_label.Text = "0";
            this.points_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameover_lbl
            // 
            this.gameover_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameover_lbl.Location = new System.Drawing.Point(259, 59);
            this.gameover_lbl.Margin = new System.Windows.Forms.Padding(50);
            this.gameover_lbl.Name = "gameover_lbl";
            this.gameover_lbl.Size = new System.Drawing.Size(345, 291);
            this.gameover_lbl.TabIndex = 4;
            this.gameover_lbl.Text = "Game Over\r\n\r\nF1- Restart Game\r\n\r\nESC- Exit\r\n";
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // game_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playground);
            this.Name = "game_form";
            this.Text = "Pinpon Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_form_KeyDown);
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rocket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.Label gameover_lbl;
        private System.Windows.Forms.Label points_label;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox rocket;
        private System.Windows.Forms.Timer timer1;
    }
}


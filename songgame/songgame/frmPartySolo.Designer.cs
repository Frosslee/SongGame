namespace songgame
{
    partial class frmPartySolo
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
            this.lblscore = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCongrats = new System.Windows.Forms.Label();
            this.lblPlayerTwos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRetun = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Font = new System.Drawing.Font("Old English Text MT", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscore.Location = new System.Drawing.Point(288, 276);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(275, 114);
            this.lblscore.TabIndex = 0;
            this.lblscore.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblCongrats);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 152);
            this.panel1.TabIndex = 1;
            // 
            // lblCongrats
            // 
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongrats.Location = new System.Drawing.Point(27, 51);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(146, 57);
            this.lblCongrats.TabIndex = 3;
            this.lblCongrats.Text = "label1";
            // 
            // lblPlayerTwos
            // 
            this.lblPlayerTwos.AutoSize = true;
            this.lblPlayerTwos.Font = new System.Drawing.Font("Old English Text MT", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwos.Location = new System.Drawing.Point(288, 523);
            this.lblPlayerTwos.Name = "lblPlayerTwos";
            this.lblPlayerTwos.Size = new System.Drawing.Size(204, 114);
            this.lblPlayerTwos.TabIndex = 2;
            this.lblPlayerTwos.Text = "asdf";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(719, 114);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player one score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(724, 114);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player two score:";
            // 
            // btnRetun
            // 
            this.btnRetun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRetun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetun.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetun.Location = new System.Drawing.Point(71, 698);
            this.btnRetun.Name = "btnRetun";
            this.btnRetun.Size = new System.Drawing.Size(308, 82);
            this.btnRetun.TabIndex = 5;
            this.btnRetun.Text = "Return";
            this.btnRetun.UseVisualStyleBackColor = false;
            this.btnRetun.Click += new System.EventHandler(this.btnRetun_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Old English Text MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(463, 698);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(308, 82);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmPartySolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(844, 806);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRetun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPlayerTwos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblscore);
            this.Name = "frmPartySolo";
            this.Text = "frmParty";
            this.Load += new System.EventHandler(this.frmPartySolo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblscore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPlayerTwos;
        private System.Windows.Forms.Label lblCongrats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRetun;
        private System.Windows.Forms.Button btnExit;
    }
}
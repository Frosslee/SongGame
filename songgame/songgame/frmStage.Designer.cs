namespace songgame
{
    partial class frmStage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAnswerFour = new System.Windows.Forms.Button();
            this.btnAnswerThree = new System.Windows.Forms.Button();
            this.btnAnswerTwo = new System.Windows.Forms.Button();
            this.btnAnswerOne = new System.Windows.Forms.Button();
            this.lblVraag = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblTimer);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblPlayer);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblRound);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1306, 125);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Location = new System.Drawing.Point(115, 56);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(35, 13);
            this.lblTimer.TabIndex = 8;
            this.lblTimer.Text = "label1";
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1048, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Player : ";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(1158, 73);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(80, 32);
            this.lblPlayer.TabIndex = 5;
            this.lblPlayer.Text = "label7";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1053, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Round :";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.Location = new System.Drawing.Point(1158, 41);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(80, 32);
            this.lblRound.TabIndex = 3;
            this.lblRound.Text = "label5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(602, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnReturn);
            this.panel2.Controls.Add(this.btnAnswerFour);
            this.panel2.Controls.Add(this.btnAnswerThree);
            this.panel2.Controls.Add(this.btnAnswerTwo);
            this.panel2.Controls.Add(this.btnAnswerOne);
            this.panel2.Controls.Add(this.lblVraag);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1306, 464);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Old English Text MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(575, 377);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(205, 75);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAnswerFour
            // 
            this.btnAnswerFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnswerFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerFour.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerFour.Location = new System.Drawing.Point(750, 265);
            this.btnAnswerFour.Name = "btnAnswerFour";
            this.btnAnswerFour.Size = new System.Drawing.Size(396, 57);
            this.btnAnswerFour.TabIndex = 4;
            this.btnAnswerFour.Text = "button4";
            this.btnAnswerFour.UseVisualStyleBackColor = false;
            this.btnAnswerFour.Click += new System.EventHandler(this.btnAnswerFour_Click);
            // 
            // btnAnswerThree
            // 
            this.btnAnswerThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnswerThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerThree.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerThree.Location = new System.Drawing.Point(197, 265);
            this.btnAnswerThree.Name = "btnAnswerThree";
            this.btnAnswerThree.Size = new System.Drawing.Size(396, 57);
            this.btnAnswerThree.TabIndex = 3;
            this.btnAnswerThree.Text = "button3";
            this.btnAnswerThree.UseVisualStyleBackColor = false;
            this.btnAnswerThree.Click += new System.EventHandler(this.btnAnswerThree_Click);
            // 
            // btnAnswerTwo
            // 
            this.btnAnswerTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnswerTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerTwo.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerTwo.Location = new System.Drawing.Point(750, 134);
            this.btnAnswerTwo.Name = "btnAnswerTwo";
            this.btnAnswerTwo.Size = new System.Drawing.Size(396, 57);
            this.btnAnswerTwo.TabIndex = 2;
            this.btnAnswerTwo.Text = "button2";
            this.btnAnswerTwo.UseVisualStyleBackColor = false;
            this.btnAnswerTwo.Click += new System.EventHandler(this.btnAnswerTwo_Click);
            // 
            // btnAnswerOne
            // 
            this.btnAnswerOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnswerOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerOne.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerOne.Location = new System.Drawing.Point(197, 134);
            this.btnAnswerOne.Name = "btnAnswerOne";
            this.btnAnswerOne.Size = new System.Drawing.Size(396, 57);
            this.btnAnswerOne.TabIndex = 1;
            this.btnAnswerOne.Text = "button1";
            this.btnAnswerOne.UseVisualStyleBackColor = false;
            this.btnAnswerOne.Click += new System.EventHandler(this.btnAnswerOne_Click);
            // 
            // lblVraag
            // 
            this.lblVraag.AutoSize = true;
            this.lblVraag.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVraag.Location = new System.Drawing.Point(29, 43);
            this.lblVraag.Name = "lblVraag";
            this.lblVraag.Size = new System.Drawing.Size(209, 57);
            this.lblVraag.TabIndex = 0;
            this.lblVraag.Text = "VRAAG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(613, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 54);
            this.label1.TabIndex = 12;
            this.label1.Text = "30 sec";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // frmStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1306, 651);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmStage";
            this.Text = "frmstage";
            this.Load += new System.EventHandler(this.frmStage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Button btnAnswerFour;
        private System.Windows.Forms.Button btnAnswerThree;
        private System.Windows.Forms.Button btnAnswerTwo;
        private System.Windows.Forms.Button btnAnswerOne;
        private System.Windows.Forms.Label lblVraag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label1;
    }
}
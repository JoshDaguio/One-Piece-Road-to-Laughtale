﻿namespace One_Piece
{
    partial class ShooterLvlThree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShooterLvlThree));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.Observer = new System.Windows.Forms.Timer(this.components);
            this.Life1 = new System.Windows.Forms.PictureBox();
            this.Life2 = new System.Windows.Forms.PictureBox();
            this.Life3 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.enem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.PlayerMove);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.FireBullet);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.MoveAliens);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 1500;
            this.timer4.Tick += new System.EventHandler(this.StrikeSpan);
            // 
            // timer5
            // 
            this.timer5.Enabled = true;
            this.timer5.Interval = 1;
            this.timer5.Tick += new System.EventHandler(this.DetectLaser);
            // 
            // Observer
            // 
            this.Observer.Interval = 1;
            this.Observer.Tick += new System.EventHandler(this.Observe);
            // 
            // Life1
            // 
            this.Life1.BackColor = System.Drawing.Color.Transparent;
            this.Life1.Image = ((System.Drawing.Image)(resources.GetObject("Life1.Image")));
            this.Life1.Location = new System.Drawing.Point(85, 714);
            this.Life1.Name = "Life1";
            this.Life1.Size = new System.Drawing.Size(30, 30);
            this.Life1.TabIndex = 1;
            this.Life1.TabStop = false;
            // 
            // Life2
            // 
            this.Life2.BackColor = System.Drawing.Color.Transparent;
            this.Life2.Image = ((System.Drawing.Image)(resources.GetObject("Life2.Image")));
            this.Life2.Location = new System.Drawing.Point(121, 714);
            this.Life2.Name = "Life2";
            this.Life2.Size = new System.Drawing.Size(30, 30);
            this.Life2.TabIndex = 1;
            this.Life2.TabStop = false;
            // 
            // Life3
            // 
            this.Life3.BackColor = System.Drawing.Color.Transparent;
            this.Life3.Image = ((System.Drawing.Image)(resources.GetObject("Life3.Image")));
            this.Life3.Location = new System.Drawing.Point(157, 714);
            this.Life3.Name = "Life3";
            this.Life3.Size = new System.Drawing.Size(30, 30);
            this.Life3.TabIndex = 1;
            this.Life3.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::One_Piece.Properties.Resources.luffy4th_r;
            this.Player.Location = new System.Drawing.Point(360, 650);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 50);
            this.Player.TabIndex = 3;
            this.Player.TabStop = false;
            // 
            // enem
            // 
            this.enem.AutoSize = true;
            this.enem.BackColor = System.Drawing.Color.Transparent;
            this.enem.Font = new System.Drawing.Font("Retro Gaming", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enem.ForeColor = System.Drawing.Color.Transparent;
            this.enem.Location = new System.Drawing.Point(737, 717);
            this.enem.Name = "enem";
            this.enem.Size = new System.Drawing.Size(36, 22);
            this.enem.TabIndex = 4;
            this.enem.Text = "50";
            // 
            // ShooterLvlThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::One_Piece.Properties.Resources.level3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.enem);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.Life3);
            this.Controls.Add(this.Life2);
            this.Controls.Add(this.Life1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ShooterLvlThree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One Piece: Road To Laugh Tale";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pressed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Released);
            ((System.ComponentModel.ISupportInitialize)(this.Life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer Observer;
        private System.Windows.Forms.PictureBox Life1;
        private System.Windows.Forms.PictureBox Life2;
        private System.Windows.Forms.PictureBox Life3;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Label enem;
    }
}
namespace One_Piece
{
    partial class Lose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lose));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.ext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::One_Piece.Properties.Resources.bbf;
            this.pictureBox1.Location = new System.Drawing.Point(-35, 138);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 544);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.FlatAppearance.BorderSize = 0;
            this.menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menu.Image = global::One_Piece.Properties.Resources.menuF;
            this.menu.Location = new System.Drawing.Point(21, 691);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(135, 44);
            this.menu.TabIndex = 1;
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            this.menu.MouseEnter += new System.EventHandler(this.menu_MouseEnter);
            this.menu.MouseLeave += new System.EventHandler(this.menu_MouseLeave);
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.Transparent;
            this.restart.FlatAppearance.BorderSize = 0;
            this.restart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.restart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restart.Image = global::One_Piece.Properties.Resources.restartF;
            this.restart.Location = new System.Drawing.Point(293, 697);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(199, 30);
            this.restart.TabIndex = 1;
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            this.restart.MouseEnter += new System.EventHandler(this.restart_MouseEnter);
            this.restart.MouseLeave += new System.EventHandler(this.restart_MouseLeave);
            // 
            // ext
            // 
            this.ext.BackColor = System.Drawing.Color.Transparent;
            this.ext.FlatAppearance.BorderSize = 0;
            this.ext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ext.Image = global::One_Piece.Properties.Resources.exitF;
            this.ext.Location = new System.Drawing.Point(657, 696);
            this.ext.Name = "ext";
            this.ext.Size = new System.Drawing.Size(100, 33);
            this.ext.TabIndex = 1;
            this.ext.UseVisualStyleBackColor = false;
            this.ext.Click += new System.EventHandler(this.ext_Click);
            this.ext.MouseEnter += new System.EventHandler(this.ext_MouseEnter);
            this.ext.MouseLeave += new System.EventHandler(this.ext_MouseLeave);
            // 
            // Lose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::One_Piece.Properties.Resources.Lose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.ext);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Lose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One Piece: Road To Laugh Tale";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button ext;
    }
}
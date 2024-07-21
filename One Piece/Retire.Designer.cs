namespace One_Piece
{
    partial class Retire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Retire));
            this.yep = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yep
            // 
            this.yep.BackColor = System.Drawing.Color.Transparent;
            this.yep.FlatAppearance.BorderSize = 0;
            this.yep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.yep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.yep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yep.Image = global::One_Piece.Properties.Resources.yesEB;
            this.yep.Location = new System.Drawing.Point(308, 139);
            this.yep.Name = "yep";
            this.yep.Size = new System.Drawing.Size(42, 22);
            this.yep.TabIndex = 0;
            this.yep.UseVisualStyleBackColor = false;
            this.yep.Click += new System.EventHandler(this.yep_Click);
            this.yep.MouseEnter += new System.EventHandler(this.yep_MouseEnter);
            this.yep.MouseLeave += new System.EventHandler(this.yep_MouseLeave);
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.Transparent;
            this.restart.FlatAppearance.BorderSize = 0;
            this.restart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.restart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restart.Image = global::One_Piece.Properties.Resources.restartMB;
            this.restart.Location = new System.Drawing.Point(377, 139);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(82, 22);
            this.restart.TabIndex = 0;
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            this.restart.MouseEnter += new System.EventHandler(this.restart_MouseEnter);
            this.restart.MouseLeave += new System.EventHandler(this.restart_MouseLeave);
            // 
            // Retire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::One_Piece.Properties.Resources.Retire;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 183);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.yep);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Retire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hang Up The Jolly Roger?";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yep;
        private System.Windows.Forms.Button restart;
    }
}
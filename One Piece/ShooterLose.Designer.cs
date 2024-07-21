namespace One_Piece
{
    partial class ShooterLose
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
            this.rst = new System.Windows.Forms.Button();
            this.cnt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rst
            // 
            this.rst.BackColor = System.Drawing.Color.Transparent;
            this.rst.FlatAppearance.BorderSize = 0;
            this.rst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rst.Image = global::One_Piece.Properties.Resources.rstSL;
            this.rst.Location = new System.Drawing.Point(161, 372);
            this.rst.Name = "rst";
            this.rst.Size = new System.Drawing.Size(167, 32);
            this.rst.TabIndex = 0;
            this.rst.UseVisualStyleBackColor = false;
            this.rst.Click += new System.EventHandler(this.rst_Click);
            this.rst.MouseEnter += new System.EventHandler(this.rst_MouseEnter);
            this.rst.MouseLeave += new System.EventHandler(this.rst_MouseLeave);
            // 
            // cnt
            // 
            this.cnt.BackColor = System.Drawing.Color.Transparent;
            this.cnt.FlatAppearance.BorderSize = 0;
            this.cnt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cnt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cnt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cnt.Image = global::One_Piece.Properties.Resources.cntSL;
            this.cnt.Location = new System.Drawing.Point(406, 372);
            this.cnt.Name = "cnt";
            this.cnt.Size = new System.Drawing.Size(193, 32);
            this.cnt.TabIndex = 0;
            this.cnt.UseVisualStyleBackColor = false;
            this.cnt.Click += new System.EventHandler(this.cnt_Click);
            this.cnt.MouseEnter += new System.EventHandler(this.cnt_MouseEnter);
            this.cnt.MouseLeave += new System.EventHandler(this.cnt_MouseLeave);
            // 
            // ShooterLose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::One_Piece.Properties.Resources.ShooterLose;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Controls.Add(this.cnt);
            this.Controls.Add(this.rst);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShooterLose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShooterLose";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rst;
        private System.Windows.Forms.Button cnt;
    }
}
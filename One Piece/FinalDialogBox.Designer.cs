namespace One_Piece
{
    partial class FinalDialogBox
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
            this.yep = new System.Windows.Forms.Button();
            this.nope = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yep
            // 
            this.yep.BackColor = System.Drawing.Color.Transparent;
            this.yep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yep.FlatAppearance.BorderSize = 0;
            this.yep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.yep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.yep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yep.Image = global::One_Piece.Properties.Resources.YesR;
            this.yep.Location = new System.Drawing.Point(117, 103);
            this.yep.Name = "yep";
            this.yep.Size = new System.Drawing.Size(75, 29);
            this.yep.TabIndex = 0;
            this.yep.UseVisualStyleBackColor = false;
            this.yep.Click += new System.EventHandler(this.yep_Click);
            this.yep.MouseEnter += new System.EventHandler(this.yep_MouseEnter);
            this.yep.MouseLeave += new System.EventHandler(this.yep_MouseLeave);
            // 
            // nope
            // 
            this.nope.BackColor = System.Drawing.Color.Transparent;
            this.nope.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nope.FlatAppearance.BorderSize = 0;
            this.nope.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nope.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nope.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nope.Image = global::One_Piece.Properties.Resources.NoR;
            this.nope.Location = new System.Drawing.Point(302, 102);
            this.nope.Name = "nope";
            this.nope.Size = new System.Drawing.Size(75, 29);
            this.nope.TabIndex = 0;
            this.nope.UseVisualStyleBackColor = false;
            this.nope.Click += new System.EventHandler(this.nope_Click);
            this.nope.MouseEnter += new System.EventHandler(this.nope_MouseEnter);
            this.nope.MouseLeave += new System.EventHandler(this.nope_MouseLeave);
            // 
            // FinalDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::One_Piece.Properties.Resources.RUS;
            this.ClientSize = new System.Drawing.Size(501, 180);
            this.Controls.Add(this.nope);
            this.Controls.Add(this.yep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FinalDialogBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinalDialogBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yep;
        private System.Windows.Forms.Button nope;
    }
}
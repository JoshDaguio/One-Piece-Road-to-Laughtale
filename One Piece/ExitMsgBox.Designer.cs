namespace One_Piece
{
    partial class ExitMsgBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitMsgBox));
            this.yep = new System.Windows.Forms.Button();
            this.nope = new System.Windows.Forms.Button();
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
            this.yep.Location = new System.Drawing.Point(333, 139);
            this.yep.Name = "yep";
            this.yep.Size = new System.Drawing.Size(43, 23);
            this.yep.TabIndex = 0;
            this.yep.UseVisualStyleBackColor = false;
            this.yep.Click += new System.EventHandler(this.yep_Click);
            this.yep.MouseEnter += new System.EventHandler(this.yep_MouseEnter);
            this.yep.MouseLeave += new System.EventHandler(this.yep_MouseLeave);
            // 
            // nope
            // 
            this.nope.BackColor = System.Drawing.Color.Transparent;
            this.nope.FlatAppearance.BorderSize = 0;
            this.nope.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nope.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nope.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nope.Image = global::One_Piece.Properties.Resources.noEB;
            this.nope.Location = new System.Drawing.Point(398, 139);
            this.nope.Name = "nope";
            this.nope.Size = new System.Drawing.Size(43, 23);
            this.nope.TabIndex = 0;
            this.nope.UseVisualStyleBackColor = false;
            this.nope.Click += new System.EventHandler(this.nope_Click);
            this.nope.MouseEnter += new System.EventHandler(this.nope_MouseEnter);
            this.nope.MouseLeave += new System.EventHandler(this.nope_MouseLeave);
            // 
            // ExitMsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::One_Piece.Properties.Resources.ExitBox;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 183);
            this.Controls.Add(this.nope);
            this.Controls.Add(this.yep);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExitMsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Leave Grand Line?";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yep;
        private System.Windows.Forms.Button nope;
    }
}
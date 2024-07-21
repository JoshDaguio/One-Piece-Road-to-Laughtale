namespace One_Piece
{
    partial class GetName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetName));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.resetname = new System.Windows.Forms.Button();
            this.confirmname = new System.Windows.Forms.Button();
            this.ext = new System.Windows.Forms.Button();
            this.nxt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Retro Gaming", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(208, 365);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 26);
            this.textBox1.TabIndex = 0;
            // 
            // resetname
            // 
            this.resetname.BackColor = System.Drawing.Color.Transparent;
            this.resetname.FlatAppearance.BorderSize = 0;
            this.resetname.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.resetname.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.resetname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetname.Image = global::One_Piece.Properties.Resources.ResetN;
            this.resetname.Location = new System.Drawing.Point(270, 442);
            this.resetname.Name = "resetname";
            this.resetname.Size = new System.Drawing.Size(85, 31);
            this.resetname.TabIndex = 1;
            this.resetname.UseVisualStyleBackColor = false;
            this.resetname.Click += new System.EventHandler(this.resetname_Click);
            this.resetname.MouseEnter += new System.EventHandler(this.resetname_MouseEnter);
            this.resetname.MouseLeave += new System.EventHandler(this.resetname_MouseLeave);
            // 
            // confirmname
            // 
            this.confirmname.BackColor = System.Drawing.Color.Transparent;
            this.confirmname.FlatAppearance.BorderSize = 0;
            this.confirmname.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.confirmname.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.confirmname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmname.Image = global::One_Piece.Properties.Resources.ConfirmN;
            this.confirmname.Location = new System.Drawing.Point(414, 442);
            this.confirmname.Name = "confirmname";
            this.confirmname.Size = new System.Drawing.Size(104, 28);
            this.confirmname.TabIndex = 1;
            this.confirmname.UseVisualStyleBackColor = false;
            this.confirmname.Click += new System.EventHandler(this.confirmname_Click);
            this.confirmname.MouseEnter += new System.EventHandler(this.confirmname_MouseEnter);
            this.confirmname.MouseLeave += new System.EventHandler(this.confirmname_MouseLeave);
            // 
            // ext
            // 
            this.ext.BackColor = System.Drawing.Color.Transparent;
            this.ext.FlatAppearance.BorderSize = 0;
            this.ext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ext.Image = global::One_Piece.Properties.Resources.ExitBTN;
            this.ext.Location = new System.Drawing.Point(640, 692);
            this.ext.Name = "ext";
            this.ext.Size = new System.Drawing.Size(108, 49);
            this.ext.TabIndex = 1;
            this.ext.UseVisualStyleBackColor = false;
            this.ext.Click += new System.EventHandler(this.ext_Click);
            this.ext.MouseEnter += new System.EventHandler(this.ext_MouseEnter);
            this.ext.MouseLeave += new System.EventHandler(this.ext_MouseLeave);
            // 
            // nxt
            // 
            this.nxt.BackColor = System.Drawing.Color.Transparent;
            this.nxt.FlatAppearance.BorderSize = 0;
            this.nxt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nxt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nxt.Image = global::One_Piece.Properties.Resources.NextBTN;
            this.nxt.Location = new System.Drawing.Point(29, 694);
            this.nxt.Name = "nxt";
            this.nxt.Size = new System.Drawing.Size(128, 46);
            this.nxt.TabIndex = 1;
            this.nxt.UseVisualStyleBackColor = false;
            this.nxt.Click += new System.EventHandler(this.nxt_Click);
            this.nxt.MouseEnter += new System.EventHandler(this.nxt_MouseEnter);
            this.nxt.MouseLeave += new System.EventHandler(this.nxt_MouseLeave);
            // 
            // GetName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::One_Piece.Properties.Resources.GetName;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.nxt);
            this.Controls.Add(this.ext);
            this.Controls.Add(this.confirmname);
            this.Controls.Add(this.resetname);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GetName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One Piece: Road To Laugh Tale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button resetname;
        private System.Windows.Forms.Button confirmname;
        private System.Windows.Forms.Button ext;
        private System.Windows.Forms.Button nxt;
    }
}
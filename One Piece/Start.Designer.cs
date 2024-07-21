namespace One_Piece
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.strt = new System.Windows.Forms.Button();
            this.ext = new System.Windows.Forms.Button();
            this.abt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // strt
            // 
            this.strt.BackColor = System.Drawing.Color.Transparent;
            this.strt.FlatAppearance.BorderSize = 0;
            this.strt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.strt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.strt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strt.ForeColor = System.Drawing.Color.Transparent;
            this.strt.Image = global::One_Piece.Properties.Resources.StrtBtn;
            this.strt.Location = new System.Drawing.Point(292, 361);
            this.strt.Name = "strt";
            this.strt.Size = new System.Drawing.Size(186, 65);
            this.strt.TabIndex = 5;
            this.strt.UseVisualStyleBackColor = false;
            this.strt.Click += new System.EventHandler(this.strt_Click);
            this.strt.MouseEnter += new System.EventHandler(this.strt_MouseEnter);
            this.strt.MouseLeave += new System.EventHandler(this.strt_MouseLeave);
            // 
            // ext
            // 
            this.ext.BackColor = System.Drawing.Color.Transparent;
            this.ext.FlatAppearance.BorderSize = 0;
            this.ext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ext.ForeColor = System.Drawing.Color.Transparent;
            this.ext.Image = global::One_Piece.Properties.Resources.ExtBtn;
            this.ext.Location = new System.Drawing.Point(292, 427);
            this.ext.Name = "ext";
            this.ext.Size = new System.Drawing.Size(186, 65);
            this.ext.TabIndex = 5;
            this.ext.UseVisualStyleBackColor = false;
            this.ext.Click += new System.EventHandler(this.ext_Click);
            this.ext.MouseEnter += new System.EventHandler(this.ext_MouseEnter);
            this.ext.MouseLeave += new System.EventHandler(this.ext_MouseLeave);
            // 
            // abt
            // 
            this.abt.BackColor = System.Drawing.Color.Transparent;
            this.abt.FlatAppearance.BorderSize = 0;
            this.abt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.abt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.abt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abt.ForeColor = System.Drawing.Color.Transparent;
            this.abt.Image = global::One_Piece.Properties.Resources.AbtBtn;
            this.abt.Location = new System.Drawing.Point(292, 499);
            this.abt.Name = "abt";
            this.abt.Size = new System.Drawing.Size(186, 65);
            this.abt.TabIndex = 5;
            this.abt.UseVisualStyleBackColor = false;
            this.abt.Click += new System.EventHandler(this.abt_Click);
            this.abt.MouseEnter += new System.EventHandler(this.abt_MouseEnter);
            this.abt.MouseLeave += new System.EventHandler(this.abt_MouseLeave);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::One_Piece.Properties.Resources.Start_Frame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.abt);
            this.Controls.Add(this.ext);
            this.Controls.Add(this.strt);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One Piece: Road To Laugh Tale";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Start_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button strt;
        private System.Windows.Forms.Button ext;
        private System.Windows.Forms.Button abt;
    }
}
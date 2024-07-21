namespace One_Piece
{
    partial class PuzzleRulesF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PuzzleRulesF));
            this.PRnext = new System.Windows.Forms.Button();
            this.PRexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PRnext
            // 
            this.PRnext.BackColor = System.Drawing.Color.Transparent;
            this.PRnext.FlatAppearance.BorderSize = 0;
            this.PRnext.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.PRnext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PRnext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PRnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PRnext.Image = global::One_Piece.Properties.Resources.NextBTN;
            this.PRnext.Location = new System.Drawing.Point(36, 694);
            this.PRnext.Name = "PRnext";
            this.PRnext.Size = new System.Drawing.Size(117, 46);
            this.PRnext.TabIndex = 0;
            this.PRnext.UseVisualStyleBackColor = false;
            this.PRnext.Click += new System.EventHandler(this.PRnext_Click);
            this.PRnext.MouseEnter += new System.EventHandler(this.PRnext_MouseEnter);
            this.PRnext.MouseLeave += new System.EventHandler(this.PRnext_MouseLeave);
            // 
            // PRexit
            // 
            this.PRexit.BackColor = System.Drawing.Color.Transparent;
            this.PRexit.FlatAppearance.BorderSize = 0;
            this.PRexit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.PRexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PRexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PRexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PRexit.Image = global::One_Piece.Properties.Resources.ExitBTN;
            this.PRexit.Location = new System.Drawing.Point(644, 697);
            this.PRexit.Name = "PRexit";
            this.PRexit.Size = new System.Drawing.Size(100, 40);
            this.PRexit.TabIndex = 0;
            this.PRexit.UseVisualStyleBackColor = false;
            this.PRexit.Click += new System.EventHandler(this.PRexit_Click);
            this.PRexit.MouseEnter += new System.EventHandler(this.PRexit_MouseEnter);
            this.PRexit.MouseLeave += new System.EventHandler(this.PRexit_MouseLeave);
            // 
            // PuzzleRulesF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::One_Piece.Properties.Resources.RulesPuzzle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.PRexit);
            this.Controls.Add(this.PRnext);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "PuzzleRulesF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One Piece: Road To Laugh Tale";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PRnext;
        private System.Windows.Forms.Button PRexit;
    }
}
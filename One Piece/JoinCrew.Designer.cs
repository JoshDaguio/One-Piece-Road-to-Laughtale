namespace One_Piece
{
    partial class JoinCrew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinCrew));
            this.refuse = new System.Windows.Forms.Button();
            this.joinc = new System.Windows.Forms.Button();
            this.Playername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // refuse
            // 
            this.refuse.BackColor = System.Drawing.Color.Transparent;
            this.refuse.FlatAppearance.BorderSize = 0;
            this.refuse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.refuse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.refuse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refuse.Image = global::One_Piece.Properties.Resources.RefuseJC;
            this.refuse.Location = new System.Drawing.Point(119, 583);
            this.refuse.Name = "refuse";
            this.refuse.Size = new System.Drawing.Size(192, 56);
            this.refuse.TabIndex = 0;
            this.refuse.UseVisualStyleBackColor = false;
            this.refuse.Click += new System.EventHandler(this.refuse_Click);
            this.refuse.MouseEnter += new System.EventHandler(this.refuse_MouseEnter);
            this.refuse.MouseLeave += new System.EventHandler(this.refuse_MouseLeave);
            // 
            // joinc
            // 
            this.joinc.BackColor = System.Drawing.Color.Transparent;
            this.joinc.FlatAppearance.BorderSize = 0;
            this.joinc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.joinc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.joinc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joinc.Image = global::One_Piece.Properties.Resources.Join_Crew;
            this.joinc.Location = new System.Drawing.Point(437, 585);
            this.joinc.Name = "joinc";
            this.joinc.Size = new System.Drawing.Size(234, 52);
            this.joinc.TabIndex = 0;
            this.joinc.UseVisualStyleBackColor = false;
            this.joinc.Click += new System.EventHandler(this.joinc_Click);
            this.joinc.MouseEnter += new System.EventHandler(this.joinc_MouseEnter);
            this.joinc.MouseLeave += new System.EventHandler(this.joinc_MouseLeave);
            // 
            // Playername
            // 
            this.Playername.AutoSize = true;
            this.Playername.BackColor = System.Drawing.Color.Transparent;
            this.Playername.Font = new System.Drawing.Font("Retro Gaming", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playername.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Playername.Location = new System.Drawing.Point(424, 484);
            this.Playername.Name = "Playername";
            this.Playername.Size = new System.Drawing.Size(102, 25);
            this.Playername.TabIndex = 1;
            this.Playername.Text = "Joshua";
            // 
            // JoinCrew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::One_Piece.Properties.Resources.Backstory_final;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.Playername);
            this.Controls.Add(this.joinc);
            this.Controls.Add(this.refuse);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "JoinCrew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One Piece: Road To Laugh Tale";
            this.Load += new System.EventHandler(this.JoinCrew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button refuse;
        private System.Windows.Forms.Button joinc;
        private System.Windows.Forms.Label Playername;
    }
}
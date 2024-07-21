namespace One_Piece
{
    partial class TimerLvl2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerLvl2));
            this.label1 = new System.Windows.Forms.Label();
            this.countdowntmr = new System.Windows.Forms.Timer(this.components);
            this.Playername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Retro Gaming", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(366, 645);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "10";
            // 
            // countdowntmr
            // 
            this.countdowntmr.Interval = 1000;
            this.countdowntmr.Tick += new System.EventHandler(this.countdowntmr_Tick);
            // 
            // Playername
            // 
            this.Playername.AutoSize = true;
            this.Playername.BackColor = System.Drawing.Color.Transparent;
            this.Playername.Font = new System.Drawing.Font("Retro Gaming", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playername.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Playername.Location = new System.Drawing.Point(126, 485);
            this.Playername.Name = "Playername";
            this.Playername.Size = new System.Drawing.Size(115, 24);
            this.Playername.TabIndex = 1;
            this.Playername.Text = "Joshua?";
            // 
            // TimerLvl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::One_Piece.Properties.Resources.Timer2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.Playername);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TimerLvl2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "One Piece: Road To Laugh Tale";
            this.Load += new System.EventHandler(this.TimerLvl2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer countdowntmr;
        private System.Windows.Forms.Label Playername;
    }
}
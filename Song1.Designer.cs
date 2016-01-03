namespace WindowsFormsApplication1
{
    partial class Song1
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
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.whatMove = new System.Windows.Forms.Label();
            this.beforeStart = new System.Windows.Forms.Timer(this.components);
            this.chancesLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Interval = 1500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // whatMove
            // 
            this.whatMove.AutoSize = true;
            this.whatMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whatMove.Location = new System.Drawing.Point(78, 115);
            this.whatMove.Name = "whatMove";
            this.whatMove.Size = new System.Drawing.Size(115, 24);
            this.whatMove.TabIndex = 0;
            this.whatMove.Text = "What move?";
            // 
            // beforeStart
            // 
            this.beforeStart.Interval = 1500;
            this.beforeStart.Tick += new System.EventHandler(this.beforeStart_Tick);
            // 
            // chancesLabel
            // 
            this.chancesLabel.AutoSize = true;
            this.chancesLabel.Location = new System.Drawing.Point(13, 13);
            this.chancesLabel.Name = "chancesLabel";
            this.chancesLabel.Size = new System.Drawing.Size(67, 13);
            this.chancesLabel.TabIndex = 1;
            this.chancesLabel.Text = "Chances: 20";
            this.chancesLabel.Click += new System.EventHandler(this.chancesLabel_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(216, 13);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(47, 13);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Score: 0";
            // 
            // Song1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.chancesLabel);
            this.Controls.Add(this.whatMove);
            this.Name = "Song1";
            this.Text = "Song1";
            this.Load += new System.EventHandler(this.Song1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label whatMove;
        private System.Windows.Forms.Timer beforeStart;
        private System.Windows.Forms.Label chancesLabel;
        private System.Windows.Forms.Label scoreLabel;
    }
}
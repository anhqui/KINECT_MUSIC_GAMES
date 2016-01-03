namespace WindowsFormsApplication1
{
    partial class Randomness
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
            this.whatMove = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.chancesLabel = new System.Windows.Forms.Label();
            this.beforeStart = new System.Windows.Forms.Timer(this.components);
            this.closeGame = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // whatMove
            // 
            this.whatMove.AutoSize = true;
            this.whatMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whatMove.Location = new System.Drawing.Point(74, 120);
            this.whatMove.Name = "whatMove";
            this.whatMove.Size = new System.Drawing.Size(127, 25);
            this.whatMove.TabIndex = 0;
            this.whatMove.Text = "what move?";
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(216, 27);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(47, 13);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Score: 0";
            // 
            // chancesLabel
            // 
            this.chancesLabel.AutoSize = true;
            this.chancesLabel.Location = new System.Drawing.Point(13, 26);
            this.chancesLabel.Name = "chancesLabel";
            this.chancesLabel.Size = new System.Drawing.Size(67, 13);
            this.chancesLabel.TabIndex = 2;
            this.chancesLabel.Text = "Chances: 20";
            // 
            // beforeStart
            // 
            this.beforeStart.Interval = 1500;
            this.beforeStart.Tick += new System.EventHandler(this.beforeStart_Tick);
            // 
            // closeGame
            // 
            this.closeGame.Interval = 2500;
            this.closeGame.Tick += new System.EventHandler(this.closeGame_Tick);
            // 
            // Randomness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.chancesLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.whatMove);
            this.Name = "Randomness";
            this.Text = "Randomness";
            this.Load += new System.EventHandler(this.Randomness_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label whatMove;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label chancesLabel;
        private System.Windows.Forms.Timer beforeStart;
        private System.Windows.Forms.Timer closeGame;
    }
}
namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.Freeplay = new System.Windows.Forms.Button();
            this.Song1 = new System.Windows.Forms.Button();
            this.Song2 = new System.Windows.Forms.Button();
            this.Song3 = new System.Windows.Forms.Button();
            this.Randomness = new System.Windows.Forms.Button();
            this.Song4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Freeplay
            // 
            this.Freeplay.Location = new System.Drawing.Point(26, 57);
            this.Freeplay.Name = "Freeplay";
            this.Freeplay.Size = new System.Drawing.Size(95, 50);
            this.Freeplay.TabIndex = 0;
            this.Freeplay.Text = "Freeplay";
            this.Freeplay.UseVisualStyleBackColor = true;
            this.Freeplay.Click += new System.EventHandler(this.button1_Click);
            // 
            // Song1
            // 
            this.Song1.Location = new System.Drawing.Point(26, 165);
            this.Song1.Name = "Song1";
            this.Song1.Size = new System.Drawing.Size(75, 23);
            this.Song1.TabIndex = 2;
            this.Song1.Text = "Song1";
            this.Song1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Song1.UseVisualStyleBackColor = true;
            this.Song1.Click += new System.EventHandler(this.Song1_Click);
            // 
            // Song2
            // 
            this.Song2.Location = new System.Drawing.Point(152, 166);
            this.Song2.Name = "Song2";
            this.Song2.Size = new System.Drawing.Size(75, 23);
            this.Song2.TabIndex = 3;
            this.Song2.Text = "Song2";
            this.Song2.UseVisualStyleBackColor = true;
            this.Song2.Click += new System.EventHandler(this.Song2_Click);
            // 
            // Song3
            // 
            this.Song3.Location = new System.Drawing.Point(271, 166);
            this.Song3.Name = "Song3";
            this.Song3.Size = new System.Drawing.Size(75, 23);
            this.Song3.TabIndex = 4;
            this.Song3.Text = "Song3";
            this.Song3.UseVisualStyleBackColor = true;
            this.Song3.Click += new System.EventHandler(this.Song3_Click);
            // 
            // Randomness
            // 
            this.Randomness.Location = new System.Drawing.Point(251, 57);
            this.Randomness.Name = "Randomness";
            this.Randomness.Size = new System.Drawing.Size(95, 50);
            this.Randomness.TabIndex = 5;
            this.Randomness.Text = "Randomness";
            this.Randomness.UseVisualStyleBackColor = true;
            this.Randomness.Click += new System.EventHandler(this.Randomness_Click);
            // 
            // Song4
            // 
            this.Song4.Location = new System.Drawing.Point(137, 242);
            this.Song4.Name = "Song4";
            this.Song4.Size = new System.Drawing.Size(118, 33);
            this.Song4.TabIndex = 6;
            this.Song4.Text = "Song4";
            this.Song4.UseVisualStyleBackColor = true;
            this.Song4.Click += new System.EventHandler(this.Song4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 300);
            this.Controls.Add(this.Song4);
            this.Controls.Add(this.Randomness);
            this.Controls.Add(this.Song3);
            this.Controls.Add(this.Song2);
            this.Controls.Add(this.Song1);
            this.Controls.Add(this.Freeplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Freeplay;
        private System.Windows.Forms.Button Song1;
        private System.Windows.Forms.Button Song2;
        private System.Windows.Forms.Button Song3;
        private System.Windows.Forms.Button Randomness;
        private System.Windows.Forms.Button Song4;
    }
}


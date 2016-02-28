namespace Game
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
            this.Startgamebutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Startgamebutton
            // 
            this.Startgamebutton.Location = new System.Drawing.Point(328, 96);
            this.Startgamebutton.Name = "Startgamebutton";
            this.Startgamebutton.Size = new System.Drawing.Size(103, 47);
            this.Startgamebutton.TabIndex = 0;
            this.Startgamebutton.Text = "Начать игру";
            this.Startgamebutton.UseVisualStyleBackColor = true;
            this.Startgamebutton.Click += new System.EventHandler(this.Startgamebutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(449, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Startgamebutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Startgamebutton;
        private System.Windows.Forms.Button button1;
    }
}


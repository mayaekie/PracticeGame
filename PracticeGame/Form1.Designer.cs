namespace PracticeGame
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
            this.startbutton = new System.Windows.Forms.Button();
            this.gametitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.Black;
            this.startbutton.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.ForeColor = System.Drawing.SystemColors.Info;
            this.startbutton.Location = new System.Drawing.Point(353, 176);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(107, 68);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "Start";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // gametitle
            // 
            this.gametitle.BackColor = System.Drawing.Color.Black;
            this.gametitle.Font = new System.Drawing.Font("Courier New", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gametitle.ForeColor = System.Drawing.SystemColors.Info;
            this.gametitle.Location = new System.Drawing.Point(329, 124);
            this.gametitle.Name = "gametitle";
            this.gametitle.Size = new System.Drawing.Size(148, 30);
            this.gametitle.TabIndex = 1;
            this.gametitle.Text = "Insert Coin";
            this.gametitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gametitle.TextChanged += new System.EventHandler(this.startbutton_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gametitle);
            this.Controls.Add(this.startbutton);
            this.Name = "Form1";
            this.Text = "Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox gametitle;
        private System.Windows.Forms.Button startbutton;
    }
}


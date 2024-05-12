
namespace DigitalClock
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
            this.components = new System.ComponentModel.Container();
            this.Displaying_Clock = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Displaying_Clock
            // 
            this.Displaying_Clock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Displaying_Clock.AutoSize = true;
            this.Displaying_Clock.Font = new System.Drawing.Font("LCDMono2", 170.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Displaying_Clock.ForeColor = System.Drawing.Color.White;
            this.Displaying_Clock.Location = new System.Drawing.Point(65, 108);
            this.Displaying_Clock.Name = "Displaying_Clock";
            this.Displaying_Clock.Size = new System.Drawing.Size(668, 198);
            this.Displaying_Clock.TabIndex = 0;
            this.Displaying_Clock.Text = "00:00";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(797, 405);
            this.Controls.Add(this.Displaying_Clock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIGITAL CLOCK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Displaying_Clock;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Timer timer1;
    }
}


namespace DiditalClock
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
            this.label1 = new System.Windows.Forms.Label();
            this.hourMinateLabel = new System.Windows.Forms.Label();
            this.secendLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.weekDayLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // hourMinateLabel
            // 
            this.hourMinateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hourMinateLabel.ForeColor = System.Drawing.Color.White;
            this.hourMinateLabel.Location = new System.Drawing.Point(93, 26);
            this.hourMinateLabel.Name = "hourMinateLabel";
            this.hourMinateLabel.Size = new System.Drawing.Size(194, 68);
            this.hourMinateLabel.TabIndex = 1;
            this.hourMinateLabel.Text = "19 : 25";
            // 
            // secendLabel
            // 
            this.secendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secendLabel.ForeColor = System.Drawing.Color.White;
            this.secendLabel.Location = new System.Drawing.Point(293, 26);
            this.secendLabel.Name = "secendLabel";
            this.secendLabel.Size = new System.Drawing.Size(194, 68);
            this.secendLabel.TabIndex = 2;
            this.secendLabel.Text = "42";
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(93, 107);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(329, 66);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Jan 03 2017";
            // 
            // weekDayLabel
            // 
            this.weekDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.weekDayLabel.ForeColor = System.Drawing.Color.White;
            this.weekDayLabel.Location = new System.Drawing.Point(93, 187);
            this.weekDayLabel.Name = "weekDayLabel";
            this.weekDayLabel.Size = new System.Drawing.Size(225, 66);
            this.weekDayLabel.TabIndex = 4;
            this.weekDayLabel.Text = "Monday";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(680, 357);
            this.Controls.Add(this.weekDayLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.secendLabel);
            this.Controls.Add(this.hourMinateLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hourMinateLabel;
        private System.Windows.Forms.Label secendLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label weekDayLabel;
        private System.Windows.Forms.Timer timer1;
    }
}


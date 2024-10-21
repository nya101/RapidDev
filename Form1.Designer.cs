namespace MyFirstProject
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnReset; // If you want a reset button
        private System.Windows.Forms.Label lblStatus;

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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button9 = new Button();
            lblStatus = new Label();
            button8 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LavenderBlush;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(61, 50);
            button1.Name = "button1";
            button1.Size = new Size(132, 102);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += ButtonClick;
            // 
            // button2
            // 
            button2.BackColor = Color.LavenderBlush;
            button2.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(190, 50);
            button2.Name = "button2";
            button2.Size = new Size(132, 102);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += ButtonClick;
            // 
            // button3
            // 
            button3.BackColor = Color.LavenderBlush;
            button3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(315, 50);
            button3.Name = "button3";
            button3.Size = new Size(132, 102);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += ButtonClick;
            // 
            // button4
            // 
            button4.BackColor = Color.LavenderBlush;
            button4.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(61, 148);
            button4.Name = "button4";
            button4.Size = new Size(132, 102);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LavenderBlush;
            button5.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ActiveCaptionText;
            button5.Location = new Point(190, 148);
            button5.Name = "button5";
            button5.Size = new Size(132, 102);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LavenderBlush;
            button6.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.ActiveCaptionText;
            button6.Location = new Point(315, 148);
            button6.Name = "button6";
            button6.Size = new Size(132, 102);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.LavenderBlush;
            button7.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = SystemColors.ActiveCaptionText;
            button7.Location = new Point(61, 247);
            button7.Name = "button7";
            button7.Size = new Size(132, 102);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.LavenderBlush;
            button9.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ActiveCaptionText;
            button9.Location = new Point(315, 247);
            button9.Name = "button9";
            button9.Size = new Size(132, 102);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.Transparent;
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(50, 370);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(300, 30);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Player X's turn";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            lblStatus.Click += lblStatus_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.LavenderBlush;
            button8.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.ForeColor = SystemColors.ActiveCaptionText;
            button8.Location = new Point(190, 247);
            button8.Name = "button8";
            button8.Size = new Size(132, 102);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(605, 430);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(lblStatus);
            ForeColor = SystemColors.AppWorkspace;
            Name = "Form1";
            Text = "Tic Tac Toe";
            ResumeLayout(false);
        }

        #endregion

        private Button button8;
    }

}
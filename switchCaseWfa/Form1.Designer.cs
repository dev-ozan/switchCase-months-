namespace switchCaseWfa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            monthText = new TextBox();
            sonucLabel = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // monthText
            // 
            monthText.Location = new Point(26, 82);
            monthText.Margin = new Padding(4, 4, 4, 4);
            monthText.Name = "monthText";
            monthText.Size = new Size(215, 29);
            monthText.TabIndex = 0;
            // 
            // sonucLabel
            // 
            sonucLabel.BackColor = Color.Silver;
            sonucLabel.Location = new Point(26, 143);
            sonucLabel.Margin = new Padding(4, 0, 4, 0);
            sonucLabel.Name = "sonucLabel";
            sonucLabel.Size = new Size(215, 32);
            sonucLabel.TabIndex = 1;
            sonucLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ButtonShadow;
            label2.Location = new Point(26, 22);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(215, 32);
            label2.TabIndex = 2;
            label2.Text = "Months ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(26, 210);
            button1.Name = "button1";
            button1.Size = new Size(215, 33);
            button1.TabIndex = 3;
            button1.Text = "Find The Month";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 294);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(sonucLabel);
            Controls.Add(monthText);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox monthText;
        private Label sonucLabel;
        private Label label2;
        private Button button1;
    }
}
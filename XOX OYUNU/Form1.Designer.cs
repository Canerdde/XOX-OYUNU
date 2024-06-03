namespace xox_oyunu
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
            lblXO = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // lblXO
            // 
            lblXO.AutoSize = true;
            lblXO.Font = new Font("Segoe UI", 20F);
            lblXO.Location = new Point(185, 22);
            lblXO.Name = "lblXO";
            lblXO.Size = new Size(33, 37);
            lblXO.TabIndex = 0;
            lblXO.Text = "X";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16F);
            button1.Location = new Point(98, 71);
            button1.Name = "button1";
            button1.Size = new Size(65, 56);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += XOXtiklama;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 16F);
            button2.Location = new Point(169, 71);
            button2.Name = "button2";
            button2.Size = new Size(65, 56);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += XOXtiklama;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 16F);
            button3.Location = new Point(240, 71);
            button3.Name = "button3";
            button3.Size = new Size(65, 56);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += XOXtiklama;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 16F);
            button4.Location = new Point(98, 133);
            button4.Name = "button4";
            button4.Size = new Size(65, 55);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = true;
            button4.Click += XOXtiklama;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 16F);
            button5.Location = new Point(169, 133);
            button5.Name = "button5";
            button5.Size = new Size(65, 55);
            button5.TabIndex = 5;
            button5.UseVisualStyleBackColor = true;
            button5.Click += XOXtiklama;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 16F);
            button6.Location = new Point(240, 133);
            button6.Name = "button6";
            button6.Size = new Size(65, 55);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = true;
            button6.Click += XOXtiklama;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 16F);
            button7.Location = new Point(98, 194);
            button7.Name = "button7";
            button7.Size = new Size(65, 55);
            button7.TabIndex = 7;
            button7.UseVisualStyleBackColor = true;
            button7.Click += XOXtiklama;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 16F);
            button8.Location = new Point(169, 194);
            button8.Name = "button8";
            button8.Size = new Size(65, 55);
            button8.TabIndex = 8;
            button8.UseVisualStyleBackColor = true;
            button8.Click += XOXtiklama;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 16F);
            button9.Location = new Point(240, 194);
            button9.Name = "button9";
            button9.Size = new Size(65, 55);
            button9.TabIndex = 9;
            button9.UseVisualStyleBackColor = true;
            button9.Click += XOXtiklama;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 379);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblXO);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblXO;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}

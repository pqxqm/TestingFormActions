namespace ButtonTesting
{
    partial class Form2
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
            ReturnButton1 = new Button();
            NameOutput1 = new Label();
            ModeOutputLabel = new Label();
            SuspendLayout();
            // 
            // ReturnButton1
            // 
            ReturnButton1.Location = new Point(283, 251);
            ReturnButton1.Name = "ReturnButton1";
            ReturnButton1.Size = new Size(148, 59);
            ReturnButton1.TabIndex = 0;
            ReturnButton1.Text = "Return to previous form";
            ReturnButton1.UseVisualStyleBackColor = true;
            ReturnButton1.Click += ReturnButton1_Click;
            // 
            // NameOutput1
            // 
            NameOutput1.AutoSize = true;
            NameOutput1.Location = new Point(146, 144);
            NameOutput1.Name = "NameOutput1";
            NameOutput1.Size = new Size(112, 20);
            NameOutput1.TabIndex = 1;
            NameOutput1.Text = "PLAYERS NAME";
            // 
            // ModeOutputLabel
            // 
            ModeOutputLabel.AutoSize = true;
            ModeOutputLabel.Location = new Point(157, 188);
            ModeOutputLabel.Name = "ModeOutputLabel";
            ModeOutputLabel.Size = new Size(101, 20);
            ModeOutputLabel.TabIndex = 2;
            ModeOutputLabel.Text = "Type of Mode";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ModeOutputLabel);
            Controls.Add(NameOutput1);
            Controls.Add(ReturnButton1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ReturnButton1;
        private Label NameOutput1;
        private Label ModeOutputLabel;
    }
}
namespace ButtonTesting
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
            NextButton1 = new Button();
            NameLabel1 = new Label();
            NameInputText1 = new TextBox();
            SuspendLayout();
            // 
            // NextButton1
            // 
            NextButton1.Location = new Point(279, 287);
            NextButton1.Name = "NextButton1";
            NextButton1.Size = new Size(142, 62);
            NextButton1.TabIndex = 0;
            NextButton1.Text = "Move to Next Form";
            NextButton1.UseVisualStyleBackColor = true;
            NextButton1.Click += MoveButton1_Click;
            // 
            // NameLabel1
            // 
            NameLabel1.AutoSize = true;
            NameLabel1.Location = new Point(98, 104);
            NameLabel1.Name = "NameLabel1";
            NameLabel1.Size = new Size(173, 20);
            NameLabel1.TabIndex = 1;
            NameLabel1.Text = "Please ENTER your name";
            // 
            // NameInputText1
            // 
            NameInputText1.Location = new Point(296, 101);
            NameInputText1.Name = "NameInputText1";
            NameInputText1.Size = new Size(369, 27);
            NameInputText1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NameInputText1);
            Controls.Add(NameLabel1);
            Controls.Add(NextButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NextButton1;
        private Label NameLabel1;
        private TextBox NameInputText1;
    }
}

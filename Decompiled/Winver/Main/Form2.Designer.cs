namespace Main
{
    partial class Terms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Terms));
            MainText = new Label();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // MainText
            // 
            MainText.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainText.Location = new Point(12, 9);
            MainText.Name = "MainText";
            MainText.Size = new Size(271, 76);
            MainText.TabIndex = 0;
            MainText.Text = "To view the Microsoft Software License Terms, please open \"C:\\Windows\\System32\\license.rtf\"";
            MainText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            CloseButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseButton.Location = new Point(116, 88);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(75, 30);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Ok";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // Terms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 121);
            Controls.Add(CloseButton);
            Controls.Add(MainText);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(332, 160);
            MinimumSize = new Size(332, 160);
            Name = "Terms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "License Terms";
            ResumeLayout(false);
        }

        #endregion

        private Label MainText;
        private Button CloseButton;
    }
}
namespace Installer
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            Header = new Label();
            MainText = new Label();
            LeftButton = new Button();
            MiddleButton = new Button();
            RightButton = new Button();
            SuspendLayout();
            // 
            // Header
            // 
            Header.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Header.Location = new Point(12, 9);
            Header.Name = "Header";
            Header.Size = new Size(1025, 55);
            Header.TabIndex = 0;
            Header.Text = "Welcome to the Winver 12 Installer";
            Header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainText
            // 
            MainText.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainText.Location = new Point(12, 113);
            MainText.Name = "MainText";
            MainText.Size = new Size(1025, 294);
            MainText.TabIndex = 1;
            MainText.Text = resources.GetString("MainText.Text");
            MainText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LeftButton
            // 
            LeftButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LeftButton.Location = new Point(12, 594);
            LeftButton.Name = "LeftButton";
            LeftButton.Size = new Size(92, 29);
            LeftButton.TabIndex = 2;
            LeftButton.Text = "Close";
            LeftButton.UseVisualStyleBackColor = true;
            LeftButton.Click += LeftButton_Click;
            // 
            // MiddleButton
            // 
            MiddleButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MiddleButton.Location = new Point(486, 594);
            MiddleButton.Name = "MiddleButton";
            MiddleButton.Size = new Size(92, 29);
            MiddleButton.TabIndex = 3;
            MiddleButton.Text = "Back";
            MiddleButton.UseVisualStyleBackColor = true;
            MiddleButton.Click += MiddleButton_Click;
            // 
            // RightButton
            // 
            RightButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RightButton.Location = new Point(945, 594);
            RightButton.Name = "RightButton";
            RightButton.Size = new Size(92, 29);
            RightButton.TabIndex = 4;
            RightButton.Text = "Next";
            RightButton.UseVisualStyleBackColor = true;
            RightButton.Click += RightButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 635);
            Controls.Add(RightButton);
            Controls.Add(MiddleButton);
            Controls.Add(LeftButton);
            Controls.Add(MainText);
            Controls.Add(Header);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1065, 674);
            MinimumSize = new Size(1065, 674);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Winver 12 Installer";
            Load += Window_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label Header;
        private Label MainText;
        private Button LeftButton;
        private Button MiddleButton;
        private Button RightButton;
    }
}

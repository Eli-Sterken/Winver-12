namespace Main
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            Logo = new PictureBox();
            Header = new Label();
            Underline = new Label();
            MainText = new Label();
            LeftButton = new Button();
            RightButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Logo).BeginInit();
            SuspendLayout();
            // 
            // Logo
            // 
            Logo.ErrorImage = (Image)resources.GetObject("Logo.ErrorImage");
            Logo.Image = (Image)resources.GetObject("Logo.Image");
            Logo.InitialImage = (Image)resources.GetObject("Logo.InitialImage");
            Logo.Location = new Point(12, 12);
            Logo.Name = "Logo";
            Logo.Size = new Size(214, 219);
            Logo.TabIndex = 0;
            Logo.TabStop = false;
            // 
            // Header
            // 
            Header.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Header.ForeColor = Color.Lime;
            Header.Location = new Point(291, 65);
            Header.Name = "Header";
            Header.Size = new Size(478, 107);
            Header.TabIndex = 1;
            Header.Text = "Windows 12";
            Header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Underline
            // 
            Underline.ForeColor = Color.Gray;
            Underline.Location = new Point(-28, 264);
            Underline.Name = "Underline";
            Underline.Size = new Size(868, 23);
            Underline.TabIndex = 2;
            Underline.Text = "________________________________________________________________________________________________________________________________________________________________________________________________________";
            Underline.TextAlign = ContentAlignment.TopCenter;
            // 
            // MainText
            // 
            MainText.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainText.Location = new Point(12, 331);
            MainText.Name = "MainText";
            MainText.Size = new Size(677, 238);
            MainText.TabIndex = 3;
            MainText.Text = resources.GetString("MainText.Text");
            // 
            // LeftButton
            // 
            LeftButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LeftButton.Location = new Point(12, 588);
            LeftButton.Name = "LeftButton";
            LeftButton.Size = new Size(105, 28);
            LeftButton.TabIndex = 4;
            LeftButton.Text = "Close";
            LeftButton.UseVisualStyleBackColor = true;
            LeftButton.Click += LeftButton_Click;
            // 
            // RightButton
            // 
            RightButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RightButton.Location = new Point(648, 588);
            RightButton.Name = "RightButton";
            RightButton.Size = new Size(169, 28);
            RightButton.TabIndex = 5;
            RightButton.Text = "View License Terms";
            RightButton.UseVisualStyleBackColor = true;
            RightButton.Click += RightButton_Click;
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 628);
            Controls.Add(RightButton);
            Controls.Add(LeftButton);
            Controls.Add(MainText);
            Controls.Add(Underline);
            Controls.Add(Header);
            Controls.Add(Logo);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(845, 667);
            MinimumSize = new Size(845, 667);
            Name = "Window";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Windows Version";
            ((System.ComponentModel.ISupportInitialize)Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Logo;
        private Label Header;
        private Label Underline;
        private Label MainText;
        private Button LeftButton;
        private Button RightButton;
    }
}

namespace Installer
{
    public partial class MainWindow : Form
    {
        int Stage = 0; // Set a varible for the installer stage
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            MiddleButton.Visible = false;
        }

        private void MiddleButton_Click(object sender, EventArgs e)
        {
            Stage = 0;
            Header.Text = "Welcome to the Winver 12 Installer";
            MainText.Text = "Hello there, welcome to the Winver 12 Installer!\r\n\r\nThis program will install the all new Winver 12 on your PC.\r\nThis will not replace the origanal winver, it will be installer as \"winver2.\"\r\n\r\nTo get going, click \"Next!\"";
            MiddleButton.Visible = false;
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            if(Stage == 0)
            {
                Stage = 1;
                Header.Text = "Please Note:";
                MainText.Text = "It may be risky to mess with the Winver system.\r\nThis program has not been tested throughly, and may cause errors.\r\nI do not recomend using it on production michenes.\r\n\r\nTo continue, click \"Next.\"";
                MiddleButton.Visible = true;
            } else if(Stage == 1)
            {
                Stage = 2;
                Header.Text = "Sucess";
                MainText.Text = "Winver 12 has been installed sucessfully!\r\n\r\nLaunch it by tying 'winver2' in Run.";
                RightButton.Visible = false;
                MiddleButton.Visible = false;
                File.Copy(@"Files\Main.dll", @"C:\Windows\System32\" + Path.GetFileName(@"Files\Main.dll"));
                File.Copy(@"Files\winver2.exe", @"C:\Windows\System32\" + Path.GetFileName(@"Files\winver2.exe"));
                File.Copy(@"Files\Main.runtimeconfig.json", @"C:\Windows\System32\" + Path.GetFileName(@"Files\Main.runtimeconfig.json"));
            }
        }
    }
}

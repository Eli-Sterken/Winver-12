namespace Main
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            new Terms().Show();
        }
    }
}

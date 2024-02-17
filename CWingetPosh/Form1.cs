namespace CWingetPosh
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WingetProxy.WGList(); 
        }
    }
}

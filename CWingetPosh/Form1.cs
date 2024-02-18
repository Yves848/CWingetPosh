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
            lb1.Items.Clear();
            List<string> list =  WingetProxy.WGList(); 
            foreach (string item in list)
            {
                lb1.Items.Add(item);
            }
        }
    }
}

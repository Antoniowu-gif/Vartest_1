namespace Vartest_1
{
    public partial class S11501020A91 : Form
    {
        public S11501020A91()
        {
            InitializeComponent();
        }

        private void btnclick_Click(object sender, EventArgs e)
        {
            int num1= 100;
            float num2 = 12.34f;
            lblintshow.Text = num1.ToString();
            lblfloatshow.Text = num2.ToString();
            lblstringshow.Text = $"{txtname.Text}，哈囉!";
            lbltimeshow.Text = DateTime.Now.ToString("yyyy/MM/dd tt hh:mm:ss");
        }
    }
}

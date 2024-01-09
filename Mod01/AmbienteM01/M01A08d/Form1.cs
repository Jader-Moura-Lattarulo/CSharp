namespace M01A08d
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtN1.Text);
            int d = num * 2;
            lblMsg.Text = "O dobro de " + num + " é " + d;
            lblMsg.Visible = true;
        }
    }
}

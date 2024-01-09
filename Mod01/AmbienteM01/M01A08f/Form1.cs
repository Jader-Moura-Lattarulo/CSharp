namespace M01A08f
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n = 0;
            int.TryParse(txtNum.Text, out n);
            int d = n * 2;
            lblResult.Text = "O dobro de " + n + " é " + d;
            lblResult.Visible = true;
        }
    }
}

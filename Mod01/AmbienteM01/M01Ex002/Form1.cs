using System.Reflection.Metadata;

namespace M01Ex002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnINICIAR_Click(object sender, EventArgs e)
        {
            lblMsg1.Visible = true; lblMsg2.Visible = true; lblMsg3.Visible = true;
            await Task.Delay(1000);
            lblMsg1.BackColor = Color.Blue;
            lblMsg1.ForeColor = Color.Yellow;
            await Task.Delay(1000);
            lblMsg2.BackColor = Color.Yellow;
            lblMsg2.ForeColor = Color.Green;
            await Task.Delay(1000);
            lblMsg3.BackColor = Color.Green;
            lblMsg3.ForeColor = Color.Yellow;

        }

    }    
}

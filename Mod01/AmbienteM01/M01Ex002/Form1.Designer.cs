
namespace M01Ex002
{
    partial class Form1
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
            lblMsg1 = new Label();
            btnINICIAR = new Button();
            lblMsg2 = new Label();
            lblMsg3 = new Label();
            SuspendLayout();
            // 
            // lblMsg1
            // 
            lblMsg1.AutoSize = true;
            lblMsg1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMsg1.Location = new Point(21, 37);
            lblMsg1.Name = "lblMsg1";
            lblMsg1.Size = new Size(95, 48);
            lblMsg1.TabIndex = 0;
            lblMsg1.Text = "MEU";
            lblMsg1.Visible = false;
            // 
            // btnINICIAR
            // 
            btnINICIAR.Location = new Point(132, 124);
            btnINICIAR.Name = "btnINICIAR";
            btnINICIAR.Size = new Size(196, 60);
            btnINICIAR.TabIndex = 1;
            btnINICIAR.Text = "INICIAR";
            btnINICIAR.UseVisualStyleBackColor = true;
            btnINICIAR.Click += btnINICIAR_Click;
            // 
            // lblMsg2
            // 
            lblMsg2.AutoSize = true;
            lblMsg2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMsg2.Location = new Point(111, 37);
            lblMsg2.Name = "lblMsg2";
            lblMsg2.Size = new Size(132, 48);
            lblMsg2.TabIndex = 2;
            lblMsg2.Text = "BRASIL";
            lblMsg2.Visible = false;
            lblMsg2.Click += label1_Click;
            // 
            // lblMsg3
            // 
            lblMsg3.AutoSize = true;
            lblMsg3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMsg3.Location = new Point(249, 37);
            lblMsg3.Name = "lblMsg3";
            lblMsg3.Size = new Size(209, 48);
            lblMsg3.TabIndex = 3;
            lblMsg3.Text = "BRASILEIRO";
            lblMsg3.Visible = false;
            // 
            // Form1
            // 
            AcceptButton = btnINICIAR;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 196);
            Controls.Add(lblMsg3);
            Controls.Add(lblMsg2);
            Controls.Add(btnINICIAR);
            Controls.Add(lblMsg1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label lblMsg1;
        private Button btnINICIAR;
        private Label lblMsg2;
        private Label lblMsg3;
    }
}

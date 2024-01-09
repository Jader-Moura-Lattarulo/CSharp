namespace M01A08f
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
            label1 = new Label();
            lblResult = new Label();
            txtNum = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 33);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 0;
            label1.Text = "Digite um número:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(44, 156);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(100, 25);
            lblResult.TabIndex = 1;
            lblResult.Text = "Mensagem";
            lblResult.Visible = false;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(211, 33);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(118, 31);
            txtNum.TabIndex = 2;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(211, 82);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(118, 38);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 236);
            Controls.Add(btnCalcular);
            Controls.Add(txtNum);
            Controls.Add(lblResult);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResult;
        private TextBox txtNum;
        private Button btnCalcular;
    }
}

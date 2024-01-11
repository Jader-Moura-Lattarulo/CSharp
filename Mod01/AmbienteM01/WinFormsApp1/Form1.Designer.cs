namespace WinFormsApp1
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
            txtNum = new TextBox();
            button1 = new Button();
            lblTxt01 = new Label();
            lblTxt02 = new Label();
            lblTxt03 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 32);
            label1.Name = "label1";
            label1.Size = new Size(310, 38);
            label1.TabIndex = 0;
            label1.Text = "Digite um número Real:";
            // 
            // txtNum
            // 
            txtNum.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum.Location = new Point(342, 32);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(150, 45);
            txtNum.TabIndex = 1;
            txtNum.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(508, 32);
            button1.Name = "button1";
            button1.Size = new Size(150, 45);
            button1.TabIndex = 2;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblTxt01
            // 
            lblTxt01.AutoSize = true;
            lblTxt01.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTxt01.Location = new Point(26, 99);
            lblTxt01.Name = "lblTxt01";
            lblTxt01.Size = new Size(144, 38);
            lblTxt01.TabIndex = 3;
            lblTxt01.Text = "Análise 01";
            lblTxt01.Visible = false;
            // 
            // lblTxt02
            // 
            lblTxt02.AutoSize = true;
            lblTxt02.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTxt02.Location = new Point(26, 153);
            lblTxt02.Name = "lblTxt02";
            lblTxt02.Size = new Size(144, 38);
            lblTxt02.TabIndex = 4;
            lblTxt02.Text = "Análise 02";
            lblTxt02.Visible = false;
            // 
            // lblTxt03
            // 
            lblTxt03.AutoSize = true;
            lblTxt03.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTxt03.Location = new Point(26, 207);
            lblTxt03.Name = "lblTxt03";
            lblTxt03.Size = new Size(144, 38);
            lblTxt03.TabIndex = 5;
            lblTxt03.Text = "Análise 03";
            lblTxt03.Visible = false;
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 268);
            Controls.Add(lblTxt03);
            Controls.Add(lblTxt02);
            Controls.Add(lblTxt01);
            Controls.Add(button1);
            Controls.Add(txtNum);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Analisador de Números";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum;
        private Button button1;
        private Label lblTxt01;
        private Label lblTxt02;
        private Label lblTxt03;
    }
}

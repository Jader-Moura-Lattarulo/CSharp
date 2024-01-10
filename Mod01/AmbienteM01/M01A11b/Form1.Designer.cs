namespace M01A11b
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
            lblMsg = new Label();
            btnOk = new Button();
            SuspendLayout();
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Location = new Point(44, 43);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(100, 25);
            lblMsg.TabIndex = 0;
            lblMsg.Text = "Mensagem";
            lblMsg.Visible = false;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(154, 168);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(231, 66);
            btnOk.TabIndex = 1;
            btnOk.Text = "Clique em mim";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 304);
            Controls.Add(btnOk);
            Controls.Add(lblMsg);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMsg;
        private Button btnOk;
    }
}

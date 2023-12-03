namespace CompanyManagement.WinForm
{
    partial class ProductUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            lblId = new Label();
            txtSerialNo = new TextBox();
            panel3 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            panel4 = new Panel();
            label2 = new Label();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 561);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblId);
            panel2.Controls.Add(txtSerialNo);
            panel2.Location = new Point(10, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(520, 50);
            panel2.TabIndex = 3;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblId.AutoSize = true;
            lblId.Location = new Point(3, 13);
            lblId.Name = "lblId";
            lblId.Size = new Size(86, 21);
            lblId.TabIndex = 0;
            lblId.Text = "Ürün ID'si :";
            // 
            // txtSerialNo
            // 
            txtSerialNo.Anchor = AnchorStyles.Right;
            txtSerialNo.Location = new Point(123, 10);
            txtSerialNo.Name = "txtSerialNo";
            txtSerialNo.Size = new Size(394, 29);
            txtSerialNo.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(10, 63);
            panel3.Name = "panel3";
            panel3.Size = new Size(520, 50);
            panel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 0;
            label1.Text = "Ürün ID'si :";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Right;
            textBox1.Location = new Point(123, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(394, 29);
            textBox1.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Controls.Add(textBox2);
            panel4.Location = new Point(10, 119);
            panel4.Name = "panel4";
            panel4.Size = new Size(520, 50);
            panel4.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 13);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 0;
            label2.Text = "Ürün ID'si :";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Right;
            textBox2.Location = new Point(123, 10);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(394, 29);
            textBox2.TabIndex = 1;
            // 
            // ProductUpdate
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 561);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "ProductUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Güncelle";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblId;
        private TextBox txtSerialNo;
        private Panel panel4;
        private Label label2;
        private TextBox textBox2;
        private Panel panel3;
        private Label label1;
        private TextBox textBox1;
    }
}
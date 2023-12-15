namespace CompanyManagement.WinForm
{
    partial class ProductDeletePage
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
            label1 = new Label();
            txtProductDelete = new TextBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 95);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // txtProductDelete
            // 
            txtProductDelete.Location = new Point(254, 116);
            txtProductDelete.Name = "txtProductDelete";
            txtProductDelete.Size = new Size(304, 23);
            txtProductDelete.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(601, 146);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 44);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "ÜRÜN SİL";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ProductDeletePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(txtProductDelete);
            Controls.Add(label1);
            Name = "ProductDeletePage";
            Text = "ProductDelete";
            FormClosing += ProductDeletePage_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProductDelete;
        private Button btnDelete;
    }
}
namespace CompanyManagement.WinForm
{
    partial class ProductUpdatePage
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
            btnUpdate = new Button();
            btnClose = new Button();
            btnClear = new Button();
            btnGetById = new Button();
            panel13 = new Panel();
            dtExpiryDate = new DateTimePicker();
            label11 = new Label();
            panel16 = new Panel();
            label14 = new Label();
            txtUnitPrice = new TextBox();
            panel15 = new Panel();
            label13 = new Label();
            txtLastPrice = new TextBox();
            panel14 = new Panel();
            label12 = new Label();
            txtQualityGrade = new TextBox();
            panel12 = new Panel();
            label10 = new Label();
            txtWeightUnit = new TextBox();
            panel11 = new Panel();
            label9 = new Label();
            txtEstWeight = new TextBox();
            panel10 = new Panel();
            label8 = new Label();
            txtQuantityUnit = new TextBox();
            panel9 = new Panel();
            label7 = new Label();
            txtQuantity = new TextBox();
            panel17 = new Panel();
            label15 = new Label();
            txtLenght = new TextBox();
            panel8 = new Panel();
            label6 = new Label();
            txtWidth = new TextBox();
            panel7 = new Panel();
            label5 = new Label();
            txtHeight = new TextBox();
            panel6 = new Panel();
            label4 = new Label();
            txtBrand = new TextBox();
            panel5 = new Panel();
            label3 = new Label();
            txtDescription = new TextBox();
            panel4 = new Panel();
            label2 = new Label();
            txtProductName = new TextBox();
            panel3 = new Panel();
            label1 = new Label();
            txtSerialNo = new TextBox();
            panel2 = new Panel();
            lblId = new Label();
            txtProductId = new TextBox();
            panel1.SuspendLayout();
            panel13.SuspendLayout();
            panel16.SuspendLayout();
            panel15.SuspendLayout();
            panel14.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel17.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnGetById);
            panel1.Controls.Add(panel13);
            panel1.Controls.Add(panel16);
            panel1.Controls.Add(panel15);
            panel1.Controls.Add(panel14);
            panel1.Controls.Add(panel12);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel17);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1095, 536);
            panel1.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(764, 468);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(157, 43);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1095, 536);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(0, 0);
            btnClose.TabIndex = 16;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(927, 468);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(157, 43);
            btnClear.TabIndex = 16;
            btnClear.Text = "Temizle";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnGetById
            // 
            btnGetById.Location = new Point(362, 63);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(168, 39);
            btnGetById.TabIndex = 0;
            btnGetById.Text = "Ürün Bilgilerini Getir";
            btnGetById.UseVisualStyleBackColor = true;
            btnGetById.Click += btnGetById_Click;
            // 
            // panel13
            // 
            panel13.Controls.Add(dtExpiryDate);
            panel13.Controls.Add(label11);
            panel13.Location = new Point(564, 231);
            panel13.Name = "panel13";
            panel13.Size = new Size(520, 50);
            panel13.TabIndex = 11;
            // 
            // dtExpiryDate
            // 
            dtExpiryDate.Location = new Point(163, 10);
            dtExpiryDate.Name = "dtExpiryDate";
            dtExpiryDate.Size = new Size(354, 29);
            dtExpiryDate.TabIndex = 11;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Location = new Point(3, 13);
            label11.Name = "label11";
            label11.Size = new Size(154, 21);
            label11.TabIndex = 11;
            label11.Text = "Son Kullanma Tarihi :";
            // 
            // panel16
            // 
            panel16.Controls.Add(label14);
            panel16.Controls.Add(txtUnitPrice);
            panel16.Location = new Point(564, 399);
            panel16.Name = "panel16";
            panel16.Size = new Size(520, 50);
            panel16.TabIndex = 15;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label14.AutoSize = true;
            label14.Location = new Point(3, 13);
            label14.Name = "label14";
            label14.Size = new Size(102, 21);
            label14.TabIndex = 15;
            label14.Text = "Güncel Fiyat :";
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Anchor = AnchorStyles.Right;
            txtUnitPrice.Location = new Point(177, 10);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(340, 29);
            txtUnitPrice.TabIndex = 15;
            // 
            // panel15
            // 
            panel15.Controls.Add(label13);
            panel15.Controls.Add(txtLastPrice);
            panel15.Location = new Point(564, 343);
            panel15.Name = "panel15";
            panel15.Size = new Size(520, 50);
            panel15.TabIndex = 14;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label13.AutoSize = true;
            label13.Location = new Point(3, 13);
            label13.Name = "label13";
            label13.Size = new Size(168, 21);
            label13.TabIndex = 14;
            label13.Text = "Son Satın Alınan Fiyat :";
            // 
            // txtLastPrice
            // 
            txtLastPrice.Anchor = AnchorStyles.Right;
            txtLastPrice.Location = new Point(177, 10);
            txtLastPrice.Name = "txtLastPrice";
            txtLastPrice.Size = new Size(340, 29);
            txtLastPrice.TabIndex = 14;
            // 
            // panel14
            // 
            panel14.Controls.Add(label12);
            panel14.Controls.Add(txtQualityGrade);
            panel14.Location = new Point(564, 287);
            panel14.Name = "panel14";
            panel14.Size = new Size(520, 50);
            panel14.TabIndex = 13;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Location = new Point(3, 13);
            label12.Name = "label12";
            label12.Size = new Size(55, 21);
            label12.TabIndex = 13;
            label12.Text = "Kalite :";
            // 
            // txtQualityGrade
            // 
            txtQualityGrade.Anchor = AnchorStyles.Right;
            txtQualityGrade.Location = new Point(123, 10);
            txtQualityGrade.Name = "txtQualityGrade";
            txtQualityGrade.Size = new Size(394, 29);
            txtQualityGrade.TabIndex = 13;
            // 
            // panel12
            // 
            panel12.Controls.Add(label10);
            panel12.Controls.Add(txtWeightUnit);
            panel12.Location = new Point(564, 175);
            panel12.Name = "panel12";
            panel12.Size = new Size(520, 50);
            panel12.TabIndex = 11;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Location = new Point(3, 13);
            label10.Name = "label10";
            label10.Size = new Size(107, 21);
            label10.TabIndex = 11;
            label10.Text = "Ağırlık Birimi :";
            // 
            // txtWeightUnit
            // 
            txtWeightUnit.Anchor = AnchorStyles.Right;
            txtWeightUnit.Location = new Point(123, 10);
            txtWeightUnit.Name = "txtWeightUnit";
            txtWeightUnit.Size = new Size(394, 29);
            txtWeightUnit.TabIndex = 11;
            // 
            // panel11
            // 
            panel11.Controls.Add(label9);
            panel11.Controls.Add(txtEstWeight);
            panel11.Location = new Point(564, 119);
            panel11.Name = "panel11";
            panel11.Size = new Size(520, 50);
            panel11.TabIndex = 10;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(3, 13);
            label9.Name = "label9";
            label9.Size = new Size(92, 21);
            label9.TabIndex = 10;
            label9.Text = "Ort. Ağırlık :";
            // 
            // txtEstWeight
            // 
            txtEstWeight.Anchor = AnchorStyles.Right;
            txtEstWeight.Location = new Point(123, 10);
            txtEstWeight.Name = "txtEstWeight";
            txtEstWeight.Size = new Size(394, 29);
            txtEstWeight.TabIndex = 10;
            // 
            // panel10
            // 
            panel10.Controls.Add(label8);
            panel10.Controls.Add(txtQuantityUnit);
            panel10.Location = new Point(564, 63);
            panel10.Name = "panel10";
            panel10.Size = new Size(520, 50);
            panel10.TabIndex = 9;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Location = new Point(3, 13);
            label8.Name = "label8";
            label8.Size = new Size(107, 21);
            label8.TabIndex = 9;
            label8.Text = "Miktar Birimi :";
            // 
            // txtQuantityUnit
            // 
            txtQuantityUnit.Anchor = AnchorStyles.Right;
            txtQuantityUnit.Location = new Point(123, 10);
            txtQuantityUnit.Name = "txtQuantityUnit";
            txtQuantityUnit.Size = new Size(394, 29);
            txtQuantityUnit.TabIndex = 9;
            // 
            // panel9
            // 
            panel9.Controls.Add(label7);
            panel9.Controls.Add(txtQuantity);
            panel9.Location = new Point(564, 7);
            panel9.Name = "panel9";
            panel9.Size = new Size(520, 50);
            panel9.TabIndex = 8;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(3, 13);
            label7.Name = "label7";
            label7.Size = new Size(62, 21);
            label7.TabIndex = 8;
            label7.Text = "Miktar :";
            // 
            // txtQuantity
            // 
            txtQuantity.Anchor = AnchorStyles.Right;
            txtQuantity.Location = new Point(123, 10);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(394, 29);
            txtQuantity.TabIndex = 8;
            // 
            // panel17
            // 
            panel17.Controls.Add(label15);
            panel17.Controls.Add(txtLenght);
            panel17.Location = new Point(10, 455);
            panel17.Name = "panel17";
            panel17.Size = new Size(520, 50);
            panel17.TabIndex = 7;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label15.AutoSize = true;
            label15.Location = new Point(3, 13);
            label15.Name = "label15";
            label15.Size = new Size(72, 21);
            label15.TabIndex = 7;
            label15.Text = "Genişlik :";
            // 
            // txtLenght
            // 
            txtLenght.Anchor = AnchorStyles.Right;
            txtLenght.Location = new Point(123, 10);
            txtLenght.Name = "txtLenght";
            txtLenght.Size = new Size(394, 29);
            txtLenght.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.Controls.Add(label6);
            panel8.Controls.Add(txtWidth);
            panel8.Location = new Point(10, 399);
            panel8.Name = "panel8";
            panel8.Size = new Size(520, 50);
            panel8.TabIndex = 7;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(3, 13);
            label6.Name = "label6";
            label6.Size = new Size(72, 21);
            label6.TabIndex = 7;
            label6.Text = "Genişlik :";
            // 
            // txtWidth
            // 
            txtWidth.Anchor = AnchorStyles.Right;
            txtWidth.Location = new Point(123, 10);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(394, 29);
            txtWidth.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.Controls.Add(label5);
            panel7.Controls.Add(txtHeight);
            panel7.Location = new Point(10, 343);
            panel7.Name = "panel7";
            panel7.Size = new Size(520, 50);
            panel7.TabIndex = 6;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(3, 13);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 6;
            label5.Text = "Yükseklik : ";
            // 
            // txtHeight
            // 
            txtHeight.Anchor = AnchorStyles.Right;
            txtHeight.Location = new Point(123, 10);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(394, 29);
            txtHeight.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.Controls.Add(label4);
            panel6.Controls.Add(txtBrand);
            panel6.Location = new Point(10, 287);
            panel6.Name = "panel6";
            panel6.Size = new Size(520, 50);
            panel6.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 13);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 5;
            label4.Text = "Marka :";
            // 
            // txtBrand
            // 
            txtBrand.Anchor = AnchorStyles.Right;
            txtBrand.Location = new Point(123, 10);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(394, 29);
            txtBrand.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.Controls.Add(label3);
            panel5.Controls.Add(txtDescription);
            panel5.Location = new Point(10, 231);
            panel5.Name = "panel5";
            panel5.Size = new Size(520, 50);
            panel5.TabIndex = 4;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(3, 13);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 4;
            label3.Text = "Açıklama :";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Right;
            txtDescription.Location = new Point(123, 10);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(394, 29);
            txtDescription.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txtProductName);
            panel4.Location = new Point(10, 175);
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
            label2.Size = new Size(79, 21);
            label2.TabIndex = 3;
            label2.Text = "Ürün Adı :";
            // 
            // txtProductName
            // 
            txtProductName.Anchor = AnchorStyles.Right;
            txtProductName.Location = new Point(123, 10);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(394, 29);
            txtProductName.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtSerialNo);
            panel3.Location = new Point(10, 119);
            panel3.Name = "panel3";
            panel3.Size = new Size(520, 50);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 2;
            label1.Text = "Seri Numarası :";
            // 
            // txtSerialNo
            // 
            txtSerialNo.Anchor = AnchorStyles.Right;
            txtSerialNo.Location = new Point(123, 10);
            txtSerialNo.Name = "txtSerialNo";
            txtSerialNo.Size = new Size(394, 29);
            txtSerialNo.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblId);
            panel2.Controls.Add(txtProductId);
            panel2.Location = new Point(10, 7);
            panel2.Name = "panel2";
            panel2.Size = new Size(520, 50);
            panel2.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lblId.AutoSize = true;
            lblId.Location = new Point(3, 13);
            lblId.Name = "lblId";
            lblId.Size = new Size(86, 21);
            lblId.TabIndex = 1;
            lblId.Text = "Ürün ID'si :";
            // 
            // txtProductId
            // 
            txtProductId.Anchor = AnchorStyles.Right;
            txtProductId.Location = new Point(123, 10);
            txtProductId.Name = "txtProductId";
            txtProductId.PlaceholderText = "Ürün bilgilerini görmek için ürünün id'sini girin...";
            txtProductId.Size = new Size(394, 29);
            txtProductId.TabIndex = 1;
            // 
            // ProductUpdatePage
            // 
            AcceptButton = btnUpdate;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(1095, 536);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductUpdatePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Güncelle";
            panel1.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel17.ResumeLayout(false);
            panel17.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblId;
        private TextBox txtProductId;
        private Panel panel4;
        private Label label2;
        private TextBox txtProductName;
        private Panel panel3;
        private Label label1;
        private TextBox txtSerialNo;
        private Panel panel6;
        private Label label4;
        private TextBox txtBrand;
        private Panel panel5;
        private Label label3;
        private TextBox txtDescription;
        private Panel panel9;
        private Label label7;
        private TextBox txtQuantity;
        private Panel panel8;
        private Label label6;
        private TextBox txtWidth;
        private Panel panel7;
        private Label label5;
        private TextBox txtHeight;
        private Panel panel11;
        private Label label9;
        private TextBox txtEstWeight;
        private Panel panel10;
        private Label label8;
        private TextBox txtQuantityUnit;
        private Panel panel13;
        private DateTimePicker dtExpiryDate;
        private Label label11;
        private Panel panel16;
        private Label label14;
        private TextBox txtUnitPrice;
        private Panel panel15;
        private Label label13;
        private TextBox txtLastPrice;
        private Panel panel14;
        private Label label12;
        private TextBox txtQualityGrade;
        private Panel panel12;
        private Label label10;
        private TextBox txtWeightUnit;
        private Button btnGetById;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnClose;
        private Panel panel17;
        private Label label15;
        private TextBox txtLenght;
    }
}
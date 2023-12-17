namespace CompanyManagement.WinForm
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            button1 = new Button();
            productPageNavbar = new MenuStrip();
            UrunEkleToolStripMenuItem = new ToolStripMenuItem();
            UrunCikarToolStripMenuItem = new ToolStripMenuItem();
            UrunGuncelleToolStripMenuItem = new ToolStripMenuItem();
            UploadExcelFile = new ToolStripMenuItem();
            pnlProductListTable = new Panel();
            btnRefreshTable = new Button();
            productListTable = new DataGridView();
            productPageNavbar.SuspendLayout();
            pnlProductListTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productListTable).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            // 
            // productPageNavbar
            // 
            productPageNavbar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            productPageNavbar.Items.AddRange(new ToolStripItem[] { UrunEkleToolStripMenuItem, UrunCikarToolStripMenuItem, UrunGuncelleToolStripMenuItem, UploadExcelFile });
            productPageNavbar.Location = new Point(0, 0);
            productPageNavbar.Name = "productPageNavbar";
            productPageNavbar.Size = new Size(1384, 29);
            productPageNavbar.TabIndex = 2;
            productPageNavbar.Text = "menuStrip1";
            // 
            // UrunEkleToolStripMenuItem
            // 
            UrunEkleToolStripMenuItem.Name = "UrunEkleToolStripMenuItem";
            UrunEkleToolStripMenuItem.Size = new Size(111, 25);
            UrunEkleToolStripMenuItem.Text = "Ürün Ekleme";
            UrunEkleToolStripMenuItem.Click += UrunEkleToolStripMenuItem_Click;
            // 
            // UrunCikarToolStripMenuItem
            // 
            UrunCikarToolStripMenuItem.Name = "UrunCikarToolStripMenuItem";
            UrunCikarToolStripMenuItem.Size = new Size(100, 25);
            UrunCikarToolStripMenuItem.Text = "Ürün Silme";
            UrunCikarToolStripMenuItem.Click += UrunCikarToolStripMenuItem_Click;
            // 
            // UrunGuncelleToolStripMenuItem
            // 
            UrunGuncelleToolStripMenuItem.Name = "UrunGuncelleToolStripMenuItem";
            UrunGuncelleToolStripMenuItem.Size = new Size(143, 25);
            UrunGuncelleToolStripMenuItem.Text = "Ürün Güncelleme";
            UrunGuncelleToolStripMenuItem.Click += UrunGuncelleToolStripMenuItem_Click;
            // 
            // UploadExcelFile
            // 
            UploadExcelFile.Name = "UploadExcelFile";
            UploadExcelFile.Size = new Size(178, 25);
            UploadExcelFile.Text = "Excel Dosyası Yükleme";
            // 
            // pnlProductListTable
            // 
            pnlProductListTable.Controls.Add(btnRefreshTable);
            pnlProductListTable.Controls.Add(productListTable);
            pnlProductListTable.Dock = DockStyle.Fill;
            pnlProductListTable.Location = new Point(0, 29);
            pnlProductListTable.Name = "pnlProductListTable";
            pnlProductListTable.Size = new Size(1384, 632);
            pnlProductListTable.TabIndex = 1;
            // 
            // btnRefreshTable
            // 
            btnRefreshTable.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefreshTable.Image = (Image)resources.GetObject("btnRefreshTable.Image");
            btnRefreshTable.Location = new Point(1322, 3);
            btnRefreshTable.Name = "btnRefreshTable";
            btnRefreshTable.Size = new Size(50, 50);
            btnRefreshTable.TabIndex = 3;
            btnRefreshTable.UseVisualStyleBackColor = true;
            btnRefreshTable.Click += btnRefreshTable_Click;
            // 
            // productListTable
            // 
            productListTable.AllowUserToAddRows = false;
            productListTable.AllowUserToDeleteRows = false;
            productListTable.AllowUserToOrderColumns = true;
            productListTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productListTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productListTable.BackgroundColor = SystemColors.Control;
            productListTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productListTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            productListTable.Location = new Point(0, 59);
            productListTable.MultiSelect = false;
            productListTable.Name = "productListTable";
            productListTable.ReadOnly = true;
            productListTable.RowTemplate.Height = 25;
            productListTable.SelectionMode = DataGridViewSelectionMode.CellSelect;
            productListTable.Size = new Size(1384, 573);
            productListTable.TabIndex = 4;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1384, 661);
            Controls.Add(pnlProductListTable);
            Controls.Add(productPageNavbar);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Yönetim v0.1";
            FormClosing += ProductPageForm_FormClosing;
            Load += ProductPageForm_Load;
            productPageNavbar.ResumeLayout(false);
            productPageNavbar.PerformLayout();
            pnlProductListTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productListTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MenuStrip productPageNavbar;
        private ToolStripMenuItem UrunEkleToolStripMenuItem;
        private ToolStripMenuItem UrunCikarToolStripMenuItem;
        private ToolStripMenuItem UrunGuncelleToolStripMenuItem;
        private Panel pnlProductListTable;
        public DataGridView productListTable;
        private Button btnRefreshTable;
        private ToolStripMenuItem UploadExcelFile;
    }
}

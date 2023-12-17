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
            UrunSilmeToolStripMenuItem = new ToolStripMenuItem();
            UrunGuncelleToolStripMenuItem = new ToolStripMenuItem();
            UploadExcelFile = new ToolStripMenuItem();
            pnlProductListTable = new Panel();
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
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
            productPageNavbar.Items.AddRange(new ToolStripItem[] { UrunEkleToolStripMenuItem, UrunSilmeToolStripMenuItem, UrunGuncelleToolStripMenuItem, UploadExcelFile });
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
            // UrunSilmeToolStripMenuItem
            // 
            UrunSilmeToolStripMenuItem.Name = "UrunSilmeToolStripMenuItem";
            UrunSilmeToolStripMenuItem.Size = new Size(100, 25);
            UrunSilmeToolStripMenuItem.Text = "Ürün Silme";
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
            pnlProductListTable.Controls.Add(btnCreate);
            pnlProductListTable.Controls.Add(btnDelete);
            pnlProductListTable.Controls.Add(btnUpdate);
            pnlProductListTable.Controls.Add(btnRefreshTable);
            pnlProductListTable.Controls.Add(productListTable);
            pnlProductListTable.Dock = DockStyle.Fill;
            pnlProductListTable.Location = new Point(0, 29);
            pnlProductListTable.Name = "pnlProductListTable";
            pnlProductListTable.Size = new Size(1384, 632);
            pnlProductListTable.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreate.Image = (Image)resources.GetObject("btnCreate.Image");
            btnCreate.Location = new Point(1154, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(50, 50);
            btnCreate.TabIndex = 3;
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(1210, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(50, 50);
            btnDelete.TabIndex = 3;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.Location = new Point(1266, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(50, 50);
            btnUpdate.TabIndex = 3;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
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
            ShowIcon = false;
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
        private ToolStripMenuItem UrunSilmeToolStripMenuItem;
        private ToolStripMenuItem UrunGuncelleToolStripMenuItem;
        private Panel pnlProductListTable;
        public DataGridView productListTable;
        private Button btnRefreshTable;
        private ToolStripMenuItem UploadExcelFile;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
    }
}

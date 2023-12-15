namespace CompanyManagement.WinForm
{
    partial class productPageForm
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
            button1 = new Button();
            productPageNavbar = new MenuStrip();
            ürünEkleToolStripMenuItem = new ToolStripMenuItem();
            ürünÇıkarToolStripMenuItem = new ToolStripMenuItem();
            ürünGüncelleToolStripMenuItem = new ToolStripMenuItem();
            ürünListesiniYenileToolStripMenuItem = new ToolStripMenuItem();
            pnlProductListTable = new Panel();
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
            productPageNavbar.Items.AddRange(new ToolStripItem[] { ürünEkleToolStripMenuItem, ürünÇıkarToolStripMenuItem, ürünGüncelleToolStripMenuItem, ürünListesiniYenileToolStripMenuItem });
            productPageNavbar.Location = new Point(0, 0);
            productPageNavbar.Name = "productPageNavbar";
            productPageNavbar.Size = new Size(1384, 29);
            productPageNavbar.TabIndex = 3;
            productPageNavbar.Text = "menuStrip1";
            // 
            // ürünEkleToolStripMenuItem
            // 
            ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            ürünEkleToolStripMenuItem.Size = new Size(89, 25);
            ürünEkleToolStripMenuItem.Text = "Ürün Ekle";
            ürünEkleToolStripMenuItem.Click += ürünEkleToolStripMenuItem_Click;
            // 
            // ürünÇıkarToolStripMenuItem
            // 
            ürünÇıkarToolStripMenuItem.Name = "ürünÇıkarToolStripMenuItem";
            ürünÇıkarToolStripMenuItem.Size = new Size(97, 25);
            ürünÇıkarToolStripMenuItem.Text = "Ürün Çıkar";
            ürünÇıkarToolStripMenuItem.Click += ürünÇıkarToolStripMenuItem_Click;
            // 
            // ürünGüncelleToolStripMenuItem
            // 
            ürünGüncelleToolStripMenuItem.Name = "ürünGüncelleToolStripMenuItem";
            ürünGüncelleToolStripMenuItem.Size = new Size(121, 25);
            ürünGüncelleToolStripMenuItem.Text = "Ürün Güncelle";
            // 
            // ürünListesiniYenileToolStripMenuItem
            // 
            ürünListesiniYenileToolStripMenuItem.Name = "ürünListesiniYenileToolStripMenuItem";
            ürünListesiniYenileToolStripMenuItem.Size = new Size(162, 25);
            ürünListesiniYenileToolStripMenuItem.Text = "Ürün Listesini Yenile";
            ürünListesiniYenileToolStripMenuItem.Click += ürünListesiniYenileToolStripMenuItem_Click;
            // 
            // pnlProductListTable
            // 
            pnlProductListTable.Controls.Add(productListTable);
            pnlProductListTable.Dock = DockStyle.Fill;
            pnlProductListTable.Location = new Point(0, 29);
            pnlProductListTable.Name = "pnlProductListTable";
            pnlProductListTable.Size = new Size(1384, 632);
            pnlProductListTable.TabIndex = 5;
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
            productListTable.Location = new Point(0, 0);
            productListTable.MultiSelect = false;
            productListTable.Name = "productListTable";
            productListTable.ReadOnly = true;
            productListTable.RowTemplate.Height = 25;
            productListTable.SelectionMode = DataGridViewSelectionMode.CellSelect;
            productListTable.Size = new Size(1384, 632);
            productListTable.TabIndex = 0;
            // 
            // productPageForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 661);
            Controls.Add(pnlProductListTable);
            Controls.Add(productPageNavbar);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            Name = "productPageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stok Yönetim v0.1";
            Load += productPageForm_Load;
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
        private ToolStripMenuItem ürünEkleToolStripMenuItem;
        private ToolStripMenuItem ürünÇıkarToolStripMenuItem;
        private ToolStripMenuItem ürünGüncelleToolStripMenuItem;
        private ToolStripMenuItem ürünListesiniYenileToolStripMenuItem;
        private Panel pnlProductListTable;
        public DataGridView productListTable;
    }
}

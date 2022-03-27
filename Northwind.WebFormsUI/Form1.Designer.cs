
namespace Northwind.WebFormsUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProduct = new System.Windows.Forms.GroupBox();
            this.tbxProduct = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxQuantityPerUnitAdd = new System.Windows.Forms.TextBox();
            this.tbxStockAdd = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceAdd = new System.Windows.Forms.TextBox();
            this.cbxCategoryAdd = new System.Windows.Forms.ComboBox();
            this.tbxProductNameAdd = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnitAdd = new System.Windows.Forms.Label();
            this.lblStockAdd = new System.Windows.Forms.Label();
            this.lblUnitPriceAdd = new System.Windows.Forms.Label();
            this.lblCategoryIdAdd = new System.Windows.Forms.Label();
            this.lblProductNameAdd = new System.Windows.Forms.Label();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxQuantityUpd = new System.Windows.Forms.TextBox();
            this.tbxStockAmountUpd = new System.Windows.Forms.TextBox();
            this.tbxPriceUpd = new System.Windows.Forms.TextBox();
            this.cbxCategoryUpd = new System.Windows.Forms.ComboBox();
            this.tbxProductNameUpd = new System.Windows.Forms.TextBox();
            this.lblQuantityUpd = new System.Windows.Forms.Label();
            this.lblStockAmountUpd = new System.Windows.Forms.Label();
            this.lblPriceUpd = new System.Windows.Forms.Label();
            this.lblCategoryUpd = new System.Windows.Forms.Label();
            this.lblProductNameUpd = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProduct.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(16, 164);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(772, 154);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(16, 9);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(772, 53);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye göre ara";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(76, 19);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(169, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(15, 22);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori : ";
            // 
            // gbxProduct
            // 
            this.gbxProduct.Controls.Add(this.btnDelete);
            this.gbxProduct.Controls.Add(this.tbxProduct);
            this.gbxProduct.Controls.Add(this.lblProduct);
            this.gbxProduct.Location = new System.Drawing.Point(16, 83);
            this.gbxProduct.Name = "gbxProduct";
            this.gbxProduct.Size = new System.Drawing.Size(772, 53);
            this.gbxProduct.TabIndex = 2;
            this.gbxProduct.TabStop = false;
            this.gbxProduct.Text = "Ürüne göre ara";
            // 
            // tbxProduct
            // 
            this.tbxProduct.Location = new System.Drawing.Point(76, 19);
            this.tbxProduct.Name = "tbxProduct";
            this.tbxProduct.Size = new System.Drawing.Size(169, 20);
            this.tbxProduct.TabIndex = 1;
            this.tbxProduct.TextChanged += new System.EventHandler(this.tbxProduct_TextChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(15, 22);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(39, 13);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Ürün : ";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnitAdd);
            this.gbxProductAdd.Controls.Add(this.tbxStockAdd);
            this.gbxProductAdd.Controls.Add(this.tbxUnitPriceAdd);
            this.gbxProductAdd.Controls.Add(this.cbxCategoryAdd);
            this.gbxProductAdd.Controls.Add(this.tbxProductNameAdd);
            this.gbxProductAdd.Controls.Add(this.lblQuantityPerUnitAdd);
            this.gbxProductAdd.Controls.Add(this.lblStockAdd);
            this.gbxProductAdd.Controls.Add(this.lblUnitPriceAdd);
            this.gbxProductAdd.Controls.Add(this.lblCategoryIdAdd);
            this.gbxProductAdd.Controls.Add(this.lblProductNameAdd);
            this.gbxProductAdd.Location = new System.Drawing.Point(16, 338);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(363, 100);
            this.gbxProductAdd.TabIndex = 3;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Yeni ürün ekle";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(189, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxQuantityPerUnitAdd
            // 
            this.tbxQuantityPerUnitAdd.Location = new System.Drawing.Point(260, 42);
            this.tbxQuantityPerUnitAdd.Name = "tbxQuantityPerUnitAdd";
            this.tbxQuantityPerUnitAdd.Size = new System.Drawing.Size(87, 20);
            this.tbxQuantityPerUnitAdd.TabIndex = 9;
            // 
            // tbxStockAdd
            // 
            this.tbxStockAdd.Location = new System.Drawing.Point(260, 16);
            this.tbxStockAdd.Name = "tbxStockAdd";
            this.tbxStockAdd.Size = new System.Drawing.Size(87, 20);
            this.tbxStockAdd.TabIndex = 8;
            // 
            // tbxUnitPriceAdd
            // 
            this.tbxUnitPriceAdd.Location = new System.Drawing.Point(79, 70);
            this.tbxUnitPriceAdd.Name = "tbxUnitPriceAdd";
            this.tbxUnitPriceAdd.Size = new System.Drawing.Size(87, 20);
            this.tbxUnitPriceAdd.TabIndex = 7;
            // 
            // cbxCategoryAdd
            // 
            this.cbxCategoryAdd.FormattingEnabled = true;
            this.cbxCategoryAdd.Location = new System.Drawing.Point(79, 42);
            this.cbxCategoryAdd.Name = "cbxCategoryAdd";
            this.cbxCategoryAdd.Size = new System.Drawing.Size(87, 21);
            this.cbxCategoryAdd.TabIndex = 6;
            // 
            // tbxProductNameAdd
            // 
            this.tbxProductNameAdd.Location = new System.Drawing.Point(79, 16);
            this.tbxProductNameAdd.Name = "tbxProductNameAdd";
            this.tbxProductNameAdd.Size = new System.Drawing.Size(87, 20);
            this.tbxProductNameAdd.TabIndex = 5;
            // 
            // lblQuantityPerUnitAdd
            // 
            this.lblQuantityPerUnitAdd.AutoSize = true;
            this.lblQuantityPerUnitAdd.Location = new System.Drawing.Point(186, 45);
            this.lblQuantityPerUnitAdd.Name = "lblQuantityPerUnitAdd";
            this.lblQuantityPerUnitAdd.Size = new System.Drawing.Size(68, 13);
            this.lblQuantityPerUnitAdd.TabIndex = 4;
            this.lblQuantityPerUnitAdd.Text = "Birim Adedi : ";
            // 
            // lblStockAdd
            // 
            this.lblStockAdd.AutoSize = true;
            this.lblStockAdd.Location = new System.Drawing.Point(186, 19);
            this.lblStockAdd.Name = "lblStockAdd";
            this.lblStockAdd.Size = new System.Drawing.Size(68, 13);
            this.lblStockAdd.TabIndex = 3;
            this.lblStockAdd.Text = "Stok Adedi : ";
            // 
            // lblUnitPriceAdd
            // 
            this.lblUnitPriceAdd.AutoSize = true;
            this.lblUnitPriceAdd.Location = new System.Drawing.Point(27, 73);
            this.lblUnitPriceAdd.Name = "lblUnitPriceAdd";
            this.lblUnitPriceAdd.Size = new System.Drawing.Size(38, 13);
            this.lblUnitPriceAdd.TabIndex = 2;
            this.lblUnitPriceAdd.Text = "Fiyat : ";
            // 
            // lblCategoryIdAdd
            // 
            this.lblCategoryIdAdd.AutoSize = true;
            this.lblCategoryIdAdd.Location = new System.Drawing.Point(18, 45);
            this.lblCategoryIdAdd.Name = "lblCategoryIdAdd";
            this.lblCategoryIdAdd.Size = new System.Drawing.Size(55, 13);
            this.lblCategoryIdAdd.TabIndex = 1;
            this.lblCategoryIdAdd.Text = "Kategori : ";
            // 
            // lblProductNameAdd
            // 
            this.lblProductNameAdd.AutoSize = true;
            this.lblProductNameAdd.Location = new System.Drawing.Point(16, 19);
            this.lblProductNameAdd.Name = "lblProductNameAdd";
            this.lblProductNameAdd.Size = new System.Drawing.Size(57, 13);
            this.lblProductNameAdd.TabIndex = 0;
            this.lblProductNameAdd.Text = "Ürün Adı : ";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxQuantityUpd);
            this.gbxUpdate.Controls.Add(this.tbxStockAmountUpd);
            this.gbxUpdate.Controls.Add(this.tbxPriceUpd);
            this.gbxUpdate.Controls.Add(this.cbxCategoryUpd);
            this.gbxUpdate.Controls.Add(this.tbxProductNameUpd);
            this.gbxUpdate.Controls.Add(this.lblQuantityUpd);
            this.gbxUpdate.Controls.Add(this.lblStockAmountUpd);
            this.gbxUpdate.Controls.Add(this.lblPriceUpd);
            this.gbxUpdate.Controls.Add(this.lblCategoryUpd);
            this.gbxUpdate.Controls.Add(this.lblProductNameUpd);
            this.gbxUpdate.Location = new System.Drawing.Point(425, 338);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(363, 100);
            this.gbxUpdate.TabIndex = 4;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Ürün güncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(189, 68);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxQuantityUpd
            // 
            this.tbxQuantityUpd.Location = new System.Drawing.Point(260, 42);
            this.tbxQuantityUpd.Name = "tbxQuantityUpd";
            this.tbxQuantityUpd.Size = new System.Drawing.Size(87, 20);
            this.tbxQuantityUpd.TabIndex = 9;
            // 
            // tbxStockAmountUpd
            // 
            this.tbxStockAmountUpd.Location = new System.Drawing.Point(260, 16);
            this.tbxStockAmountUpd.Name = "tbxStockAmountUpd";
            this.tbxStockAmountUpd.Size = new System.Drawing.Size(87, 20);
            this.tbxStockAmountUpd.TabIndex = 8;
            // 
            // tbxPriceUpd
            // 
            this.tbxPriceUpd.AcceptsReturn = true;
            this.tbxPriceUpd.Location = new System.Drawing.Point(79, 70);
            this.tbxPriceUpd.Name = "tbxPriceUpd";
            this.tbxPriceUpd.Size = new System.Drawing.Size(87, 20);
            this.tbxPriceUpd.TabIndex = 7;
            // 
            // cbxCategoryUpd
            // 
            this.cbxCategoryUpd.FormattingEnabled = true;
            this.cbxCategoryUpd.Location = new System.Drawing.Point(79, 42);
            this.cbxCategoryUpd.Name = "cbxCategoryUpd";
            this.cbxCategoryUpd.Size = new System.Drawing.Size(87, 21);
            this.cbxCategoryUpd.TabIndex = 6;
            // 
            // tbxProductNameUpd
            // 
            this.tbxProductNameUpd.Location = new System.Drawing.Point(79, 16);
            this.tbxProductNameUpd.Name = "tbxProductNameUpd";
            this.tbxProductNameUpd.Size = new System.Drawing.Size(87, 20);
            this.tbxProductNameUpd.TabIndex = 5;
            // 
            // lblQuantityUpd
            // 
            this.lblQuantityUpd.AutoSize = true;
            this.lblQuantityUpd.Location = new System.Drawing.Point(186, 45);
            this.lblQuantityUpd.Name = "lblQuantityUpd";
            this.lblQuantityUpd.Size = new System.Drawing.Size(68, 13);
            this.lblQuantityUpd.TabIndex = 4;
            this.lblQuantityUpd.Text = "Birim Adedi : ";
            // 
            // lblStockAmountUpd
            // 
            this.lblStockAmountUpd.AutoSize = true;
            this.lblStockAmountUpd.Location = new System.Drawing.Point(186, 19);
            this.lblStockAmountUpd.Name = "lblStockAmountUpd";
            this.lblStockAmountUpd.Size = new System.Drawing.Size(68, 13);
            this.lblStockAmountUpd.TabIndex = 3;
            this.lblStockAmountUpd.Text = "Stok Adedi : ";
            // 
            // lblPriceUpd
            // 
            this.lblPriceUpd.AutoSize = true;
            this.lblPriceUpd.Location = new System.Drawing.Point(27, 73);
            this.lblPriceUpd.Name = "lblPriceUpd";
            this.lblPriceUpd.Size = new System.Drawing.Size(38, 13);
            this.lblPriceUpd.TabIndex = 2;
            this.lblPriceUpd.Text = "Fiyat : ";
            // 
            // lblCategoryUpd
            // 
            this.lblCategoryUpd.AutoSize = true;
            this.lblCategoryUpd.Location = new System.Drawing.Point(18, 45);
            this.lblCategoryUpd.Name = "lblCategoryUpd";
            this.lblCategoryUpd.Size = new System.Drawing.Size(55, 13);
            this.lblCategoryUpd.TabIndex = 1;
            this.lblCategoryUpd.Text = "Kategori : ";
            // 
            // lblProductNameUpd
            // 
            this.lblProductNameUpd.AutoSize = true;
            this.lblProductNameUpd.Location = new System.Drawing.Point(16, 19);
            this.lblProductNameUpd.Name = "lblProductNameUpd";
            this.lblProductNameUpd.Size = new System.Drawing.Size(57, 13);
            this.lblProductNameUpd.TabIndex = 0;
            this.lblProductNameUpd.Text = "Ürün Adı : ";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(669, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 460);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProduct);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProduct.ResumeLayout(false);
            this.gbxProduct.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProduct;
        private System.Windows.Forms.TextBox tbxProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitAdd;
        private System.Windows.Forms.TextBox tbxStockAdd;
        private System.Windows.Forms.TextBox tbxUnitPriceAdd;
        private System.Windows.Forms.ComboBox cbxCategoryAdd;
        private System.Windows.Forms.TextBox tbxProductNameAdd;
        private System.Windows.Forms.Label lblQuantityPerUnitAdd;
        private System.Windows.Forms.Label lblStockAdd;
        private System.Windows.Forms.Label lblUnitPriceAdd;
        private System.Windows.Forms.Label lblCategoryIdAdd;
        private System.Windows.Forms.Label lblProductNameAdd;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxQuantityUpd;
        private System.Windows.Forms.TextBox tbxStockAmountUpd;
        private System.Windows.Forms.TextBox tbxPriceUpd;
        private System.Windows.Forms.ComboBox cbxCategoryUpd;
        private System.Windows.Forms.TextBox tbxProductNameUpd;
        private System.Windows.Forms.Label lblQuantityUpd;
        private System.Windows.Forms.Label lblStockAmountUpd;
        private System.Windows.Forms.Label lblPriceUpd;
        private System.Windows.Forms.Label lblCategoryUpd;
        private System.Windows.Forms.Label lblProductNameUpd;
        private System.Windows.Forms.Button btnDelete;
    }
}


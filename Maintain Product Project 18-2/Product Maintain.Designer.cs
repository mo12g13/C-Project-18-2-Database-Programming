namespace Maintain_Product_Project_18_2
{
    partial class productMaintenance
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productMaintenance));
            System.Windows.Forms.Label productCodeLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label versionLabel;
            System.Windows.Forms.Label releaseDateLabel;
            this.productsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.productsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.versionTextBox = new System.Windows.Forms.TextBox();
            this.releaseDateTextBox = new System.Windows.Forms.TextBox();
            this.fillByProductCodeToolStrip = new System.Windows.Forms.ToolStrip();
            this.productCodeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.productCodeToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByProductCodeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techSupport_DataDataSet = new Maintain_Product_Project_18_2.TechSupport_DataDataSet();
            this.productsTableAdapter = new Maintain_Product_Project_18_2.TechSupport_DataDataSetTableAdapters.ProductsTableAdapter();
            this.tableAdapterManager = new Maintain_Product_Project_18_2.TechSupport_DataDataSetTableAdapters.TableAdapterManager();
            productCodeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            versionLabel = new System.Windows.Forms.Label();
            releaseDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).BeginInit();
            this.productsBindingNavigator.SuspendLayout();
            this.fillByProductCodeToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupport_DataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // productsBindingNavigator
            // 
            this.productsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productsBindingNavigator.BindingSource = this.productsBindingSource;
            this.productsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.productsBindingNavigatorSaveItem});
            this.productsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productsBindingNavigator.Name = "productsBindingNavigator";
            this.productsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productsBindingNavigator.Size = new System.Drawing.Size(356, 25);
            this.productsBindingNavigator.TabIndex = 0;
            this.productsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // productsBindingNavigatorSaveItem
            // 
            this.productsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productsBindingNavigatorSaveItem.Image")));
            this.productsBindingNavigatorSaveItem.Name = "productsBindingNavigatorSaveItem";
            this.productsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productsBindingNavigatorSaveItem.Text = "Save Data";
            this.productsBindingNavigatorSaveItem.Click += new System.EventHandler(this.productsBindingNavigatorSaveItem_Click_2);
            // 
            // productCodeLabel
            // 
            productCodeLabel.AutoSize = true;
            productCodeLabel.Location = new System.Drawing.Point(12, 66);
            productCodeLabel.Name = "productCodeLabel";
            productCodeLabel.Size = new System.Drawing.Size(75, 13);
            productCodeLabel.TabIndex = 1;
            productCodeLabel.Text = "Product Code:";
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ProductCode", true));
            this.productCodeTextBox.Location = new System.Drawing.Point(93, 63);
            this.productCodeTextBox.MaxLength = 10;
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.ReadOnly = true;
            this.productCodeTextBox.Size = new System.Drawing.Size(77, 20);
            this.productCodeTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 92);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(93, 89);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(165, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.Location = new System.Drawing.Point(12, 118);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new System.Drawing.Size(45, 13);
            versionLabel.TabIndex = 5;
            versionLabel.Text = "Version:";
            // 
            // versionTextBox
            // 
            this.versionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "Version", true));
            this.versionTextBox.Location = new System.Drawing.Point(93, 115);
            this.versionTextBox.MaxLength = 18;
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.Size = new System.Drawing.Size(77, 20);
            this.versionTextBox.TabIndex = 6;
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Location = new System.Drawing.Point(12, 144);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new System.Drawing.Size(75, 13);
            releaseDateLabel.TabIndex = 7;
            releaseDateLabel.Text = "Release Date:";
            // 
            // releaseDateTextBox
            // 
            this.releaseDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "ReleaseDate", true));
            this.releaseDateTextBox.Location = new System.Drawing.Point(93, 141);
            this.releaseDateTextBox.Name = "releaseDateTextBox";
            this.releaseDateTextBox.Size = new System.Drawing.Size(77, 20);
            this.releaseDateTextBox.TabIndex = 8;
            // 
            // fillByProductCodeToolStrip
            // 
            this.fillByProductCodeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productCodeToolStripLabel,
            this.productCodeToolStripTextBox,
            this.fillByProductCodeToolStripButton});
            this.fillByProductCodeToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByProductCodeToolStrip.Name = "fillByProductCodeToolStrip";
            this.fillByProductCodeToolStrip.Size = new System.Drawing.Size(356, 25);
            this.fillByProductCodeToolStrip.TabIndex = 9;
            this.fillByProductCodeToolStrip.Text = "fillByProductCodeToolStrip";
            // 
            // productCodeToolStripLabel
            // 
            this.productCodeToolStripLabel.Name = "productCodeToolStripLabel";
            this.productCodeToolStripLabel.Size = new System.Drawing.Size(80, 22);
            this.productCodeToolStripLabel.Text = "ProductCode:";
            // 
            // productCodeToolStripTextBox
            // 
            this.productCodeToolStripTextBox.Name = "productCodeToolStripTextBox";
            this.productCodeToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByProductCodeToolStripButton
            // 
            this.fillByProductCodeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByProductCodeToolStripButton.Name = "fillByProductCodeToolStripButton";
            this.fillByProductCodeToolStripButton.Size = new System.Drawing.Size(109, 22);
            this.fillByProductCodeToolStripButton.Text = "FillByProductCode";
            this.fillByProductCodeToolStripButton.Click += new System.EventHandler(this.fillByProductCodeToolStripButton_Click);
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.techSupport_DataDataSet;
            // 
            // techSupport_DataDataSet
            // 
            this.techSupport_DataDataSet.DataSetName = "TechSupport_DataDataSet";
            this.techSupport_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Maintain_Product_Project_18_2.TechSupport_DataDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 261);
            this.Controls.Add(this.fillByProductCodeToolStrip);
            this.Controls.Add(productCodeLabel);
            this.Controls.Add(this.productCodeTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(versionLabel);
            this.Controls.Add(this.versionTextBox);
            this.Controls.Add(releaseDateLabel);
            this.Controls.Add(this.releaseDateTextBox);
            this.Controls.Add(this.productsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Product Maintain";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingNavigator)).EndInit();
            this.productsBindingNavigator.ResumeLayout(false);
            this.productsBindingNavigator.PerformLayout();
            this.fillByProductCodeToolStrip.ResumeLayout(false);
            this.fillByProductCodeToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupport_DataDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TechSupport_DataDataSet techSupport_DataDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private TechSupport_DataDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private TechSupport_DataDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator productsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton productsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox versionTextBox;
        private System.Windows.Forms.TextBox releaseDateTextBox;
        private System.Windows.Forms.ToolStrip fillByProductCodeToolStrip;
        private System.Windows.Forms.ToolStripLabel productCodeToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox productCodeToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByProductCodeToolStripButton;
    }
}


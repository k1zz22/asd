namespace GearPoint
{
    partial class AddOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrder));
            System.Windows.Forms.Label itemLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label sizeLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label priceLabel;
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.roundedPanel1 = new GearPoint.RoundedPanel();
            this.OrderImageBox = new GearPoint.RoundedPictureBox();
            this.BackButton = new RoundButton();
            this.AddToCartBtn = new RoundButton();
            this.roundedPictureBox1 = new GearPoint.RoundedPictureBox();
            this.databaseDataSet = new GearPoint.DatabaseDataSet();
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartTableAdapter = new GearPoint.DatabaseDataSetTableAdapters.CartTableAdapter();
            this.tableAdapterManager = new GearPoint.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.cartBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cartBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.ItemNameLbl = new System.Windows.Forms.Label();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.SizesComboBox = new System.Windows.Forms.ComboBox();
            this.QuantityBox = new System.Windows.Forms.NumericUpDown();
            this.PriceOutputLbl = new System.Windows.Forms.Label();
            itemLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingNavigator)).BeginInit();
            this.cartBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(439, 65);
            this.dataGridView1.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.PowderBlue;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.Controls.Add(itemLabel);
            this.roundedPanel1.Controls.Add(this.ItemNameLbl);
            this.roundedPanel1.Controls.Add(genderLabel);
            this.roundedPanel1.Controls.Add(this.GenderLbl);
            this.roundedPanel1.Controls.Add(sizeLabel);
            this.roundedPanel1.Controls.Add(this.SizesComboBox);
            this.roundedPanel1.Controls.Add(quantityLabel);
            this.roundedPanel1.Controls.Add(this.QuantityBox);
            this.roundedPanel1.Controls.Add(priceLabel);
            this.roundedPanel1.Controls.Add(this.PriceOutputLbl);
            this.roundedPanel1.Controls.Add(this.OrderImageBox);
            this.roundedPanel1.Controls.Add(this.BackButton);
            this.roundedPanel1.Controls.Add(this.AddToCartBtn);
            this.roundedPanel1.Location = new System.Drawing.Point(32, 109);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(401, 548);
            this.roundedPanel1.TabIndex = 9;
            this.roundedPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.roundedPanel1_Paint);
            // 
            // OrderImageBox
            // 
            this.OrderImageBox.BackgroundImage = global::GearPoint.Properties.Resources.placeholder;
            this.OrderImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OrderImageBox.CornerRadius = 20;
            this.OrderImageBox.Location = new System.Drawing.Point(89, 42);
            this.OrderImageBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrderImageBox.Name = "OrderImageBox";
            this.OrderImageBox.Size = new System.Drawing.Size(188, 203);
            this.OrderImageBox.TabIndex = 7;
            this.OrderImageBox.TabStop = false;
            this.OrderImageBox.Click += new System.EventHandler(this.OrderImageBox_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.BackButton.BorderRadius = 30;
            this.BackButton.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.BackButton.Location = new System.Drawing.Point(75, 462);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(61, 49);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AddToCartBtn
            // 
            this.AddToCartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.AddToCartBtn.BorderRadius = 30;
            this.AddToCartBtn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddToCartBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.AddToCartBtn.Location = new System.Drawing.Point(160, 462);
            this.AddToCartBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddToCartBtn.Name = "AddToCartBtn";
            this.AddToCartBtn.Size = new System.Drawing.Size(159, 49);
            this.AddToCartBtn.TabIndex = 3;
            this.AddToCartBtn.Text = "Add to Cart";
            this.AddToCartBtn.UseVisualStyleBackColor = false;
            this.AddToCartBtn.Click += new System.EventHandler(this.AddToCartBtn_Click);
            // 
            // roundedPictureBox1
            // 
            this.roundedPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roundedPictureBox1.BackgroundImage")));
            this.roundedPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.roundedPictureBox1.CornerRadius = 40;
            this.roundedPictureBox1.Location = new System.Drawing.Point(20, 10);
            this.roundedPictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roundedPictureBox1.Name = "roundedPictureBox1";
            this.roundedPictureBox1.Size = new System.Drawing.Size(83, 43);
            this.roundedPictureBox1.TabIndex = 8;
            this.roundedPictureBox1.TabStop = false;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartBindingSource
            // 
            this.cartBindingSource.DataMember = "Cart";
            this.cartBindingSource.DataSource = this.databaseDataSet;
            // 
            // cartTableAdapter
            // 
            this.cartTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CartTableAdapter = this.cartTableAdapter;
            this.tableAdapterManager.UpdateOrder = GearPoint.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cartBindingNavigator
            // 
            this.cartBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cartBindingNavigator.BindingSource = this.cartBindingSource;
            this.cartBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cartBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cartBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cartBindingNavigatorSaveItem});
            this.cartBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cartBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cartBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cartBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cartBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cartBindingNavigator.Name = "cartBindingNavigator";
            this.cartBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cartBindingNavigator.Size = new System.Drawing.Size(435, 25);
            this.cartBindingNavigator.TabIndex = 10;
            this.cartBindingNavigator.Text = "bindingNavigator1";
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
            // cartBindingNavigatorSaveItem
            // 
            this.cartBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cartBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cartBindingNavigatorSaveItem.Image")));
            this.cartBindingNavigatorSaveItem.Name = "cartBindingNavigatorSaveItem";
            this.cartBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cartBindingNavigatorSaveItem.Text = "Save Data";
            this.cartBindingNavigatorSaveItem.Click += new System.EventHandler(this.cartBindingNavigatorSaveItem_Click);
            // 
            // itemLabel
            // 
            itemLabel.AutoSize = true;
            itemLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            itemLabel.Location = new System.Drawing.Point(95, 274);
            itemLabel.Name = "itemLabel";
            itemLabel.Size = new System.Drawing.Size(42, 18);
            itemLabel.TabIndex = 16;
            itemLabel.Text = "Item:";
            // 
            // ItemNameLbl
            // 
            this.ItemNameLbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cartBindingSource, "Item", true));
            this.ItemNameLbl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameLbl.Location = new System.Drawing.Point(150, 274);
            this.ItemNameLbl.Name = "ItemNameLbl";
            this.ItemNameLbl.Size = new System.Drawing.Size(121, 23);
            this.ItemNameLbl.TabIndex = 17;
            this.ItemNameLbl.Text = "N/A";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(94, 301);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(66, 18);
            genderLabel.TabIndex = 18;
            genderLabel.Text = "Gender:";
            // 
            // GenderLbl
            // 
            this.GenderLbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cartBindingSource, "Gender", true));
            this.GenderLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLbl.Location = new System.Drawing.Point(166, 301);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(121, 23);
            this.GenderLbl.TabIndex = 19;
            this.GenderLbl.Text = "N/A";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sizeLabel.Location = new System.Drawing.Point(94, 333);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(43, 18);
            sizeLabel.TabIndex = 20;
            sizeLabel.Text = "Size:";
            // 
            // SizesComboBox
            // 
            this.SizesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cartBindingSource, "Size", true));
            this.SizesComboBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizesComboBox.FormattingEnabled = true;
            this.SizesComboBox.Location = new System.Drawing.Point(169, 330);
            this.SizesComboBox.Name = "SizesComboBox";
            this.SizesComboBox.Size = new System.Drawing.Size(86, 25);
            this.SizesComboBox.TabIndex = 21;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quantityLabel.Location = new System.Drawing.Point(94, 361);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(71, 18);
            quantityLabel.TabIndex = 22;
            quantityLabel.Text = "Quantity:";
            // 
            // QuantityBox
            // 
            this.QuantityBox.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cartBindingSource, "Quantity", true));
            this.QuantityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityBox.Location = new System.Drawing.Point(169, 361);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.Size = new System.Drawing.Size(86, 22);
            this.QuantityBox.TabIndex = 23;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.Location = new System.Drawing.Point(101, 420);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(49, 18);
            priceLabel.TabIndex = 24;
            priceLabel.Text = "Price:";
            // 
            // PriceOutputLbl
            // 
            this.PriceOutputLbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cartBindingSource, "Price", true));
            this.PriceOutputLbl.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceOutputLbl.Location = new System.Drawing.Point(156, 416);
            this.PriceOutputLbl.Name = "PriceOutputLbl";
            this.PriceOutputLbl.Size = new System.Drawing.Size(121, 23);
            this.PriceOutputLbl.TabIndex = 25;
            this.PriceOutputLbl.Text = "$0.00";
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(452, 605);
            this.Controls.Add(this.cartBindingNavigator);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.roundedPictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrder";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingNavigator)).EndInit();
            this.cartBindingNavigator.ResumeLayout(false);
            this.cartBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private RoundButton BackButton;
        private RoundButton AddToCartBtn;
        private RoundedPictureBox roundedPictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RoundedPictureBox OrderImageBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private DatabaseDataSetTableAdapters.CartTableAdapter cartTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cartBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cartBindingNavigatorSaveItem;
        private System.Windows.Forms.Label ItemNameLbl;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.ComboBox SizesComboBox;
        private System.Windows.Forms.NumericUpDown QuantityBox;
        private System.Windows.Forms.Label PriceOutputLbl;
    }
}
namespace Finances
{
    partial class Finances
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
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.tb_product = new System.Windows.Forms.TextBox();
            this.nud_amount = new System.Windows.Forms.NumericUpDown();
            this.gb_ExpencesForm = new System.Windows.Forms.GroupBox();
            this.lb_amount = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.btn_showAll = new System.Windows.Forms.Button();
            this.btn_showSameAmount = new System.Windows.Forms.Button();
            this.lb_sameAmount = new System.Windows.Forms.Label();
            this.nud_sameAmount = new System.Windows.Forms.NumericUpDown();
            this.listBox_products = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_amount)).BeginInit();
            this.gb_ExpencesForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sameAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(96, 118);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(124, 49);
            this.btn_addProduct.TabIndex = 1;
            this.btn_addProduct.Text = "Add expence to transaction log ";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.addProduct);
            // 
            // tb_product
            // 
            this.tb_product.Location = new System.Drawing.Point(96, 38);
            this.tb_product.Name = "tb_product";
            this.tb_product.Size = new System.Drawing.Size(124, 27);
            this.tb_product.TabIndex = 2;
            this.tb_product.Text = "Candy";
            // 
            // nud_amount
            // 
            this.nud_amount.DecimalPlaces = 2;
            this.nud_amount.Location = new System.Drawing.Point(96, 76);
            this.nud_amount.Name = "nud_amount";
            this.nud_amount.Size = new System.Drawing.Size(77, 27);
            this.nud_amount.TabIndex = 2;
            this.nud_amount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // gb_ExpencesForm
            // 
            this.gb_ExpencesForm.Controls.Add(this.lb_amount);
            this.gb_ExpencesForm.Controls.Add(this.btn_addProduct);
            this.gb_ExpencesForm.Controls.Add(this.lb_name);
            this.gb_ExpencesForm.Controls.Add(this.tb_product);
            this.gb_ExpencesForm.Controls.Add(this.nud_amount);
            this.gb_ExpencesForm.Location = new System.Drawing.Point(12, 21);
            this.gb_ExpencesForm.Name = "gb_ExpencesForm";
            this.gb_ExpencesForm.Size = new System.Drawing.Size(240, 181);
            this.gb_ExpencesForm.TabIndex = 3;
            this.gb_ExpencesForm.TabStop = false;
            this.gb_ExpencesForm.Text = "Expences form";
            // 
            // lb_amount
            // 
            this.lb_amount.AutoSize = true;
            this.lb_amount.Location = new System.Drawing.Point(15, 78);
            this.lb_amount.Name = "lb_amount";
            this.lb_amount.Size = new System.Drawing.Size(65, 20);
            this.lb_amount.TabIndex = 4;
            this.lb_amount.Text = "Amount:";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(15, 38);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(52, 20);
            this.lb_name.TabIndex = 3;
            this.lb_name.Text = "Name:";
            // 
            // btn_showAll
            // 
            this.btn_showAll.Location = new System.Drawing.Point(12, 208);
            this.btn_showAll.Name = "btn_showAll";
            this.btn_showAll.Size = new System.Drawing.Size(240, 34);
            this.btn_showAll.TabIndex = 5;
            this.btn_showAll.Text = "Show all expences";
            this.btn_showAll.UseVisualStyleBackColor = true;
            this.btn_showAll.Click += new System.EventHandler(this.showAllExpences);
            // 
            // btn_showSameAmount
            // 
            this.btn_showSameAmount.Location = new System.Drawing.Point(14, 311);
            this.btn_showSameAmount.Name = "btn_showSameAmount";
            this.btn_showSameAmount.Size = new System.Drawing.Size(240, 34);
            this.btn_showSameAmount.TabIndex = 6;
            this.btn_showSameAmount.Text = "Show expences with the same amount";
            this.btn_showSameAmount.UseVisualStyleBackColor = true;
            this.btn_showSameAmount.Click += new System.EventHandler(this.showExpencesSameAmount);
            // 
            // lb_sameAmount
            // 
            this.lb_sameAmount.AutoSize = true;
            this.lb_sameAmount.Location = new System.Drawing.Point(14, 272);
            this.lb_sameAmount.Name = "lb_sameAmount";
            this.lb_sameAmount.Size = new System.Drawing.Size(65, 20);
            this.lb_sameAmount.TabIndex = 5;
            this.lb_sameAmount.Text = "Amount:";
            // 
            // nud_sameAmount
            // 
            this.nud_sameAmount.DecimalPlaces = 2;
            this.nud_sameAmount.Location = new System.Drawing.Point(98, 265);
            this.nud_sameAmount.Name = "nud_sameAmount";
            this.nud_sameAmount.Size = new System.Drawing.Size(154, 27);
            this.nud_sameAmount.TabIndex = 5;
            this.nud_sameAmount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // listBox_products
            // 
            this.listBox_products.FormattingEnabled = true;
            this.listBox_products.ItemHeight = 20;
            this.listBox_products.Location = new System.Drawing.Point(269, 21);
            this.listBox_products.Name = "listBox_products";
            this.listBox_products.Size = new System.Drawing.Size(219, 324);
            this.listBox_products.TabIndex = 7;
            // 
            // Finances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 365);
            this.Controls.Add(this.listBox_products);
            this.Controls.Add(this.nud_sameAmount);
            this.Controls.Add(this.lb_sameAmount);
            this.Controls.Add(this.btn_showSameAmount);
            this.Controls.Add(this.btn_showAll);
            this.Controls.Add(this.gb_ExpencesForm);
            this.Name = "Finances";
            this.Text = "Finances";
            ((System.ComponentModel.ISupportInitialize)(this.nud_amount)).EndInit();
            this.gb_ExpencesForm.ResumeLayout(false);
            this.gb_ExpencesForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_sameAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_addProduct;
        private TextBox tb_product;
        private NumericUpDown nud_amount;
        private GroupBox gb_ExpencesForm;
        private Label lb_amount;
        private Label lb_name;
        private Button btn_showAll;
        private Button btn_showSameAmount;
        private Label lb_sameAmount;
        private NumericUpDown nud_sameAmount;
        private ListBox listBox_products;
    }
}
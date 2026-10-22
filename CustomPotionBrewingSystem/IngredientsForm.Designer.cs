namespace CustomPotionBrewingSystem
{
    partial class IngredientsForm
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
            lblHeading = new Label();
            dgvIngredients = new DataGridView();
            lblName = new Label();
            txtIngredientName = new TextBox();
            lblStock = new Label();
            numStock = new NumericUpDown();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRetire = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AccessibleName = "lblHeading";
            lblHeading.AutoSize = true;
            lblHeading.Location = new Point(26, 16);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(112, 15);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Manage Ingredients";
            // 
            // dgvIngredients
            // 
            dgvIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIngredients.Location = new Point(27, 49);
            dgvIngredients.Name = "dgvIngredients";
            dgvIngredients.Size = new Size(240, 150);
            dgvIngredients.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AccessibleName = "lblName";
            lblName.AutoSize = true;
            lblName.Location = new Point(30, 221);
            lblName.Name = "lblName";
            lblName.Size = new Size(96, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Ingredient Name";
            lblName.Click += lblName_Click;
            // 
            // txtIngredientName
            // 
            txtIngredientName.AccessibleName = "txtIngredientName";
            txtIngredientName.Location = new Point(34, 247);
            txtIngredientName.Name = "txtIngredientName";
            txtIngredientName.Size = new Size(100, 23);
            txtIngredientName.TabIndex = 3;
            // 
            // lblStock
            // 
            lblStock.AccessibleName = "lblStock";
            lblStock.AutoSize = true;
            lblStock.Location = new Point(35, 283);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(36, 15);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock";
            // 
            // numStock
            // 
            numStock.AccessibleName = "numStock";
            numStock.Location = new Point(40, 310);
            numStock.Name = "numStock";
            numStock.Size = new Size(120, 23);
            numStock.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.AccessibleName = "btnAdd";
            btnAdd.Location = new Point(41, 346);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Ingredient";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(44, 380);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update Stock";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnRetire
            // 
            btnRetire.Location = new Point(48, 415);
            btnRetire.Name = "btnRetire";
            btnRetire.Size = new Size(112, 23);
            btnRetire.TabIndex = 8;
            btnRetire.Text = "Retire Ingredient";
            btnRetire.UseVisualStyleBackColor = true;
            btnRetire.Click += btnRetire_Click;
            // 
            // IngredientsForm
            // 
            AccessibleName = "dgvIngredients";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRetire);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(numStock);
            Controls.Add(lblStock);
            Controls.Add(txtIngredientName);
            Controls.Add(lblName);
            Controls.Add(dgvIngredients);
            Controls.Add(lblHeading);
            Name = "IngredientsForm";
            Text = "IngredientsForm";
            ((System.ComponentModel.ISupportInitialize)dgvIngredients).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private DataGridView dgvIngredients;
        private Label lblName;
        private TextBox txtIngredientName;
        private Label lblStock;
        private NumericUpDown numStock;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRetire;
    }
}
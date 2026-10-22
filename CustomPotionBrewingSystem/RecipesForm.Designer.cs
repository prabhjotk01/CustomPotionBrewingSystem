namespace CustomPotionBrewingSystem
{
    partial class RecipesForm
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
            lblRecipeName = new Label();
            txtRecipeName = new TextBox();
            lblDuration = new Label();
            numDuration = new NumericUpDown();
            lblIngredient = new Label();
            cmbIngredients = new ComboBox();
            lblQuantity = new Label();
            numQuantity = new NumericUpDown();
            btnAddngredient = new Button();
            dgvRecipeIngredients = new DataGridView();
            btnSaveRecipe = new Button();
            colIngredientId = new DataGridViewTextBoxColumn();
            colIngredientName = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecipeIngredients).BeginInit();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Location = new Point(20, 24);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(93, 15);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Manage Recipes";
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Location = new Point(25, 50);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(77, 15);
            lblRecipeName.TabIndex = 1;
            lblRecipeName.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Location = new Point(27, 77);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(100, 23);
            txtRecipeName.TabIndex = 2;
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(27, 116);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(134, 15);
            lblDuration.TabIndex = 3;
            lblDuration.Text = "Brewing Time (seconds)";
            // 
            // numDuration
            // 
            numDuration.Location = new Point(30, 145);
            numDuration.Name = "numDuration";
            numDuration.Size = new Size(120, 23);
            numDuration.TabIndex = 4;
            // 
            // lblIngredient
            // 
            lblIngredient.AutoSize = true;
            lblIngredient.Location = new Point(31, 185);
            lblIngredient.Name = "lblIngredient";
            lblIngredient.Size = new Size(95, 15);
            lblIngredient.TabIndex = 5;
            lblIngredient.Text = "Select Ingredient";
            // 
            // cmbIngredients
            // 
            cmbIngredients.FormattingEnabled = true;
            cmbIngredients.Location = new Point(35, 218);
            cmbIngredients.Name = "cmbIngredients";
            cmbIngredients.Size = new Size(121, 23);
            cmbIngredients.TabIndex = 6;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(34, 256);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(103, 15);
            lblQuantity.TabIndex = 7;
            lblQuantity.Text = "Quantity Required";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(34, 280);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(120, 23);
            numQuantity.TabIndex = 8;
            // 
            // btnAddngredient
            // 
            btnAddngredient.Location = new Point(34, 322);
            btnAddngredient.Name = "btnAddngredient";
            btnAddngredient.Size = new Size(173, 23);
            btnAddngredient.TabIndex = 9;
            btnAddngredient.Text = "Add Ingredient to Recipe";
            btnAddngredient.UseVisualStyleBackColor = true;
            btnAddngredient.Click += btnAddngredient_Click;
            // 
            // dgvRecipeIngredients
            // 
            dgvRecipeIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipeIngredients.Columns.AddRange(new DataGridViewColumn[] { colIngredientId, colIngredientName, colQuantity });
            dgvRecipeIngredients.Location = new Point(35, 363);
            dgvRecipeIngredients.Name = "dgvRecipeIngredients";
            dgvRecipeIngredients.Size = new Size(240, 150);
            dgvRecipeIngredients.TabIndex = 10;
            // 
            // btnSaveRecipe
            // 
            btnSaveRecipe.Location = new Point(309, 419);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(107, 23);
            btnSaveRecipe.TabIndex = 11;
            btnSaveRecipe.Text = "Save Recipe";
            btnSaveRecipe.UseVisualStyleBackColor = true;
            btnSaveRecipe.Click += btnSaveRecipe_Click;
            // 
            // colIngredientId
            // 
            colIngredientId.HeaderText = "Ingredient ID";
            colIngredientId.Name = "colIngredientId";
            // 
            // colIngredientName
            // 
            colIngredientName.HeaderText = "Ingredient Name";
            colIngredientName.Name = "colIngredientName";
            // 
            // colQuantity
            // 
            colQuantity.HeaderText = "Quantity Required";
            colQuantity.Name = "colQuantity";
            // 
            // RecipesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaveRecipe);
            Controls.Add(dgvRecipeIngredients);
            Controls.Add(btnAddngredient);
            Controls.Add(numQuantity);
            Controls.Add(lblQuantity);
            Controls.Add(cmbIngredients);
            Controls.Add(lblIngredient);
            Controls.Add(numDuration);
            Controls.Add(lblDuration);
            Controls.Add(txtRecipeName);
            Controls.Add(lblRecipeName);
            Controls.Add(lblHeading);
            Name = "RecipesForm";
            Text = "RecipesForm";
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRecipeIngredients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private Label lblRecipeName;
        private TextBox txtRecipeName;
        private Label lblDuration;
        private NumericUpDown numDuration;
        private Label lblIngredient;
        private ComboBox cmbIngredients;
        private Label lblQuantity;
        private NumericUpDown numQuantity;
        private Button btnAddngredient;
        private DataGridView dgvRecipeIngredients;
        private Button btnSaveRecipe;
        private DataGridViewTextBoxColumn colIngredientId;
        private DataGridViewTextBoxColumn colIngredientName;
        private DataGridViewTextBoxColumn colQuantity;
    }
}
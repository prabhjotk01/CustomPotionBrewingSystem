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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRetire = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleName = "lblHeading";
            label1.AutoSize = true;
            label1.Location = new Point(26, 16);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 0;
            label1.Text = "Manage Ingredients";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AccessibleName = "lblName";
            label2.AutoSize = true;
            label2.Location = new Point(30, 221);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 2;
            label2.Text = "Ingredient Name";
            // 
            // textBox1
            // 
            textBox1.AccessibleName = "txtIngredientName";
            textBox1.Location = new Point(34, 247);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AccessibleName = "lblStock";
            label3.AutoSize = true;
            label3.Location = new Point(35, 283);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Stock";
            // 
            // numericUpDown1
            // 
            numericUpDown1.AccessibleName = "numStock";
            numericUpDown1.Location = new Point(40, 310);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 5;
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
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "IngredientsForm";
            Text = "IngredientsForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnRetire;
    }
}
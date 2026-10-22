namespace CustomPotionBrewingSystem
{
    partial class Form1
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AccessibleName = "btnIngredienrs";
            button1.Location = new Point(34, 12);
            button1.Name = "button1";
            button1.Size = new Size(151, 23);
            button1.TabIndex = 0;
            button1.Text = "Manage Ingredients";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AccessibleName = "btnRecipes";
            button2.Location = new Point(34, 51);
            button2.Name = "button2";
            button2.Size = new Size(147, 23);
            button2.TabIndex = 1;
            button2.Text = "Manage Recipes";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.AccessibleName = "btnBrewing";
            button3.Location = new Point(34, 89);
            button3.Name = "button3";
            button3.Size = new Size(145, 23);
            button3.TabIndex = 2;
            button3.Text = "Brew Potion";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.AccessibleName = "btnPotions";
            button4.Location = new Point(34, 129);
            button4.Name = "button4";
            button4.Size = new Size(143, 23);
            button4.TabIndex = 3;
            button4.Text = "Potion Inventory";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.AccessibleName = "btnDashboard";
            button5.Location = new Point(34, 170);
            button5.Name = "button5";
            button5.Size = new Size(139, 23);
            button5.TabIndex = 4;
            button5.Text = "Dashboard";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AccessibleName = "lblTitle";
            label1.AutoSize = true;
            label1.Location = new Point(34, 209);
            label1.Name = "label1";
            label1.Size = new Size(174, 15);
            label1.TabIndex = 5;
            label1.Text = "Custom Potion Brewing System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Potion Brewing System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
    }
}

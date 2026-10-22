using CustomPotionBrewingSystem.Data;
using CustomPotionBrewingSystem.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CustomPotionBrewingSystem
{
    public partial class RecipesForm : Form
    {
        public RecipesForm()
        {
            InitializeComponent();
            LoadIngredients();
        }

        private void LoadIngredients()
        {
            using (var db = new PotionContext())
            {
                cmbIngredients.DataSource = db.Ingredients.ToList();
                cmbIngredients.DisplayMember = "Name";
                cmbIngredients.ValueMember = "Id";
            }
        }

        private void btnAddngredient_Click(object sender, EventArgs e)
        {
            if (cmbIngredients.SelectedItem == null)
            {
                MessageBox.Show("Please select an ingredient.");
                return;
            }

            int ingredientId = (int)cmbIngredients.SelectedValue;
            int quantity = (int)numQuantity.Value;

            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.");
                return;
            }

            dgvRecipeIngredients.Rows.Add(
                ingredientId,
                cmbIngredients.Text,
                quantity);
        }

        private void btnSaveRecipe_Click(object sender, EventArgs e)
        {
            if (txtRecipeName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a recipe name.");
                return;
            }

            if (dgvRecipeIngredients.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one ingredient.");
                return;
            }

            using (var db = new PotionContext())
            {
                Recipe recipe = new Recipe();
                recipe.Name = txtRecipeName.Text.Trim();
                recipe.BrewingDurationSeconds = (int)numDuration.Value;

                db.Recipes.Add(recipe);
                db.SaveChanges();

                foreach (DataGridViewRow row in dgvRecipeIngredients.Rows)
                {
                    RecipeIngredient item = new RecipeIngredient();
                    item.RecipeId = recipe.Id;
                    item.IngredientId = Convert.ToInt32(row.Cells[0].Value);
                    item.QuantityRequired = Convert.ToInt32(row.Cells[2].Value);

                    db.RecipeIngredients.Add(item);
                }

                db.SaveChanges();
            }

            MessageBox.Show("Recipe saved successfully!");

            txtRecipeName.Clear();
            dgvRecipeIngredients.Rows.Clear();
        }


    }
}

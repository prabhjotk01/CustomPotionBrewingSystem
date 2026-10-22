using CustomPotionBrewingSystem.Data;
using CustomPotionBrewingSystem.Models;
using System.Linq;
using System.Windows.Forms;

namespace CustomPotionBrewingSystem
{
    public partial class IngredientsForm : Form
    {
        public IngredientsForm()
        {
            InitializeComponent();
            LoadIngredients();
        }

        private void LoadIngredients()
        {
            using (var db = new PotionContext())
            {
                dgvIngredients.DataSource = db.Ingredients.ToList();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtIngredientName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter an ingredient name.");
                return;
            }

            using (var db = new PotionContext())
            {
                Ingredient ingredient = new Ingredient();

                ingredient.Name = txtIngredientName.Text.Trim();
                ingredient.Stock = (int)numStock.Value;

                db.Ingredients.Add(ingredient);
                db.SaveChanges();
            }

            txtIngredientName.Clear();
            numStock.Value = 0;

            LoadIngredients();

            MessageBox.Show("Ingredient added successfully!");
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            if (dgvIngredients.CurrentRow == null)
            {
                MessageBox.Show("Please select an ingredient.");
                return;
            }

            int id = (int)dgvIngredients.CurrentRow.Cells["Id"].Value;

            using (var db = new PotionContext())
            {
                var ingredient = db.Ingredients.Find(id);

                if (ingredient != null)
                {
                    ingredient.Stock = (int)numStock.Value;
                    db.SaveChanges();
                }
            }

            LoadIngredients();
            MessageBox.Show("Stock updated successfully!");
        }

        private void btnRetire_Click(object sender, EventArgs e)
        {
            if (dgvIngredients.CurrentRow == null)
            {
                MessageBox.Show("Please select an ingredient.");
                return;
            }

            int id = (int)dgvIngredients.CurrentRow.Cells["Id"].Value;

            using (var db = new PotionContext())
            {
                var ingredient = db.Ingredients.Find(id);

                if (ingredient != null)
                {
                    bool usedInRecipe = db.RecipeIngredients
                        .Any(ri => ri.IngredientId == id);

                    if (usedInRecipe)
                    {
                        MessageBox.Show(
                            "This ingredient is used in a recipe and cannot be retired.");
                        return;
                    }

                    db.Ingredients.Remove(ingredient);
                    db.SaveChanges();
                }
            }

            LoadIngredients();
            MessageBox.Show("Ingredient retired successfully!");
        }
    }
}

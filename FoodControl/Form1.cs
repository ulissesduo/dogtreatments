using FoodControl.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FoodControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateProduct();
        }

        private void CreateProduct()
        {
            using (var context = new DogFoodContext())
            {
                var newProduct = new Treatment
                {
                    Id = 3,
                    Food = int.Parse(txtfood.Text),
                    MissingFood = int.Parse(txtMissingFood.Text),
                    Water = int.Parse(txtfood.Text),
                    MissingWater = int.Parse(txtfood.Text),
                    Date = "10-02-2023"

                };

                context.Treatments.Add(newProduct);
                context.SaveChanges();
            }
        }

        private void LoadProducts()
        {
            using (var context = new DogFoodContext())
            {
                var products = context.Treatments.ToList();
                dataGridView1.DataSource = products;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadProducts();

        }
    }
}
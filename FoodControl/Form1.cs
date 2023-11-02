using FoodControl.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FoodControl
{
    public partial class Form1 : Form
    {
        readonly public DateTime today = DateTime.Now;
        public bool VerifyDate = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var s = Directory.GetCurrentDirectory();
            MessageBox.Show(s);
        }



        public bool RecordExistsForToday()
        {
            using (var context = new DogtreatmentsContext())
            {
                return context.Treatments.Any(t => t.Date.Date == today.Date);
            }
        }


        private void CreateProduct()
        {
            using (var context = new DogtreatmentsContext())
            {
                var newProduct = new Treatment
                {

                    Food = int.Parse(txtfood.Text),
                    MissingFood = int.Parse(txtMissingFood.Text),
                    Water = int.Parse(txtfood.Text),
                    MissingWater = int.Parse(txtfood.Text),
                    Date = DateTime.Now

                };

                context.Treatments.Add(newProduct);
                context.SaveChanges();
            }
        }


        public void Update()
        {
            using (var context = new DogtreatmentsContext())
            {
                // Retrieve the existing Treatment entity to update
                var existingTreatment = context.Treatments.FirstOrDefault(t => t.Date.Date == today.Date);

                if (existingTreatment != null)
                {
                    existingTreatment.Food = int.Parse(txtfood.Text);
                    existingTreatment.MissingFood = int.Parse(txtMissingFood.Text);
                    existingTreatment.Water = int.Parse(txtfood.Text);
                    existingTreatment.MissingWater = int.Parse(txtfood.Text);
                    context.SaveChanges();

                }
            }
        }



        private void LoadProducts()
        {
            using (var context = new DogtreatmentsContext())
            {
                var products = context.Treatments.ToList();
                dataGridView1.DataSource = products;
            }
        }



        private void btnReadAll_Click_1(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            if (RecordExistsForToday())
                Update();
            else
                CreateProduct();
        }
    }
}
using FoodControl.Models;
using Microsoft.EntityFrameworkCore;
using SQLiteTeste.Models;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FoodControl
{
    public partial class Form1 : Form
    {
        readonly public DateTime today = DateTime.Now;
        public bool VerifyDate = false;
<<<<<<< HEAD
        private readonly DogTreatmentDbContext _context;

        public Form1(DogTreatmentDbContext context)
=======
        public Form1()
>>>>>>> 9c783497dcf175db3ccf5f17b316c768d9d285b7
        {

            InitializeComponent();
            _context = context;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var s = Directory.GetCurrentDirectory();
            MessageBox.Show(s);
        }

<<<<<<< HEAD
        public bool RecordExistsForToday()
        {
            var teste = _context.tbDogTreatments.Any(t => t.Date.Date == today.Date);
            return teste;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (RecordExistsForToday())
            //    Update();
            //else
            CreateProduct();
        }

        private int MissingFoodCalculation(int food) 
        {
            int missingFood = food - (int)numExpFood.Value;
            return missingFood;
        }

        private void CreateProduct()
        {
            var newProduct = new Treatment
            {
                Food = int.Parse(txtfood.Text),
                MissingFood = int.Parse(txtMissingFood.Text),
                Water = int.Parse(txtWater.Text),
                MissingWater = int.Parse(txtMissingWater.Text),
                Date = DateTime.Now
            };
=======


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
>>>>>>> 9c783497dcf175db3ccf5f17b316c768d9d285b7

            _context.tbDogTreatments.Add(newProduct);
            _context.SaveChanges();
        }

        public void Update()
        {

            var existingTreatment = _context.tbDogTreatments.FirstOrDefault(t => t.Date.Date == today.Date);

            if (existingTreatment != null)
            {
                existingTreatment.Food = int.Parse(txtfood.Text);
                existingTreatment.MissingFood = int.Parse(txtMissingFood.Text);
                existingTreatment.Water = int.Parse(txtfood.Text);
                existingTreatment.MissingWater = int.Parse(txtfood.Text);
                _context.SaveChanges();
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
<<<<<<< HEAD

            var products = _context.tbDogTreatments.ToList();
            dataGridView1.DataSource = products;

=======
            using (var context = new DogtreatmentsContext())
            {
                var products = context.Treatments.ToList();
                dataGridView1.DataSource = products;
            }
>>>>>>> 9c783497dcf175db3ccf5f17b316c768d9d285b7
        }



        private void btnReadAll_Click_1(object sender, EventArgs e)
        {
            LoadProducts();
<<<<<<< HEAD
=======
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            if (RecordExistsForToday())
                Update();
            else
                CreateProduct();
>>>>>>> 9c783497dcf175db3ccf5f17b316c768d9d285b7
        }
    }
}
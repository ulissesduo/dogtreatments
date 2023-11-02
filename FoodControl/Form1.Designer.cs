namespace FoodControl
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
            btnInsert = new Button();
            txtfood = new TextBox();
            txtMissingFood = new TextBox();
            txtWater = new TextBox();
            txtMissingWater = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            btnReadAll = new Button();
<<<<<<< HEAD
            label5 = new Label();
            numExpFood = new NumericUpDown();
            numExpWater = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
=======
>>>>>>> 9c783497dcf175db3ccf5f17b316c768d9d285b7
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numExpFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numExpWater).BeginInit();
            SuspendLayout();
            // 
            // btnInsert
            // 
<<<<<<< HEAD
            btnInsert.Location = new Point(643, 88);
=======
            btnInsert.Location = new Point(485, 122);
>>>>>>> 9c783497dcf175db3ccf5f17b316c768d9d285b7
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Add";
            btnInsert.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            btnInsert.Click += button1_Click;
            // 
            // txtfood
            // 
            txtfood.Location = new Point(234, 39);
=======
            btnInsert.Click += btnInsert_Click_1;
            // 
            // txtfood
            // 
            txtfood.Location = new Point(234, 35);
>>>>>>> 9c783497dcf175db3ccf5f17b316c768d9d285b7
            txtfood.Name = "txtfood";
            txtfood.Size = new Size(125, 27);
            txtfood.TabIndex = 1;
            // 
            // txtMissingFood
            // 
<<<<<<< HEAD
            txtMissingFood.Location = new Point(234, 131);
=======
            txtMissingFood.Location = new Point(234, 83);
>>>>>>> 9c783497dcf175db3ccf5f17b316c768d9d285b7
            txtMissingFood.Name = "txtMissingFood";
            txtMissingFood.Size = new Size(125, 27);
            txtMissingFood.TabIndex = 2;
            // 
            // txtWater
            // 
<<<<<<< HEAD
            txtWater.Location = new Point(234, 88);
=======
            txtWater.Location = new Point(234, 130);
>>>>>>> 9c783497dcf175db3ccf5f17b316c768d9d285b7
            txtWater.Name = "txtWater";
            txtWater.Size = new Size(125, 27);
            txtWater.TabIndex = 3;
            // 
            // txtMissingWater
            // 
            txtMissingWater.Location = new Point(234, 176);
            txtMissingWater.Name = "txtMissingWater";
            txtMissingWater.Size = new Size(125, 27);
            txtMissingWater.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
<<<<<<< HEAD
            label1.Location = new Point(145, 42);
=======
            label1.Location = new Point(145, 38);
>>>>>>> 9c783497dcf175db3ccf5f17b316c768d9d285b7
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 5;
            label1.Text = "Food(g):";
            // 
            // label2
            // 
            label2.AutoSize = true;
<<<<<<< HEAD
            label2.Location = new Point(91, 138);
=======
            label2.Location = new Point(145, 90);
>>>>>>> 9c783497dcf175db3ccf5f17b316c768d9d285b7
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 6;
            label2.Text = "Missing Food(g):";
            // 
            // label3
            // 
            label3.AutoSize = true;
<<<<<<< HEAD
            label3.Location = new Point(128, 95);
=======
            label3.Location = new Point(145, 137);
>>>>>>> 9c783497dcf175db3ccf5f17b316c768d9d285b7
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 8;
            label3.Text = "Water (ml):";
            // 
            // label4
            // 
            label4.AutoSize = true;
<<<<<<< HEAD
            label4.Location = new Point(74, 183);
=======
            label4.Location = new Point(145, 183);
>>>>>>> 9c783497dcf175db3ccf5f17b316c768d9d285b7
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 7;
            label4.Text = "Missing Water (ml):";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(860, 188);
            dataGridView1.TabIndex = 9;
            // 
            // btnReadAll
            // 
<<<<<<< HEAD
            btnReadAll.Location = new Point(643, 58);
=======
            btnReadAll.Location = new Point(495, 56);
>>>>>>> 9c783497dcf175db3ccf5f17b316c768d9d285b7
            btnReadAll.Name = "btnReadAll";
            btnReadAll.Size = new Size(94, 29);
            btnReadAll.TabIndex = 10;
            btnReadAll.Text = "Read All";
            btnReadAll.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            btnReadAll.Click += button2_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(643, 120);
            label5.MaximumSize = new Size(300, 0);
            label5.Name = "label5";
            label5.Size = new Size(295, 60);
            label5.TabIndex = 11;
            label5.Text = "After first record it will update the record for today. A new record will be on the next day.";
            // 
            // numExpFood
            // 
            numExpFood.Location = new Point(419, 39);
            numExpFood.Name = "numExpFood";
            numExpFood.Size = new Size(150, 27);
            numExpFood.TabIndex = 12;
            // 
            // numExpWater
            // 
            numExpWater.Location = new Point(419, 131);
            numExpWater.Name = "numExpWater";
            numExpWater.Size = new Size(150, 27);
            numExpWater.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(419, 16);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 14;
            label6.Text = "Expected Food (g):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(419, 108);
            label7.Name = "label7";
            label7.Size = new Size(147, 20);
            label7.TabIndex = 15;
            label7.Text = "Expected Water (ml):";
=======
            btnReadAll.Click += btnReadAll_Click_1;
>>>>>>> 9c783497dcf175db3ccf5f17b316c768d9d285b7
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< HEAD
            ClientSize = new Size(959, 564);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(numExpWater);
            Controls.Add(numExpFood);
            Controls.Add(label5);
=======
            ClientSize = new Size(800, 450);
>>>>>>> 9c783497dcf175db3ccf5f17b316c768d9d285b7
            Controls.Add(btnReadAll);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMissingWater);
            Controls.Add(txtWater);
            Controls.Add(txtMissingFood);
            Controls.Add(txtfood);
            Controls.Add(btnInsert);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numExpFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)numExpWater).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsert;
        private TextBox txtfood;
        private TextBox txtMissingFood;
        private TextBox txtWater;
        private TextBox txtMissingWater;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Button btnReadAll;
<<<<<<< HEAD
        private Label label5;
        private NumericUpDown numExpFood;
        private NumericUpDown numExpWater;
        private Label label6;
        private Label label7;
=======
>>>>>>> 9c783497dcf175db3ccf5f17b316c768d9d285b7
    }
}
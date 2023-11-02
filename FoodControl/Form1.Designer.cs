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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(485, 122);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Add";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click_1;
            // 
            // txtfood
            // 
            txtfood.Location = new Point(234, 35);
            txtfood.Name = "txtfood";
            txtfood.Size = new Size(125, 27);
            txtfood.TabIndex = 1;
            // 
            // txtMissingFood
            // 
            txtMissingFood.Location = new Point(234, 83);
            txtMissingFood.Name = "txtMissingFood";
            txtMissingFood.Size = new Size(125, 27);
            txtMissingFood.TabIndex = 2;
            // 
            // txtWater
            // 
            txtWater.Location = new Point(234, 130);
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
            label1.Location = new Point(145, 38);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 90);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 137);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 8;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(145, 183);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(441, 213);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 9;
            // 
            // btnReadAll
            // 
            btnReadAll.Location = new Point(495, 56);
            btnReadAll.Name = "btnReadAll";
            btnReadAll.Size = new Size(94, 29);
            btnReadAll.TabIndex = 10;
            btnReadAll.Text = "Read All";
            btnReadAll.UseVisualStyleBackColor = true;
            btnReadAll.Click += btnReadAll_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
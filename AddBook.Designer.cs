namespace Library_Management_System
{
    partial class AddBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            BookName = new TextBox();
            ISBN = new TextBox();
            Category = new TextBox();
            Quantity = new TextBox();
            PublishDate = new DateTimePicker();
            BookSave = new Button();
            BookCancel = new Button();
            textBox1 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(61, 57);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 0;
            label1.Text = "Book Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(61, 100);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 1;
            label2.Text = "ISBN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(61, 147);
            label3.Name = "label3";
            label3.Size = new Size(84, 17);
            label3.TabIndex = 2;
            label3.Text = "Publish Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(61, 196);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 3;
            label4.Text = "Category";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(61, 244);
            label5.Name = "label5";
            label5.Size = new Size(61, 17);
            label5.TabIndex = 4;
            label5.Text = "Quantity";
            // 
            // BookName
            // 
            BookName.Location = new Point(146, 54);
            BookName.Name = "BookName";
            BookName.Size = new Size(333, 23);
            BookName.TabIndex = 5;
            // 
            // ISBN
            // 
            ISBN.Location = new Point(146, 97);
            ISBN.Name = "ISBN";
            ISBN.Size = new Size(333, 23);
            ISBN.TabIndex = 6;
            // 
            // Category
            // 
            Category.Location = new Point(146, 193);
            Category.Name = "Category";
            Category.Size = new Size(333, 23);
            Category.TabIndex = 8;
            // 
            // Quantity
            // 
            Quantity.Location = new Point(146, 241);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(333, 23);
            Quantity.TabIndex = 9;
            // 
            // PublishDate
            // 
            PublishDate.Location = new Point(146, 147);
            PublishDate.Name = "PublishDate";
            PublishDate.Size = new Size(333, 23);
            PublishDate.TabIndex = 10;
            // 
            // BookSave
            // 
            BookSave.BackColor = Color.Green;
            BookSave.FlatStyle = FlatStyle.Flat;
            BookSave.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BookSave.ForeColor = Color.White;
            BookSave.Location = new Point(61, 332);
            BookSave.Name = "BookSave";
            BookSave.Size = new Size(418, 45);
            BookSave.TabIndex = 11;
            BookSave.Text = "Save";
            BookSave.UseVisualStyleBackColor = false;
            BookSave.Click += BookSave_Click;
            // 
            // BookCancel
            // 
            BookCancel.BackColor = Color.Maroon;
            BookCancel.FlatStyle = FlatStyle.Flat;
            BookCancel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            BookCancel.ForeColor = Color.White;
            BookCancel.Location = new Point(61, 383);
            BookCancel.Name = "BookCancel";
            BookCancel.Size = new Size(418, 45);
            BookCancel.TabIndex = 12;
            BookCancel.Text = "Cancel";
            BookCancel.UseVisualStyleBackColor = false;
            BookCancel.Click += BookCancel_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 292);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 23);
            textBox1.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(61, 295);
            label6.Name = "label6";
            label6.Size = new Size(51, 17);
            label6.TabIndex = 13;
            label6.Text = "Author";
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(BookCancel);
            Controls.Add(BookSave);
            Controls.Add(PublishDate);
            Controls.Add(Quantity);
            Controls.Add(Category);
            Controls.Add(ISBN);
            Controls.Add(BookName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddBook";
            Size = new Size(541, 478);
            Load += AddBook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox BookName;
        private TextBox ISBN;
        private TextBox Category;
        private TextBox Quantity;
        private DateTimePicker PublishDate;
        private Button BookSave;
        public Button BookCancel;
        private TextBox textBox1;
        private Label label6;
    }
}

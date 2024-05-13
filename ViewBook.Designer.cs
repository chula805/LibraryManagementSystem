namespace Library_Management_System
{
    partial class ViewBook
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
            comboBox1 = new ComboBox();
            SearchBook = new Button();
            BookView = new Panel();
            dataGridView1 = new DataGridView();
            SelectType = new TextBox();
            BookView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ISBN", "Book Name", "Category" });
            comboBox1.Location = new Point(54, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(156, 23);
            comboBox1.TabIndex = 0;
            comboBox1.Text = "Select From Dropdown";
            // 
            // SearchBook
            // 
            SearchBook.BackColor = Color.Green;
            SearchBook.FlatAppearance.BorderSize = 0;
            SearchBook.FlatStyle = FlatStyle.Flat;
            SearchBook.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBook.ForeColor = Color.White;
            SearchBook.Location = new Point(413, 55);
            SearchBook.Name = "SearchBook";
            SearchBook.Size = new Size(77, 33);
            SearchBook.TabIndex = 1;
            SearchBook.Text = "Search";
            SearchBook.UseVisualStyleBackColor = false;
            SearchBook.Click += SearchBook_Click;
            // 
            // BookView
            // 
            BookView.Controls.Add(dataGridView1);
            BookView.Location = new Point(54, 95);
            BookView.Name = "BookView";
            BookView.Size = new Size(439, 367);
            BookView.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(439, 342);
            dataGridView1.TabIndex = 0;
            // 
            // SelectType
            // 
            SelectType.Location = new Point(216, 55);
            SelectType.Name = "SelectType";
            SelectType.Size = new Size(191, 23);
            SelectType.TabIndex = 3;
            // 
            // ViewBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(SelectType);
            Controls.Add(BookView);
            Controls.Add(SearchBook);
            Controls.Add(comboBox1);
            Name = "ViewBook";
            Size = new Size(541, 478);
            BookView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button SearchBook;
        private Panel BookView;
        private DataGridView dataGridView1;
        private TextBox SelectType;
    }
}

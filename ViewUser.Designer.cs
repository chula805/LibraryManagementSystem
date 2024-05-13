namespace Library_Management_System
{
    partial class ViewUser
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
            text = new TextBox();
            BookView = new Panel();
            dataGridView1 = new DataGridView();
            SearchBook = new Button();
            UserID = new Label();
            BookView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // text
            // 
            text.Location = new Point(131, 59);
            text.Name = "text";
            text.Size = new Size(240, 23);
            text.TabIndex = 7;
            // 
            // BookView
            // 
            BookView.Controls.Add(dataGridView1);
            BookView.Location = new Point(54, 100);
            BookView.Name = "BookView";
            BookView.Size = new Size(439, 318);
            BookView.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(436, 315);
            dataGridView1.TabIndex = 0;
            // 
            // SearchBook
            // 
            SearchBook.BackColor = Color.Green;
            SearchBook.FlatAppearance.BorderSize = 0;
            SearchBook.FlatStyle = FlatStyle.Flat;
            SearchBook.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SearchBook.ForeColor = Color.White;
            SearchBook.Location = new Point(377, 58);
            SearchBook.Name = "SearchBook";
            SearchBook.Size = new Size(104, 33);
            SearchBook.TabIndex = 5;
            SearchBook.Text = "Search";
            SearchBook.UseVisualStyleBackColor = false;
            SearchBook.Click += SearchBook_Click;
            // 
            // UserID
            // 
            UserID.AutoSize = true;
            UserID.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            UserID.Location = new Point(57, 60);
            UserID.Name = "UserID";
            UserID.Size = new Size(52, 17);
            UserID.TabIndex = 8;
            UserID.Text = "User ID";
            // 
            // ViewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(UserID);
            Controls.Add(text);
            Controls.Add(BookView);
            Controls.Add(SearchBook);
            Name = "ViewUser";
            Size = new Size(541, 478);
            BookView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox text;
        private Panel BookView;
        private DataGridView dataGridView1;
        private Button SearchBook;
        private Label UserID;
    }
}

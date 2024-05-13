namespace Library_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox2 = new PictureBox();
            Username = new Label();
            UsernameText = new TextBox();
            button1 = new Button();
            PasswordText = new TextBox();
            Password = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.login;
            pictureBox2.Location = new Point(643, 100);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(120, 78);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Username
            // 
            Username.Anchor = AnchorStyles.None;
            Username.AutoSize = true;
            Username.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Username.ForeColor = Color.Black;
            Username.Location = new Point(583, 214);
            Username.Name = "Username";
            Username.Size = new Size(95, 22);
            Username.TabIndex = 2;
            Username.Text = "Username";
            // 
            // UsernameText
            // 
            UsernameText.Anchor = AnchorStyles.None;
            UsernameText.Location = new Point(587, 247);
            UsernameText.Margin = new Padding(0);
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(229, 24);
            UsernameText.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Maroon;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cooper Black", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(587, 389);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(230, 40);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PasswordText
            // 
            PasswordText.Anchor = AnchorStyles.None;
            PasswordText.Location = new Point(587, 328);
            PasswordText.Margin = new Padding(0);
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(229, 24);
            PasswordText.TabIndex = 8;
            PasswordText.TextChanged += PasswordText_TextChanged;
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.None;
            Password.AutoSize = true;
            Password.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Password.ForeColor = Color.Black;
            Password.Location = new Point(583, 295);
            Password.Name = "Password";
            Password.Size = new Size(90, 22);
            Password.TabIndex = 7;
            Password.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.SignIn_img;
            pictureBox1.Location = new Point(18, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(427, 455);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 542);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Matura MT Script Capitals", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(28, 26);
            label1.Name = "label1";
            label1.Size = new Size(402, 36);
            label1.TabIndex = 1;
            label1.Text = "Library Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(902, 7);
            label2.Name = "label2";
            label2.Size = new Size(17, 17);
            label2.TabIndex = 10;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(923, 542);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(PasswordText);
            Controls.Add(Password);
            Controls.Add(button1);
            Controls.Add(UsernameText);
            Controls.Add(Username);
            Controls.Add(pictureBox2);
            Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Linen;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Label Username;
        private TextBox UsernameText;
        private Button button1;
        private TextBox PasswordText;
        private Label Password;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
    }
}
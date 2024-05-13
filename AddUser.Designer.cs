namespace Library_Management_System
{
    partial class Add_User
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
            Uname = new TextBox();
            UID = new TextBox();
            label2 = new Label();
            UContact = new TextBox();
            label3 = new Label();
            UEmail = new TextBox();
            label4 = new Label();
            Save = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(73, 60);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // Uname
            // 
            Uname.Location = new Point(73, 91);
            Uname.Name = "Uname";
            Uname.Size = new Size(401, 25);
            Uname.TabIndex = 1;
            // 
            // UID
            // 
            UID.Location = new Point(73, 162);
            UID.Name = "UID";
            UID.Size = new Size(401, 25);
            UID.TabIndex = 3;
            UID.Text = "XXXX-YY-ZZZ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(73, 131);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 2;
            label2.Text = "User ID";
            // 
            // UContact
            // 
            UContact.Location = new Point(73, 237);
            UContact.Name = "UContact";
            UContact.Size = new Size(401, 25);
            UContact.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(73, 206);
            label3.Name = "label3";
            label3.Size = new Size(109, 17);
            label3.TabIndex = 4;
            label3.Text = "Contact Number";
            // 
            // UEmail
            // 
            UEmail.Location = new Point(73, 316);
            UEmail.Name = "UEmail";
            UEmail.Size = new Size(401, 25);
            UEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(73, 286);
            label4.Name = "label4";
            label4.Size = new Size(40, 17);
            label4.TabIndex = 6;
            label4.Text = "Email";
            // 
            // Save
            // 
            Save.BackColor = Color.Green;
            Save.FlatAppearance.BorderSize = 0;
            Save.FlatStyle = FlatStyle.Flat;
            Save.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Save.ForeColor = Color.White;
            Save.Location = new Point(73, 363);
            Save.Name = "Save";
            Save.Size = new Size(401, 45);
            Save.TabIndex = 8;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // Add_User
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(Save);
            Controls.Add(UEmail);
            Controls.Add(label4);
            Controls.Add(UContact);
            Controls.Add(label3);
            Controls.Add(UID);
            Controls.Add(label2);
            Controls.Add(Uname);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Add_User";
            Size = new Size(541, 478);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Uname;
        private TextBox UID;
        private Label label2;
        private TextBox UContact;
        private Label label3;
        private TextBox UEmail;
        private Label label4;
        private Button Save;
        private Button button1;
    }
}

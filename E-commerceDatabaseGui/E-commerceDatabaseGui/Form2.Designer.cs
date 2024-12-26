namespace E_commerceDatabaseGui
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePicker1 = new DateTimePicker();
            lbl_birth = new Label();
            lstbox_gender = new ListBox();
            lbl_gender = new Label();
            txt_password = new TextBox();
            lbl_password = new Label();
            txt_email = new TextBox();
            lbl_email = new Label();
            txt_name = new TextBox();
            lbl_name = new Label();
            txt_id = new TextBox();
            lbl_id = new Label();
            txt_address = new TextBox();
            lbl_address = new Label();
            btn_add = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(715, 103);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(252, 27);
            dateTimePicker1.TabIndex = 23;
            // 
            // lbl_birth
            // 
            lbl_birth.AutoSize = true;
            lbl_birth.Font = new Font("Segoe UI", 12F);
            lbl_birth.Location = new Point(556, 101);
            lbl_birth.Name = "lbl_birth";
            lbl_birth.Size = new Size(99, 28);
            lbl_birth.TabIndex = 22;
            lbl_birth.Text = "Birth Date";
            // 
            // lstbox_gender
            // 
            lstbox_gender.FormattingEnabled = true;
            lstbox_gender.Items.AddRange(new object[] { "Male", "Female" });
            lstbox_gender.Location = new Point(715, 40);
            lstbox_gender.Name = "lstbox_gender";
            lstbox_gender.Size = new Size(252, 24);
            lstbox_gender.TabIndex = 21;
            // 
            // lbl_gender
            // 
            lbl_gender.AutoSize = true;
            lbl_gender.Font = new Font("Segoe UI", 12F);
            lbl_gender.Location = new Point(556, 40);
            lbl_gender.Name = "lbl_gender";
            lbl_gender.Size = new Size(76, 28);
            lbl_gender.TabIndex = 20;
            lbl_gender.Text = "Gender";
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 10F);
            txt_password.Location = new Point(199, 239);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(252, 30);
            txt_password.TabIndex = 19;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI", 12F);
            lbl_password.Location = new Point(40, 237);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(93, 28);
            lbl_password.TabIndex = 18;
            lbl_password.Text = "Password";
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 10F);
            txt_email.Location = new Point(199, 170);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(252, 30);
            txt_email.TabIndex = 17;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Segoe UI", 12F);
            lbl_email.Location = new Point(40, 168);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(59, 28);
            lbl_email.TabIndex = 16;
            lbl_email.Text = "Email";
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 10F);
            txt_name.Location = new Point(199, 103);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(252, 30);
            txt_name.TabIndex = 15;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new Font("Segoe UI", 12F);
            lbl_name.Location = new Point(40, 101);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(64, 28);
            lbl_name.TabIndex = 14;
            lbl_name.Text = "Name";
            // 
            // txt_id
            // 
            txt_id.Font = new Font("Segoe UI", 10F);
            txt_id.Location = new Point(199, 38);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(252, 30);
            txt_id.TabIndex = 13;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Segoe UI", 12F);
            lbl_id.Location = new Point(40, 36);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(120, 28);
            lbl_id.TabIndex = 12;
            lbl_id.Text = "Customer ID";
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Segoe UI", 10F);
            txt_address.Location = new Point(715, 170);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(252, 30);
            txt_address.TabIndex = 25;
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Font = new Font("Segoe UI", 12F);
            lbl_address.Location = new Point(556, 168);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(82, 28);
            lbl_address.TabIndex = 24;
            lbl_address.Text = "Address";
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 12F);
            btn_add.Location = new Point(411, 325);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(209, 65);
            btn_add.TabIndex = 26;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += button_add_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 417);
            Controls.Add(btn_add);
            Controls.Add(txt_address);
            Controls.Add(lbl_address);
            Controls.Add(dateTimePicker1);
            Controls.Add(lbl_birth);
            Controls.Add(lstbox_gender);
            Controls.Add(lbl_gender);
            Controls.Add(txt_password);
            Controls.Add(lbl_password);
            Controls.Add(txt_email);
            Controls.Add(lbl_email);
            Controls.Add(txt_name);
            Controls.Add(lbl_name);
            Controls.Add(txt_id);
            Controls.Add(lbl_id);
            Name = "Form2";
            Text = "Add a Customer";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label lbl_birth;
        private ListBox lstbox_gender;
        private Label lbl_gender;
        private TextBox txt_password;
        private Label lbl_password;
        private TextBox txt_email;
        private Label lbl_email;
        private TextBox txt_name;
        private Label lbl_name;
        private TextBox txt_id;
        private Label lbl_id;
        private TextBox txt_address;
        private Label lbl_address;
        private Button btn_add;
    }
}
namespace E_commerceDatabaseGui
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
            txtbox_id = new TextBox();
            lbl_id = new Label();
            btn_view = new Button();
            btn_modify = new Button();
            btn_delete = new Button();
            btn_add = new Button();
            SuspendLayout();
            // 
            // txtbox_id
            // 
            txtbox_id.Font = new Font("Segoe UI", 10F);
            txtbox_id.Location = new Point(201, 74);
            txtbox_id.Name = "txtbox_id";
            txtbox_id.Size = new Size(145, 30);
            txtbox_id.TabIndex = 15;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Segoe UI", 12F);
            lbl_id.Location = new Point(54, 72);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(120, 28);
            lbl_id.TabIndex = 14;
            lbl_id.Text = "Customer ID";
            // 
            // btn_view
            // 
            btn_view.Font = new Font("Segoe UI", 10F);
            btn_view.Location = new Point(79, 307);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(241, 57);
            btn_view.TabIndex = 16;
            btn_view.Text = "View All Customers";
            btn_view.UseVisualStyleBackColor = true;
            btn_view.Click += btn_view_Click;
            // 
            // btn_modify
            // 
            btn_modify.Font = new Font("Segoe UI", 10F);
            btn_modify.Location = new Point(79, 232);
            btn_modify.Name = "btn_modify";
            btn_modify.Size = new Size(241, 57);
            btn_modify.TabIndex = 17;
            btn_modify.Text = "Modify Customer Info";
            btn_modify.UseVisualStyleBackColor = true;
            btn_modify.Click += btn_modify_Click;
            // 
            // btn_delete
            // 
            btn_delete.Font = new Font("Segoe UI", 10F);
            btn_delete.Location = new Point(79, 385);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(241, 57);
            btn_delete.TabIndex = 18;
            btn_delete.Text = "Delete a Customer";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 10F);
            btn_add.Location = new Point(79, 156);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(241, 57);
            btn_add.TabIndex = 19;
            btn_add.Text = "Add a Customer";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 482);
            Controls.Add(btn_add);
            Controls.Add(btn_delete);
            Controls.Add(btn_modify);
            Controls.Add(btn_view);
            Controls.Add(txtbox_id);
            Controls.Add(lbl_id);
            Name = "Form1";
            Text = "E-Commerce Platform";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbox_id;
        private Label lbl_id;
        private Button btn_view;
        private Button btn_modify;
        private Button btn_delete;
        private Button btn_add;
    }
}

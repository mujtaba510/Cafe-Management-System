namespace DB_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            roleLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            roleTextBox = new ComboBox();
            Phone = new Label();
            textBox3 = new TextBox();
            rolenum = new Label();
            textBox4 = new TextBox();
            facultyid = new Label();
            facultyidtextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1263, 680);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(481, 9);
            label1.Name = "label1";
            label1.Size = new Size(246, 54);
            label1.TabIndex = 1;
            label1.Text = "Registation";
            label1.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(24, 58);
            label4.Name = "label4";
            label4.Size = new Size(230, 55);
            label4.TabIndex = 10;
            label4.Text = "User Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(24, 118);
            label2.Name = "label2";
            label2.Size = new Size(145, 55);
            label2.TabIndex = 11;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(24, 179);
            label3.Name = "label3";
            label3.Size = new Size(221, 55);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "STUDENT", "FACULTY" });
            comboBox1.Location = new Point(351, 84);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(326, 27);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(351, 118);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(326, 42);
            textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(351, 179);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(326, 42);
            textBox2.TabIndex = 15;
            // 
            // roleLabel
            // 
            roleLabel.AutoSize = true;
            roleLabel.BackColor = SystemColors.ActiveCaptionText;
            roleLabel.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            roleLabel.ForeColor = SystemColors.Control;
            roleLabel.Location = new Point(24, 364);
            roleLabel.Name = "roleLabel";
            roleLabel.Size = new Size(117, 55);
            roleLabel.TabIndex = 16;
            roleLabel.Text = "Role";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(896, 451);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(150, 38);
            button1.TabIndex = 18;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(10, 458);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(150, 38);
            button2.TabIndex = 19;
            button2.Text = "EXIT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // roleTextBox
            // 
            roleTextBox.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            roleTextBox.FormattingEnabled = true;
            roleTextBox.Items.AddRange(new object[] { "Visiting", "Instructor", "Professor", "Hod" });
            roleTextBox.Location = new Point(345, 382);
            roleTextBox.Margin = new Padding(3, 2, 3, 2);
            roleTextBox.Name = "roleTextBox";
            roleTextBox.Size = new Size(326, 27);
            roleTextBox.TabIndex = 20;
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.BackColor = SystemColors.ActiveCaptionText;
            Phone.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            Phone.ForeColor = SystemColors.Control;
            Phone.Location = new Point(24, 238);
            Phone.Name = "Phone";
            Phone.Size = new Size(150, 55);
            Phone.TabIndex = 21;
            Phone.Text = "Phone";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.Location = new Point(351, 238);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(326, 42);
            textBox3.TabIndex = 22;
            // 
            // rolenum
            // 
            rolenum.AutoSize = true;
            rolenum.BackColor = SystemColors.ActiveCaptionText;
            rolenum.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            rolenum.ForeColor = SystemColors.Control;
            rolenum.Location = new Point(24, 298);
            rolenum.Name = "rolenum";
            rolenum.Size = new Size(231, 55);
            rolenum.TabIndex = 23;
            rolenum.Text = "Role Num";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(351, 312);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(326, 42);
            textBox4.TabIndex = 24;
            // 
            // facultyid
            // 
            facultyid.AutoSize = true;
            facultyid.BackColor = SystemColors.ActiveCaptionText;
            facultyid.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point);
            facultyid.ForeColor = SystemColors.Control;
            facultyid.Location = new Point(24, 298);
            facultyid.Name = "facultyid";
            facultyid.Size = new Size(243, 55);
            facultyid.TabIndex = 25;
            facultyid.Text = "Faculty ID";
            // 
            // facultyidtextbox
            // 
            facultyidtextbox.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            facultyidtextbox.Location = new Point(351, 312);
            facultyidtextbox.Margin = new Padding(3, 2, 3, 2);
            facultyidtextbox.Name = "facultyidtextbox";
            facultyidtextbox.Size = new Size(326, 42);
            facultyidtextbox.TabIndex = 26;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(facultyidtextbox);
            Controls.Add(facultyid);
            Controls.Add(textBox4);
            Controls.Add(rolenum);
            Controls.Add(textBox3);
            Controls.Add(Phone);
            Controls.Add(roleTextBox);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(roleLabel);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label roleLabel;
        private Button button1;
        private Button button2;
        private ComboBox roleTextBox;
        private Label Phone;
        private TextBox textBox3;
        private Label rolenum;
        private TextBox textBox4;
        private Label facultyid;
        private TextBox facultyidtextbox;
    }
}
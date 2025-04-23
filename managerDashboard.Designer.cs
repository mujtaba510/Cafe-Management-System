namespace DB_Project
{
    partial class managerDashboard
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 68);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "View Employees";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 100);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 1;
            label2.Text = "Add Item In Inventory ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 25);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 131);
            label4.Name = "label4";
            label4.Size = new Size(130, 15);
            label4.TabIndex = 3;
            label4.Text = "View Staff Performance";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(107, 163);
            label5.Name = "label5";
            label5.Size = new Size(162, 15);
            label5.TabIndex = 4;
            label5.Text = "Check Menu Item Availability";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(110, 199);
            label6.Name = "label6";
            label6.Size = new Size(117, 15);
            label6.TabIndex = 5;
            label6.Text = "Orders And Payment";
            // 
            // managerDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "managerDashboard";
            Text = "managerDashboard";
            Load += managerDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
    }
}
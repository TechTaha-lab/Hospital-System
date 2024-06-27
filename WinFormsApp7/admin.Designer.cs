namespace WinFormsApp7
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            textBox4 = new TextBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            textBox3 = new TextBox();
            label9 = new Label();
            button3 = new Button();
            label5 = new Label();
            tabPage3 = new TabPage();
            button4 = new Button();
            textBox6 = new TextBox();
            label13 = new Label();
            comboBox3 = new ComboBox();
            label12 = new Label();
            textBox5 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(2, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(796, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(788, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add/Remove employee";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(55, 329);
            button2.Name = "button2";
            button2.Size = new Size(136, 33);
            button2.TabIndex = 15;
            button2.Text = "delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(80, 285);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(147, 23);
            textBox4.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(26, 284);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 11;
            label6.Text = "Name:";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "patient", "nurse", "doctor" });
            comboBox2.Location = new Point(319, 284);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(145, 23);
            comboBox2.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(265, 283);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 9;
            label7.Text = "Roles:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(26, 230);
            label8.Name = "label8";
            label8.Size = new Size(165, 25);
            label8.TabIndex = 8;
            label8.Text = "Remove employee";
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(319, 109);
            button1.Name = "button1";
            button1.Size = new Size(136, 33);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(80, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(147, 23);
            textBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(26, 118);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 5;
            label4.Text = "Pass:\r\n";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 23);
            textBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 77);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "Name:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "patient", "nurse", "doctor" });
            comboBox1.Location = new Point(319, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(145, 23);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(265, 76);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Roles:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 23);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 0;
            label1.Text = "Add Employee:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listView1);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(788, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "available Employee";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(130, 200);
            listView1.Name = "listView1";
            listView1.Size = new Size(457, 97);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "roles";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 200;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(130, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(306, 23);
            textBox3.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(44, 105);
            label9.Name = "label9";
            label9.Size = new Size(66, 25);
            label9.TabIndex = 3;
            label9.Text = "Name:";
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(462, 105);
            button3.Name = "button3";
            button3.Size = new Size(128, 35);
            button3.TabIndex = 2;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(35, 31);
            label5.Name = "label5";
            label5.Size = new Size(180, 25);
            label5.TabIndex = 1;
            label5.Text = "Available Employee:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(textBox6);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(comboBox3);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(textBox5);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label10);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(788, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "FInd password";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button4.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonFace;
            button4.Location = new Point(136, 326);
            button4.Name = "button4";
            button4.Size = new Size(205, 43);
            button4.TabIndex = 9;
            button4.Text = "Find Password";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(136, 182);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(213, 94);
            textBox6.TabIndex = 8;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(60, 177);
            label13.Name = "label13";
            label13.Size = new Size(66, 25);
            label13.TabIndex = 7;
            label13.Text = "Result:";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "patient", "nurse", "doctor" });
            comboBox3.Location = new Point(142, 129);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(213, 23);
            comboBox3.TabIndex = 6;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(60, 129);
            label12.Name = "label12";
            label12.Size = new Size(60, 25);
            label12.TabIndex = 5;
            label12.Text = "Roles:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(142, 81);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(213, 23);
            textBox5.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(60, 76);
            label11.Name = "label11";
            label11.Size = new Size(66, 25);
            label11.TabIndex = 3;
            label11.Text = "Name:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(24, 35);
            label10.Name = "label10";
            label10.Size = new Size(132, 25);
            label10.TabIndex = 2;
            label10.Text = "Find Password";
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin dashboard";
            Load += admin_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button2;
        private TextBox textBox4;
        private Label label6;
        private ComboBox comboBox2;
        private Label label7;
        private Label label8;
        private Button button1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private ComboBox comboBox1;
        private ListView listView1;
        private TextBox textBox3;
        private Label label9;
        private Button button3;
        private Label label5;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button4;
        private TextBox textBox6;
        private Label label13;
        private ComboBox comboBox3;
        private Label label12;
        private TextBox textBox5;
        private Label label11;
        private Label label10;
    }
}
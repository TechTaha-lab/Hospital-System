﻿namespace WinFormsApp7
{
    partial class patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patient));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            l1 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            l2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            button2 = new Button();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tabPage3 = new TabPage();
            dateTimePicker1 = new DateTimePicker();
            label12 = new Label();
            button3 = new Button();
            textBox4 = new TextBox();
            label9 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tabPage4 = new TabPage();
            listView1 = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            button4 = new Button();
            textBox5 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(2, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(796, 450);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(l1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(788, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Available Doctor";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // l1
            // 
            l1.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader5 });
            l1.Location = new Point(166, 167);
            l1.Name = "l1";
            l1.Size = new Size(404, 97);
            l1.TabIndex = 4;
            l1.UseCompatibleStateImageBehavior = false;
            l1.View = View.Details;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Id";
            columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Name";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 200;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(190, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(441, 60);
            button1.Name = "button1";
            button1.Size = new Size(191, 32);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(92, 67);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 1;
            label2.Text = "Doctor Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 29);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 0;
            label1.Text = "Available Doctor";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(l2);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(788, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Available Nurse";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // l2
            // 
            l2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            l2.Location = new Point(177, 169);
            l2.Name = "l2";
            l2.Size = new Size(404, 97);
            l2.TabIndex = 9;
            l2.UseCompatibleStateImageBehavior = false;
            l2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 200;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(452, 62);
            button2.Name = "button2";
            button2.Size = new Size(191, 32);
            button2.TabIndex = 8;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(201, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 23);
            textBox2.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(103, 69);
            label3.Name = "label3";
            label3.Size = new Size(88, 19);
            label3.TabIndex = 6;
            label3.Text = "Nurse Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 31);
            label4.Name = "label4";
            label4.Size = new Size(144, 25);
            label4.TabIndex = 5;
            label4.Text = "Available Nurse";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dateTimePicker1);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(textBox4);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(comboBox2);
            tabPage3.Controls.Add(comboBox1);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(788, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Make Appointment";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(184, 218);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(162, 23);
            dateTimePicker1.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Nirmala UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(74, 218);
            label12.Name = "label12";
            label12.Size = new Size(41, 19);
            label12.TabIndex = 16;
            label12.Text = "Date:";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLight;
            button3.Location = new Point(151, 350);
            button3.Name = "button3";
            button3.Size = new Size(194, 41);
            button3.TabIndex = 15;
            button3.Text = "Book Appoinmtent";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(184, 268);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(162, 66);
            textBox4.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nirmala UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(74, 268);
            label9.Name = "label9";
            label9.Size = new Size(81, 19);
            label9.TabIndex = 13;
            label9.Text = "Description:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(184, 173);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(162, 23);
            textBox3.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(74, 173);
            label8.Name = "label8";
            label8.Size = new Size(95, 19);
            label8.TabIndex = 11;
            label8.Text = "Patient Name:";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(184, 122);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(155, 23);
            comboBox2.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(184, 73);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(155, 23);
            comboBox1.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(74, 122);
            label7.Name = "label7";
            label7.Size = new Size(88, 19);
            label7.TabIndex = 8;
            label7.Text = "Nurse Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(74, 73);
            label6.Name = "label6";
            label6.Size = new Size(94, 19);
            label6.TabIndex = 7;
            label6.Text = "Doctor Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(26, 31);
            label5.Name = "label5";
            label5.Size = new Size(229, 25);
            label5.TabIndex = 6;
            label5.Text = "Book A New Appointment";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(listView1);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(textBox5);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(label10);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(788, 422);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Medicine";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader6, columnHeader7 });
            listView1.Location = new Point(123, 170);
            listView1.Name = "listView1";
            listView1.Size = new Size(465, 97);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Id";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Medicine Name";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "description";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 200;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button4.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(453, 61);
            button4.Name = "button4";
            button4.Size = new Size(135, 34);
            button4.TabIndex = 10;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(196, 69);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(241, 23);
            textBox5.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Nirmala UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(110, 69);
            label11.Name = "label11";
            label11.Size = new Size(80, 19);
            label11.TabIndex = 8;
            label11.Text = "Your Name:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(17, 22);
            label10.Name = "label10";
            label10.Size = new Size(201, 25);
            label10.TabIndex = 7;
            label10.Text = "Search For A Medicine";
            // 
            // patient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "patient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Patient Dashboard";
            Load += patient_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListView l1;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private ListView l2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button button2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label5;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label7;
        private Label label6;
        private Button button3;
        private TextBox textBox4;
        private Label label9;
        private TextBox textBox3;
        private Label label8;
        private Button button4;
        private TextBox textBox5;
        private Label label11;
        private Label label10;
        private ListView listView1;
        private Label label12;
        private DateTimePicker dateTimePicker1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}
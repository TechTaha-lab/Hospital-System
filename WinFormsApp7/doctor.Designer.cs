namespace WinFormsApp7
{
    partial class doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doctor));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            l1 = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            button1 = new Button();
            textBox1 = new TextBox();
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
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            listView3 = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            button3 = new Button();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tabPage4 = new TabPage();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button4 = new Button();
            textBox7 = new TextBox();
            label11 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            patientToolStripMenuItem = new ToolStripMenuItem();
            nurseToolStripMenuItem = new ToolStripMenuItem();
            doctorToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(5, 33);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(793, 417);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(l1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(785, 389);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Available Patient";
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(467, 57);
            button1.Name = "button1";
            button1.Size = new Size(191, 32);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(190, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(245, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(89, 64);
            label2.Name = "label2";
            label2.Size = new Size(95, 19);
            label2.TabIndex = 1;
            label2.Text = "Patient Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 26);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 0;
            label1.Text = "Available Patient";
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
            tabPage2.Size = new Size(785, 389);
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
            button2.Location = new Point(452, 66);
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
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(100, 66);
            label3.Name = "label3";
            label3.Size = new Size(88, 19);
            label3.TabIndex = 6;
            label3.Text = "Nurse Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(40, 28);
            label4.Name = "label4";
            label4.Size = new Size(144, 25);
            label4.TabIndex = 5;
            label4.Text = "Available Nurse";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(radioButton3);
            tabPage3.Controls.Add(radioButton4);
            tabPage3.Controls.Add(listView3);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label6);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(785, 389);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Appointment";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(637, 328);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(45, 19);
            radioButton3.TabIndex = 23;
            radioButton3.TabStop = true;
            radioButton3.Text = "Red";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(637, 299);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(51, 19);
            radioButton4.TabIndex = 22;
            radioButton4.TabStop = true;
            radioButton4.Text = "Blue ";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader6, columnHeader7, columnHeader8 });
            listView3.Location = new Point(74, 166);
            listView3.Name = "listView3";
            listView3.Size = new Size(624, 97);
            listView3.TabIndex = 13;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Id";
            columnHeader3.Width = 70;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Patient Name";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Time";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Description";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 200;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(465, 64);
            button3.Name = "button3";
            button3.Size = new Size(191, 32);
            button3.TabIndex = 12;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(194, 64);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(245, 23);
            textBox3.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(93, 64);
            label5.Name = "label5";
            label5.Size = new Size(24, 19);
            label5.TabIndex = 10;
            label5.Text = "Id:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(33, 26);
            label6.Name = "label6";
            label6.Size = new Size(149, 25);
            label6.TabIndex = 9;
            label6.Text = "All Appointment";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(radioButton2);
            tabPage4.Controls.Add(radioButton1);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(textBox7);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(textBox6);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(textBox5);
            tabPage4.Controls.Add(textBox4);
            tabPage4.Controls.Add(label9);
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(label7);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(785, 389);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Make Medicine";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(512, 79);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(45, 19);
            radioButton2.TabIndex = 21;
            radioButton2.TabStop = true;
            radioButton2.Text = "Red";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(512, 50);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 20;
            radioButton1.TabStop = true;
            radioButton1.Text = "Blue ";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button4.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(102, 253);
            button4.Name = "button4";
            button4.Size = new Size(263, 42);
            button4.TabIndex = 19;
            button4.Text = "Add A New Medicine\r\n";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(188, 149);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(177, 23);
            textBox7.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Nirmala UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(92, 149);
            label11.Name = "label11";
            label11.Size = new Size(78, 19);
            label11.TabIndex = 17;
            label11.Text = "medicine n:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(188, 194);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(177, 23);
            textBox6.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Nirmala UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(92, 194);
            label10.Name = "label10";
            label10.Size = new Size(81, 19);
            label10.TabIndex = 15;
            label10.Text = "Decsription:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(188, 109);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(177, 23);
            textBox5.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(188, 75);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(177, 23);
            textBox4.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nirmala UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(92, 109);
            label9.Name = "label9";
            label9.Size = new Size(93, 19);
            label9.TabIndex = 12;
            label9.Text = "patient name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 10.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(92, 75);
            label8.Name = "label8";
            label8.Size = new Size(90, 19);
            label8.TabIndex = 11;
            label8.Text = "doctor name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(24, 33);
            label7.Name = "label7";
            label7.Size = new Size(211, 25);
            label7.TabIndex = 10;
            label7.Text = "Make A Medicine Paper";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Checked = true;
            toolStripMenuItem1.CheckState = CheckState.Checked;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(49, 20);
            toolStripMenuItem1.Tag = "hello world";
            toolStripMenuItem1.Text = "Login";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { patientToolStripMenuItem, nurseToolStripMenuItem, doctorToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(99, 20);
            toolStripMenuItem2.Text = "employee roles";
            // 
            // patientToolStripMenuItem
            // 
            patientToolStripMenuItem.Name = "patientToolStripMenuItem";
            patientToolStripMenuItem.Size = new Size(111, 22);
            patientToolStripMenuItem.Text = "patient";
            // 
            // nurseToolStripMenuItem
            // 
            nurseToolStripMenuItem.Name = "nurseToolStripMenuItem";
            nurseToolStripMenuItem.Size = new Size(111, 22);
            nurseToolStripMenuItem.Text = "nurse";
            // 
            // doctorToolStripMenuItem
            // 
            doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            doctorToolStripMenuItem.Size = new Size(111, 22);
            doctorToolStripMenuItem.Text = "doctor";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(62, 20);
            toolStripMenuItem3.Text = "Log Out";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(38, 20);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menu";
            // 
            // doctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "doctor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctor Dachboard";
            Load += doctor_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ListView l1;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private ListView l2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button button2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TabPage tabPage4;
        private Button button3;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private ListView listView3;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Label label8;
        private Label label7;
        private Button button4;
        private TextBox textBox7;
        private Label label11;
        private TextBox textBox6;
        private Label label10;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label9;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem patientToolStripMenuItem;
        private ToolStripMenuItem nurseToolStripMenuItem;
        private ToolStripMenuItem doctorToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem exitToolStripMenuItem;
        private MenuStrip menuStrip1;
    }
}
namespace lab_5
{
    partial class Form1
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimeBirth = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDateBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStreet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHouse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFlat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonFind = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxHouse = new System.Windows.Forms.TextBox();
            this.textBoxFlat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFindCity = new System.Windows.Forms.TextBox();
            this.textBoxFindStreet = new System.Windows.Forms.TextBox();
            this.textBoxFindHouse = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxAverageAge = new System.Windows.Forms.TextBox();
            this.labelAverageAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(1048, 70);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(149, 22);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(1048, 204);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(149, 22);
            this.textBoxPhone.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1233, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1233, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1233, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date of Birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1233, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Phone number";
            // 
            // dateTimeBirth
            // 
            this.dateTimeBirth.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimeBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBirth.Location = new System.Drawing.Point(1048, 159);
            this.dateTimeBirth.Name = "dateTimeBirth";
            this.dateTimeBirth.Size = new System.Drawing.Size(149, 22);
            this.dateTimeBirth.TabIndex = 3;
            this.dateTimeBirth.Value = new System.DateTime(2022, 4, 4, 19, 45, 25, 0);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAdd.Location = new System.Drawing.Point(1048, 520);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(101, 47);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Firebrick;
            this.buttonRemove.Location = new System.Drawing.Point(32, 580);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(166, 47);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Visible = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Silver;
            this.buttonSave.Location = new System.Drawing.Point(229, 580);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(166, 47);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save in file";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.BackColor = System.Drawing.Color.Silver;
            this.buttonOpen.Location = new System.Drawing.Point(437, 580);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(166, 47);
            this.buttonOpen.TabIndex = 5;
            this.buttonOpen.Text = "Open from file";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Yellow;
            this.buttonEdit.Location = new System.Drawing.Point(32, 648);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(166, 47);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Visible = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(1061, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Location = new System.Drawing.Point(1168, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnName,
            this.columnSurname,
            this.columnDateBirth,
            this.columnPhone,
            this.columnCity,
            this.columnStreet,
            this.columnHouse,
            this.columnFlat});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 54);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(984, 520);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnId
            // 
            this.columnId.Text = "Id";
            this.columnId.Width = 28;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 79;
            // 
            // columnSurname
            // 
            this.columnSurname.Text = "Surname";
            this.columnSurname.Width = 130;
            // 
            // columnDateBirth
            // 
            this.columnDateBirth.Text = "Date of Birth";
            this.columnDateBirth.Width = 139;
            // 
            // columnPhone
            // 
            this.columnPhone.Text = "Phone number";
            this.columnPhone.Width = 163;
            // 
            // columnCity
            // 
            this.columnCity.Text = "City";
            this.columnCity.Width = 93;
            // 
            // columnStreet
            // 
            this.columnStreet.Text = "Street";
            this.columnStreet.Width = 108;
            // 
            // columnHouse
            // 
            this.columnHouse.Text = "House number";
            this.columnHouse.Width = 103;
            // 
            // columnFlat
            // 
            this.columnFlat.Text = "Flat number";
            this.columnFlat.Width = 118;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(823, 7);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(101, 36);
            this.buttonFind.TabIndex = 9;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(823, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 36);
            this.button3.TabIndex = 9;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1233, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Surname";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(1048, 116);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(149, 22);
            this.textBoxSurname.TabIndex = 1;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(1048, 260);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(149, 22);
            this.textBoxCity.TabIndex = 1;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(1048, 307);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(149, 22);
            this.textBoxStreet.TabIndex = 1;
            // 
            // textBoxHouse
            // 
            this.textBoxHouse.Location = new System.Drawing.Point(1048, 364);
            this.textBoxHouse.Name = "textBoxHouse";
            this.textBoxHouse.Size = new System.Drawing.Size(149, 22);
            this.textBoxHouse.TabIndex = 1;
            // 
            // textBoxFlat
            // 
            this.textBoxFlat.Location = new System.Drawing.Point(1048, 418);
            this.textBoxFlat.Name = "textBoxFlat";
            this.textBoxFlat.Size = new System.Drawing.Size(149, 22);
            this.textBoxFlat.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1233, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1233, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Street";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1233, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "House number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1233, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Flat number";
            // 
            // textBoxFindCity
            // 
            this.textBoxFindCity.Location = new System.Drawing.Point(82, 13);
            this.textBoxFindCity.Name = "textBoxFindCity";
            this.textBoxFindCity.Size = new System.Drawing.Size(149, 22);
            this.textBoxFindCity.TabIndex = 1;
            // 
            // textBoxFindStreet
            // 
            this.textBoxFindStreet.Location = new System.Drawing.Point(308, 12);
            this.textBoxFindStreet.Name = "textBoxFindStreet";
            this.textBoxFindStreet.Size = new System.Drawing.Size(101, 22);
            this.textBoxFindStreet.TabIndex = 1;
            // 
            // textBoxFindHouse
            // 
            this.textBoxFindHouse.Location = new System.Drawing.Point(551, 14);
            this.textBoxFindHouse.Name = "textBoxFindHouse";
            this.textBoxFindHouse.Size = new System.Drawing.Size(89, 22);
            this.textBoxFindHouse.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "City";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(256, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Street";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(434, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "House number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-148, -393);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "House number";
            // 
            // textBoxAverageAge
            // 
            this.textBoxAverageAge.Location = new System.Drawing.Point(865, 595);
            this.textBoxAverageAge.Name = "textBoxAverageAge";
            this.textBoxAverageAge.ReadOnly = true;
            this.textBoxAverageAge.Size = new System.Drawing.Size(124, 22);
            this.textBoxAverageAge.TabIndex = 1;
            // 
            // labelAverageAge
            // 
            this.labelAverageAge.AutoSize = true;
            this.labelAverageAge.CausesValidation = false;
            this.labelAverageAge.Location = new System.Drawing.Point(751, 600);
            this.labelAverageAge.Name = "labelAverageAge";
            this.labelAverageAge.Size = new System.Drawing.Size(86, 16);
            this.labelAverageAge.TabIndex = 2;
            this.labelAverageAge.Text = "Average age";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 711);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dateTimeBirth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelAverageAge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxAverageAge);
            this.Controls.Add(this.textBoxFlat);
            this.Controls.Add(this.textBoxHouse);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.textBoxFindHouse);
            this.Controls.Add(this.textBoxFindStreet);
            this.Controls.Add(this.textBoxFindCity);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimeBirth;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnSurname;
        private System.Windows.Forms.ColumnHeader columnPhone;
        private System.Windows.Forms.ColumnHeader columnCity;
        private System.Windows.Forms.ColumnHeader columnDateBirth;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader columnStreet;
        private System.Windows.Forms.ColumnHeader columnFlat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.ColumnHeader columnHouse;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxHouse;
        private System.Windows.Forms.TextBox textBoxFlat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFindCity;
        private System.Windows.Forms.TextBox textBoxFindStreet;
        private System.Windows.Forms.TextBox textBoxFindHouse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxAverageAge;
        private System.Windows.Forms.Label labelAverageAge;
    }
}


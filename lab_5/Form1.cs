using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {  
            InitializeComponent();
            listView1.Show();
            labelAverageAge.Visible = false;
            textBoxAverageAge.Visible = false;
        }
        private static int id = 0;
        List<Person> persons = new List<Person>();

        private string xsdpath = "../../schema.xsd";

        private string openfilepath = "";

        private Person editPerson = null;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxSurname.Text) || string.IsNullOrEmpty(textBoxPhone.Text) || string.IsNullOrEmpty(dateTimeBirth.Text) || string.IsNullOrEmpty(textBoxCity.Text) || string.IsNullOrEmpty(textBoxStreet.Text) || string.IsNullOrEmpty(textBoxHouse.Text))
            {
                buttonAdd.Visible = false;
                return;
            }
            try
            {
                int flat = int.Parse(textBoxFlat.Text);
                persons.Add(new Person(++id, textBoxName.Text, textBoxSurname.Text, DateTime.Parse(dateTimeBirth.Text), textBoxPhone.Text, textBoxCity.Text, textBoxStreet.Text, int.Parse(textBoxHouse.Text), flat));
            }
            catch
            {
                int? flat = null;
                persons.Add(new Person(++id, textBoxName.Text, textBoxSurname.Text, DateTime.Parse(dateTimeBirth.Text), textBoxPhone.Text, textBoxCity.Text, textBoxStreet.Text, int.Parse(textBoxHouse.Text), flat));
            }
            ViewRefresh();
            button2.Visible = true;
            button2.PerformClick();
            button3.PerformClick();
            listView1.Show();
            //textBoxName.Clear();
            //numericUpDownAmount.Clear();
            //numericUpDownWeight.Clear();
            //textBoxFlightNumber.Clear();
            //this.dateTimePicker1.Value = System.DateTime.Now;
            //textBoxFtime.Clear();
            //textBoxDestination.Clear();
            //buttonAdd.Visible = false;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count >0){
                try{
                    var toRemove = persons.Find(p => p.Id == int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
                    persons.Remove(toRemove);
                    ViewRefresh();
                    buttonRemove.Visible = false;
                    buttonEdit.Visible = false;
                }
                catch
                {

                }
            }
        }
        private void ViewRefresh()
        {
            listView1.Items.Clear();
            foreach (var p in persons)
            {
                AddToListView(p);
            }
            if (!buttonFind.Visible)
            {
                Refind();
            }
        }
        private void AddToListView(Person p)
        {
            ListViewItem item = new ListViewItem(p.Id.ToString());
            item.SubItems.Add(p.FirstName);
            item.SubItems.Add(p.LastName);
            item.SubItems.Add(p.Date.ToString());
            item.SubItems.Add(p.Phone);
            item.SubItems.Add(p.City);
            item.SubItems.Add(p.Street);
            item.SubItems.Add(p.House.ToString());
            item.SubItems.Add(p.Flat.ToString());
            listView1.Items.Add(item);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRemove.Visible = true;
            buttonEdit.Visible = true;

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            textBoxName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBoxSurname.Text=listView1.SelectedItems[0].SubItems[2].Text;
            this.dateTimeBirth.Text=listView1.SelectedItems[0].SubItems[3].Text;
            textBoxPhone.Text=listView1.SelectedItems[0].SubItems[4].Text;
            textBoxCity.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textBoxStreet.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textBoxHouse.Text=listView1.SelectedItems[0].SubItems[7].Text;
            textBoxFlat.Text=listView1.SelectedItems[0].SubItems[8].Text;
            var person = persons.FirstOrDefault(p => p.Id == int.Parse(listView1.SelectedItems[0].SubItems[0].Text));
            editPerson = person;
            buttonAdd.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            buttonRemove.Visible = false;
            buttonEdit.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int flat = int.Parse(textBoxFlat.Text);
                persons[persons.IndexOf(editPerson)] = new Person(editPerson.Id, textBoxName.Text, textBoxSurname.Text, DateTime.Parse(dateTimeBirth.Text), textBoxPhone.Text, textBoxCity.Text, textBoxStreet.Text, int.Parse(textBoxHouse.Text), flat);
            }
            catch
            {
                int? flat = null;
                persons[persons.IndexOf(editPerson)] = new Person(editPerson.Id, textBoxName.Text, textBoxSurname.Text, DateTime.Parse(dateTimeBirth.Text), textBoxPhone.Text, textBoxCity.Text, textBoxStreet.Text, int.Parse(textBoxHouse.Text), flat);
            }
            ViewRefresh();
            textBoxName.Clear();
            //textBoxName.Text = listView1.;
            textBoxSurname.Clear();
            textBoxPhone.Clear();
            this.dateTimeBirth.Value = System.DateTime.Now;

            textBoxCity.Clear();
            textBoxStreet.Clear();
            textBoxHouse.Clear();
            textBoxFlat.Clear();
            button1.Visible = false;
            button2.Visible = false;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            //textBoxName.Text = listView1.;
            textBoxSurname.Clear();
            textBoxPhone.Clear();
            this.dateTimeBirth.Value = System.DateTime.Now;
            
            textBoxCity.Clear();
            textBoxStreet.Clear();
            textBoxHouse.Clear();
            textBoxFlat.Clear();
            buttonAdd.Visible = false;
            button2.Visible = false;
            button1.Visible = false;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBoxFindCity.Text))
            {
                MessageBox.Show("Enter the values!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Refind();
            if(listView1.Items.Count == 0)
            {
                MessageBox.Show("No one lives at such an address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonFind.Visible = true;
                return;
            }
            AverageAge(listView1);
 
        }
        private void Refind()
        {
            buttonFind.Visible = false;
            listView1.Items.Clear();
            foreach (var item in persons)
            {
                if (item.City == textBoxFindCity.Text)
                {
                    //if (!string.IsNullOrWhiteSpace(textBoxFindStreet.Text))
                    //{
                    //    if (item.Street == textBoxFindStreet.Text)
                    //    {
                    //        if (!string.IsNullOrWhiteSpace(textBoxFindHouse.Text))
                    //        {
                    //            if (item.House == int.Parse(textBoxFindHouse.Text))
                    //            {
                    //                AddToListView(item);
                    //            }
                    //            else { MessageBox.Show("No one lives at such an address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break; }
                    //        }
                    //        else AddToListView(item);
                    //    }
                    //
                    AddToListView(item);
                    //  else { MessageBox.Show("No one lives at such an address!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); break; }
                }
            }
            button3.Visible = true;
        }
        private void AverageAge(ListView list)
        {
            double averageAge = 0;
            foreach(ListViewItem i in list.Items)
            {
                averageAge += CalculateAge(DateTime.Now, DateTime.Parse(i.SubItems[3].Text));
            }
            textBoxAverageAge.Text = Math.Round((averageAge / list.Items.Count),3).ToString();
            labelAverageAge.Visible = true;
            textBoxAverageAge.Visible = true;
        }
        private long CalculateAge(DateTime Startdate, DateTime EndDate)
        {
            System.TimeSpan ts = new TimeSpan(Startdate.Ticks - EndDate.Ticks);
            long age = (long)(ts.Days / 365);
            return age;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            buttonFind.Visible = true;
            listView1.Visible = true;
            button3.Visible = false;
            labelAverageAge.Visible = false;
            textBoxAverageAge.Visible = false;
            ViewRefresh();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "SaveFileDialog Export2File";
            sfd.Filter = "Text File (.xml) | *.xml";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filename = sfd.FileName.ToString();
                if (filename != "")
                {
                    var xmlSerializer = new XmlSerializer(typeof(List<Person>));
                    using (var writer = new StreamWriter(filename))
                    {
                        xmlSerializer.Serialize(writer, persons);
                    }
                }
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {

            string filename = "";
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "OpenFileDialog Export2File";
            ofd.Filter = "Text File (.xml) | *.xml";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filename = ofd.FileName.ToString();
                if (filename != "")
                {
                    try
                    {
                        Validate(filename);
                        var xmlSerializer = new XmlSerializer(typeof(List<Person>));
                        using (var reader = new StreamReader(filename))
                        {
                            var p = (List<Person>)xmlSerializer.Deserialize(reader);
                            persons = p;
                            id = persons.Max(m => m.Id);
                        }
                        openfilepath = filename;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }



                    ViewRefresh();
                }
            }

            listView1.Show();
        }
        private void Validate(string filename)
        {
            XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
            xmlReaderSettings.ValidationType = ValidationType.Schema;
            xmlReaderSettings.Schemas.Add(null, xsdpath);
            using (XmlReader reader = XmlReader.Create(filename, xmlReaderSettings))
            {
                while (reader.Read()) { }
            }
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            if (!button1.Visible)
            {
                buttonAdd.Visible = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!string.IsNullOrEmpty(openfilepath))
            {
                var xmlSerializer = new XmlSerializer(typeof(List<Person>));
                using (var writer = new StreamWriter(openfilepath))
                {
                    xmlSerializer.Serialize(writer, persons);
                }
            }
        }
    }
}

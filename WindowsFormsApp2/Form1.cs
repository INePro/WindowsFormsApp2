using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Phone> phones = new List<Phone>
        {
            new Phone { Id=11, Name="Samsung Galaxy Ace 2", Year=2012},
            new Phone { Id=12, Name="Samsung Galaxy S4", Year=2013},
            new Phone { Id=13, Name="iPhone 6", Year=2014},
            new Phone { Id=14, Name="Microsoft Lumia 435", Year=2015},
            new Phone { Id=15, Name="Xiaomi Mi 5", Year=2015}
        };

            comboBox1.DataSource = phones;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            listBox1.DataSource = phones;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";

            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;

            checkedListBox1.MultiColumn = true;
            checkedListBox1.DataSource = phones;
            checkedListBox1.DisplayMember = "Name";
            checkedListBox1.ValueMember = "Id";

            checkedListBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;

            List<string> states = new List<string>
        {
            "Аргентина", "Бразилия", "Венесуэла", "Колумбия", "Чили"
        };

            // добавляем список элементов
            domainUpDown1.Items.AddRange(states);
            domainUpDown1.TextChanged += domainUpDown1_TextChanged;
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Phone phone = (Phone)comboBox1.SelectedItem;
            listBox1.Items.Add(phone);
        }
        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // получаем id выделенного объекта
            int id = (int)listBox1.SelectedValue;

            // получаем весь выделенный объект
            Phone phone = (Phone)listBox1.SelectedItem;
            MessageBox.Show(id.ToString() + ". " + phone.Name);
        }
        void checkedlistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // получаем id выделенного объекта
            int id = (int)checkedListBox1.SelectedValue;

            // получаем весь выделенный объект
            Phone phone = (Phone)checkedListBox1.SelectedItem;
        }

        void domainUpDown1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show(domainUpDown1.Text);
        }
    }
    class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
    }
}

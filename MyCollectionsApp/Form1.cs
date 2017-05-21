using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;



namespace MyCollectionsApp
{
    public partial class Form1 : Form
    {

        List<MyNewClass> itemList = new List<MyNewClass>();

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(Enum.GetNames(typeof(MyNewClass.Colors)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyNewClass newListBoxItem = new MyNewClass("Item - " + (listBox1.Items.Count + 1).ToString(), "decription");
            itemList.Add(newListBoxItem);
            listBox1.Items.Clear();
            listBox1.Items.AddRange(itemList.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            itemList.Remove(listBox1.SelectedItem as MyNewClass);
            listBox1.Items.Clear();
            listBox1.Items.AddRange(itemList.ToArray());
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            InfoDialog.InfoDialog infoDialog = new InfoDialog.InfoDialog(listBox1.SelectedItem as MyNewClass);
            infoDialog.ShowDialog();

            listBox1.refreshItems();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            IEnumerable<MyNewClass> filterResult = itemList
                .Where(s => nameFilterTextBox.Text == "" || s.name == nameFilterTextBox.Text)
                .Where(s => descriptionFilterTextBox.Text == "" || s.description == descriptionFilterTextBox.Text)
                .Where(s => comboBox1.SelectedIndex == null || s.color == (MyNewClass.Colors)comboBox1.SelectedIndex).ToList();

            listBox1.Items.Clear();
            listBox1.Items.AddRange(filterResult.ToArray());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            descriptionFilterTextBox.Clear();
            nameFilterTextBox.Clear();
            listBox1.Items.Clear();
            listBox1.Items.AddRange(itemList.ToArray());
        }
    }
}

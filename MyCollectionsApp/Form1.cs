using System;
using System.Windows.Forms;


namespace MyCollectionsApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyNewClass newListBoxItem = new MyNewClass("Item - " + (listBox1.Items.Count + 1).ToString(), "decription");
            listBox1.Items.Add(newListBoxItem);
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            InfoDialog.InfoDialog infoDialog = new InfoDialog.InfoDialog(listBox1.SelectedItem as MyNewClass);
            infoDialog.ShowDialog();

            listBox1.refreshItems();


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyCollectionsApp.InfoDialog
{
    public partial class InfoDialog : Form
    {
        private MyNewClass item;
        public InfoDialog(MyNewClass item)
        {
            InitializeComponent();

            this.item = item;

            textBox1.Text = item.name;
            textBox2.Text = item.description;
            comboBox1.Items.AddRange(Enum.GetNames(typeof(MyNewClass.Colors)));


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            item.name = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            item.description = textBox2.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            item.color = (MyNewClass.Colors)comboBox1.SelectedIndex;
        }
    }
}

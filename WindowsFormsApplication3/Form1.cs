using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Text = string.Format("{0} bölegesine eleman ekle",listBox1.SelectedItem.ToString());
            textBox1.Text = listBox1.SelectedItem.ToString();
            groupBox1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem li = new ListViewItem();
            li.Text = textBox1.Text;
            li.SubItems.Add(textBox2.Text);
            li.SubItems.Add(textBox3.Text);
            li.SubItems.Add(textBox4.Text);


            listView1.Items.Add(li);
            button1.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
        }

       

      
      
    }
}

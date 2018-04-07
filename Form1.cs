using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_SharpEnum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int seasonNumber = Convert.ToInt32(textBox1.Text);
            Seasons seasons;
            seasons = (Seasons)seasonNumber-1;
            listBox1.Items.Clear();
            listBox1.Items.Add(seasons.ToString());
           
        }
    }

    
}

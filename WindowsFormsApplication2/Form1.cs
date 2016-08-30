using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.EF;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindEntities ctx = new NorthwindEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = ctx.Products.ToList();
            categorySource.DataSource = ctx.Categories.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }
    }
}

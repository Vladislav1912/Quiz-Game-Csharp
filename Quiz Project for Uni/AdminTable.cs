using Quiz_Project_for_Uni.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Project_for_Uni
{
    public partial class AdminTable : Form
    {
        public AdminTable()
        {
            InitializeComponent();
        }

        private void AdminTable_Load(object sender, EventArgs e)
        {

            using (var data = new AppDbContext())// using pravi connection s bazata 
            {
                var quizes = data.Quizes.ToList();
                this.dataGridView1.DataSource = quizes;
            
            }
        }
    }
}

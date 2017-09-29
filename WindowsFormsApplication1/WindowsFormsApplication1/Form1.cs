using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // задание
            InitializeComponent();
            Car first = new Car() { model = "aa", price = 11 } ;
            
            Car second = new Car() { model = "bb", price = 22 };
           
            BindingList<Car> cars = new BindingList<Car>() { first, second };
            dataGridView1.DataSource = cars;

        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

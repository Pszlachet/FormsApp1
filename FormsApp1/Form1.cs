using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp1
{
    public partial class Form1 : Form
    {

        static string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=orderline;Integrated Security=True"; // this the only part you need from Connection String in database properties
        public Form1()
        {
            InitializeComponent();
        }
    }
}

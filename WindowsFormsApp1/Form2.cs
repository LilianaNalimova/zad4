using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void subjectDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private DataClasses1DataContext DataClasses1ContextForm2 = new DataClasses1DataContext();

        private void Form2_Load_1(object sender, EventArgs e)
        {
            subjectBindingSource.DataSource = DataClasses1ContextForm2.Subject;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var StudentQuery = from Subject
                               in DataClasses1ContextForm2.Subject
                               where Subject.Teacher == textBox1.Text
                               select Subject;
            subjectBindingSource.DataSource = StudentQuery;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

            var StudentQuery = from Subject in DataClasses1ContextForm2.Subject
                               select Subject;
            subjectBindingSource.DataSource = StudentQuery.ToList();
        }
    }
}

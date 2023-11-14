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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void studentListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }
        private DataClasses1DataContext DataClasses1ContextForm1 = new DataClasses1DataContext();


        private void Form1_Load_1(object sender, EventArgs e)
        {
            studentListBindingSource.DataSource = DataClasses1ContextForm1.StudentList;
        }

        private void studentListBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataClasses1ContextForm1.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                var StudentQuery = from StudentList in DataClasses1ContextForm1.StudentList
                                   where StudentList.Surname == textBox1.Text
                                   select StudentList;
                studentListBindingSource.DataSource = StudentQuery;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; 

            var StudentQuery = from StudentList in DataClasses1ContextForm1.StudentList
                               select StudentList;
            studentListBindingSource.DataSource = StudentQuery.ToList();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        
    }
}

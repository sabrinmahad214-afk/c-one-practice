using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // variables
            String studentName, studentdept, studentsem, Full_info;
            int StudentId;
            studentName = txtname.Text;
            StudentId = int.Parse(txtstudentid.Text);
            studentdept = txtdepartment.Text;
            studentsem = txtsemester.Text;
            Full_info = studentName + " "+ StudentId + " "+ studentdept + " "+ studentsem;

            lbloutput.Text = Full_info;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();

            // clearing label
            lbloutput.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}

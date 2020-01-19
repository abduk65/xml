using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace StudentApp
{
    public partial class Form1 : Form
    {
        XmlSerializer xs;
        List<StudentClass> ls;

        public Form1()
        {
            InitializeComponent();
            xs = new XmlSerializer(typeof(List<StudentClass>));
            ls = new List<StudentClass>();
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("D:\\Student.xml", FileMode.Create, FileAccess.Write);

            StudentClass sc = new StudentClass();
            sc.Name = nameField.Text;
            sc.Sex = sexField.Text;
            sc.City = cityField.Text;

            ls.Add(sc);
            xs.Serialize(fs, ls);
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("D:\\Student.xml", FileMode.Open, FileAccess.Read);
            ls = (List<StudentClass>)xs.Deserialize(fs);
            dataGridView1.DataSource = ls;
            fs.Close();

        }
    }
}

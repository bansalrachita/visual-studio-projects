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
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();

             foreach (string name in new string[5] { "Rachita", "Kevin", "Paul","Devin","Pearl" })
             {
                 studentFactory sf = new studentFactory();
                 Student s = (Student)sf.produceStudent("student");
                 s.Name = name;
                 students.Add(s);
             }

             foreach (Student s in students) {

                 Assignment assignment1 = new Assignment();
                 Assignment assignment2 = new Assignment();
                 Assignment assignment3 = new Assignment();

                 assignment1.AssignmentName = "Assignment 1";
                 assignment2.AssignmentName = "Assignment 2";
                 assignment3.AssignmentName = "Assignment 3";

                 if (s.Name.Equals("Rachita")) {                    
                     assignment1.Grade = 75;
                     assignment2.Grade = 80;
                     assignment3.Grade = 90; 
                 }
                 else if (s.Name.Equals("Kevin")) {                     
                     assignment1.Grade = 85;
                     assignment2.Grade = 80;
                     assignment3.Grade = 90;
                 }
                 else if (s.Name.Equals("Paul")) {                   
                     assignment1.Grade = 65;
                     assignment2.Grade = 70;
                     assignment3.Grade = 60;
                 }
                 else if (s.Name.Equals("Devin"))
                 {
                     assignment1.Grade = 95;
                     assignment2.Grade = 90;
                     assignment3.Grade = 90;
                 }
                 else if (s.Name.Equals("Pearl"))
                 {
                     assignment1.Grade = 75;
                     assignment2.Grade = 70;
                     assignment3.Grade = 80;
                 }
                 s._Assign.Add(assignment1);
                 s._Assign.Add(assignment2);
                 s._Assign.Add(assignment3);
                 s.calculateGrade(s._Assign);

             }

            /*Console.WriteLine("iterating the list");
            
            foreach(Student name in students)
            {
                Console.WriteLine(name.name);
                Console.WriteLine(name.grade);
                
            }*/
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            foreach(Student s in students){

                ListViewItem item = new ListViewItem(s.Name);
                
                foreach(Assignment a in s._Assign){

                    item.SubItems.Add(a.Grade.ToString());

                }

                item.SubItems.Add(s.Grade);
                listView1.Items.Add(item);
            }
              
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public abstract class Person
    {

    }


    public class Student : Person
    {
        private string _Name;
        private string _Grade;
        public List<Assignment> _Assign;

        public Student() {
            _Assign = new List<Assignment>();
        }

        public string Name
        {
            //set the student name
            set { this._Name = value; }
            //get the student name 
            get { return this._Name; }
        }

        public string Grade
        {
            //set the student grade
            set { this._Grade = value; }
            //get the student grade 
            get { return this._Grade; }
        }

        public List<Assignment> Assign
        {
            //set the student assignment
            set { this._Assign = value; }
            //get the student assignment 
            get { return this._Assign; }
        }

        public string calculateGrade(List<Assignment> assignment){
            
            string value =null;
            
            try { 
                    float total = 0;
                    int count = 0;

                    foreach(Assignment a in assignment){

                        total += a.Grade;
                        count++;

                     }

                //Console.WriteLine(total);
                //Console.WriteLine(count);
                
                if (total > 0)
                    total = total / count;

                //Console.WriteLine(total);
                
                if (total >= 90)
                    Grade = "A";
                else if (total >= 85 && total < 90)
                    Grade = "B+";
                else if (total >= 75 && total < 85)
                    Grade = "B";
                else if (total < 75)
                    Grade = "C";
            }
            catch(Exception e){
                
                Console.WriteLine(e.StackTrace);

            }
            return value;
        }

    }


    public class Assignment {

        public float _Grade;
        private string _AssignmentName;

        public float Grade
        {
            //set the student grade
            set { this._Grade = value; }
            //get the student grade 
            get { return this._Grade; }
        }

        public string AssignmentName
        {
            //set the AssignmentName
            set { this._AssignmentName = value; }
            //get the AssignmentName 
            get { return this._AssignmentName; }
        }

    }

     
    public class studentFactory { 
        
        public Person produceStudent(string name){
            
            Person person = null;
           
            if (name == "student") 
            {
                person = new Student();      
            }

            return person;
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

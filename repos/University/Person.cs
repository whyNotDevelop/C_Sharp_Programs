

namespace University
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Person
    {

         protected String name;
         protected int age { set; get; }
         protected string email {  set; get; }

        public Person(string name, string email, int age)
        {
            this.name = name;
            this.email = email;
            this.age = age;
        }
        public void setName(string name) { this.name = name; }
        public string getName() { return this.name; }

        public int getAge() { return this.age; } 
        public string getEmail() { return this.email;}

        public void setAge(int age) { this.age = age; }
        public void setEmail(string email) {  this.email = email; }
    }

    class Student : Person, IAttendee
    {
        private int stuNumber {  get; set; }
        private string major {  set; get; }
        

        public Student(int stuNumber, string major, string name, string email, int age) : base(name, email, age) 
        {
            this.stuNumber = stuNumber;
            this.major = major;
        }
        public string getMajor() { return this.major; }
        public void setMajor(string major) { this.major = major; }
        public int getStuNumber() { return stuNumber; }
        public void setStuNumber(int stuNumber) { this.stuNumber = stuNumber; }
        /*         
        Exercise 5: Advanced Inheritance
        Implement a class hierarchy for a university system. Create a base class Person with properties like Name, Age, and Email.
        Then, create derived classes Student and Professor inheriting from Person. Add appropriate properties and methods
        to represent student-specific and professor-specific details. Additionally, 
        implement an interface IAttendee for classes that represent attendees of university events, such as Student, and Professor.
        */
        public void EnrollCourse(string courseName)
        {
            Console.WriteLine("Student:"+name+" enrolled in course:"+courseName);
        }
        public void DropCourse(string courseName)
        {
            Console.WriteLine("Student:"+name+" dropped course: "+courseName);
        }
        public void AttendEvent(string eventName)
        {
            Console.WriteLine("Student:"+name+" is attending event: "+eventName);
        }
        public void diplayInfo()
        {
            Console.WriteLine("stuNumber\tstuName\t\tstuMajor\t\tstuAge\tstuEmail");
            Console.WriteLine(stuNumber+"\t"+name+"\t"+major+"\t"+age +"\t" +email);
        }
        public int GetStuNumber()
        {
            return stuNumber;
        }

    }
    class Professor : Person, IAttendee
    {
        private int empId {  get; set; }
        private string department {  set; get; }
        //private Student studentList;

        public Professor(int empId,string department,string name, string email, int age) : base(name,email,age)
        {
            this.empId = empId;
            this.department = department;
        }

        public void TeachCourse(string courseName)
        {
            Console.WriteLine("Professor:" + name + "is teaching course: " + courseName);
        }
        public void GradeAssignment(string assignmentName,Student student)
        {
            Console.WriteLine("Professor:" + name + " graded asssignment " + assignmentName + " for student" + student.getName());
        }
        public void AttendEvent(string eventName)
        {
            Console.WriteLine("Professor:"+name+" is attending event: "+eventName);
        }

        public void searchStudent(ArrayList studentList)
        {
            bool stuFound=false;
            Console.Write("Prof "+this.name+"\nEnter student number:");
            var stuNumber = int.Parse(Console.ReadLine());

            foreach (Student student in studentList)
            {
                if(student.getStuNumber() == stuNumber)
                {
                    Console.WriteLine("\nStudent found!!");
                    student.diplayInfo();
                    stuFound = true;
                    break;
                }                           
            }
            if (stuFound == false)
            {
                Console.WriteLine("Student not found!!");
            }
                
        }
        public void addStudent(ArrayList studentList)
        {
            Console.WriteLine("\nProf " + this.name);
            Console.WriteLine("How many students you want to add");
            int countStudents = int.Parse(Console.ReadLine());
            Student student;
            int count = 0;
            string locateNames = "C:\\Users\\Student\\Documents\\NewFeature\\studentsNames.txt";
            string locateAge = "C:\\Users\\Student\\Documents\\NewFeature\\studentsAge.txt";
            string locateMajor = "C:\\Users\\Student\\Documents\\NewFeature\\major.txt";
            string locateStudentNumber = "C:\\Users\\Student\\Documents\\NewFeature\\studentNumbers.txt";
            string locateEmail = "C:\\Users\\Student\\Documents\\NewFeature\\studentEmails.txt";
 
            do
            {
                Console.Write("Enter student name: ");
                var name = Console.ReadLine();
                Console.Write("Enter student number: ");
                int stuNumber = int.Parse(Console.ReadLine());
                Console.Write("Enter student email: ");
                string email = Console.ReadLine();
                Console.Write("Enter student age:");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Enter student major: ");
                string major = Console.ReadLine();
                bool stuExists = false;
                             
                foreach(Student stu in studentList)
                {
                    if (stuNumber == stu.getStuNumber())
                    {
                        Console.WriteLine("\nStudent number " + stuNumber + " exists!");
                        //Console.WriteLine(stu.diplayInfo());
                        stuExists = true;

                    }               
                    
                }
                if (stuExists == false)
                {
                    student = new Student(stuNumber, major, name, email, age);
                    studentList.Add(student);
                    StreamWriter writeName = new StreamWriter(locateNames);
                    StreamWriter writeAge = new StreamWriter(locateAge);
                    StreamWriter writeMajor = new StreamWriter(locateMajor);
                    StreamWriter writeStudentNumber = new StreamWriter(locateStudentNumber);
                    StreamWriter writeEmail = new StreamWriter(locateEmail);

                    writeName.WriteLine(name);
                    writeAge.WriteLine(age);
                    writeMajor.WriteLine(major);
                    writeStudentNumber.WriteLine(stuNumber);
                    writeEmail.WriteLine(email);

               }
                Console.WriteLine("______________________________________________\n");
                count++;

            } while(count != countStudents);
        }
        public void removeStudent(ArrayList studentsList)
        {
            bool stuFound = false;
            Console.Write("Prof " + this.name + "\nEnter student number for student you want to Delete:");
            var stuNumber = int.Parse(Console.ReadLine());
         
            foreach (Student student in studentsList)
            {
                if (student.getStuNumber() == stuNumber)
                {
                    studentsList.Remove(student);
                    Console.WriteLine("Student successfully deleted from your course");
                    stuFound = true;
                    break;
                }
            }
            if (stuFound == false)
            {
                Console.WriteLine("Student not found!!");
            }          
        }
    }
    interface IAttendee
    {
         void AttendEvent(string eventName);
    }
}

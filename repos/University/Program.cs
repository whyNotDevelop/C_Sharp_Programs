using University;
using System.IO;
using System.Collections;
using MySql.Data.MySqlClient;

class Program
{

    private static void Main(string[] args)
    {
        
        
        /*
         
        Exercise 5: Advanced Inheritance
        Implement a class hierarchy for a university system. Create a base class Person with properties like Name, Age, and Email.
        Then, create derived classes Student and Professor inheriting from Person. Add appropriate properties and methods
        to represent student-specific and professor-specific details. Additionally, 
        implement an interface IAttendee for classes that represent attendees of university events, such as Student, and Professor.
        */
        //Student student = new Student("32123","Computer Science","Sicelo","sicelo32@gmail.com","23");
        Professor prof = new Professor(23243, "Natural Science", "John Wick", "johnwick@gmail.com", 43);
        ArrayList studentsList = loadStudentData();
        displayStudensInfo(studentsList);
            //prof.searchStudent(studentsList);
           // prof.addStudent(studentsList);
            //prof.removeStudent(studentsList);
            //displayStudensInfo(studentsList);

            //student.EnrollCourse("Techninal Programming");
            // student.AttendEvent("guest lecture");

            //prof.TeachCourse("Development Software");
            //prof.AttendEvent("Faculty meeting");

            /*string filePath = "example.txt";

            // Open the file for writing (create if not exists)
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write content to the file
                writer.WriteLine("Hello, world!");
                writer.WriteLine("This is a new line.");
            }*/

        }
    public static ArrayList loadStudentData()
    {
        //This string gonna be used to Access DBMS 
        string accessDMS = "server = localhost; user = root; database = Person; password = #MYSQL101";

        //Creating MSQL connection object
        MySqlConnection mysqlConnection = new MySqlConnection(accessDMS);
        ArrayList studentsList = new ArrayList();

        try
        {
            //Open connetion
            mysqlConnection.Open();

            //Query select from database to columns to read
            string query = "SELECT name, age, major, stuNumber, email FROM student";

            /*
             * Executes a command against a data source; often in the form of a SQL statement
             that retrieves data from the data source*/
            MySqlCommand command = new MySqlCommand(query, mysqlConnection);

            //Performs a forward-only (sequential) access of the data in the data source
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string readName = reader.GetString(0);
                int readAge = reader.GetInt32(1);
                string readMajor = reader.GetString(2);
                int readStudentNum = reader.GetInt32(3);
                string readEmail = reader.GetString(4);
                //(int stuNumber, string major, string name, string email, string age)
                studentsList.Add(new Student(readStudentNum, readMajor, readName, readEmail, readAge));

                Console.WriteLine("Connection Achieved");
                //Student studentTemp = new Student(readName, readAge, readMajor, readStudentNum, readEmail);

                
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Table not found {ex.Message}");
        }

        /*string locateNames = "C:\\Users\\Student\\Documents\\NewFeature\\studentsNames.txt";
        string locateAge = "C:\\Users\\Student\\Documents\\NewFeature\\studentsAge.txt";
        string locateMajor = "C:\\Users\\Student\\Documents\\NewFeature\\major.txt";
        string locateStudentNumber = "C:\\Users\\Student\\Documents\\NewFeature\\studentNumbers.txt";
        string locateEmail = "C:\\Users\\Student\\Documents\\NewFeature\\studentEmails.txt";
        ArrayList studentsList = new ArrayList();

        if //(File.Exists(locateAge) && File.Exists(locateMajor) && File.Exists(locateStudentNumber) && File.Exists(locateNames))
        {
            string[] name = File.ReadAllLines(locateNames);
            string[] age = File.ReadAllLines(locateAge);
            string[] major = File.ReadAllLines(locateMajor);
            string[] studentNumber = File.ReadAllLines(locateStudentNumber);
            string[] email = File.ReadAllLines(locateEmail);

            int numOfSt = studentNumber.Length;           
            int stuTemp = 0;

            for (int i = 0; i < numOfSt; i++)
            {
                stuTemp = int.Parse(studentNumber[i]);
                Student studentTemp = new Student(stuTemp, major[i], name[i], email[i], age[i]);
                studentsList.Add(studentTemp);
            }
        }
        else
        {
            Console.WriteLine("Files Not Found!!");
        }*/
        return studentsList;
    }

    public static void displayStudensInfo(ArrayList studentList)
    {
        //to get arrayList size... studentList.Count
        //to get type at specific index... studentList[index].GetType()
        //to remove a student... studentList.Remove(student)
        //..another way is studentList.RemoveAt(index)
        //to remove the last.. studentList.Remove(studentList.Count-1)

        Console.WriteLine("\nstuNumber\tstuName\t\tstuMajor\t\tstuAge\tstuEmail");
        foreach(Student student in studentList)
        {
            Console.WriteLine(student.getStuNumber()+"\t"+student.getName()+"\t"+student.getMajor()+"\t"+student.getAge()+"\t"+student.getEmail());

        }
        Console.WriteLine();
    }
}
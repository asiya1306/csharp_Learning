using System;
namespace Interface
{
    interface IStudent
    {
        void getStud(string name, int age, int id);
        void displayStud();
    }
    interface IFaculty
    {
        void getFaculty(string name, int age, string sub);
        void displayFaculty();
    }
    class Person : IStudent, IFaculty
    {
        string studName, facName;
        int studAge, facAge;
        int studId;
        string subject;

        public void getStud(string name, int age, int id)
        {
            this.studName = name;
            this.studAge = age;
            this.studId = id;
        }
        public void displayStud()
        {
            Console.WriteLine("Student name {0}, age {1} and id is {2}", studName, studAge, studId);
        }

        public void getFaculty(string name, int age, string sub)
        {
            this.facName = name;
            this.facAge = age;
            this.subject = sub;
        }
        public void displayFaculty()
        {
            Console.WriteLine("Faculty name {0}, age {1} and Subject is {2}" , facName, facAge, subject);
        }

    }
}

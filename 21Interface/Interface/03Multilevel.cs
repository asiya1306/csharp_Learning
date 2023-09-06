using System;

namespace Interface
{
    interface IGrandparent
    {
        void getGrand(string name, int age, string education);
        void displayGrand();
    }

    interface IParent : IGrandparent
    {
        void getParent(string name, int age, string education);
        void displayParent();
    }

    interface IChild : IParent
    {
        void getChild(string name, int age, string education);
        void displayChild();
    }

    class Person1 : IChild
    {
        string grandName, parentName, childName;
        int grandAge, parentAge, childAge;
        string grandEducation, parentEducation, childEducation;

        public void getGrand(string name, int age, string education)
        {
            grandName = name;
            grandAge = age;
            grandEducation = education;
        }

        public void displayGrand()
        {
            Console.WriteLine("Grandparent - Name: {0}, Age: {1}, Education: {2}", grandName, grandAge, grandEducation);
        }

        public void getParent(string name, int age, string education)
        {
            parentName = name;
            parentAge = age;
            parentEducation = education;
        }

        public void displayParent()
        {
            Console.WriteLine("Parent - Name: {0}, Age: {1}, Education: {2}", parentName, parentAge, parentEducation);
        }

        public void getChild(string name, int age, string education)
        {
            childName = name;
            childAge = age;
            childEducation = education;
        }

        public void displayChild()
        {
            Console.WriteLine("Child - Name: {0}, Age: {1}, Education: {2}", childName, childAge, childEducation);
        }
    }
}
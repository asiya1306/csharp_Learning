//if statement
int age;
Console.WriteLine("enter your age: ");
age=int.Parse(Console.ReadLine());
if (age >= 18)  
{
    Console.WriteLine("You are allowed to vote");
}

//if-else statement
int num;
Console.WriteLine("enter number: ");
num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine(num+" is even"); 
}
else
{
    Console.WriteLine(num + " is odd");
}

//else if
int marks;
Console.WriteLine("enter marks: ");
marks = int.Parse(Console.ReadLine());
if (marks >=80 && marks<=100)
{
    Console.WriteLine("Grade A");
}
else if(marks >= 60 && marks <= 79)
{
    Console.WriteLine("Grade B");
}
else if (marks >= 40 && marks <= 59)
{
    Console.WriteLine("Grade C");
}
else if (marks < 40 && marks>0)
{
    Console.WriteLine("You are Fail");
}
else
{
    Console.WriteLine("Enter Valid Marks");
}

using System;

class Program
{
    static void Main()
    {

        
        /*
            Variable is something that stores a value and name.
            The Value of variable can be change. 
            constant have a same behaviour but the value can't be change.

            variable and constant have same behaviour, just can store 1 value.
            if your need stores many value in one variable we using array ([]).
            variable of array or constant of array can store more than 1 value. 
        */ 
        string name = "Gama Ariefsadya";
        int age = 24;
        bool activeStudent = true;
        char initial = 'G';
        const double GPA = 3.82;
        string[] skill = { "accounting", "finance", "software developer", "data engineer", "data analyst" };

        string jobType="freelance";

        System.Console.WriteLine($"Hello My Name is {name} I'am {age} years old. you can call me {initial}.");

        /*
            Control Flow (Condition)
            Control Flow is using when you want add some condition in your application. 

            you can using keyword if,else if , else and also switch. the diffrent beetween using if and switch is just the syntax
            but the purposes it's not different at all.
                    
        */

        if (activeStudent)
        {
            System.Console.WriteLine($"And Also I'am a acountant student. with GPA {GPA} and i have skill in " + string.Join(",", skill));
        }

        switch (jobType)
        {
            case "fulltime":
                System.Console.WriteLine("and currently I'm not Open To Work");
                break;
            case "freelance":
                System.Console.WriteLine("and currently I'm open to work");
                break;
            case "hiring":
                System.Console.WriteLine("and currently I'm Hiring ");
                break;
            default:
                System.Console.WriteLine("and currently I'm not graduate yet");
                break;

        }


        /*
            Control Flow (Loop)
            Loop using when you want repeat the same activities with some limitation.
            you can using for and while.

            You can use FOR when you know the minimun to start and maxisimum to end. 
            example:
                you want repeat to print number 1 - 10 it's mean you know the minimun start is 1 and maxsimun it's 10

            and you can used while when you want repeat some activities with some condition and change the condition inside the loop.
            the different you using for and while is, when you used for the will start automaticly. and while the condition should be true
            and the loop can be executed.
        */

        for (int i = 0; i <= 10; i++)
        {
            System.Console.WriteLine($"Number:{i}");
            
        }

        System.Console.WriteLine("While Loop");

        int number =10;
        while(number > 1){
            System.Console.WriteLine($"Number:{number}");
            number--;

        }



        SayHello();
        System.Console.WriteLine( CalculateNumber(10,10));

    }

        /*
        
            A function (method) is a named set of commands, which can be called multiple times to perform a specific task.

            a function have structure 
            [access modifier] [return type] [function name]()

            Key Rules When Creating a Function in C#:
            Static functions can only call other static functions.
            The body of a function is the part that gets executed whenever the function is called.
            Every function must have a clear return type, such as void, int, or string.
        */

    static void SayHello(){
        System.Console.WriteLine("Hello ");
    }

    public static int CalculateNumber(int number1,int number2){
        return number1+number2;
    }
}



using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Zadanie nr.7 

        Console.WriteLine("Let's check which number is the highest?");
        Console.WriteLine("Please enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter third number:");
        int c = int.Parse(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine("THe highest number is: " + a);
        }
        if (b > a && b > c)
        { 
            Console.WriteLine("The highest number is: " + b);
        }
        else
        {
            Console.WriteLine("The highest number is: " + c);
        }

        Console.WriteLine("------------------------------------------------");

        //Zadanie nr.8

        Console.WriteLine("In order to check whether you can take part in recrutation, please enter your results from the below subjects:");
        Console.WriteLine("Please enter your Math results: ");
        int math = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your Physics results: ");
        int physics = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your Chemistry results: ");
        int chemistry = int.Parse(Console.ReadLine());

        if (math + physics > 150 || math + chemistry > 150)
        {
            Console.WriteLine("You are eligible to take part in recrutation");
        }
        else if (math > 70 && physics > 55 && chemistry > 45 && (math + chemistry + physics) > 180)
        {
            Console.WriteLine("You are eligible to take part in recrutation");
        }
        else
        {
            Console.WriteLine("You are not eligible to take part in recrutation");
        }

        Console.WriteLine("------------------------------------------------");

        //Zadanie nr.9

        Console.WriteLine("Please enter the temperature:");
        int temp = int.Parse(Console.ReadLine());
        if (temp < 0)
        {
            Console.WriteLine("Cholernie pizdzi");
        }
        else if (temp > 0 && temp < 10)
        {
            Console.WriteLine("Zimno");
        }
        else if (temp > 10 && temp < 20)
        {
            Console.WriteLine("Chłodno");
        }
        else if (temp > 20 && temp < 30)
        {
            Console.WriteLine("W sam raz");
        }
        else if (temp > 30 && temp < 40)
        {
            Console.WriteLine("Zaczyna być słabo bo gorąco");
        }
        else 
        {
            Console.WriteLine("a weź wyprowadzam się na Alaskę");
        }

        Console.WriteLine("------------------------------------------------");

        //Zadanie nr.10

        Console.WriteLine("Let's check if we can build a triangle with the lenghts you enter");
        Console.WriteLine("Please enter 1st lenght: ");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter 2nd lenght: ");
        int second = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter 3rd lenght: ");
        int third = int.Parse(Console.ReadLine());

        if (first > second && first > third && first < (second + third))
        {
            Console.WriteLine("You can build triangle with these lenghts");
        }
        if (second > first && second > third && second < (first + third))
        {
            Console.WriteLine("You can build triangle with these lenghts");
        }
        if (third > first && third > second && third < (first + second))
        {
            Console.WriteLine("You can build triangle with these lenghts");
        }
        else
        {
            Console.WriteLine("Unfortunately you can't build a triangle with these lenghts");
        }

        Console.WriteLine("------------------------------------------------");

        //Zadanie nr.11

        Console.WriteLine("Please enter students grade:");
        int grade = int.Parse(Console.ReadLine());

        switch (grade)
        {
            case 1:
                Console.WriteLine("Niedostateczny");
                break;
            case 2:
                Console.WriteLine("Dopuszczający");
                break;
            case 3:
                Console.WriteLine("Dostateczny");
                break;
            case 4:
                Console.WriteLine("Dobry");
                break;
            case 5:
                Console.WriteLine("Bardzo dobry");
                break;
            case 6:
                Console.WriteLine("Celujący");
                break;
            
        }

        Console.WriteLine("------------------------------------------------");

        //Zadanie nr.12

        Console.WriteLine("Please enter number of the day:");
        int day = int.Parse(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Poniedziałek");
                break;
            case 2:
                Console.WriteLine("Wtorek");
                break;
            case 3:
                Console.WriteLine("Środa");
                break;
            case 4:
                Console.WriteLine("Czwartek");
                break;
            case 5:
                Console.WriteLine("Piątek");
                break;
            case 6:
                Console.WriteLine("Sobota");
                break;
            case 7:
                Console.WriteLine("Niedziela");
                break;
        }

        Console.WriteLine("------------------------------------------------");

        //Zadanie nr.13

        Console.WriteLine("Welcome in our first basic calculator");
        Console.WriteLine("Please enter your first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter your second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the number of the chosen operation:");
        Console.WriteLine("1. Add ");
        Console.WriteLine("2. Subtract ");
        Console.WriteLine("3. MUltiply ");
        Console.WriteLine("4. Divide ");
        int chosenOperation = int.Parse(Console.ReadLine());

        switch (chosenOperation) 
        {
            case 1:
                Console.WriteLine("The result is: " + (num1 + num2));
                break;
            case 2:
                Console.WriteLine("The result is: " + (num1 - num2));
                break;
            case 3:
                Console.WriteLine("The result is: " + (num1 * num2));
                break;
            case 4:
                Console.WriteLine("The result is: " + (num1 / num2));
                break;
            default:
                Console.WriteLine("Please select the correct number of the operation");
                break;
        }
    }
}
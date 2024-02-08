namespace Assignment_4_C_;

class Program
{
    static void Main(string[] args)
    {
        Random number1 = new Random();
        Random number2 = new Random();
        Random number3 = new Random();


        int firstNum = number1.Next(1,20);
        int secondNum = number2.Next(1,20);
        int thirdNum = number3.Next(1,20);

        int correctSum = firstNum + secondNum + thirdNum;

        int attempts = 0;
        Boolean isRight = false;

        Console.WriteLine("Can you solve this equation? " + firstNum + " + " + secondNum + " + " + thirdNum);

        while(!isRight){
            Console.Write("Input your guess: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int userGuess)){    //out refers to the output value and i am declaring that the string value is now an integer value stored to userGuess
                attempts++;
                if (userGuess == correctSum){
                    isRight = true;
                    Console.WriteLine("You are Correct! " + correctSum + " is the answer.");
                } 
                else {
                    string hint = (userGuess < correctSum) ? "Your answer is too low. Try again " : "Your answer is too high. Try again "; //Says if the input is less than the first string is outputted.
                    Console.Write(hint);
                }
            } 
            else {
                Console.WriteLine("Please input a valid number");
            }
        }

        Console.WriteLine("Thank you for playing! Good job!");

    }
}

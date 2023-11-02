using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string programRun;

            Console.WriteLine("Hello and Welcome to LOOOOOOOOPPPPPPSSSSS");
            Console.WriteLine("Would you like to play, Prompter, PercentPassing, OddSum, RandomNumbers, DiceGame.");
            programRun = Console.ReadLine().ToLower();
            if (programRun == "prompter")
            {
                Console.Clear();
                prompter();
            }
            else if (programRun == "percentpassing")
            {
                Console.Clear();
                percentpassing();
            }
            else if (programRun == "oddsum")
            {
                Console.Clear();
                oddsum();
            }
            else if (programRun == "randomnumbers")
            {
                Console.Clear();
                randomnumbers();
            }
            else if (programRun == "dicegame")
            {
                Console.Clear();
                dicegame();
            }
            Console.Clear();
            


        }

        private static void prompter()
        {
            int minVal, maxVal, number;

            Console.WriteLine("Welcome to Prompter");
            Console.WriteLine("Please enter a minimul range number"); 
            minVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you, now please enter a maximum range number");
            maxVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you.");
           
            Console.WriteLine("Now please enter a value within those range numbers.");
            number = Convert.ToInt32(Console.ReadLine());
            while (number < minVal)
            {
                Console.WriteLine("INVALID RESPONSE. Now please enter a value within those range numbers.");
                number = Convert.ToInt32(Console.ReadLine());
                while (number > maxVal)
                {
                    Console.WriteLine("INVALID RESPONSE. Now please enter a value within those range numbers.");
                    number = Convert.ToInt32(Console.ReadLine());

                }
            }
            while (number > maxVal)
            {
                Console.WriteLine("INVALID RESPONSE. Now please enter a value within those range numbers.");
                number = Convert.ToInt32(Console.ReadLine());
                while (number < minVal)
                {
                    Console.WriteLine("INVALID RESPONSE. Now please enter a value within those range numbers.");
                    number = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();
            Console.WriteLine("VALID RESPONSE.");
            Console.WriteLine("Thank you for using Prompter");
            Console.ReadLine();
        }

        private static void percentpassing()
        {
            int scoresNum, passScores = 0;

            
            Console.WriteLine("Welcome to Percent Passing, How many scores would you like to enter?");
            scoresNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < scoresNum; i++)
            {
                Console.WriteLine("Please enter a score");
                if (Convert.ToInt32(Console.ReadLine()) >= 70)
                    passScores++;
            }
            Console.WriteLine($"{passScores * 100 / scoresNum}% of the scores were above 70");
            Console.ReadLine();
        }

        private static void oddsum()
        {
            int choseNum;
            int oddSum = 0;

            Console.WriteLine("Welcome to Odd Sum");
            Console.WriteLine("Please enter a odd number that you would like to know the sum of it and all odd numbers below it");
            choseNum = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 1; i < choseNum; i += 2)
            {
                oddSum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"{oddSum} is the sum of the number you entered");
            Console.ReadLine();
        }

        private static void randomnumbers()
        {
            int maxVal, minVal;
            Random _generator;
            _generator = new Random();
            Console.WriteLine("Welcome to RANDOM NUMBERS! please enter a max value");
            maxVal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you, please enter a minimum value");
            minVal = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 25; i++)
            {
               Console.Write(_generator.Next(minVal, maxVal + 1)+", ");
            }
            Console.ReadLine();
        }

        private static void dicegame()
        {
            Die die1 = new Die();
            Die die2 = new Die();

            double bankMoney = 100.0;
            double bet;
            string decision;
            bool repeat = true;

            while (repeat)
            {


                die1.RollDie();
                die2.RollDie();

                Console.WriteLine("Welcome to the Casino!");
                Console.WriteLine($"You have {bankMoney}$ in your account");
                Console.WriteLine("Would you like to continue? Yes to Continue, No to exit");
                if (Console.ReadLine().ToLower() == "no")
                {
                    repeat = false;
                    break;
                }
                Console.WriteLine("How much would you like to bet on the dice?");
                bet = Convert.ToDouble(Console.ReadLine());
                if (bet < 0)
                {
                    bet = 0.00;
                    Console.WriteLine("You have attempted to enter a negative bet, Youre bet for this round will be 0.");
                }
                else if (bet > bankMoney)
                {
                    bet = bankMoney;
                    Console.WriteLine("You have attempted to bet more than you have so we have adjusted your bet to all that you have.");
                }
            
            Console.WriteLine();
            Console.WriteLine($"You have bet {bet}$.");
            Console.WriteLine("would you like to bet on an even sum, odd sum, double or not double?");
            Console.WriteLine("for even and odd sum, you will win or lose your bet.");
            Console.WriteLine("for double you will win/lose double your bet, and for not double you will win/lose half your bet");
            decision = Console.ReadLine().ToLower();
                switch (decision)
                {
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("");
                        break;

                    case "double":
                        if (die1 == die2)
                        {
                            Console.WriteLine($"Congrats you won, you will now receive double you bet {(bet * 2) + bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        else
                        {
                            Console.WriteLine($"Unfortunate you lost double your bet {(bet * 2) - bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        break;

                    case "not double":
                        if (die1 != die2)
                        {
                            Console.WriteLine($"Congrats you won, since you picked not double you won half you bet {(bet / 2) + bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        else
                        {
                            Console.WriteLine($"Unfortunate you lost, since you picked not double you loss half you bet {(bet / 2) - bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        break;

                    case "not":
                        if (die1 != die2)
                        {
                            Console.WriteLine($"Congrats you won, since you picked not double you won half you bet {(bet / 2) + bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        else
                        {
                            Console.WriteLine($"Unfortunate you lost, since you picked not double you loss half you bet {(bet / 2) - bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        break;

                    case "even sum":
                        if (die1.Roll + die2.Roll == 2)
                        {
                            Console.WriteLine($"Congrats you won, since you picked even sum you won your bet {bet + bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        else if (die1.Roll + die2.Roll == 4)
                        {
                            Console.WriteLine($"Congrats you won, since you picked even sum you won your bet {bet + bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        else if (die1.Roll + die2.Roll == 6)
                        {
                            Console.WriteLine($"Congrats you won, since you picked even sum you won your bet {bet + bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        else
                        {
                            Console.WriteLine($"Unfortunate you lost, since you picked even sum you lost your bet {bet - bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        break;

                    case "even":
                        if (die1.Roll + die2.Roll == 2)
                        {
                            Console.WriteLine($"Congrats you won, since you picked even sum you won your bet {bet + bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        else if (die1.Roll + die2.Roll == 4)
                        {
                            Console.WriteLine($"Congrats you won, since you picked even sum you won your bet {bet + bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        else if (die1.Roll + die2.Roll == 6)
                        {
                            Console.WriteLine($"Congrats you won, since you picked even sum you won your bet {bet + bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        else if (die1.Roll + die2.Roll == 8)
                        {
                            Console.WriteLine($"Congrats you won, since you picked even sum you won your bet {bet + bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        else if (die1.Roll + die2.Roll == 10)
                        {
                            Console.WriteLine($"Congrats you won, since you picked even sum you won your bet {bet + bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        else if (die1.Roll + die2.Roll == 12)
                        {
                            Console.WriteLine($"Congrats you won, since you picked even sum you won your bet {bet + bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        else
                        {
                            Console.WriteLine($"Unfortunate you lost, since you picked even sum you lost your bet {bet - bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        break;

                    case "odd sum":
                        if (die1.Roll - die2.Roll == 3)
                        {
                            Console.WriteLine($"Congrats you won, since you picked odd sum you won your bet {bet + bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        else if (die1.Roll - die2.Roll == 5)
                        {
                            Console.WriteLine($"Congrats you won, since you picked odd sum you won your bet {bet + bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        else if (die1.Roll - die2.Roll == 7)
                        {
                            Console.WriteLine($"Congrats you won, since you picked odd sum you won your bet {bet + bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        else if (die1.Roll - die2.Roll == 9)
                        {
                            Console.WriteLine($"Congrats you won, since you picked odd sum you won your bet {bet + bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        else if (die1.Roll - die2.Roll == 11)
                        {
                            Console.WriteLine($"Congrats you won, since you picked odd sum you won your bet {bet + bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        else
                        {
                            Console.WriteLine($"Unfortunate you lost, since you picked odd sum you lost your bet {bet - bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        break;

                    case "odd":
                        if (die1.Roll - die2.Roll == 3)
                        {
                            Console.WriteLine($"Congrats you won, since you picked odd sum you won your bet {bet + bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        else if (die1.Roll - die2.Roll == 5)
                        {
                            Console.WriteLine($"Congrats you won, since you picked odd sum you won your bet {bet + bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        else
                        {
                            Console.WriteLine($"Unfortunate you lost, since you picked odd sum you lost your bet {bet - bankMoney}");
                            Console.WriteLine($"Your new balance is {bankMoney}");
                        }
                        break;
                        

                }
                if (bankMoney == 0)
                {
                    repeat = false;
                }
            }

        }


    }
}

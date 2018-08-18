using System;

namespace Checkpoint_2
{
    class Program
    {
        //Method that returns questions
        string getQuestions(int i)
        {
            string[] questions =
            {
"1. Which mathematician's principle of fluid dynamics is the most widely taught explanation of how planes fly?",
"2. Movement of the plane about the vertical axis of motion is called?",
"3. When the pilot moves the wheel on the control/yoke to the left the result will be?",
"4. VOR stands for Variable Oscillation Radar.",
"5. Where on the aircraft would you find the green navigation light?",
"6. In aviation, ILS stands for Instrument Landing System.",
"7. What is the purpose of an aircraft’s altimeter?",
"8. The four main forces acting on an air plane are: lift, drag, thrust and weight.",
"9. VFR stands for Vehicle Flight Recorder.",
"10. In aviation, what is FOD?"
}; // will be questions used on test. 6 Multiple choice and 4 true/false

            return questions[i];
        }

        //Method that returns answers
        string getAnswers(int i)
        {
            string[] answers =
            {
"a. Albert Einstein b. Plato c. Bill Smith d. Daniel Bernoulli",
"a. Bank b. Yaw c. Pitch d. Flight",
"a. The elevator goes up b. The right aileron goes up and the left aileron goes down c. The left aileron goes up and the right aileron goes down d. Both ailerons go down",
"true false",
"a. Left Wingtip b. Above the Cockpit c. Right Wingtip d. Tail",
"true false",
"a. To show the aircraft’s airspeed b. To show the aircraft’s angle of attack c. To show the aircraft’s engine temperature d. To show the aircraft’s altitude",
"true false",
"true false",
"a. Fire Oppression Device b. Foreign Object Debris c. Foul Odor Detector d. First Officer’s Den",
}; // these will stand as answer bank for all questions

            return answers[i];
        }

        //Method that returns correct answers
        string getCorrectAnswers(int i)
        {
            string[] correctanswer =
            {
                "d",
                "b",
                "c",
                "false",
                "c",
                "true",
                "d",
                "true",
                "false",
                "b"
            }; //these are the correct answers to all the question. any other selections will be counted as incorrect

            return correctanswer[i];
        }

        //Validates the input
        Boolean validateInput(string answer, string correctAnswer)
        {
            //For true/false questions
            if (correctAnswer.Equals("true") || correctAnswer.Equals("false"))
            {
                if (answer.Equals("true") || answer.Equals("false"))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("\n Invalid Answer!!! Answer as either True/False... \n");
                    return false;
                }
            }
            else
            {
                if (answer.Equals("a") || answer.Equals("b") || answer.Equals("c") || answer.Equals("d"))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("\n Invalid Answer!!! Answer as either a/b/c/d... \n");
                    return false;
                }
            }
        }

        //Game
        int playGame()
        {
            //Variables
            int scoreCard = 0; // everyone starts with 0 correct out of ten. once quiz is completed score will be listed as 1-10.

            int[] questionsIncorrect = new int[10];

            Console.WriteLine();
            int j = -1;
            string check;

            Console.WriteLine("Attempt No 1");
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Q{0}", getQuestions(i));
                System.Console.WriteLine("{0}", getAnswers(i));
                System.Console.WriteLine("Enter Answer :: ");
                check = Console.ReadLine();

                //Validating answer
                while (validateInput(check, getCorrectAnswers(i)) == false)
                {
                    //Re-reading
                    check = Console.ReadLine();
                }

                Console.WriteLine();
                if (check.Equals(getCorrectAnswers(i)))
                {
                    scoreCard = scoreCard + 1;
                }
                else
                {
                    j++;

                    questionsIncorrect[j] = i;
                }
                Console.Clear(); // TO CLEAR THE SCREEN 
            }
            int k;
            if (j > -1)
            {
                Console.WriteLine("Attempt No 2 for wrong question");
                for (int i = 0; i <= j; i++)
                {
                    k = questionsIncorrect[i];
                    System.Console.WriteLine("Q{0}", getQuestions(k));
                    System.Console.WriteLine("{0}", getAnswers(k));
                    System.Console.WriteLine("Enter Answer :: ");
                    check = Console.ReadLine();

                    //Validating answer
                    while (validateInput(check, getCorrectAnswers(k)) == false)
                    {
                        //Re-reading
                        check = Console.ReadLine();
                    }

                    Console.WriteLine();
                    if (check.Equals(getCorrectAnswers(k)))
                    {
                        scoreCard = scoreCard + 1;
                        Console.Clear(); // TO CLEAR THE SCREEN 
                    }
                    else
                    {
                        System.Console.WriteLine("Correct Answer is {0}\n\n", getCorrectAnswers(k));
                        Console.ReadLine(); // WAIT FOR KEY PRESS
                        Console.Clear(); // TO CLEAR THE SCREEN 
                    }
                    
                }
               
            }

            return scoreCard;
        }

        //Main method
        static void Main(string[] args)
        {
            Console.WriteLine("General Aviation Quiz");

            //Welcome To Program
            Console.WriteLine("James Fox, ENGR115- General Aviation Quiz");

            //Creating object
            Program p = new Program();
            Console.WriteLine("Score is {0}", p.playGame());
            Console.ReadKey();
        }

    }

}
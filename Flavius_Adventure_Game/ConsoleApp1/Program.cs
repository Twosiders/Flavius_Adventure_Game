using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static string[] frame = System.IO.File.ReadAllLines(@"C:\Users\Jimmy\Desktop\C# Applications\ConsoleApp1\EnemyDrawings\frame.txt");

        //56 chars each line, 41 char free space each line. 
        //Leave first 4 lines & last 3 lines as it is.
        static void textFrame(string input) {
            int numLines = input.Length / 41 + 1;
            string[] output = new string[8+numLines];     
            //sandwich the input aka. "first 4 lines of frame + [input lines] + last 3 lines of frame"
            for (int i = 0; i < 4; i++) {
                output[i] = frame[i];
            }

            /*
            for (int i = 4; i < 4 + numLines; i++) {
                output[i] = frame[3];
                //Ha paratlan
                if (input.Length % 2 == 1)
                {
                    //[7th] + (41-input.length)/2
                }
                else {

                }
            }*/

            /*
            for (int i = 4; i<numLines+4; i++) {
                output[] = "   | |  " + input.Substring(0,40) +"  | |   ";
            }*/
            output[4] = "   | |  " + input.Substring(0, 40) + "  | |   ";
            output[5] = "   | |  " + input.Substring(41, 82) + "  | |   ";
            output[6] = "   | |  " + input.Substring(83, 124) + "  | |   ";
            for (int i = 0; i < input.Length; i++) {
                output[i/41 + 4] = "   | |  " + input.Substring(0, 40) + "  | |   ";
            }


            for (int i = frame.Length-3; i < frame.Length; i++)
            {
                output[i+numLines] = frame[i];
            }

            for (int i = 0; i < output.Length - 1; i++) {
                Console.WriteLine(output[i]);
            }


        }

        //------------------------------------------------------------------------MAIN-----------------------------------------------------------------------------
        static void Main(string[] args)
        {
            //Console.WriteLine("   | |  ".Length); //9th (8) + input.length/2 
            string playerName = "";
            string userInput = "";

            textFrame("Hello mi a neved? A nevem JOnas a jottevo kis angyal. Azert jottem ma ide hogy elraboljalak.");
            bool input = false;

             
            /*
            int tempor = 56;
            foreach (string line in frame) { 
                Console.WriteLine(line);
                /*if (tempor < line.Length)
                    tempor = line.Length;
                if (tempor != line.Length)
                    Console.WriteLine("nooo");
                    
            }
            Console.WriteLine(tempor);
            string test = "                                         ";
            Console.WriteLine(test.Length);*/


            Console.WriteLine("Hail, traveller. (PRESS ENTER)");
            Console.ReadKey();


            Console.Clear();
            Console.WriteLine("What is your name?");
            playerName = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ah, so your name is " + playerName + "? (YES/NO)");
            userInput = Console.ReadLine();

            do
            {
                switch (userInput.ToLower().Trim())
                {
                    case "no":
                    case "n":
                    case "nope":
                        input = false;
                        Console.Clear();
                        Console.WriteLine("What is your name?");
                        playerName = Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine("Ah, so your name is " + playerName + "? (YES/NO)");
                        userInput = Console.ReadLine();
                        break;
                    case "yes":
                    case "y":
                        input = true;
                        Console.Clear();
                        Console.WriteLine("Nice to meet you " + playerName + ". (PRESS ENTER)");
                        break;
                    default:
                        input = false;
                        Console.WriteLine("I don't recognize this command. Write either YES or NO.");
                        userInput = Console.ReadLine();
                        break;

                }
            } while (!input);


            Console.ReadKey();
        }
        /*
        class TextFrame {
            //56 chars each line, 41 char free space each line. 
            //Leave first 4 lines & last 3 lines as it is.
            private static TextFrame textFrameInstance;
            string[] frame = System.IO.File.ReadAllLines(@"C:\Users\Jimmy\Desktop\C# Applications\ConsoleApp1\EnemyDrawings\frame.txt");

            private TextFrame() { }

            public static TextFrame createTextFrame() {
                if (null == textFrameInstance) {
                    textFrameInstance = new TextFrame() {

                    };
                }
                return textFrameInstance;
            }
        }*/
    }
}

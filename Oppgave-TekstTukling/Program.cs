namespace Oppgave_TekstTukling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TekstTukling();
            void TekstTukling(){
                Console.WriteLine("1. RotateText");
                Console.WriteLine("2. Change Word // Changes e's to a's");
                Console.WriteLine("type 'exit' to close");

                string userInput = Console.ReadLine();
                Console.WriteLine();
                switch (userInput)
                {
                    case "1":
                        RotateText();
                        break;
                    case "2":
                        ChangeWord();
                        break;
                    case "exit":
                        break;
                    default:
                        TekstTukling();
                        break;
                }
            }
            void RotateText()
            {
                Console.WriteLine("Write the text you want to rotate!");
                string inputText = Console.ReadLine();
                string rotatedText = "";


                for (int i = inputText.Length-1; i > -1; i--)
                {
                    rotatedText += inputText[i];
                }

                Console.WriteLine(rotatedText);
                Console.WriteLine();
                TekstTukling();
            }


            void ChangeWord()
            {
                Console.WriteLine("Write the text you want to change!");
                string inputText = Console.ReadLine();
                string changedText = "";

                foreach(char letter in inputText)
                {
                    if (letter == 'e')
                    {
                        changedText += 'a';
                    }
                    else
                    {
                        changedText += letter;
                    }
                }

                Console.WriteLine(changedText);
                Console.WriteLine();
                TekstTukling();
            }



        }
    }
}

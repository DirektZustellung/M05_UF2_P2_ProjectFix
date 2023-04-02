using System;
using System.Drawing;

namespace ParenthesisChecker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a text with parenthesis");
            string response = Console.ReadLine();
            int open = CountChars(response, '(');
            int close = CountChars(response, ')');
            
            
            if(open == close)
            {
                Console.WriteLine("The parenthesis close");
            }
            else
            {
                Console.WriteLine("The parenthesis don't close");
            }
        }
        public static int CountChars(string text, char search)
        {
            int amount = 0;
            
            
            if ((text[0] == '(' && text[text.Length -1] == ')' && text.Length % 2 == 0) || (search =='(')) 
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == search)
                    {

                        amount++;
                    }
                    if (amount < 0 && search ==')') return amount;
                    
                }
            }
            else return -1;
           
            return amount;
            /*bool isOpen = false;
            if (text[0]== '(') isOpen = true;
            
            foreach (char c in text)
            {
                if (c == search)
                {
                    if (search == '(')
                    { 
                        amount++;
                        isOpen = true;
                    }
                    else
                    {
                        amount--;
                        isOpen = false;
                    }
                }
                else if (c == '(')
                {
                    amount++;
                    isOpen = true;
                }
                else if (c == ')')
                {
                    amount--;
                    isOpen = false;
                }

                if (amount < 0)
                {
                    return amount;
                }
            }
            if (amount == 0 && isOpen == false)
            {
                return 0;
            }
            return amount;*/

            /*return amount;*/
        }
    }
}

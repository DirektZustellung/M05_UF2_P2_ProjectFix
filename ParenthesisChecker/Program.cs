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
               int amountClose = 0;

               if ((text[0] == '(' && text[text.Length -1] == ')' && text.Length % 2 == 0) || (search =='(')) 
               {
                   for (int i = 0; i < text.Length; i++)
                   {
                       if (text[i] == '(')
                       {
                           if (search == '(') amount++;
                           amountClose++;
                       }
                       else
                       {
                           amountClose--;
                           if (amountClose < 0)
                           {
                               if (search == '(') return amount;                            
                               return amountClose;
                           }

                       }

                   }
                   if (amountClose != 0 && search == '(') return amount; 
                   if (amountClose == 0) return amountClose;

               }
               else if (search == '(')
               {
                    return amount;
               }
               else if (search == ')')
               {
                    return -1;
               }

            return amountClose;

    
        }
    }
}

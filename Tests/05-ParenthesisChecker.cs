using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Tests
{
    [TestClass]
    public class ParenthesisChecker_Tests
    {
        [TestMethod]
        public void ParenthesisChecker_Test()
        {
            //Arrange
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Utils.random.Next(10,100); i++)
            {
                if(Utils.random.Next(2) > 0)
                {
                    sb.Append('(');
                }
                else
                {
                    sb.Append(')');
                }
            }
            string original = sb.ToString();
            
            bool resultOK = false;
            if (original[0] == '(' && original.Length % 2 == 0 && original.Last() == ')')
            {
                /*int countOpen = original.Count(c => c == '(');
                int countClose = original.Count(c => c == ')');
                resultOK = countOpen == countClose;*/
                int count = 0;
                for (int i = 0; i < original.Length; i++)
                {
                    if (original[i] == '(')
                    {
                        count++;
                    }
                    if (original[i] == ')')
                    {
                        count--;
                    }
                    if (count < 0) break;
                    
                }
                if (count == 0) resultOK = true;
            }
            bool result = false;
            //Act
            result = ParenthesisChecker.Program.CountChars(original, ')') == ParenthesisChecker.Program.CountChars(original, '(');
            //Assert
            Assert.AreEqual(resultOK, result);
        }
    }
}

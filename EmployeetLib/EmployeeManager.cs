using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeetLib
{
    public class EmployeeManager
    {
        /// <returns>String shortened to your specific number. If is string shorter, X will append.</returns>
        public string GetEmployeeId(string firstname, string lastname)
        {
            string employeeId = $"{GetPartOfName(firstname, 5)}{GetPartOfName(lastname, 5)}{DateTime.Now.Millisecond.ToString()}";
            return employeeId;
        }

        private string GetPartOfName(string name, int numberOfCharacters)
        {
            string output = name;
            if (name.Length >= numberOfCharacters && name.Length != 0)
            {
                output = name.Substring(0, numberOfCharacters);
            }
            else if(name.Length == 0 && numberOfCharacters == 4)                                //Easter Egg
            {
                output = "Yeet";
            }
            else
            {
                do
                {
                    output += "X";
                } while (output.Length < numberOfCharacters);
            }

            return output;
        }


    }
}

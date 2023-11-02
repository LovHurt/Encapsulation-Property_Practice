using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Property_Practice
{
    public class Employee
    {
        private string TrIDNumber;

        public string TRIDNUMBER
        {
            get
            {
                return TrIDNumber.Substring(0, 5)+"******";
            }
            set
            {
                bool control = false;

                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool IsNumber = char.IsNumber(value[i]);

                        if (IsNumber)
                        {
                            //Don't need to do anything, because it is true
                        }
                        else
                        {
                            control = true;
                            break;
                        }

                    }
                    if (control)
                    {
                        Console.WriteLine("Please enter a valid TR ID Number");
                    }
                    else
                    {
                        TrIDNumber = value;
                    }
                }
                else
                {
                    Console.WriteLine("The length of your input is not equal to 11, please edit it");
                }
            }
        }

    }
}

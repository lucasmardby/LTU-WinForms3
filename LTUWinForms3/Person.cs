using System;
using System.Configuration;

namespace LTUWinForms3
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private string personalNumber;
        private string gender;

        public string GetFirstName()
        {
            return firstName;
        }
        public void SetFirstName(string value)
        {
            if (value.IsNotNullOrEmpty())
                firstName = value;
            else
                MessageBox.Show("Invalid value!");
        }
        public string GetLastName()
        {
            return lastName;
        }
        public void SetLastName(string value)
        {
            if (value.IsNotNullOrEmpty())
                lastName = value;
            else
                MessageBox.Show("Invalid value!");
        }
        public string GetPersonalNumber()
        {
            return personalNumber;
        }
        public bool SetPersonalNumber(string value)
        {
            bool ok = int.TryParse(value, out int number);

            if (value.Length == 10 || value.Length == 12)
            {
                if (ControlPersonalNumber(value))
                {
                    personalNumber = value;
                    ok = true;
                }
            }
            else
            {
                ok = false;
            }

            return ok;
        }
        public string GetGender()
        {
            return gender;
        }
        public void SetGender()
        {
            ControlGender();
        }

        private static bool ControlPersonalNumber(string value)
        {
            if (value.Length == 12)
            {
                value.Remove(0, 2);
            }

            char[] numberArray = value.ToCharArray();
            double sum = 0;
            int counter = 2;

            foreach (char c in numberArray)
            {
                int holder = 0;
                int digit = Convert.ToInt32(Char.GetNumericValue(c));

                if (counter == 1)
                {
                    holder = digit * 1;
                    counter++;
                }
                else if (counter == 2)
                {
                    if (digit == 0)
                        holder = digit;
                    else
                        holder = digit * 2;

                    counter--;
                }

                if (holder > 9)
                {
                    char[] test = holder.ToString().ToCharArray();
                    sum += Char.GetNumericValue(test[0]) + Char.GetNumericValue(test[1]);
                }
                else
                {
                    sum = sum + holder;
                }
            }

            bool validPersonalNumber;
            if (sum % 10 == 0)
            {
                validPersonalNumber = true;
            }
            else
            { 
                validPersonalNumber = false; 
            }

            return validPersonalNumber;
        }
        private void ControlGender()
        {
            char[] values = personalNumber.ToCharArray();
            int determiner = 0;

            if (values.Length > 0)
            {
                determiner = values.Length - 2;
            }

            int genderNum = Convert.ToInt32(values[determiner].ToString());

            if (genderNum % 2 == 0)
            {
                gender = "Female";
            }
            else 
            {
                gender = "Male";
            }
        }
    }
}

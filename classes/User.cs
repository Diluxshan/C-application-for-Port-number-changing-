using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace on_off_displaying.classes
{
    class User
    {
        String firstName;
        String LastName;
        int age;

        public User(String firstName, String LastName)
        {
            this.firstName = firstName;
            this.LastName = LastName;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public String getFirstName()
        {
            return this.firstName;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public int getAge()
        {
            return this.age;
        }

        public static bool compareAge(int age1, int age2)
        {
            if (age1 == age2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

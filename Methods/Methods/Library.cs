using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public class Library
    {
        public string[] username = new string[10];
        public string[] password = new string[10];
        static int counter = 0;


        public string enPass(string user, string pass)
        {
            byte[] aarr = System.Text.ASCIIEncoding.ASCII.GetBytes(pass);
            string encryption = Convert.ToBase64String(aarr);
            for (int i = 0; i < 10; i++)
            {
                if (password[i] == null && username[i] == null)
                {
                    username[i] = user;
                    password[i] = encryption;
                    break;
                }
            }
            return pass;
        }

        public string dePass(string pass)
        {
            byte[] arr = System.Text.ASCIIEncoding.ASCII.GetBytes(pass);
            string encryption = Convert.ToBase64String(arr);
            return encryption;
        }
        public int Counter()
        {
            counter++;
            return counter;
        }
    }
}

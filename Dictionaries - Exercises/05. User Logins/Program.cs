using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.User_Logins
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var savedUsers = new Dictionary<string, string>();

            var loginFails = 0;

            while (line != "login")
            {
                var input = line.Split();
                var username = input[0];
                var password = input[input.Length - 1];

                savedUsers[username] = password;

                line = Console.ReadLine();
            }
            line = Console.ReadLine();

            while (line != "end")
            {
                var input = line.Split();
                var loginUserName = input[0];
                var loginPassword = input[input.Length - 1];

                if (!savedUsers.ContainsKey(loginUserName) || !savedUsers.ContainsValue(loginPassword))
                {
                    Console.WriteLine("{0}: login failed", loginUserName);
                    loginFails++;
                }
                else if (savedUsers.ContainsKey(loginUserName) && savedUsers.ContainsValue(loginPassword))
                {
                    Console.WriteLine("{0}: logged in successfully", loginUserName);
                }

                line = Console.ReadLine();
            }
            Console.WriteLine("unsuccessful login attempts: {0}", loginFails);
        }
    }
}

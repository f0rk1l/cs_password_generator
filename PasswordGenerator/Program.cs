using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Program
    {

        static string GeneratePassword(int Length, PasswordType Type)
        {
            Random rand = new Random();

            string Password = "";

            switch (Type)
            {
                case PasswordType.LETTERS:

                    string Letters = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";

                    for (int i = 0; i < Length; i++)
                    {
                        Password += Letters[rand.Next(0, Letters.Length)];
                    }

                    break;

                case PasswordType.NUMBERS:

                    for (int i = 0; i < Length; i++)
                    {
                        Password += Convert.ToString(rand.Next(0, 10));
                    }

                    break;

                case PasswordType.SPEC_SYMBOLS:

                    string spec_symbols = "!@#$%^&*()-_=+/?<>,.\\";

                    for (int i = 0; i < Length; i++)
                    {
                        Password += spec_symbols[rand.Next(0, spec_symbols.Length)];
                    }

                    break;

                case PasswordType.ALL_TYPES:

                    string all_symbols = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM!@#$%^&*()-_=+/?<>,.\\1234567890";

                    for (int i = 0; i < Length; i++)
                    {
                        Password += all_symbols[rand.Next(0, all_symbols.Length)];
                    }

                    break;
            }

            return Password;
        }

        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Enter password length: ");
                int Length = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nChoose password type:\n\n[1] Letters\n\n[2] Numbers\n\n[3] Special symbols\n\n[4] All types\n\nChoose: ");
                int Choose = Convert.ToInt32(Console.ReadLine());

                if (Choose >= 1 && Choose <= 4)
                {
                    Console.WriteLine($"\nPassword: {GeneratePassword(Length, (PasswordType) Choose)}");
                }

                Console.Write("\nPress some button to clear output...");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Generator_For_Simple_Passwords.Model
{
    class Generator
    {
        private string passwords;
        public Generator()
        {
            passwords = string.Empty;
        }

        public string Generate(int n, int l)
        {
            for (int num01 = 1; num01 <= n; num01++)
            {
                for (int num02 = 1; num02 <= n; num02++)
                {
                    for (char letter01 = 'a'; letter01 < 'a' + l; letter01++)
                    {
                        for (char letter02 = 'a'; letter02 < 'a' + l; letter02++)
                        {
                            for (int num03 = Math.Max(num01, num02) + 1; num03 <= n; num03++)
                            {
                                passwords = $"{num01}{num02}{letter01}{letter02}{num03}";
                                Console.WriteLine(passwords);
                            }
                        }
                    }
                }
            }

            return passwords;
        }
    }
}

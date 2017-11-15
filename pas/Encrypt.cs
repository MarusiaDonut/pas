using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
namespace pas
{
    class Encrypt
    {
        private char[] characters = new char[] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
                                                'K', 'M', 'L', 'N', 'O', 'P', 'Q', 'R', 'S',
                                                'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '1', '2', '3', '4', '5', '6', '7',
                                                '8', '9', '0' };
        private string f = @"f.txt";
        public string F
        {
            get
            {
                return f;
            }
        }
        private string EncPass(string Pass, string Key)
        {
           
            int N = characters.Length;
            string result = "";
            int keyword_index = 0;
           
                for (int i = 0; i< Pass.Length; i++)
               
                {
                   int c = (Array.IndexOf(characters, Pass[i]) +
                   Array.IndexOf(characters, Key[keyword_index])) % N;
                   result += characters[c];
                   keyword_index++;

                if ((keyword_index + 1) == Key.Length)
                    keyword_index = 0;
            }

            return result;
        }

        private string GenerateKeyWord(int length = 4)
        {
            Random rand = new Random();
            
            string result = "";
            for (int i = 0; i < length; i++)
                result += characters[rand.Next(0, characters.Length)];
            return result;
        }
       public string Write(string pass)
       {

            string result = GenerateKeyWord();
            StreamWriter file = new StreamWriter(f);
            file.Write(EncPass(pass, result));
            file.Close();
            return result;
       }
        public bool CheckPass(string pass, string res)
        {
           StreamReader file = new StreamReader(f);
            if (String.Equals(EncPass(pass, res), file.ReadLine()))

            {
                file.Close();
                return true;
            }
            else
            {
                file.Close();
                return false;
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{

    class Master
    {

        private char[] _mastersColours = new char[7];
        private string _code; 

        public Master(char[] cols) {
            _mastersColours = cols;
            SetCode();
            //Console.WriteLine("Code: " + _code);
        }

        private void ShuffleColours()
        {
            Random rnd = new Random();
            int comp1, comp2;
            char temp;
            for (int i = 0; i < 20; ++i)
            {
                comp1 = rnd.Next(0, _mastersColours.Length);
                comp2 = rnd.Next(0, _mastersColours.Length);
                temp = _mastersColours[comp1];
                _mastersColours[comp1] = _mastersColours[comp2];
                _mastersColours[comp2] = temp;
            }
        }

        private void SetCode()
        {
            ShuffleColours();
            for (int i = 0; i < 4; ++i)
            {
                _code += _mastersColours[i];
            }
            ShuffleColours();
        }

        public void CheckString(string guess, out int Correct, out int IncorrectPosition) {
            Correct = 0; IncorrectPosition = 0;
            for (int i = 0; i < guess.Length; ++i)
            {
                if (char.ToUpper(guess[i]) == _code[i])
                {
                    ++Correct;
                    continue;
                }
                
                for (int k = 0; k < _code.Length; ++k)
                {
                    if (char.ToUpper(guess[i]) == _code[k])
                    {
                        ++IncorrectPosition;
                        break;
                    }
                }

                
            }
        }
        

    }
}

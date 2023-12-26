using System;
using Magic_Numbers.Model;
using Magic_Numbers.Views;

namespace Magic_Numbers.Controller
{
    class MagicNumbersController
    {
        private Display display;
        private MagicalNumbers magicNumbers;

        public MagicNumbersController()
        {
            display = new Display(this);
            magicNumbers = new MagicalNumbers();
        }

        public void HandleUserInput(string userInput)
        {
            if (int.TryParse(userInput, out int magicalNumber) && magicalNumber >= 1 && magicalNumber <= 999999)
            {
                magicNumbers.FindAllMagicNumbers(magicalNumber);
                display.PrintResults(magicNumbers.GetMagicalNumbers());
            }
        }

        public void Run()
        {
            display.GetUserInput();
        }
    }
}

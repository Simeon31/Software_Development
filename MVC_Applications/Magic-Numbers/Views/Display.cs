using Magic_Numbers.Controller;
using System;

namespace Magic_Numbers.Views
{
    class Display
    {
        private MagicNumbersController controller;

        public Display(MagicNumbersController controller)
        {
            this.controller = controller;
        }

        public void GetUserInput()
        {
            string userInput = Console.ReadLine();
            controller.HandleUserInput(userInput);
        }

        public void PrintResults(string magicalNumbers)
        {
            Console.Write($"{magicalNumbers}");
        }
    }
}

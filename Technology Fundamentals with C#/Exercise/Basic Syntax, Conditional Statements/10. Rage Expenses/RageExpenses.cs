namespace _10._Rage_Expenses
{
    using System;

    class RageExpenses
    {
        static void Main()
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int countHeadset = 0;
            int countMouse = 0;
            int countKeyboard = 0;
            int countDisplay = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                bool isMouseTrashed = false;
                bool isHeadsetTrashed = false;
                bool isKeyboardTrashed = false;

                if (i % 2 == 0)
                {
                    countHeadset++;
                    isHeadsetTrashed = true;
                }
                if (i % 3 == 0)
                {
                    isMouseTrashed = true;
                    countMouse++;
                }
                if (isHeadsetTrashed && isMouseTrashed)
                {
                    countKeyboard++;
                    isKeyboardTrashed = true;
                }
                if (countKeyboard != 0 && countKeyboard % 2 == 0 && isKeyboardTrashed)
                {
                    countDisplay++;
                }
            }
            double totalCost = countDisplay * displayPrice + countKeyboard * keyboardPrice + countMouse * mousePrice + countHeadset * headsetPrice;
            Console.WriteLine($"Rage expenses: {totalCost:f2} lv.");
        }
    }
}

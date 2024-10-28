namespace Coffee_machine
{
    internal class Program
    {

        const double neededAmountOfWaterForAmericano = 0.09;
        const double neededAmountOfWaterForCappucin = 0.08;
        const double neededAmountOfWaterForLatte = 0.05;
        const double neededAmountOfCoffeeForAmericano = 0.02;
        const double neededAmountOfCoffeeForCappucin = 0.03;
        const double neededAmountOfCoffeeForLatte = 0.03;
        const double neededAmountOfMilkForCappucin = 0.2;
        const double neededAmountOfMilkForLatte = 0.18;
        const double neededAmountOfSugarForAmericano = 0.05;
        const double neededAmountOfSugarForCappucin = 0.09;
        const double neededAmountOfSugarForLatte = 0.06;


        const int americanoPrice = 199;
        const int cappucinPrice = 149;
        const int lattePrice = 219;

        public double RemainingWater { get; private set; }  // = 100;

        public double RemainingCoffee { get; private set; } // = 50;

        public double RemainingMilk { get; private set; }   // = 50;

        public double RemainingSugar { get; private set; }  // = 30;

        public int RemainingCash { get; private set; }     // = 300;

        public int TotalSolds { get; private set; } = 0;

        public string Name { get; set; }

        private int _userInsertedAmountOfMoney = 0;
        //private int _currentPurchaseAmount = 0;

        public Program(string name, int water, int coffee, int milk, int sugar, int cash)
        {

            Name = name;
            RemainingWater = water;
            RemainingCoffee = coffee;
            RemainingMilk = milk;
            RemainingSugar = sugar;
            RemainingCash = cash;
        }

        public void BuyAmericano(bool isNeedSugar)
        {
            if (ErrorsCheck (ErrorCheckProvider.Americano))
            {
                if (isNeedSugar)
                {
                    MakeAmericanoWithSugar();
                    DropChange(_userInsertedAmountOfMoney - americanoPrice);
                }
                else
                {
                    MakeAmericano();
                    DropChange(_userInsertedAmountOfMOney - americanoPrice):
                }
            }
            
        }

        private void MakeAmericanoWithSugar()
        {
            RemainingWater -= neededAmountOfWaterForAmericano;
            RemainingCoffee -= neededAmountOfCoffeeForAmericano;
            RemainingSugar -= neededAmountOfSugarForAmericano;
            Console.WriteLine("\nHere's your americano with sugar!\n");
        }
        private void MakeAmericano()
        {
            RemainingWater -= neededAmountOfWaterforAmericano;
            RemainingCoffee -= neededAmountOfCoffeeForAmericano;
            Console.WriteLine("\nHere's your americano!\n");
        }


        public void BuyCappucin(bool isNeedSugar)
        {
            if (ErrorsCheck(ErrorCheckProvider.Cappucin))
            {
                if (isNeedSugar)
                {
                    MakeCappucinWithSugar();
                    DropChange(_userInsertedAmountOfMoney - cappucinPrice);
                }
                else
                {
                    MakeCappucin();
                    DropChange(_userInsertedAmountOfMoney - cappucinPrice);
                }
            }
        }
        private void MakeCappucinWithSugar()
        {
            RemainingWater -= neededAmountOfWaterForCappucin;
            RemainingCoffee -= neededAmountOfCoffeeForCappucin;
            RemainingSugar - = neededAmountOfSugarForCappucin;
            Console.WriteLine("\nHere's your cappucin with sugar!\n");
        }
        private void MakeCappucin()
        {
            RemainingWater -= neededAmountOfWaterForCappucin;
            RemainingCoffee -= neededAmountOfCoffeeForCappucin;
            Console.WriteLine("\nHere's your cappucin!\n");
        }

        public void BuyLatte(bool isNeedSugar)
        {
            if (ErrorsCheck(ErrorsCheckProvider.latte))
            {
                if (isNeedSugar)
                {
                    MakeLatteWithSugar();
                    DropChange(_userInsertedAmountOfMoney - lattePrice);
                }
                else
                }
            
                    
        
    }
}

namespace SolidPrinciples
{

    interface ICardType
    {
        void GetTransactionFee(double amount);
    }





    class Visa : ICardType
    {
        public void GetTransactionFee(double amount)
        {
            const double VISA_RATE = 0.03;
            Console.WriteLine($"Transaction Fee : ${amount * VISA_RATE}");
        }
    }

    class MasterCard : ICardType
    {
        public void GetTransactionFee(double amount)
        {
            const double MASTER_CARD_RATE = 0.06;
            Console.WriteLine($"Transaction Fee : ${amount * MASTER_CARD_RATE}");
        }
    }

    class OpenClosed
    {
        static void main()
        {
            Visa V1 = new Visa();
            V1.GetTransactionFee(321.123);


        }
    }
}





namespace RAZRpr02
{
    class Bits
    {
        private long number;

        public Bits(byte number)
        {
            this.number = number;
        }
        public Bits(int number)
        {
            this.number = number;
        }
        public Bits(long number)
        {
            this.number = number;
        }

        public string ToBinaryString()
        {
            return Convert.ToString(number, 2);
        }
    }
    class Program
    {
        static void Main()
        {
            byte number1 = 156;
            Bits numberInBits = new Bits(number1);

            Console.WriteLine($"Битовое представление числа {number1} : {numberInBits.ToBinaryString()}");

            int number2 = 6584648;
            Bits numberInBits2 = new Bits(number2);

            Console.WriteLine($"Битовое представление числа {number2} : {numberInBits2.ToBinaryString()}");

            long number3 = 143124221798;
            Bits numberInBits3 = new Bits(number3);

            Console.WriteLine($"Битовое представление числа {number3} : {numberInBits3.ToBinaryString()}");
        }
    }
}
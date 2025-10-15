namespace OOP2_MidtermPractice_2.Classes

{
    public static class RandomGenerator
    {
        public static Random random = new Random(DateTime.Now.Millisecond);

        public static int Random1To100()
        {
            return random.Next(1, 100);
        }
    }
}

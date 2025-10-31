namespace OOP2_MidtermPractice_2.Classes

{
    public class RNG
    {
        public static Random random = new Random(DateTime.Now.Millisecond);

        public int Random1To100()
        {
            return random.Next(1, 100);
        }
    }
}

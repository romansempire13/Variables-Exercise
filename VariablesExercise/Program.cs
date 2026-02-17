namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string myName = "Roman";
            int age = 34;
            char initial = 'R';
            double avg = 98.7;
            decimal bankAccount = 66.6m;
            bool single = true;
            
            Console.WriteLine($"Name: {myName}\nAge: {age}\nInitial: {initial}\nAverage: {avg}\nMoney: {bankAccount}\nSingle: {single}");
        }
    }
}

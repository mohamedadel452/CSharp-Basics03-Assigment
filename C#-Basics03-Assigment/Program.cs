

namespace Session3Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Q1: String ToUpper()

            Console.WriteLine("Q1: String ToUpper() ");
            Console.WriteLine("Create a string variable named title with the value \"clean code\".");

            string title = "clean code";
            string upperTitle = title.ToUpper();

            Console.WriteLine("The string title and upperTitle are created.");
            Console.WriteLine("print the original title and the upperTitle  after using ToUpper():");
            Console.WriteLine($"Original: {title}");

            // Print the upperTitle after using ToUpper()
            // the ToUpper() method converts all the characters in the string to uppercase.
            // the sring title is "clean code" and the upperTitle is "CLEAN CODE"

            Console.WriteLine($"Uppercase: {upperTitle}");

            #endregion

        }
    }
}
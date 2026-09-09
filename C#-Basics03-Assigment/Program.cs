

using System.Text;

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

            #region Q2: String ReferenceEquals

            Console.WriteLine("\nQ2: String ReferenceEquals");

            Console.WriteLine("-Create two string variables str1 and str2 with the same value \"Clean Code\".");

            string str1 = "Clean Code";
            string str2 = "Clean Code";


            // Check if str1 and str2 reference the same object in memory
            bool areSameReference = object.ReferenceEquals(str1, str2);

            Console.WriteLine($"Are the strings the same reference? {areSameReference}");

            // The output will be True because string literals with the same value are interned in C#.
            //and the same reference means that both str1 and str2 point to the same memory location where the string "Clean Code" is stored.

            Console.WriteLine("-Now, create a new string variable str3 with the value \"clean code\" (note the lowercase).");

            string str3 = new string("Clean Code".ToCharArray());
            bool areSameReference2 = object.ReferenceEquals(str1, str3);

            Console.WriteLine($"Are the strings the same reference? {areSameReference2}");



            #endregion

            #region Q3:StringBuilder Append
            Console.WriteLine("\nQ3: StringBuilder Append");

            Console.WriteLine("-Create a StringBuilder object named str_builder.");

            StringBuilder str_builder = new StringBuilder();

            Console.WriteLine("append the string \"Book List\" to the str_builder using the Append() method.");
            //apend the string "Book List" to the StringBuilder object str_builder using the Append() method.
            str_builder.Append("Book List");


            Console.WriteLine("The string \"Book List\" has been appended to the str_builder.");

            //append the string " - Updated" to the StringBuilder object str_builder using the Append() method.
            Console.WriteLine("append the string \" - Updated\" to the StringBuilder object str_builder using the Append() method.");
            str_builder.Append(" - Updated");

            // Print the final string after appending
            Console.WriteLine($"Final string: {str_builder}");

            //Q3 is answered

            #endregion

            #region Q4: StringBuilder Replace
            Console.WriteLine("\nQ4: StringBuilder Replace ");

            Console.WriteLine("use the Replace() method of the StringBuilder class, replace the substring\n \"Book List\" with \"Library\" in the str_builder object.");
           
            //using the Replace() method of the StringBuilder class, replace the substring "Book List" with "Library" in the str_builder object.
            str_builder.Replace("Book List", "Library");
            Console.WriteLine($"Final string after replacement: {str_builder}");
            Console.WriteLine("The substring \"Book List\" has been replaced with \"Library\" in the str_builder object.");




            #endregion

            #region Q5: String Concatenation (+)
            Console.WriteLine("\nQ5: String Concatenation (+) ");
            Console.WriteLine("Create a string variable named title2 with the value \"Clean Code\"\n and an integer variable named pages with the value 464.");
            string title2 = "Clean Code";
            int pages = 464;
            string sentence1 = "Book: " + title2 + ", Pages: " + pages;
            Console.WriteLine(sentence1 + "\n");
            #endregion

            #region Q6: String Interpolation ($)
            Console.WriteLine("Q6: String Interpolation ($) ");

            Console.WriteLine("Create this sentence using string interpolation: Book: Clean Code, Pages: 464");
           
            // Create this sentence using string interpolation: Book: Clean Code, Pages: 464
            string sentence2 = $"Book: {title2}, Pages: {pages}";
            Console.WriteLine(sentence2 + "\n");

            #endregion

            #region Q7: String.Format
            Console.WriteLine("Q7: String.Format ");

            Console.WriteLine("Create this sentence using String.Format: Book: Clean Code, Pages: 464");
            string sentence3 = string.Format("Book: {0}, Pages: {1}", title2, pages);
        
            Console.WriteLine(sentence3 + "\n");

            #endregion






        }
    }
}
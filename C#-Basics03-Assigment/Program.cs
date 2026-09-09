

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

            #region Q8: If / Else Statement

            
            Console.WriteLine(" Q8: If / Else Statement ");
           
            Console.WriteLine("Create an if/else statement that checks if the number of pages is greater than 300.\n If it is, print \"Long Book\"; otherwise, print \"Short Book\".");
          
            int pagess = 464;
            
            if (pagess > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }

            #endregion

            #region Q9: Logical AND (&&)And If Statment

            Console.WriteLine(" Q9: Logical AND (&&) And If Statment");
            
            bool isAvailable = true;
            
            if (pagess > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book\n");
            }
            #endregion

            #region Q10: Switch Statement
            Console.WriteLine("Q10: Switch Statement ");
            string title3 = "Refactoring";
            Console.WriteLine("The Titel is :");
            switch (title3)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            Console.WriteLine();
            #endregion

            #region Q11: Ternary Operator
            Console.WriteLine("Q11: Ternary Operator ");
            Console.WriteLine("Use the ternary operator to assign a string variable named sizeLabel with the value:\n" +
                " \"Long Book\" if the number of pages is greater than " +
                " 300, \n or \"Short Book\" otherwise.");
            string sizeLabel = (pagess > 300) ? "Long Book" : "Short Book";

            //varible = (condition) ? value_if_true : value_if_false;
            Console.WriteLine($"sizeLabel: {sizeLabel}\n");
            #endregion

            #region Q12: For Loop
            Console.WriteLine("Q12: For Loop ");
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //print the list of books using a for loop
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }
            Console.WriteLine();
            #endregion

            #region Q13: While Loop
            Console.WriteLine("Q13: While Loop ");
            //print the list of books using a while loop
            // Initialize a variable to keep track of the index
            int index = 0;
            //print the list of books using a while loop till the index is less than the length of the books array
            while (index < books.Length)
            {
                Console.WriteLine($"{index + 1}. {books[index]}");
                // Increment the index to avoid an infinite loop
                index++;
            }
            Console.WriteLine();
            #endregion

            #region Q14: Do-While Loop
            Console.WriteLine(" Q14: Do-While Loop ");
            int count = 0;
            // Use a do-while loop to print "Checking book..." three times
            // The do-while loop will execute the block of code at least once before checking the condition
            do
            {
                Console.WriteLine("Checking book...");
                count++;
            }
            // The loop will continue as long as count is less than 3
            while (count < 3);
            Console.WriteLine();
            #endregion

            #region Q15: Foreach Loop
            Console.WriteLine(" Q15: Foreach Loop ");
            foreach (string book in books)
            {
                // Print the index of the book in the list using IndexOf method and add 1 to make it 1-based index
                //Index of method returns the index of the first occurrence of a specific object in the list
                Console.WriteLine($"{books.IndexOf(book) + 1}. {book}");
            }
            Console.WriteLine();
            #endregion

            #region Q16: Break Statement
            Console.WriteLine(" Q16: Break Statement ");
            //var data structure to store the list of books instead of writing string data type
            foreach (var book in books)
            {
                if (book == "Refactoring")
                {
                    // If the book is "Refactoring", break out of the loop 
                    break;
                }
                Console.WriteLine($"{books.IndexOf(book) + 1}. {book}");
            }

            #endregion

            #region Q17: Continue Statement
            Console.WriteLine("\nQ17: Continue Statement ");
            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    // If the book is "The Pragmatic Programmer", skip the rest of the loop and continue with the next iteration
                    continue;
                }
                Console.WriteLine($"{books.IndexOf(book) + 1}. {book}");
            }
            Console.WriteLine();
            #endregion

            #region Q18: Method PrintFirstBook (with early return)
            Console.WriteLine("Q18: Method PrintFirstBook ");
            PrintFirstBook(books);

            // Testing with an empty array
            Console.WriteLine("\nTesting PrintFirstBook with empty array:");
            string[] emptyBooks = new string[0];
            PrintFirstBook(emptyBooks);
            Console.WriteLine();

            //Testing with a null array
            Console.WriteLine("Testing PrintFirstBook with null array:");
            PrintFirstBook(null);
            Console.WriteLine(); 
            #endregion


        }

        #region Method for Q18
         
        // This method takes an array of strings (booksArray) as input and prints the first book in the array.
        //the method is static , meaning it belongs to the class itself rather than an instance of the class
        //onle static methods can be called without creating an instance of the class.
        // The method has a void return type, indicating that it does not return any value.
        // The method uses an early return to exit the method if the input array is null or empty, preventing any further execution and avoiding potential errors.
        static void PrintFirstBook(string[] booksArray)
        {
            if (booksArray == null || booksArray.Length == 0)
            {
                Console.WriteLine("The array is empty or null. No books to display.");
                return;
            }
            Console.WriteLine($"First book is: {booksArray[0]}");
        }
        #endregion


    }
}

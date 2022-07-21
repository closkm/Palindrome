namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please type a word and I will see if it is a palindrome!");

            string word = Console.ReadLine();
            Palindrome palindrome = new Palindrome(word);
            Console.WriteLine(palindrome.isPalindrome());
        }
    }
}
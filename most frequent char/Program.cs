namespace most_frequent_char
{
    public class Program
    {
        public static char mostFrequentChar(string s)
        {
            int mostFrequent = 0; // int to keep track of the most frequent char value
            char mostFrequentChar = char.MaxValue; // char that we return

            Dictionary<char,int> count = characterCount(s); // calling our method which puts string into dictionary

            foreach (char c in s) // iterate through the string
            {
                if (count[c] > mostFrequent) // checking if the value in the dictionary (number of times the character appears in the string) is greater than our current most frequent value
                {
                    mostFrequent = count[c];
                    mostFrequentChar = c;
                }
            }

            return mostFrequentChar;
        }

        public static char mostFrequentChar2(string s)
        {
            
            char mostFrequentChar = '\0'; // setting most frequent char to null-like value, keeping track of key of dictionary because this is what we want to return at the end

            Dictionary<char, int> count = characterCount(s); // calling our method which puts string into dictionary

            foreach (char c in s) // iterate through the string
            {
                if(mostFrequentChar == '\0' || count[c] > count[mostFrequentChar]) // checking if most frequent is null or the count of the current char we are iterating through is greater than the value of current 
                {
                    mostFrequentChar = c;
                }
            }

            return mostFrequentChar;
        }

        // method that puts string in a dictionary, the key is the char and the value is the number of times that char appears in the string
        public static Dictionary<char,int> characterCount(string s)
        {
            Dictionary<char, int> count = new Dictionary<char, int>();

            foreach (char c in s) 
            {
                if (!count.ContainsKey(c)) // if dictionary does not contain the char
                {
                    count[c] = 0; // initialized the char in dictionary
                }            
                count[c]++; // increment the value of the char by 1
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(mostFrequentChar2("mississipi"));
        }
    }
}

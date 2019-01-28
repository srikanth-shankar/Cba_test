using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBA
{
    public class CountingRules
    {
        // Cr1 == CountingRule1 == Avg len of words starting with A or a
        /*
            // loop through the words list 
            // identify the words starting with startChar & increment a counter for every find
            // append to another length counter that'll have the total sum of all the string lenghts of the found words
            // take avg and write to a file
        */
        public void Cr1(List<string> wordsList, string startChar = "a")
        {
            int noOfWords = 0;
            int foundWordTotalLength = 0;
            using (var file = new StreamWriter("average_length_of_words_starting_with_a.txt"))
            {
                foreach (var word in wordsList)
                {
                    if (word.StartsWith(startChar.ToLower()))
                    {
                        noOfWords++;
                        foundWordTotalLength = foundWordTotalLength + word.Length;
                        file.WriteLine($"Avg len of words starting with {startChar}: {foundWordTotalLength/noOfWords}");
                    }
                }
            }
        }
    
        // Cr2 == CountingRule2 == Total count of e's in the words that start with b
        /*
            // loop through the words list 
            // identify the words starting with startChar
            // append to a length counter that'll have the total count of e's in the found words
            // write to a file
        */
        public void Cr2(List<string> wordsList, string startChar = "b", string findChar = "e")
        {
            int foundWordTotalLength = 0;
            startChar = startChar.ToLower();
            findChar = findChar.ToLower();
            using (var file = new StreamWriter("count_of_e_in_words_starting_with_b.txt"))
            {
                foreach (var word in wordsList)
                {
                    if (word.StartsWith(startChar))
                    {
                        if(word.Contains(findChar))
                        {
                            foundWordTotalLength = foundWordTotalLength + word.Count(x => x == findChar.ToCharArray()[0]);
                            file.WriteLine($"Total count of {findChar}'s in the words that start with {startChar}");
                        }
                        
                    }
                }
            }
        }

        // Cr3 == CountingRule3 == longest words starting with abc
        /*
            // customer input required: Will we have to always search with any 3 characters or it may vary?
            // Assuming the startChars are not less than 3 chars : example1:a, b or c, exmple2: g,y,t
            // make a string list of words that start with a,b or c which is configurable, but minimum 3 req'd
            // order by desc usng linq and take first elem.
            //write to file
        */
        public void Cr3(List<string> wordsList, string startChars = "abc")
        {
            var foundStrings = new List<string>();

            wordsList.ForEach(x => {
                if(x.StartsWith(startChars.ToCharArray()[0].ToString()) 
                    || x.StartsWith(startChars.ToCharArray()[1].ToString())
                        || x.StartsWith(startChars.ToCharArray()[2].ToString())) 
                {
                    foundStrings.Add(x);
                }
            });
            using (var file = new StreamWriter("longest_words_starting_with_abc.txt"))
            {
                if (foundStrings != null && foundStrings.Count > 0)
                {
                    int longestLen = foundStrings.OrderByDescending(x => x.Length).First().Length;
                    file.WriteLine($"longest len of words starting with a, b or c: {longestLen}");
                }
                       
            }
        }

        // Cr4 == CountingRule4 == count of seq of words starting with c and next word with a 
        /*
            // for loop for all words
            // if word starts with c, chk if next word starts with a. 
            //if above is yes, incr a counter
            // write to file
        */
        public void Cr4(List<string> wordsList, string startChar = "c", string nextChar = "a")
        {
            using (var file = new StreamWriter("count_of_seq_of_words_starting_with_c_and_a.txt"))
            {
                int count = 0;
                for(int i=0; i<wordsList.Count; i++)
                {
                    if(wordsList[i].StartsWith(startChar))
                    {
                        if(wordsList[i + 1].StartsWith(nextChar))
                            count++;
                    }
                }
                file.WriteLine($"count of sequences that have 1st word start with c and next start with a");
            }
        }
    }
}

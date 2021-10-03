using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindMissingLetter
{
    class MissingLetterFinderClass
    {
        static List<char> toLowerLetters = new List<char>()
        { 'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
           
        static List<char> toUpperLetters = new List<char>() 
        { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        
        public static char MissingLetterFinderMeth(char[] testarray)
        {
            char result;
            char[] resultArray = new char[1];
            List<char> testlist = new List<char>();
            for (int i = 0; i<= testarray.Length - 1; i++)
            {
                testlist.Add(testarray[i]);
            }
            int lowerA = toLowerLetters.IndexOf(testarray[0]);
            int lowerB = toLowerLetters.IndexOf(testarray[testarray.Length - 1]);
            int upperA = toUpperLetters.IndexOf(testarray[0]);
            int upperB = toUpperLetters.IndexOf(testarray[testarray.Length - 1]);
            switch(toLowerLetters.Contains(testlist[0]))
            {
                case true:
                    {
                        for (int i = lowerA; i <= lowerB;)
                        {
                            if (testlist.Contains(toLowerLetters[i]))
                            {
                                i++;
                            }
                            else
                            {

                                resultArray[0] = toLowerLetters[i];
                                break;

                            }
                        }
                        break;
                    }
                case false:
                    {
                        for (int i = upperA; i <= upperB;)
                        {
                            if (testlist.Contains(toUpperLetters[i]))
                            {
                                i++;
                            }
                            else
                            {

                                resultArray[0] = toUpperLetters[i];
                                break;

                            }
                        }
                        break;
                    }

            }
            
            return result = resultArray[0];  
        }

        //LINQ method
        public static char FindMissingLetter(char[] array) => (char)Enumerable.Range(array[0], 25).First(x => !array.Contains((char)x));
    }
    class Program
    {
        static void Main(string[] args)
        {
            char[] testarray1 = { 'h', 'i', 'j','l' };
            char[] testarray2 = { 'H', 'I', 'J', 'L' };
            char a =  MissingLetterFinderClass.MissingLetterFinderMeth(testarray1);
            Console.WriteLine(a);
            
        }
    }
}

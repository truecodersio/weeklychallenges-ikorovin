﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


            public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            } 
               
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            
            else
            {
                return false;
            }
                
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {   
            if (numbers == null || numbers.Count() ==0)
            return 0;
            //double sum;
            return  numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
            return str2.Length;
            }
            return str1.Length;  
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            for(int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;     
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
                return 0;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
                if(numbers[i]%2 ==0)
            {
                sum += numbers[i];
             }
                return sum;
            
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) 
            return false;
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
                sum += numbers[i];
            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
            return false;
            }
            
        } 

             


        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0)
                return 0;
                 long count  = 0;
            for (long i = 0; i < number; i++)
                if (i % 2 != 0)
                {
                    count += 1;
                }
                 return count;
                
                    

        }
    }
}

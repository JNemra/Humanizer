﻿using System;
using Humanizer.Localisation.NumberToWords.Italian;

namespace Humanizer.Localisation.NumberToWords
{
    internal class ItalianNumberToWordsConverter : GenderedNumberToWordsConverter
    {
        public override string Convert(int number, GrammaticalGender gender)
        {
            if (number < 0)
                return "meno " + Convert(Math.Abs(number), gender);
        
            var cruncher = new ItalianCardinalNumberCruncher(number, gender);
            
            return cruncher.Convert();
        }

        public override string ConvertToOrdinal(int number, GrammaticalGender gender)
        {
            var cruncher = new ItalianOrdinalNumberCruncher(number, gender);
            
            return cruncher.Convert();
        }
    }
}
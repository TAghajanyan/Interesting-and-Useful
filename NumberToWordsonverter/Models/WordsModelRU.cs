using System;
using System.Collections.Generic;

namespace NumberToWordsonverter.Models
{
    class WordsModelRU : ModelBase
    {
        public WordsModelRU()
        {
            Ones = new List<Tuple<int, string>>();
            Ones.Add(new Tuple<int, string>(0, " "));
            Ones.Add(new Tuple<int, string>(1, " Один"));
            Ones.Add(new Tuple<int, string>(2, " Два"));
            Ones.Add(new Tuple<int, string>(3, " Три"));
            Ones.Add(new Tuple<int, string>(4, " Четыре"));
            Ones.Add(new Tuple<int, string>(5, " Пять"));
            Ones.Add(new Tuple<int, string>(6, " Шесть"));
            Ones.Add(new Tuple<int, string>(7, " Семь"));
            Ones.Add(new Tuple<int, string>(8, " Восемь"));
            Ones.Add(new Tuple<int, string>(9, " Девять"));

            Teens = new List<Tuple<int, string>>();
            Teens.Add(new Tuple<int, string>(0, " Десять"));
            Teens.Add(new Tuple<int, string>(1, " Одиннадцать"));
            Teens.Add(new Tuple<int, string>(2, " Двенадцать"));
            Teens.Add(new Tuple<int, string>(3, " Тринадцать"));
            Teens.Add(new Tuple<int, string>(4, " Четырнадцать"));
            Teens.Add(new Tuple<int, string>(5, " Пятнадцать"));
            Teens.Add(new Tuple<int, string>(6, " Шестнадцать"));
            Teens.Add(new Tuple<int, string>(7, " Семнадцать"));
            Teens.Add(new Tuple<int, string>(8, " Восемнадцать"));
            Teens.Add(new Tuple<int, string>(9, " Девятнадцать"));

            Tens = new List<Tuple<int, string>>();
            Tens.Add(new Tuple<int, string>(0, " "));
            Tens.Add(new Tuple<int, string>(1, " Десять"));
            Tens.Add(new Tuple<int, string>(2, " Двадцать"));
            Tens.Add(new Tuple<int, string>(3, " Тридцать"));
            Tens.Add(new Tuple<int, string>(4, " Сорок"));
            Tens.Add(new Tuple<int, string>(5, " Пятьдесят"));
            Tens.Add(new Tuple<int, string>(6, " Шестьдесят"));
            Tens.Add(new Tuple<int, string>(7, " Семьдесят"));
            Tens.Add(new Tuple<int, string>(8, " Восемьдесят"));
            Tens.Add(new Tuple<int, string>(9, " Девяносто"));

            Hundreds = new List<Tuple<int, string>>();
            Hundreds.Add(new Tuple<int, string>(0, " Сто"));
            Hundreds.Add(new Tuple<int, string>(1, " Тысяча"));
            Hundreds.Add(new Tuple<int, string>(2, " Миллиона"));
        }
    }
}

using System;
using System.Collections.Generic;

namespace NumberToWordsonverter.Models
{
    class WordsModelARM : ModelBase
    {
        public WordsModelARM()
        {
            Ones = new List<Tuple<int, string>>();
            Ones.Add(new Tuple<int, string>(0, " "));
            Ones.Add(new Tuple<int, string>(1, " Մեկ"));
            Ones.Add(new Tuple<int, string>(2, " Երկու"));
            Ones.Add(new Tuple<int, string>(3, " Երեք"));
            Ones.Add(new Tuple<int, string>(4, " Չորս"));
            Ones.Add(new Tuple<int, string>(5, " Հինգ"));
            Ones.Add(new Tuple<int, string>(6, " Վեց"));
            Ones.Add(new Tuple<int, string>(7, " Յոթ"));
            Ones.Add(new Tuple<int, string>(8, " Ութ"));
            Ones.Add(new Tuple<int, string>(9, " Ինը"));

            Teens = new List<Tuple<int, string>>();
            Teens.Add(new Tuple<int, string>(0, " Տասը"));
            Teens.Add(new Tuple<int, string>(1, " Տասնմեկ"));
            Teens.Add(new Tuple<int, string>(2, " Տասներկու"));
            Teens.Add(new Tuple<int, string>(3, " Տասներեք"));
            Teens.Add(new Tuple<int, string>(4, " Տասնչորս"));
            Teens.Add(new Tuple<int, string>(5, " Տասնհինգ"));
            Teens.Add(new Tuple<int, string>(6, " Տասնվեց"));
            Teens.Add(new Tuple<int, string>(7, " Տասնյոթ"));
            Teens.Add(new Tuple<int, string>(8, " Տասնութ"));
            Teens.Add(new Tuple<int, string>(9, " Տասնիննը"));

            Tens = new List<Tuple<int, string>>();
            Tens.Add(new Tuple<int, string>(0, " "));
            Tens.Add(new Tuple<int, string>(1, " Տասը"));
            Tens.Add(new Tuple<int, string>(2, " Քսան"));
            Tens.Add(new Tuple<int, string>(3, " Երեսուն"));
            Tens.Add(new Tuple<int, string>(4, " Քառասուն"));
            Tens.Add(new Tuple<int, string>(5, " Հիսուն"));
            Tens.Add(new Tuple<int, string>(6, " Վաթցսուն"));
            Tens.Add(new Tuple<int, string>(7, " Յոթանասուն"));
            Tens.Add(new Tuple<int, string>(8, " Ութսուն"));
            Tens.Add(new Tuple<int, string>(9, " Ինիսուն"));

            Hundreds = new List<Tuple<int, string>>();
            Hundreds.Add(new Tuple<int, string>(0, " Հարյուր"));
            Hundreds.Add(new Tuple<int, string>(1, " Հազար"));
            Hundreds.Add(new Tuple<int, string>(2, " Միլիոն"));
        }
    }
}

using NumberToWordsonverter.Models;
using System;
using System.Linq;

namespace NumberToWordsonverter
{
    class Converter
    {
        private ModelBase _model;
        private DataModel _result;
        private string _lng;

        public Converter(string languae)
        {
            _lng = languae;

            switch (languae)
            {
                case ("ARM"):
                    _model = new WordsModelARM();
                    break;

                case ("EN"):
                    _model = new WordsModelEN();
                    break;

                case ("RU"):
                    _model = new WordsModelRU();
                    break;

                default:
                    throw new Exception("Wrong language!!!");
            }
            _result = new DataModel();
        }

        public DataModel ProcessConversion(string number)
        {
            _result.Numbers = number;

            //try
            //{
                _result.Words = string.Format(ConvertNumberToWords(Convert.ToInt32(number)).Words);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            return _result;
        }

        private DataModel ConvertNumberToWords(int value)
        {
            //Ones
            if (value <= 9)
            {
                _result.Words += _model.Ones[value].Item2;
            }
            //Teens
            else if (value <= 19)
            {
                _result.Words += _model.Teens[value % 10].Item2;
            }
            //Tens
            else if (value <= 99) //45
            {
                int tens = value / 10;
                int ones = value % 10;
                _result.Words += _model.Tens[tens].Item2;
                ConvertNumberToWords(ones);
            }
            //Hundreds
            else if (value <= 999) //456
            {
                int hundreds = value / 100;
                int tens = value % 100;

                _result.Words += _model.Ones[hundreds].Item2 + _model.Hundreds[0].Item2;

                ConvertNumberToWords(tens);
            }
            //Thousands
            else if (value <= 9999) //4567
            {
                int thousands = value / 1000;
                int hundreds = value % 1000;


                _result.Words += _model.Ones[thousands].Item2 + _model.Hundreds[1].Item2;

                ConvertNumberToWords(hundreds);
            }
            //Ten Thousands
            else if (value <= 99999) //13520
            {
                int tenthousands = (value / 1000) % 10;
                int hundreds = value % 1000;

                _result.Words += _model.Teens[tenthousands].Item2 + _model.Hundreds[1].Item2;
                ConvertNumberToWords(hundreds);
            }
            //Hundred Thousands
            else if (value <= 999999) //135202
            {
                int hundreds1 = value / 1000;
                int hundreds2 = value % 1000;

                ConvertNumberToWords(hundreds1);

                _result.Words += _model.Hundreds[1].Item2;

                ConvertNumberToWords(hundreds2);
            }
            //Million
            else if (value <= 9999999) //1352522 
            {
                int million = value / 1000000;
                int hundredthousands = value % 1000000;

                _result.Words += _model.Ones[million].Item2 + _model.Hundreds[2].Item2;
                ConvertNumberToWords(hundredthousands);
            }
            else
            {
                throw new Exception("Bigger number. Max 9999999");
            }

            return _result;
        }
    }
}

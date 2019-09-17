using System;
using System.ComponentModel.DataAnnotations;

namespace Opgave1UnitTest
{
    public class Bog
    {

        public string _titel;

        private string _forfatter;

        private int _sidetal;

        private string _isbn13;

        public Bog(string forfatter, int sidetal, string isbn13, string titel)
        {
            _forfatter = forfatter;
            _sidetal = sidetal;
            _isbn13 = isbn13;
            _titel = titel;
        }

        public Bog()
        {
        }


        public string Isbn13
        {
            get { return _isbn13; }
            set { checkCharacters(value); _isbn13 = value; }
        }

        public int Sidetal
        {
            get { return _sidetal; }
            set
            {
                checkSidetal(value); _sidetal= value; }
        }

        public string Forfatter
        {
            get { return _forfatter; }
            set
            {
                checkifNull(value); _forfatter = value; }
        }

        public string Titel
        {
            get { return _titel; }
            set
            {
                checkMinimumCharacter(value); _titel = value; }
        }

        public int checkSidetal(int sideTal)
        {
            if (10 <= sideTal && sideTal <= 1000)
            {
                return sideTal;
            }
            throw new ArgumentException("Skal minimum være 10 sidder, og maksimum 1000");
        }

        public string checkCharacters(string characters)
        {
            if (characters.Length < 13 || characters.Length > 13 ) 
            {
                throw new ArgumentException("Has to be 13 characters");
            }
            return characters;
        }

        public string checkifNull(string checkNull)
        {
            if (String.IsNullOrEmpty(checkNull))
            {
                throw new ArgumentException("You have to type something in");
            }

            return checkNull;

        }

        public string checkMinimumCharacter(string check)
        {
            if (check.Length <= 2)
            {
                throw  new ArgumentException("Must be minimum 2 characters");
            }

            return check;
        }

        

        
    }
}

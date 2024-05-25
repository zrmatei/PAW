using System;

namespace proiectPAW_dictionar
{
    [Serializable]
    public class CuvEng
    {
        private string word;
        private string romanianWord;
        private DateTime registrationDate;

        public CuvEng()
        {
        }

        public CuvEng(string word, string romanianWord, DateTime registrationDate)
        {
            this.word = word;
            this.romanianWord = romanianWord;
            this.registrationDate = registrationDate;
        }

        public string Word { get => word; set => word = value; }
        public string RomanianWord { get => romanianWord; set => romanianWord = value; }
        public DateTime RegistrationDate { get => registrationDate; set => registrationDate = value; }
    }
}

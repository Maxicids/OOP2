using System;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Banking
{
    [Serializable]
    public class Owner
    {
        private DateTime birthDateTime;
        private int passportNumber;
        [NonSerialized]
        private readonly Random rnd = new Random(DateTime.Now.Millisecond);

        [Required]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        [MinLength(3)]
        [MaxLength(15)]
        private string name;

        public string Name => name;

        public int PassportNumber
        {
            get => passportNumber;
            set => passportNumber = value;
        }

        public DateTime BirthDateTime => birthDateTime;

        public Owner(string name, DateTime birthDateTime)
        {
            this.name = name;
            this.birthDateTime = birthDateTime;
            this.passportNumber = rnd.Next(100000, 999999 + 1);
        }
        public override string ToString()
        {
            return string.Concat(this.name, " born on the ", BirthDateTime) ;
        }
    }
}

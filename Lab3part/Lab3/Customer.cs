using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Customer
    {
        [Required]
        public int PassportId { get; set; }
        [Required, RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        [MinLength(3)]
        [MaxLength(15)]
        public string Name { get; set; }
        [Required, DataType(DataType.Password)]
        public int PassWord { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }

    }

    public class PassportAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string passport = value.ToString();
                if (passport.StartsWith("MP") && passport.Length.Equals(9))
                {
                    return true;
                }
                else
                {
                    this.ErrorMessage = "Only for citizens of Belarus";
                }
            }
            return false;
        }
    }
}

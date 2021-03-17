using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MiniProjeto
{
    public class Hero
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Required field.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Minimum 3 characters, maximum 60.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Required field.")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "Minimum 1, maximum 10.")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Required field.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Minimum 3 characters, maximum 60.")]
        public string SecretId { get; set; }

        [PowersAmount(ErrorMessage = "Minimum 1 and maximum 10 powers")]
        public List<string> Powers { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}", Name, Age);
        }
    }
}

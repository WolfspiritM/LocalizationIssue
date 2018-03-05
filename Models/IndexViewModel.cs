using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizationIssue.Models
{
    using System.ComponentModel.DataAnnotations;

    public class IndexViewModel
    {
        [StringLength(20, ErrorMessage = "LengthNotMatch", MinimumLength = 5)]
        [Display(Name = "Username")]
        public string Username { get; set; }
    }
}

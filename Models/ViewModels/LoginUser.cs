using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeltExam.Models
{
  public class LoginUser
  {
    [Required]
    [DataType(DataType.EmailAddress)]
    [Display(Name = "Email")]
    public string LoginEmail {get; set;}

    [Required]
    [NotMapped]
    // [MinLength(8)]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string LoginPassword {get; set;}
  }
}


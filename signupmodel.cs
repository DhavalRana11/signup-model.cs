using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuickShoap.Models
{
    public class signupmodel
    {


        [Required(ErrorMessage ="Enter your firstname")]
        public string firstname { get; set; }

        [Required(ErrorMessage ="Enter your lastname")]
        public string lastname { get; set; }

        

        [Required(ErrorMessage = "selected categary")]
        public string gender { get; set; }


        [Required(ErrorMessage = "Enter your Email ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter password")]
        public string password { get; set; }

        [Required(ErrorMessage = "Enter cpassword")]
        [System.ComponentModel.DataAnnotations.Compare("password", ErrorMessage = "your entered the confirm password not match passowrd")]
        public string cpassword { get; set; }

        [Required(ErrorMessage = "Enter your Residency")]
        public  string Residency { get; set; }

        [Required(ErrorMessage = "Enter city")]
        public string City { get; set; }
    



    }
}
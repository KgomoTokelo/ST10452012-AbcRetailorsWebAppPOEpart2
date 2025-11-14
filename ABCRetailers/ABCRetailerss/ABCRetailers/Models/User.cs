using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ABCRetailers.Models
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [StringLength(100, ErrorMessage = "Username cannot exceed 100 characters")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password hash is required")]
        [StringLength(255, ErrorMessage = "Password hash cannot exceed 255 characters")]
        public string PasswordHash { get; set; }

        [Required(ErrorMessage = "Role is required")]
        [StringLength(20, ErrorMessage = "Role cannot exceed 20 characters")]
        [Display(Name = "User Role")]
        public string Role { get; set; }
    }
}
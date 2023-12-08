using System;
using System.ComponentModel.DataAnnotations;
using fruitkha_task.Entities;

namespace fruitkha_task.Models
{
	public class ContactViewModel
	{
		public string? Name { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }

        [Required]
        public string? Subject { get; set; }

        [Required]
        public string? Message { get; set; }
    }
}


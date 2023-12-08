using System;
using System.ComponentModel.DataAnnotations;

namespace fruitkha_task.Entities
{
	public class Contact
	{
		public int Id { get; set; }
		[Required]
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


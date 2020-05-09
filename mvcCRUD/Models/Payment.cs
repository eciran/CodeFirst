using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcCRUD.Models
{
	public class Payment
	{
		[Key]
		[Required]
		public int PaymentID { get; set; }
	    [MaxLength(20, ErrorMessage = "PaymentName max. 20 karakter olabilir"), MinLength(3, ErrorMessage = "PaymentName min. 3 karakter olabilir")]
		public string PaymentName { get; set; }

		public virtual ICollection<Invoice> Invoices { get; set; }
	}
}
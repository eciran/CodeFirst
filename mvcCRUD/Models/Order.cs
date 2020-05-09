using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mvcCRUD.Models
{
	public class Order
	{

		[Key]
		[Column("ID")]
		[Required]
		public int OrderID { get; set; }
		[Required]
		public int MemberID { get; set; }    //  FK
		[Required]
		[Column("SiparisTarihi")]
		public DateTime? OrderDate { get; set; }
		public bool? IsPay { get; set; }
		[Column("ToplamOdeme")]
		public decimal? TotalPrice { get; set; }

		public virtual Member Member { get; set; }
		public virtual ICollection<Invoice> Invoice { get; set; }
		public virtual ICollection<OrderDetail> OrderDetail { get; set; }
	}
}
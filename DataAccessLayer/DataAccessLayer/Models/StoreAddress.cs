using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class StoreAddress
    {
        [Key]
        public int Id { get; set; }
        public int StoreId { get; set; }
        //[ForeignKey("StoreId")]
        //public Store? Store { get; set; }
        public string Street { get; set; }
        public string WardId { get; set; }
        //[ForeignKey("WardId")]
        //public Ward? Ward {  get; set; }
    }
}

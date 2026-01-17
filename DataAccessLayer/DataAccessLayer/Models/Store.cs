using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Store
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        //public double MaxPrice { get; set; }
        public string Image {  get; set; }
        public TimeSpan OpenTime { get; set; }
        public TimeSpan CloseTime { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId {  get; set; }
        //public ICollection<StoreAddress>? StoreAddresses { get; set; }
    }
}

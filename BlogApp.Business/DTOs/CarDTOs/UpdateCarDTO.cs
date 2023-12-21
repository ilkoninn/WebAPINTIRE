using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.DTOs.CarDTOs
{
    public class UpdateCarDTO
    {
        public int Id { get; set; }
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
    }
}

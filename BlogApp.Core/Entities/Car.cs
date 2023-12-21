using BlogApp.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Core.Entities
{
    public class Car : BaseEntity
    {
        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
        public int BrandId { get; set; }
        public Brand? Brand { get; set; }
    }
}

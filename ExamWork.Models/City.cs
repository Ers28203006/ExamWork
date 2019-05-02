using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamWork.Models
{
   public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? CantryId { get; set; }
        public virtual Cantry Cantry { get; set; }

        public virtual ICollection<Street> Streets { get; set; }
        public City()
        {
            Streets = new List<Street>();
        }
    }
}

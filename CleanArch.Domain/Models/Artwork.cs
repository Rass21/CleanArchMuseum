using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Models
{
    public class Artwork
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public DateTime Year { get; set; }
    }
}

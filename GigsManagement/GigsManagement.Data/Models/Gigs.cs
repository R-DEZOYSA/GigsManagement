using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GigsManagement.Data.Models
{
    public class Gigs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GigsGenreType Genre { get; set; }
    }
}

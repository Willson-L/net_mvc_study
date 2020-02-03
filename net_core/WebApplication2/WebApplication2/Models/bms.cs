using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class bms
    {
        private bms_connect connect;
        public int Id { get; set; }

        public string Name { get; set; }

        public string ArtistName { get; set; }

        public int Price { get; set; }

        public string Genre { get; set; }
    }
}

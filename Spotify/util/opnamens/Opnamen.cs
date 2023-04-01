using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.util.opnamens {
    internal class Opnamen {

        public string name {
            get; set; 
        }

        public List<string> maker;

        public int id {
            get; set; 
        }

        public string url {
            get; set; 
        }

        public Opnamen() {
            maker = new();
        }
    }
}

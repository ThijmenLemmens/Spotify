using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.util.opnamens {
    public class Opnamen {

        public string name {
            get; set; 
        }

        public List<string> creator;

        public int id {
            get; set; 
        }

        /// <summary>
        /// url for the htpp request
        /// </summary>
        public string url {
            get; set; 
        }

        public Opnamen() {
            creator = new();
        }

        /// <summary>
        /// overrides the normal Equals method for better control
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override Boolean Equals(Object? obj) {
            return obj is Opnamen opnamen &&
                   id == opnamen.id;
        }
    }
}

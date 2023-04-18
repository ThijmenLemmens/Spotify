using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.util.opnamens {
    public class Opnamen : IEquatable<Opnamen> {

        public string name {
            get; set; 
        }

        public List<string> creator;

        public int id {
            get; set; 
        }

        public string url {
            get; set; 
        }

        public Opnamen() {
            creator = new();
        }

        public override Boolean Equals(Object? obj) {
            return obj is Opnamen opnamen &&
                   id == opnamen.id;
        }

        public Boolean Equals(Opnamen? opnamen) {
            return id == opnamen.id;
        }
    }
}

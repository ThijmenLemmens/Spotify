using Spotify.util.opnamens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.util.afspeellijsten {
    public class Lijst {

        public List<Opnamen> items;

        public List<Account> owners;

        public string rawJson {
            get; set;
        }

        public string Name {
            get; set; 
        }

        public Int32 id {
            get; set;
        }

        public Lijst() {
            items = new();
            owners = new();
        }
    }
}

using Spotify.util.opnamens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.util.afspeellijsten {
    internal class Lijst {

        public List<Opnamen> items;

        public string Name {
            get; set; 
        }

        public Lijst() {
            items = new();
        }
    }
}

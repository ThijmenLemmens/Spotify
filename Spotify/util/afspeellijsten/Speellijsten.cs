using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spotify.util.opnamens;

namespace Spotify.util.afspeellijsten {

    internal class Speellijsten : Lijst {

        private static Random random = new();

        public void shuffle() {
            int count = items.Count;
            while (count > 1) {
                count--;
                int nummer = random.Next(count + 1);
                Opnamen value = items[nummer];
                items[nummer] = items[count];
                items[count] = value;
            }
        }
    }
}

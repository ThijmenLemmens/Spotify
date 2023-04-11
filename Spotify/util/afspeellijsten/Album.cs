using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.util.afspeellijsten {

    public class Album : Lijst {

        public List<string> artiestNames;

        public Album() {
            artiestNames = new();
        }
    }
}

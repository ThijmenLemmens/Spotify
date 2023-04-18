using Spotify.util.afspeellijsten;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify {
    
    public class Account {

        public int id {
            get; set; 
        }

        public string name {
            get; set;
        }

        public string password {
            get; set; 
        }

        public List<Int32> ?friendIds;

        public List<Account>? friends;

        public List<Playlist> playlists;

        public Account() {
            friendIds = new();
            playlists = new();
            friends = new();
        }
    }
}

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

        public List<int> ?friendIds;

        public Account() {
            friendIds = new();
        }
    }
}

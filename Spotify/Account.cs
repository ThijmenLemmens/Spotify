using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify {
    
    internal class Account {

        public string name {
            get; set;
        }

        public List<Account> friends;

        public Account() {
            friends = new();
        }
    }
}

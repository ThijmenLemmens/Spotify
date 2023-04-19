using Spotify.util.afspeellijsten;
using Spotify.util.opnamens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify {
    public class Util {

        /// <summary>
        /// returns a string that has te owners names of the opnamen.
        /// </summary>
        /// <param name="opnamen"></param>
        /// <returns></returns>
        public static string setOwners(Opnamen opnamen) {
            StringBuilder builder = new();

            for (Int32 i = 0; i < opnamen.creator.Count; i++) {
                if (i == 0) {
                    builder.Append(opnamen.creator[i]);
                    continue;
                }

                builder.Append($", {opnamen.creator[i]}");
            }

            return builder.ToString();
        }

        /// <summary>
        /// returns a string that has te owners names of the playlist.
        /// </summary>
        /// <param name="playlist"></param>
        /// <returns></returns>
        public static string setOwners(Playlist playlist) {
            StringBuilder builder = new();

            for (Int32 i = 0; i < playlist.owners.Count; i++) {
                if (i == 0) {
                    builder.Append(playlist.owners[i].name);
                    continue;
                }

                builder.Append($", {playlist.owners[i].name}");
            }

            return builder.ToString();
        }

        /// <summary>
        /// Compares 2 lists and returns the object that are the same.
        /// </summary>
        /// <param name="playlist"></param>
        /// <param name="playlist1"></param>
        /// <returns></returns>
        public static List<Opnamen> comparePlaylist(Playlist playlist, Playlist playlist1) {

            List<Opnamen> opnamens = new();

            playlist.items.ForEach(item1 => {
                if (playlist1.items.Contains(item1))
                    opnamens.Add(item1);
            });

            return opnamens;
        }

        public static void changePlaylistName() {
            
        }
    }
}

using NAudio.Wave;
using Spotify.util.opnamens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Spotify {
    internal class MediaPlayer {

        private static readonly HttpClient client = new HttpClient();

        public static WaveOut waveOut;

        public static MemoryStream memoryStream;

        private static bool playing = false;

        public static int currentTotalSeconds = 0;

        public static void play(Opnamen opnamen) {
            if (playing) {
                waveOut.Stop();
                waveOut.Dispose();
                playing = false;
            }

            // gets the stream for a http request
            byte[] stream = client.GetByteArrayAsync(opnamen.url).Result;

            memoryStream = new(stream);

            // makes it possible to play form a stream
            using WaveStream blockAlignedStream =
                new BlockAlignReductionStream(
                    WaveFormatConversionStream.CreatePcmStream(
                        new Mp3FileReader(memoryStream)));

            waveOut = new(WaveCallbackInfo.FunctionCallback());

            waveOut.Init(blockAlignedStream);

            do {
                playing = true;

                waveOut.Play();

                while (waveOut.PlaybackState == PlaybackState.Playing || waveOut.PlaybackState == PlaybackState.Paused) {
                    System.Threading.Thread.Sleep(100);
                }

                memoryStream.Position = 0;
            } while (Form1.repeat);

            // dispose resources 
            waveOut.Dispose();
            memoryStream.Dispose();

            playing = false;
        }

        /// <summary>
        /// resumes the song
        /// </summary>
        public static void resume() {
            if (playing)
                waveOut.Play();
        }

        /// <summary>
        /// pauses the song
        /// </summary>
        public static void pause() {
            if (playing)
                waveOut.Pause();
        }
    }
}

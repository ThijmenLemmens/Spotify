using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Spotify {
    internal class MediaPlayer {

        private static readonly HttpClient client = new HttpClient();

        private static WaveOut waveOut;

        private static bool playing = false;

        public static void play(string url) {
            if (playing)
                return;

            byte[] stream = client.GetByteArrayAsync(url).Result;

            MemoryStream memoryStream = new(stream);

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

            waveOut.Dispose();
            memoryStream.Dispose();

            playing = false;
        }

        public static void resume() {
            if (playing)
                waveOut.Play();
        }

        public static void pause() {
            if (playing)
                waveOut.Pause();
        }

        public static void repeat() {
        
        }
    }
}

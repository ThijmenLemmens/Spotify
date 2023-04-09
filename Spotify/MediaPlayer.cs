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

        private static MemoryStream currentStream;

        private static WaveOut waveOut;

        private static bool playing = false;

        private async void button3_Click(Object sender, EventArgs e) {
            string url = "https://download.samplelib.com/mp3/sample-15s.mp3";

            using MemoryStream memoryStream = new();
            Stream stream = client.GetStreamAsync(url).Result;
            //byte[] buffer = new byte[32768];
            //int read;
            //while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
            //    memoryStream.Write(buffer, 0, read);

            //stream.CopyTo(memoryStream);

            //memoryStream.Seek(0, SeekOrigin.Begin);

            stream.Seek(0, SeekOrigin.Begin);

            using WaveStream blockAlignedStream =
                new BlockAlignReductionStream(
                    WaveFormatConversionStream.CreatePcmStream(
                        new Mp3FileReader(stream)));

            waveOut.Init(blockAlignedStream);
            waveOut.Play();

            while (waveOut.PlaybackState == PlaybackState.Playing) {
                System.Threading.Thread.Sleep(100);
            }

            memoryStream.Close();
        }

        public static void play(string url) {
            if (playing)
                return;

            using MemoryStream memoryStream = new();

            byte[] stream = client.GetByteArrayAsync(url).Result;

            //byte[] buffer = new byte[32768];

            //stream.CopyTo(memoryStream);

            //memoryStream.Seek(0, SeekOrigin.Begin);

            //currentStream = memoryStream;

            using WaveStream blockAlignedStream =
                new BlockAlignReductionStream(
                    WaveFormatConversionStream.CreatePcmStream(
                        new Mp3FileReader(new MemoryStream(stream))));

            waveOut = new(WaveCallbackInfo.FunctionCallback());

            waveOut.Init(blockAlignedStream);
            waveOut.Play();

            playing = true;

            while (waveOut.PlaybackState == PlaybackState.Playing || waveOut.PlaybackState == PlaybackState.Paused) {
                System.Threading.Thread.Sleep(100);
            }

            waveOut.Dispose();
            memoryStream.Close();

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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace NAudio.Wave
{
    /// <summary>
    /// Event Args for WaveInStream event
    /// </summary>
    public class WaveInEventArgs : EventArgs
    {
        private byte[] buffer;
        private int bytes;
        private Stopwatch watchSinceCapture;

        /// <summary>
        /// Creates new WaveInEventArgs
        /// </summary>
        public WaveInEventArgs(byte[] buffer, int bytes, Stopwatch watchSinceCapture = null)
        {
            this.buffer = buffer;
            this.bytes = bytes;
            this.watchSinceCapture = watchSinceCapture;
        }

        /// <summary>
        /// Buffer containing recorded data. Note that it might not be completely
        /// full. <seealso cref="BytesRecorded"/>
        /// </summary>
        public byte[] Buffer
        {
            get { return buffer; }
        }

        /// <summary>
        /// The number of recorded bytes in Buffer. <seealso cref="Buffer"/>
        /// </summary>
        public int BytesRecorded
        {
            get { return bytes; }
        }

        /// <summary>
        /// Watch started when the time was really captured from hardware.
        /// </summary>
        public Stopwatch WatchSinceCapture
        {
            get { return watchSinceCapture; }
        }
    }
}

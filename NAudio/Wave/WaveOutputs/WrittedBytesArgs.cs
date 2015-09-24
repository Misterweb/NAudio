using System;

namespace NAudio.Wave
{
    /// <summary>
    /// EventArgs for WrittedBytes event in WaveOutBuffer and WaveOut
    /// </summary>
    public class WrittedBytesArgs : EventArgs
    {
        /// <summary>
        /// 
        /// </summary>
        public byte[] Bytes { get; set; }

        /// <summary>
        /// Number of bytes writted
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Constructor of WrittedBytesArgs
        /// </summary>
        /// <param name="bytes">array of bytes effectively writted</param>
        /// <param name="count">number of bytes writted</param>
        public WrittedBytesArgs(byte[] bytes, int count) {
            Bytes = bytes;
            Count = count;
        }
    }
}
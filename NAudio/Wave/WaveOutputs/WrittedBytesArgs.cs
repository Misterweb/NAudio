using System;
using System.Diagnostics;

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
        /// StopWatch started when call to hardware where done
        /// </summary>
        public Stopwatch CallHardwareWatch { get; set; }

        /// <summary>
        /// Constructor of WrittedBytesArgs
        /// </summary>
        /// <param name="bytes">array of bytes effectively writted</param>
        /// <param name="count">number of bytes writted</param>
        public WrittedBytesArgs(byte[] bytes, int count) {
            Bytes = bytes;
            Count = count;
            CallHardwareWatch = null;
        }

        /// <summary>
        /// Constructor of WrittedBytesArgs
        /// </summary>
        /// <param name="bytes">array of bytes effectively writted</param>
        /// <param name="count">number of bytes writted</param>
        /// /// <param name="watch">Watch started when hardware were called</param>
        public WrittedBytesArgs(byte[] bytes, int count, Stopwatch watch)
        {
            Bytes = bytes;
            Count = count;
            CallHardwareWatch = watch;
        }
    }
}
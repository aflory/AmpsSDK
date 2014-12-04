﻿namespace AmpsBoxSdk.Events
{
    using System;

    public class SerialDataReceived : EventArgs
    {
        public SerialDataReceived(byte[] receivedBytes)
        {
            this.ReceivedBytes = receivedBytes;
        }

        public byte[] ReceivedBytes { get; private set; }
    }
}
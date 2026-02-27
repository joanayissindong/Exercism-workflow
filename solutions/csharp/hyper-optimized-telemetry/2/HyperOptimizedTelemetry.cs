using System;
using System.Linq;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] buffer = new byte[9];
        int payloadSize;

        if (reading >= short.MinValue && reading <= short.MaxValue)
        {
            buffer[0] = 2 + 256;
            BitConverter.GetBytes((short)reading).CopyTo(buffer, 1);
            payloadSize = 2;
        }

        else if (reading >= int.MinValue && reading <= int.MaxValue)
        {
            buffer[0] = 4 + 256;
            BitConverter.GetBytes((int)reading).CopyTo(buffer, 1);
            payloadSize = 4;
        }

        else // long
        {
            buffer[0] = 8 + 256;
            BitConverter.GetBytes(reading).CopyTo(buffer, 1);
            payloadSize = 8;
        }

            return buffer.Take(payloadSize + 1).ToArray();
        }

    public static long FromBuffer(byte[] buffer)
    {
        
    }
}

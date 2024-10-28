using System;
using System.IO;

namespace MonoGame.Utilities
{
    internal static class StreamExtensions
    {
        public static void CopyTo(this Stream input, Stream output)
        {
            // This method exists only in .NET 4 and higher

            byte[] buffer = new byte[4 * 1024];
            int bytesRead;

            while ((bytesRead = input.Read(buffer, 0, buffer.Length)) != 0)
            {
                output.Write(buffer, 0, bytesRead);
            }
        }
    }
}
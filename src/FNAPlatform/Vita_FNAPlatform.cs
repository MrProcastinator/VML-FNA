#region License
/* FNA - XNA4 Reimplementation for Desktop Platforms
 * Copyright 2009-2024 Ethan Lee and the MonoGame Team
 *
 * Released under the Microsoft Public License.
 * See LICENSE for details.
 */
#endregion

#region Using Statements
using System;
using System.IO;
using System.Collections.Generic;
using SDL2;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
#endregion

namespace Microsoft.Xna.Framework
{
	internal static class Vita_FNAPlatform
	{
        internal static class TextFile
        {
            private const string LOG_FILE = "ux0:/data/FNA_log.txt";

            private static string Message(string level, string message)
            {
                return string.Format("[{0}] {1}\n", level, message);
            }

            public static void LogWarn(string msg)
            {
                File.AppendAllText(LOG_FILE, Message("W", msg));
            }

            public static void LogError(string msg)
            {
                File.AppendAllText(LOG_FILE, Message("E", msg));
            }

            public static void LogInfo(string msg)
            {
                File.AppendAllText(LOG_FILE, Message("I", msg));
            }
        }
    }
}
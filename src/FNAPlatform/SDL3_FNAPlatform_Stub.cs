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
using System.Text;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
#endregion

/* Stuv class for SDL3_FNAPlatform, as SDL3 is not supported in PSVita (for now) */
namespace Microsoft.Xna.Framework
{
    internal static unsafe class SDL3_FNAPlatform
    {
        public static string ProgramInit(LaunchParameters args)
        {
            throw new NotImplementedException();
        }

        public static void ProgramExit(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public static IntPtr Malloc(int size)
        {
            throw new NotImplementedException();
        }

        public static void SetEnv(string name, string value)
        {
            throw new NotImplementedException();
        }

        public static GameWindow CreateWindow()
        {
            throw new NotImplementedException();
        }

        public static void DisposeWindow(GameWindow window)
        {
            throw new NotImplementedException();
        }

        public static void ApplyWindowChanges(
			IntPtr window,
			int clientWidth,
			int clientHeight,
			bool wantsFullscreen,
			string screenDeviceName,
			ref string resultDeviceName
		) {
            throw new NotImplementedException();
        }

        public static void ScaleForWindow(IntPtr window, bool invert, ref int w, ref int h)
        {
            throw new NotImplementedException();
        }

        public static Rectangle GetWindowBounds(IntPtr window)
		{
            throw new NotImplementedException();
        }

        public static bool GetWindowResizable(IntPtr window)
        {
            throw new NotImplementedException();
        }

        public static void SetWindowResizable(IntPtr window, bool resizable)
        {
            throw new NotImplementedException();
        }

        public static bool GetWindowBorderless(IntPtr window)
        {
            throw new NotImplementedException();
        }

        public static void SetWindowBorderless(IntPtr window, bool borderless)
        {
            throw new NotImplementedException();
        }

        public static void SetWindowTitle(IntPtr window, string title)
        {
            throw new NotImplementedException();
        }

        public static bool IsScreenKeyboardShown(IntPtr window)
        {
            throw new NotImplementedException();
        }

        public static void SetTextInputRectangle(IntPtr window, Rectangle rectangle)
        {
            throw new NotImplementedException();
        }

        public static bool SupportsOrientationChanges()
        {
            throw new NotImplementedException();
        }

        public static GraphicsAdapter RegisterGame(Game game)
        {
            throw new NotImplementedException();
        }

        public static void UnregisterGame(Game game)
        {
            throw new NotImplementedException();
        }

        public static unsafe void PollEvents(
			Game game,
			ref GraphicsAdapter currentAdapter,
			bool[] textInputControlDown,
			ref bool textInputSuppress
		)
        {
            throw new NotImplementedException();
        }

        public static bool NeedsPlatformMainLoop()
        {
            throw new NotImplementedException();
        }

        public static void RunPlatformMainLoop(Game game)
        {
            throw new NotImplementedException();
        }

        public static GraphicsAdapter[] GetGraphicsAdapters()
        {
            throw new NotImplementedException();
        }

        public static DisplayMode GetCurrentDisplayMode(int adapterIndex)
        {
            throw new NotImplementedException();
        }

        public static void GetMouseState(
			IntPtr window,
			out int x,
			out int y,
			out ButtonState left,
			out ButtonState middle,
			out ButtonState right,
			out ButtonState x1,
			out ButtonState x2
		)
        {
            throw new NotImplementedException();
        }

        public static void WarpMouseInWindow(IntPtr window, int x, int y)
        {
            throw new NotImplementedException();
        }

        public static void OnIsMouseVisibleChanged(bool visible)
        {
            throw new NotImplementedException();
        }

        public static bool GetRelativeMouseMode(IntPtr window)
        {
            throw new NotImplementedException();
        }

        public static void SetRelativeMouseMode(IntPtr window, bool enable)
        {
            throw new NotImplementedException();
        }

        public static Keys GetKeyFromScancode(Keys scancode)
        {
            throw new NotImplementedException();
        }

        public static string GetStorageRoot()
        {
            throw new NotImplementedException();
        }

        public static DriveInfo GetDriveInfo(string storageRoot)
        {
            throw new NotImplementedException();
        }

        public static IntPtr ReadToPointer(string path, out IntPtr size)
        {
            throw new NotImplementedException();
        }

        public static void FreeFilePointer(IntPtr file)
        {
            throw new NotImplementedException();
        }

        public static void ShowRuntimeError(string title, string message)
        {
            throw new NotImplementedException();
        }

        public static Microphone[] GetMicrophones()
        {
            throw new NotImplementedException();
        }

        public static unsafe int GetMicrophoneSamples(
			uint handle,
			byte[] buffer,
			int offset,
			int count
		)
        {
            throw new NotImplementedException();
        }

        public static int GetMicrophoneQueuedBytes(uint handle)
        {
            throw new NotImplementedException();
        }

        public static void StartMicrophone(uint handle)
        {
            throw new NotImplementedException();
        }

        public static void StopMicrophone(uint handle)
        {
            throw new NotImplementedException();
        }

        public static GamePadCapabilities GetGamePadCapabilities(int index)
        {
            throw new NotImplementedException();
        }

        public static GamePadState GetGamePadState(int index, GamePadDeadZone deadZoneMode)
        {
            throw new NotImplementedException();
        }

        public static bool SetGamePadVibration(int index, float leftMotor, float rightMotor)
        {
            throw new NotImplementedException();
        }

        public static bool SetGamePadTriggerVibration(int index, float leftTrigger, float rightTrigger)
        {
            throw new NotImplementedException();
        }

        public static string GetGamePadGUID(int index)
        {
            throw new NotImplementedException();
        }

        public static void SetGamePadLightBar(int index, Color color)
        {
            throw new NotImplementedException();
        }

        public static bool GetGamePadGyro(int index, out Vector3 gyro)
        {
            throw new NotImplementedException();
        }

        public static bool GetGamePadAccelerometer(int index, out Vector3 accel)
        {
            throw new NotImplementedException();
        }

        public static TouchPanelCapabilities GetTouchCapabilities()
        {
            throw new NotImplementedException();
        }

        public static unsafe void UpdateTouchPanelState()
        {
            throw new NotImplementedException();
        }

        public static int GetNumTouchFingers()
        {
            throw new NotImplementedException();
        }

        public static bool IsTextInputActive(IntPtr window)
        {
            throw new NotImplementedException();
        }

        public static void StartTextInput(IntPtr window)
        {
            throw new NotImplementedException();
        }

        public static void StopTextInput(IntPtr window)
        {
            throw new NotImplementedException();
        }
    }
}

namespace SDL3
{
    internal static class SDL
    {
        public static void SDL_free(IntPtr ptr)
        {
            throw new NotImplementedException();
        }
    }
}
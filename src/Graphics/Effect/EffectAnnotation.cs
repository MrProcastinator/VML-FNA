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
#endregion

namespace Microsoft.Xna.Framework.Graphics
{
	public sealed class EffectAnnotation
	{
		#region Public Properties

		public string Name
		{
			get;
			private set;
		}

		public string Semantic
		{
			get;
			private set;
		}

		public int RowCount
		{
			get;
			private set;
		}

		public int ColumnCount
		{
			get;
			private set;
		}

		public EffectParameterClass ParameterClass
		{
			get;
			private set;
		}

		public EffectParameterType ParameterType
		{
			get;
			private set;
		}

		#endregion

		#region Internal Variables

		internal string cachedString = string.Empty;

		#endregion

		#region Private Variables

		IntPtr values;

		#endregion

		#region Internal Constructor

		internal EffectAnnotation(
			string name,
			string semantic,
			int rowCount,
			int columnCount,
			EffectParameterClass parameterClass,
			EffectParameterType parameterType,
			IntPtr data
		) {
			Name = name;
			Semantic = semantic ?? string.Empty;
			RowCount = rowCount;
			ColumnCount = columnCount;
			ParameterClass = parameterClass;
			ParameterType = parameterType;
			values = data;
		}

		#endregion

		#region Public Methods

		public bool GetValueBoolean()
		{
			unsafe
			{
				// Values are always 4 bytes, so we get to do this. -flibit
				int* resPtr = (int*) values;
				return *resPtr != 0;
			}
		}

		public int GetValueInt32()
		{
			unsafe
			{
				int* resPtr = (int*) values;
				return *resPtr;
			}
		}

		public Matrix GetValueMatrix()
		{
			unsafe
			{
				float* resPtr = (float*) values;
				return new Matrix()
				{
					M11 = resPtr[0],
					M12 = resPtr[4],
					M13 = resPtr[8],
					M14 = resPtr[12],
					M21 = resPtr[1],
					M22 = resPtr[5],
					M23 = resPtr[9],
					M24 = resPtr[13],
					M31 = resPtr[2],
					M32 = resPtr[6],
					M33 = resPtr[10],
					M34 = resPtr[14],
					M41 = resPtr[3],
					M42 = resPtr[7],
					M43 = resPtr[11],
					M44 = resPtr[15]
				};
			}
		}

		public float GetValueSingle()
		{
			unsafe
			{
				float* resPtr = (float*) values;
				return *resPtr;
			}
		}

		public string GetValueString()
		{
			return cachedString;
		}

		public Vector2 GetValueVector2()
		{
			unsafe
			{
				float* resPtr = (float*) values;
				return new Vector2(resPtr[0], resPtr[1]);
			}
		}

		public Vector3 GetValueVector3()
		{
			unsafe
			{
				float* resPtr = (float*) values;
				return new Vector3(resPtr[0], resPtr[1], resPtr[2]);
			}
		}

		public Vector4 GetValueVector4()
		{
			unsafe
			{
				float* resPtr = (float*) values;
				return new Vector4(
					resPtr[0],
					resPtr[1],
					resPtr[2],
					resPtr[3]
				);
			}
		}

		#endregion
	}
}

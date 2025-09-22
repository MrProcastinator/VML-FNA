#region License
/* FNA - XNA4 Reimplementation for Desktop Platforms
 * Copyright 2009-2024 Ethan Lee and the MonoGame Team
 *
 * Released under the Microsoft Public License.
 * See LICENSE for details.
 */
#endregion

namespace Microsoft.Xna.Framework.Content
{
	class MatrixReader : ContentTypeReader<Matrix>
	{
		#region Protected Read Method

		protected internal override Matrix Read(
			ContentReader input,
			Matrix existingInstance
		) {
			// 4x4 matrix
			return new Matrix()
			{
				M11 = input.ReadSingle(),
				M12 = input.ReadSingle(),
				M13 = input.ReadSingle(),
				M14 = input.ReadSingle(),
				M21 = input.ReadSingle(),
				M22 = input.ReadSingle(),
				M23 = input.ReadSingle(),
				M24 = input.ReadSingle(),
				M31 = input.ReadSingle(),
				M32 = input.ReadSingle(),
				M33 = input.ReadSingle(),
				M34 = input.ReadSingle(),
				M41 = input.ReadSingle(),
				M42 = input.ReadSingle(),
				M43 = input.ReadSingle(),
				M44 = input.ReadSingle(),
			};
		}

		#endregion
	}
}

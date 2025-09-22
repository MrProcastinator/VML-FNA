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
using System.Collections;
using System.ComponentModel;
using System.Globalization;
#endregion

namespace Microsoft.Xna.Framework.Design
{
	public class MatrixConverter : MathTypeConverter
	{
		#region Public Constructor

		public MatrixConverter() : base()
		{
			// FIXME: Initialize propertyDescriptions... how? -flibit
			supportStringConvert = false;
		}

		#endregion

		#region Public Methods

		public override object ConvertTo(
			ITypeDescriptorContext context,
			CultureInfo culture,
			object value,
			Type destinationType
		) {
			// FIXME: This method exists in the spec, but... why?! -flibit
			return base.ConvertTo(context, culture, value, destinationType);
		}

		public override object CreateInstance(
			ITypeDescriptorContext context,
			IDictionary propertyValues
		) {
			return (object) new Matrix()
			{
				M11 = (float) propertyValues["M11"],
				M12 = (float) propertyValues["M12"],
				M13 = (float) propertyValues["M13"],
				M14 = (float) propertyValues["M14"],
				M21 = (float) propertyValues["M21"],
				M22 = (float) propertyValues["M22"],
				M23 = (float) propertyValues["M23"],
				M24 = (float) propertyValues["M24"],
				M31 = (float) propertyValues["M31"],
				M32 = (float) propertyValues["M32"],
				M33 = (float) propertyValues["M33"],
				M34 = (float) propertyValues["M34"],
				M41 = (float) propertyValues["M41"],
				M42 = (float) propertyValues["M42"],
				M43 = (float) propertyValues["M43"],
				M44 = (float) propertyValues["M44"]
			};
		}

		#endregion
	}
}

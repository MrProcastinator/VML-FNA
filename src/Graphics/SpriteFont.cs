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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Text;
#endregion

namespace Microsoft.Xna.Framework.Graphics
{
	#region Request Structs
	/* These structs were made as a workaround to a bug found on Mono
	 * 32-bit AOT compiler for PSVita, where passing more than 5
	 * parameters in a function causes stack corruption for the sixth
	 * parameter. This struct is exactly the same as the arguments
	 * needed to pass for a call to the following methods:
	 *     - SpriteFont Constructor
	 * -MrProcastinator
	 */
	[StructLayout(LayoutKind.Sequential)]
	internal struct SpriteFontProperties
	{
		internal List<Rectangle> GlyphBounds;
		internal List<Rectangle> Cropping;
		internal List<char> Characters;
		internal int LineSpacing;
		internal float Spacing;
		internal List<Vector3> Kerning;
		internal char? DefaultCharacter;
	}

	#endregion

	// http://msdn.microsoft.com/en-us/library/microsoft.xna.framework.graphics.spritefont.aspx
	public sealed class SpriteFont
	{
		#region Public Properties

		public ReadOnlyCollection<char> Characters
		{
			get;
			private set;
		}

		public char? DefaultCharacter
		{
			get;
			set;
		}

		public int LineSpacing
		{
			get
			{
				return lineSpacing;
			}
			set
			{
				lineSpacing = value;
			}
		}

		public float Spacing
		{
			get
			{
				return spacing;
			}
			set
			{
				spacing = value;
			}
		}

		#endregion

		#region Internal Variables

		/* I've had a bunch of games use reflection on SpriteFont to get
		 * this data. Keep these names as they are for XNA4 accuracy!
		 * -flibit
		 */
		internal Texture2D textureValue;
		internal List<Rectangle> glyphData;
		internal List<Rectangle> croppingData;
		internal List<Vector3> kerning;
		internal List<char> characterMap;

		/* If, by chance, you're seeing this and thinking about using
		 * reflection to access the fields:
		 * Don't.
		 * To date, one (1) game is using the fields directly,
		 * even though the properties are publicly accessible.
		 * Not even FNA uses the fields directly.
		 * -ade
		 */
		internal int lineSpacing;
		internal float spacing;

		/* This is not a part of the spec as far as we know, but we
		 * added this because it's WAY faster than going to characterMap
		 * and calling IndexOf on each character.
		 */
		internal Dictionary<char, int> characterIndexMap;

		#endregion

		#region Internal Constructor

		[Obsolete("This constructor corrupts the value of spacing when called, it should not be used, use the one with SpriteFontProperties.", true)]
		internal SpriteFont(
			Texture2D texture,
			List<Rectangle> glyphBounds,
			List<Rectangle> cropping,
			List<char> characters,
			int lineSpacing,
			float spacing,
			List<Vector3> kerningData,
			char? defaultCharacter
		)
		{
			throw new NotSupportedException("This constructor corrupts the value of spacing when called, it should not be used, use the one with SpriteFontProperties.");
		}

		internal SpriteFont(
			Texture2D texture,
			SpriteFontProperties properties
		)
		{
			Characters = new ReadOnlyCollection<char>(properties.Characters.ToArray());
			DefaultCharacter = properties.DefaultCharacter;
			LineSpacing = properties.LineSpacing;
			Spacing = properties.Spacing;

			textureValue = texture;
			glyphData = properties.GlyphBounds;
			croppingData = properties.Cropping;
			kerning = properties.Kerning;
			characterMap = properties.Characters;

			characterIndexMap = new Dictionary<char, int>(properties.Characters.Count);
			for (int i = 0; i < properties.Characters.Count; i += 1)
			{
				characterIndexMap[properties.Characters[i]] = i;
			}
		}

		#endregion

		#region Public MeasureString Methods

		public Vector2 MeasureString(string text)
		{
			/* FIXME: This method is a duplicate of MeasureString(StringBuilder)!
			 * The only difference is how we iterate through the string.
			 * -flibit
			 */
			if (text == null)
			{
				throw new ArgumentNullException("text");
			}
			if (text.Length == 0)
			{
				return Vector2.Zero;
			}

			// FIXME: This needs an accuracy check! -flibit

			Vector2 result = Vector2.Zero;
			float curLineWidth = 0.0f;
			float finalLineHeight = LineSpacing;
			bool firstInLine = true;

			foreach (char c in text)
			{
				// Special characters
				if (c == '\r')
				{
					continue;
				}
				if (c == '\n')
				{
					result.X = Math.Max(result.X, curLineWidth);
					result.Y += LineSpacing;
					curLineWidth = 0.0f;
					finalLineHeight = LineSpacing;
					firstInLine = true;
					continue;
				}

				/* Get the List index from the character map, defaulting to the
				 * DefaultCharacter if it's set.
				 */
				int index;
				if (!characterIndexMap.TryGetValue(c, out index))
				{
					if (!DefaultCharacter.HasValue)
					{
						throw new ArgumentException(
							"Text contains characters that cannot be" +
							" resolved by this SpriteFont.",
							"text"
						);
					}
					index = characterIndexMap[DefaultCharacter.Value];
				}

				/* For the first character in a line, always push the width
				 * rightward, even if the kerning pushes the character to the
				 * left.
				 */
				Vector3 cKern = kerning[index];
				if (firstInLine)
				{
					curLineWidth += Math.Abs(cKern.X);
					firstInLine = false;
				}
				else
				{
					curLineWidth += Spacing + cKern.X;
				}

				/* Add the character width and right-side bearing to the line
				 * width.
				 */
				curLineWidth += cKern.Y + cKern.Z;

				/* If a character is taller than the default line height,
				 * increase the height to that of the line's tallest character.
				 */
				int cCropHeight = croppingData[index].Height;
				if (cCropHeight > finalLineHeight)
				{
					finalLineHeight = cCropHeight;
				}
			}

			// Calculate the final width/height of the text box
			result.X = Math.Max(result.X, curLineWidth);
			result.Y += finalLineHeight;

			return result;
		}

		public Vector2 MeasureString(StringBuilder text)
		{
			/* FIXME: This method is a duplicate of MeasureString(string)!
			 * The only difference is how we iterate through the StringBuilder.
			 * We don't use ToString() since it generates garbage.
			 * -flibit
			 */
			if (text == null)
			{
				throw new ArgumentNullException("text");
			}
			if (text.Length == 0)
			{
				return Vector2.Zero;
			}

			// FIXME: This needs an accuracy check! -flibit

			Vector2 result = Vector2.Zero;
			float curLineWidth = 0.0f;
			float finalLineHeight = LineSpacing;
			bool firstInLine = true;

			for (int i = 0; i < text.Length; i += 1)
			{
				char c = text[i];

				// Special characters
				if (c == '\r')
				{
					continue;
				}
				if (c == '\n')
				{
					result.X = Math.Max(result.X, curLineWidth);
					result.Y += LineSpacing;
					curLineWidth = 0.0f;
					finalLineHeight = LineSpacing;
					firstInLine = true;
					continue;
				}

				/* Get the List index from the character map, defaulting to the
				 * DefaultCharacter if it's set.
				 */
				int index;
				if (!characterIndexMap.TryGetValue(c, out index))
				{
					if (!DefaultCharacter.HasValue)
					{
						throw new ArgumentException(
							"Text contains characters that cannot be" +
							" resolved by this SpriteFont.",
							"text"
						);
					}
					index = characterIndexMap[DefaultCharacter.Value];
				}

				/* For the first character in a line, always push the width
				 * rightward, even if the kerning pushes the character to the
				 * left.
				 */
				Vector3 cKern = kerning[index];
				if (firstInLine)
				{
					curLineWidth += Math.Abs(cKern.X);
					firstInLine = false;
				}
				else
				{
					curLineWidth += Spacing + cKern.X;
				}

				/* Add the character width and right-side bearing to the line
				 * width.
				 */
				curLineWidth += cKern.Y + cKern.Z;

				/* If a character is taller than the default line height,
				 * increase the height to that of the line's tallest character.
				 */
				int cCropHeight = croppingData[index].Height;
				if (cCropHeight > finalLineHeight)
				{
					finalLineHeight = cCropHeight;
				}
			}

			// Calculate the final width/height of the text box
			result.X = Math.Max(result.X, curLineWidth);
			result.Y += finalLineHeight;

			return result;
		}

		#endregion
	}
}

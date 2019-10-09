using System;

namespace MathClasses
{
    public class Colour
    {
        /// <summary>
        /// Returns a Colour with the values for light gray
        /// </summary>
        public static Colour lightgray { get { return new Colour(200, 200, 200, 255); } }
        /// <summary>
        /// Returns a Colour with the values for gray
        /// </summary>
        public static Colour gray { get { return new Colour(130, 130, 130, 255); } }
        /// <summary>
        /// Returns a Colour with the values for drak gray
        /// </summary>
        public static Colour darkgray { get { return new Colour(80, 80, 80, 255); } }
        /// <summary>
        /// Returns a Colour with the values for yellow
        /// </summary>
        public static Colour yellow { get { return new Colour(253, 249, 0, 255); } }
        /// <summary>
        /// Returns a Colour with the values for gold
        /// </summary>
        public static Colour gold { get { return new Colour(255, 203, 0, 255); } }
        /// <summary>
        /// Returns a Colour with the values for orange
        /// </summary>
        public static Colour orange { get { return new Colour(255, 161, 0, 255); } }
        /// <summary>
        /// Returns a Colour with the values for pink
        /// </summary>
        public static Colour pink { get { return new Colour(255, 109, 194, 255); } }
        /// <summary>
        /// Returns a Colour with the values for red
        /// </summary>
        public static Colour red { get { return new Colour(230, 41, 55, 255); } }
        /// <summary>
        /// Returns a Colour with the values for maroon
        /// </summary>
        public static Colour maroon { get { return new Colour(190, 33, 55, 255); } }
        /// <summary>
        /// Returns a Colour with the values for green
        /// </summary>
        public static Colour green { get { return new Colour(0, 228, 48, 255); } }
        /// <summary>
        /// Returns a Colour with the values for lime
        /// </summary>
        public static Colour lime { get { return new Colour(0, 158, 47, 255); } }
        /// <summary>
        /// Returns a Colour with the values for dark green
        /// </summary>
        public static Colour darkgreen { get { return new Colour(0, 117, 44, 255); } }
        /// <summary>
        /// Returns a Colour with the values for sky blue
        /// </summary>
        public static Colour skyblue { get { return new Colour(102, 191, 255, 255); } }
        /// <summary>
        /// Returns a Colour with the values for blue
        /// </summary>
        public static Colour blue { get { return new Colour(0, 121, 241, 255); } }
        /// <summary>
        /// Returns a Colour with the values for dark blue
        /// </summary>
        public static Colour darkblue { get { return new Colour(0, 82, 172, 255); } }
        /// <summary>
        /// Returns a Colour with the values for purple
        /// </summary>
        public static Colour purple { get { return new Colour(200, 122, 255, 255); } }
        /// <summary>
        /// Returns a Colour with the values for violet
        /// </summary>
        public static Colour violet { get { return new Colour(135, 60, 190, 255); } }
        /// <summary>
        /// Returns a Colour with the values for dark purple
        /// </summary>
        public static Colour darkpurple { get { return new Colour(112, 31, 126, 255); } }
        /// <summary>
        /// Returns a Colour with the values for beige
        /// </summary>
        public static Colour beige { get { return new Colour(211, 176, 131, 255); } }
        /// <summary>
        /// Returns a Colour with the values for brown
        /// </summary>
        public static Colour brown { get { return new Colour(127, 106, 79, 255); } }
        /// <summary>
        /// Returns a Colour with the values for dark brown
        /// </summary>
        public static Colour darkbrown { get { return new Colour(76, 63, 47, 255); } }
        /// <summary>
        /// Returns a Colour with the values for white
        /// </summary>
        public static Colour white { get { return new Colour(255, 255, 255, 255); } }
        /// <summary>
        /// Returns a Colour with the values for black
        /// </summary>
        public static Colour black { get { return new Colour(0, 0, 0, 255); } }
        /// <summary>
        /// Returns a Colour with blank values
        /// </summary>
        public static Colour blank { get { return new Colour(0, 0, 0, 0); } }
        /// <summary>
        /// Returns a Colour with the values for magenta
        /// </summary>
        public static Colour magenta { get { return new Colour(255, 0, 255, 255); } }

        /// <summary>
        /// Variable that stores the colour values
        /// </summary>
        public uint colour;

        /// <summary>
        /// Default Constructor. Colour will be blank.
        /// </summary>
        public Colour()
        {
            colour = 0;
        }

        /// <summary>
        /// Creates a new Colour and Sets the colour values to the number provided. Format: AARRGGBB
        /// </summary>
        public Colour(uint c)
        {
            colour = c;
            
        }

        /// <summary>
        /// Creates a new Colour and Sets RGB values and sets A to 255
        /// </summary>
        public Colour(uint R, uint G, uint B)
        {
            colour = (uint)255 * (uint)Math.Pow(2, 24) + R * (uint)Math.Pow(2, 16) + G * (uint)Math.Pow(2, 8) + B;
        }

        /// <summary>
        /// Creates a new Colour and Sets RGBA values
        /// </summary>
        public Colour(uint R, uint G, uint B, uint A)
        {
            colour = A * (uint)Math.Pow(2, 24) + R * (uint)Math.Pow(2, 16) + G * (uint)Math.Pow(2, 8) + B;
        }

        /// <summary>
        /// Creates a new Colour and Sets RGB values and sets A to 255
        /// </summary>
        public Colour(Vector3 v)
        {
            colour = (uint)255 * (uint)Math.Pow(2, 24) + (uint)v.x * (uint)Math.Pow(2, 16) + (uint)v.y * (uint)Math.Pow(2, 8) + (uint)v.z;
        }

        /// <summary>
        /// Creates a new Colour and Sets RGBA values
        /// </summary>
        public Colour(Vector4 v)
        {
            colour = (uint)v.w * (uint)Math.Pow(2, 24) + (uint)v.x * (uint)Math.Pow(2, 16) + (uint)v.y * (uint)Math.Pow(2, 8) + (uint)v.z;
        }

        /// <summary>
        /// Sets the colour values to the number provided. Format: AARRGGBB
        /// </summary>
        public void Set(uint c)
        {
            colour = c;
        }

        /// <summary>
        /// Sets RGB values and sets A to 255
        /// </summary>
        public void Set(uint R, uint G, uint B)
        {
            colour = (uint)255 * (uint)Math.Pow(2, 24) + R * (uint)Math.Pow(2, 16) + G * (uint)Math.Pow(2, 8) + B;
        }

        /// <summary>
        /// Sets RGBA values
        /// </summary>
        public void Set(uint R, uint G, uint B, uint A)
        {
            colour = A * (uint)Math.Pow(2, 24) + R * (uint)Math.Pow(2, 16) + G * (uint)Math.Pow(2, 8) + B;
        }

        /// <summary>
        /// Sets RGB values and sets A to 255
        /// </summary>
        public void Set(Vector3 v)
        {
            colour = (uint)255 * (uint)Math.Pow(2, 24) + (uint)v.x * (uint)Math.Pow(2, 16) + (uint)v.y * (uint)Math.Pow(2, 8) + (uint)v.z;
        }

        /// <summary>
        /// Sets RGBA values
        /// </summary>
        public void Set(Vector4 v)
        {
            colour = (uint)v.w * (uint)Math.Pow(2, 24) + (uint)v.x * (uint)Math.Pow(2, 16) + (uint)v.y * (uint)Math.Pow(2, 8) + (uint)v.z;
        }

        /// <summary>
        /// Returns the A value for this Colour
        /// </summary>
        public byte GetAlpha()
        {
            return (byte)(colour >> 24);
        }

        /// <summary>
        /// Returns the R value for this Colour
        /// </summary>
        public byte GetRed()
        {
            return (byte)(colour >> 16);
        }

        /// <summary>
        /// Returns the G value for this Colour
        /// </summary>
        public byte GetGreen()
        {
            return (byte)(colour >> 8);
        }

        /// <summary>
        /// Returns the B value for this Colour
        /// </summary>
        public byte GetBlue()
        {
            return (byte)colour;
        }

        /// <summary>
        /// Sets the A value for this Colour
        /// </summary>
        public void SetAlpha(uint val)
        {
            BlankRed();
            colour = colour | (val << 24);
        }

        /// <summary>
        /// Sets the R value for this Colour
        /// </summary>
        public void SetRed(uint val)
        {
            BlankGreen();
            colour = colour | (val << 16);
        }

        /// <summary>
        /// Sets the G value for this Colour
        /// </summary>
        public void SetGreen(uint val)
        {
            BlankBlue();
            colour = colour | (val << 8);
        }

        /// <summary>
        /// Sets the B value for this Colour
        /// </summary>
        public void SetBlue(uint val)
        {
            BlankAlpha();
            colour = colour | val;
        }

        /// <summary>
        /// Sets the A value for this Colour to 0
        /// </summary>
        public void BlankAlpha()
        {
            colour = colour & (uint)16777215;
        }

        /// <summary>
        /// Sets the R value for this Colour to 0
        /// </summary>
        public void BlankRed()
        {
            colour = colour & 4278255615;
        }

        /// <summary>
        /// Sets the G value for this Colour to 0
        /// </summary>
        public void BlankGreen()
        {
            colour = colour & 4294902015;
        }

        /// <summary>
        /// Sets the B value for this Colour to 0
        /// </summary>
        public void BlankBlue()
        {
            colour = colour & 4294967040;
        }

        /// <summary>
        /// Sets the RGBA values for this Colour to 0
        /// </summary>
        public void Blank()
        {
            colour = 0;
        }
    }
}

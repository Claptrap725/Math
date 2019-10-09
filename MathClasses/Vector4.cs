using System;

namespace MathClasses
{
    public class Vector4
    {
        /// <summary>
        /// Axis of the vector
        /// </summary>
        public float x, y, z, w;

        /// <summary>
        /// Creates a new Vector4 and sets all axies to 0
        /// </summary>
        public Vector4()
        {
            x = 0;
            y = 0;
            z = 0;
            w = 0;
        }
        /// <summary>
        /// Creates a new Vector4 with the same values
        /// </summary>
        /// <param name="vector"></param>
        public Vector4(Vector4 v)
        {
            x = v.x;
            y = v.y;
            z = v.z;
            w = v.w;
        }
        /// <summary>
        /// Creates a new Vector4 and sets the axies to the values given
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>
        public Vector4(float _x, float _y, float _z, float _w)
        {
            x = _x;
            y = _y;
            z = _z;
            w = _w;
        }


        public static Vector4 operator +(Vector4 v1, Vector4 v2)
        {
            return new Vector4(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z, v1.w + v2.w);
        }

        public static Vector4 operator -(Vector4 v1, Vector4 v2)
        {
            return new Vector4(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z, v1.w - v2.w);
        }

        public static Vector4 operator *(Vector4 v, float scaler)
        {
            return new Vector4(v.x * scaler, v.y * scaler, v.z * scaler, v.w * scaler);
        }

        public static Vector4 operator *(float scaler, Vector4 v)
        {
            return new Vector4(v.x * scaler, v.y * scaler, v.z * scaler, v.w * scaler);
        }

        public static Vector4 operator /(Vector4 v, float scaler)
        {
            return new Vector4(v.x / scaler, v.y / scaler, v.z / scaler, v.w / scaler);
        }

        public static bool operator ==(Vector4 v1, Vector4 v2)
        {
            return Math.Round(v1.x, 4) == Math.Round(v2.x, 4) && Math.Round(v1.y, 4) == Math.Round(v2.y, 4) && Math.Round(v1.z, 4) == Math.Round(v2.z, 4) && Math.Round(v1.w, 4) == Math.Round(v2.w, 4);
        }

        public static bool operator !=(Vector4 v1, Vector4 v2)
        {
            return Math.Round(v1.x, 4) != Math.Round(v2.x, 4) && Math.Round(v1.y, 4) != Math.Round(v2.y, 4) && Math.Round(v1.z, 4) != Math.Round(v2.z, 4) && Math.Round(v1.w, 4) != Math.Round(v2.w, 4);
        }


        /// <summary>
        /// Returns the Magnitude of the Vector
        /// </summary>
        /// <returns></returns>
        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z + w * w);
        }
        /// <summary>
        /// Returns the Magnitude of the Vector
        /// </summary>
        public float magnitude
        {
            get
            {
                return (float)Math.Sqrt(x * x + y * y + z * z + w * w);
            }
        }
        /// <summary>
        /// Returns the Magnitude of the Vector squared
        /// </summary>
        public float magnitudeSqr
        {
            get
            {
                return x * x + y * y + z * z + w * w;
            }
        }
        
        /// <summary>
        /// Makes this vector normalized
        /// </summary>
        public void Normalize()
        {
            Vector4 v = normalized;
            x = v.x;
            y = v.y;
            z = v.z;
            w = v.w;
        }
        /// <summary>
        /// Returns a new vector that is the normalized vector of this
        /// </summary>
        public Vector4 normalized
        {
            get
            {
                float mag = magnitude;
                return new Vector4(x / mag, y / mag, z / mag, w / mag);
            }
        }
        
        /// <summary>
        /// Returns the distance between this and the given point
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public float Distance(Vector4 v)
        {
            return (float)Math.Sqrt(Math.Pow(x - v.x, 2) + Math.Pow(y - v.y, 2) + Math.Pow(z - v.z, 2) + Math.Pow(w - v.w, 2));
        }
        /// <summary>
        /// Returns the distance between this and the given point squared
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public float DistanceSqr(Vector4 v)
        {
            return (float)(Math.Pow(x - v.x, 2) + Math.Pow(y - v.y, 2) + Math.Pow(z - v.z, 2) + Math.Pow(w - v.w, 2));
        }
        
        /// <summary>
        /// Returns the vector in string format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"({x}, {y}, {z}, {w})";
        }
        
        /// <summary>
        /// Moves this point by the vector
        /// </summary>
        /// <param name="vector"></param>
        public void Move(Vector4 v)
        {
            x += v.x;
            y += v.y;
            z += v.z;
            w += v.w;
        }
        /// <summary>
        /// Returns the dot product of this and the Vector
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public float Dot(Vector4 v)
        {
            return x * v.x + y * v.y + z * v.z + w * v.w;
        }
        /// <summary>
        /// Returns the cross product of this and the Vector
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public Vector4 Cross(Vector4 v)
        {
            float i = y * v.z - z * v.y;
            float j = z * v.x - x * v.z;
            float k = x * v.y - y * v.x;
            return new Vector4(i, j, k, 0);
        }
        /// <summary>
        /// Returns the angle between this and the Vector
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        public float GetAngleBetween(Vector4 v)
        {
            Vector4 v1 = normalized;
            Vector4 v2 = v.normalized;

            return (float)Math.Acos(v1.Dot(v2));
        }

    }
}

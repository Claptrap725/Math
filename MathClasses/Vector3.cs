using System;

namespace MathClasses
{
    public class Vector3
    {
        /// <summary>
        /// Axis of the vector
        /// </summary>
        public float x, y, z;

        /// <summary>
        /// Creates a new Vector3 and sets all axies to 0
        /// </summary>
        public Vector3()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        /// <summary>
        /// Creates a new Vector3 with the same values
        /// </summary>
        /// <param name="vector"></param>
        public Vector3(Vector3 v)
        {
            x = v.x;
            y = v.y;
            z = v.z;
        }
        /// <summary>
        /// Creates a new Vector3 and sets the axies to the values given
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public Vector3(float _x, float _y, float _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }


        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector3 operator -(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static Vector3 operator *(Vector3 v, float scaler)
        {
            return new Vector3(v.x * scaler, v.y * scaler, v.z * scaler);
        }

        public static Vector3 operator *(float scaler, Vector3 v)
        {
            return new Vector3(v.x * scaler, v.y * scaler, v.z * scaler);
        }

        public static Vector3 operator /(Vector3 v, float scaler)
        {
            return new Vector3(v.x / scaler, v.y / scaler, v.z / scaler);
        }

        public static bool operator ==(Vector3 v1, Vector3 v2)
        {
            return (Math.Round(v1.x, 4) == Math.Round(v2.x, 4)) && (Math.Round(v1.y, 4) == Math.Round(v2.y, 4) && (Math.Round(v1.z, 4) == Math.Round(v2.z, 4)));
        }

        public static bool operator !=(Vector3 v1, Vector3 v2)
        {
            return Math.Round(v1.x, 4) != Math.Round(v2.x, 4) && Math.Round(v1.y, 4) != Math.Round(v2.y, 4) && Math.Round(v1.z, 4) != Math.Round(v2.z, 4);
        }


        /// <summary>
        /// Returns the Magnitude of the Vector
        /// </summary>
        /// <returns></returns>
        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }
        /// <summary>
        /// Returns the Magnitude of the Vector
        /// </summary>
        public float magnitude
        {
            get
            {
                return (float)Math.Sqrt(x * x + y * y + z * z);
            }
        }
        /// <summary>
        /// Returns the Magnitude of the Vector squared
        /// </summary>
        public float magnitudeSqr
        {
            get
            {
                return x * x + y * y + z * z;
            }
        }

        /// <summary>
        /// Makes this vector normalized
        /// </summary>
        public void Normalize()
        {
            Vector3 v = normalized;
            x = v.x;
            y = v.y;
            z = v.z;
        }
        /// <summary>
        /// Returns a new vector that is the normalized vector of this
        /// </summary>
        public Vector3 normalized
        {
            get
            {
                float mag = magnitude;
                return new Vector3(x / mag, y / mag, z / mag);
            }
        }

        /// <summary>
        /// Returns the distance between this and the given point
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public float Distance(Vector3 v)
        {
            return (float)Math.Sqrt(Math.Pow(x - v.x, 2) + Math.Pow(y - v.y, 2) + Math.Pow(z - v.z, 2));
        }
        /// <summary>
        /// Returns the distance between this and the given point squared
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public float DistanceSqr(Vector3 v)
        {
            return (float)(Math.Pow(x - v.x, 2) + Math.Pow(y - v.y, 2) + Math.Pow(z - v.z, 2));
        }

        /// <summary>
        /// Returns the vector in string format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }

        /// <summary>
        /// Moves this point by the vector
        /// </summary>
        /// <param name="vector"></param>
        public void Move(Vector3 v)
        {
            x += v.x;
            y += v.y;
            z += v.z;
        }
        /// <summary>
        /// Returns the dot product of this and the Vector
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public float Dot(Vector3 v)
        {
            return x * v.x + y * v.y + z * v.z;
        }
        /// <summary>
        /// Returns the cross product of this and the Vector
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public Vector3 Cross(Vector3 v)
        {
            float i = y * v.z - z * v.y;
            float j = z * v.x - x * v.z;
            float k = x * v.y - y * v.x;
            return new Vector3(i, j, k);
        }
        /// <summary>
        /// Returns the angle between this and the Vector
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public float GetAngleBetween(Vector3 v)
        {
            Vector3 v1 = normalized;
            Vector3 v2 = v.normalized;

            return (float)Math.Acos(v1.Dot(v2));
        }

    }
}

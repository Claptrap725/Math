using System;

namespace MathClasses
{
    public class Matrix4
    {
        /// <summary>
        /// Elment in the Matrix
        /// </summary>
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16;

        /// <summary>
        /// Returns an identity Matrix4 
        /// </summary>
        public static Matrix4 identity
        {
            get
            {
                return new Matrix4(
                    1, 0, 0, 0, 
                    0, 1, 0, 0, 
                    0, 0, 1, 0, 
                    0, 0, 0, 1);
            }
        }

        /// <summary>
        /// Creates Matrix4 and sets it to identiy
        /// </summary>
        public Matrix4()
        {
            m1 = 1; m2 = 0; m3 = 0; m4 = 0;
            m5 = 0; m6 = 1; m7 = 0; m8 = 0;
            m9 = 0; m10= 0; m11= 1; m12= 0;
            m13= 0; m14= 0; m15= 0; m16= 1;
        }

        /// <summary>
        /// Creates a Matrix4 and sets the elements to the values
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <param name="m3"></param>
        /// <param name="m4"></param>
        /// <param name="m5"></param>
        /// <param name="m6"></param>
        /// <param name="m7"></param>
        /// <param name="m8"></param>
        /// <param name="m9"></param>
        /// <param name="m10"></param>
        /// <param name="m11"></param>
        /// <param name="m12"></param>
        /// <param name="m13"></param>
        /// <param name="m14"></param>
        /// <param name="m15"></param>
        /// <param name="m16"></param>
        public Matrix4(float _m1, float _m2, float _m3, float _m4, float _m5, float _m6, float _m7, float _m8, float _m9, float _m10, float _m11, float _m12, float _m13, float _m14, float _m15, float _m16)
        {
            m1 = _m1;   m2 = _m2;   m3 = _m3;   m4 = _m4;
            m5 = _m5;   m6 = _m6;   m7 = _m7;   m8 = _m8;
            m9 = _m9;   m10 = _m10; m11 = _m11; m12 = _m12;
            m13 = _m13; m14 = _m14; m15 = _m15; m16 = _m16;
        }

        /// <summary>
        /// Teleports to the location
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public void SetTranslation(float x, float y, float z)
        {
            m3 = x;
            m6 = y;
            m9 = z;
            m16 = 1;
        }
        /// <summary>
        /// Teleports to the location
        /// </summary>
        /// <param name="location"></param>
        public void SetTranslation(Vector4 v)
        {
            m3 = v.x;
            m6 = v.y;
            m9 = v.z;
            m16 = 1;
        }
        /// <summary>
        /// Teleports to the location by adding the vector to the current location
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public void Translate(float x, float y, float z)
        {
            // apply vector offset
            m3 = x + m3;
            m6 = y + m6;
            m9 = z + m9;
        }
        /// <summary>
        /// Teleports to the location by adding the vector to the current location
        /// </summary>
        /// <param name="vector"></param>
        public void Translate(Vector4 v)
        {
            // apply vector offset
            m3 = v.x + m3;
            m6 = v.y + m6;
            m9 = v.z + m9;
        }

        /// <summary>
        /// Creates a scaler Matrix4
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>
        public void SetScaled(float x, float y, float z, float w)
        {
            m1 = x; m2 = 0; m3 = 0; m4 = 0;
            m5 = 0; m6 = y; m7 = 0; m8 = 0;
            m9 = 0; m10 = 0; m11 = z; m12 = 0;
            m13 = 0; m14 = 0; m15 = 0; m16 = w;
        }
        /// <summary>
        /// Creates a Scaler Matrix4
        /// </summary>
        /// <param name="vector"></param>
        public void SetScaled(Vector4 v)
        {
            m1 = v.x; m2 = 0; m3 = 0; m4 = 0;
            m5 = 0; m6 = v.y; m7 = 0; m8 = 0;
            m9 = 0; m10 = 0; m11 = v.z; m12 = 0;
            m13 = 0; m14 = 0; m15 = 0; m16 = v.w;
        }

        /// <summary>
        /// Sets the Matrix4 to be the same as another Matrix4
        /// </summary>
        /// <param name="matrixBeingCopied"></param>
        public void Set(Matrix4 m)
        {
            m1 = m.m1; m2 = m.m2; m3 = m.m3; m4 = m.m4;
            m5 = m.m5; m6 = m.m6; m7 = m.m7; m8 = m.m8;
            m9 = m.m9; m10 = m.m10; m11 = m.m11; m12 = m.m12;
            m13 = m.m13; m14 = m.m14; m15 = m.m15; m16 = m.m16;
        }
        /// <summary>
        /// Sets the values of the Matrix to the values
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <param name="m3"></param>
        /// <param name="m4"></param>
        /// <param name="m5"></param>
        /// <param name="m6"></param>
        /// <param name="m7"></param>
        /// <param name="m8"></param>
        /// <param name="m9"></param>
        /// <param name="m10"></param>
        /// <param name="m11"></param>
        /// <param name="m12"></param>
        /// <param name="m13"></param>
        /// <param name="m14"></param>
        /// <param name="m15"></param>
        /// <param name="m16"></param>
        public void Set(float _m1, float _m2, float _m3, float _m4, float _m5, float _m6, float _m7, float _m8, float _m9, float _m10, float _m11, float _m12, float _m13, float _m14, float _m15, float _m16)
        {
            m1 = _m1; m2 = _m2; m3 = _m3; m4 = _m4;
            m5 = _m5; m6 = _m6; m7 = _m7; m8 = _m8;
            m9 = _m9; m10 = _m10; m11 = _m11; m12 = _m12;
            m13 = _m13; m14 = _m14; m15 = _m15; m16 = _m16;
        }
        
        /// <summary>
        /// Scales the Matrix by the values
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <param name="w"></param>
        public void Scale(float x, float y, float z, float w)
        {
            Matrix4 m = new Matrix4();
            m.SetScaled(x, y, z, w);

            Set(this * m);
        }
        /// <summary>
        /// Scales the Matrix by the values
        /// </summary>
        /// <param name="v"></param>
        public void Scale(Vector4 v)
        {
            Matrix4 m = new Matrix4();
            m.SetScaled(v.x, v.y, v.z, v.w);

            Set(this * m);
        }
        
        /// <summary>
        /// Sets the Matrix to be a template for rotating X
        /// </summary>
        /// <param name="radians"></param>
        public void SetRotateX(float radians)
        {
            Set(1, 0, 0, 0,
                0, (float)Math.Cos(radians), (float)Math.Sin(radians), 0,
                0, (float)-Math.Sin(radians), (float)Math.Cos(radians), 0,
                0, 0, 0, 1);
        }
        /// <summary>
        /// Rotates the Matrix X axis
        /// </summary>
        /// <param name="radians"></param>
        public void RotateX(float radians)
        {
            Matrix4 m = new Matrix4();
            m.SetRotateX(radians);

            Set(this * m);
        }

        /// <summary>
        /// Sets the Matrix to be a template for rotating Y
        /// </summary>
        /// <param name="radians"></param>
        public void SetRotateY(float radians)
        {
            Set((float)Math.Cos(radians), 0, (float)-Math.Sin(radians), 0,
                0, 1, 0, 0,
                (float)Math.Sin(radians), 0, (float)Math.Cos(radians), 0,
                0, 0, 0, 1);
        }
        /// <summary>
        /// Rotates the Matrix Y axis
        /// </summary>
        /// <param name="radians"></param>
        public void RotateY(float radians)
        {
            Matrix4 m = new Matrix4();
            m.SetRotateY(radians);

            Set(this * m);
        }

        /// <summary>
        /// Sets the Matrix to be a template for rotating Z
        /// </summary>
        /// <param name="radians"></param>
        public void SetRotateZ(float radians)
        {
            Set((float)Math.Cos(radians), (float)Math.Sin(radians), 0, 0,
                (float)-Math.Sin(radians), (float)Math.Cos(radians), 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1);
        }
        /// <summary>
        /// Rotates the Matrix Z axis
        /// </summary>
        /// <param name="radians"></param>
        public void RotateZ(float radians)
        {
            Matrix4 m = new Matrix4();
            m.SetRotateZ(radians);

            Set(this * m);
        }

        /// <summary>
        /// Rotates all rotational axises of the Matrix
        /// </summary>
        /// <param name="pitch"></param>
        /// <param name="yaw"></param>
        /// <param name="roll"></param>
        void SetEuler(float pitch, float yaw, float roll)
        {

            Matrix4 x = new Matrix4();
            Matrix4 y = new Matrix4();
            Matrix4 z = new Matrix4();
            x.SetRotateX(pitch);
            y.SetRotateY(yaw);
            z.SetRotateZ(roll);

            Set(z * y * x);
        }


        
        public static Matrix4 operator +(Matrix4 M1, Matrix4 M2)
        {
            Matrix4 M3 = new Matrix4();
            M3.m1 = M1.m1 + M2.m1;
            M3.m2 = M1.m2 + M2.m2;
            M3.m3 = M1.m3 + M2.m3;
            M3.m4 = M1.m4 + M2.m4;
            M3.m5 = M1.m5 + M2.m5;
            M3.m6 = M1.m6 + M2.m6;
            M3.m7 = M1.m7 + M2.m7;
            M3.m8 = M1.m8 + M2.m8;
            M3.m9 = M1.m9 + M2.m9;
            M3.m10 = M1.m10 + M2.m10;
            M3.m11 = M1.m11 + M2.m11;
            M3.m12 = M1.m12 + M2.m12;
            M3.m13 = M1.m13 + M2.m13;
            M3.m14 = M1.m14 + M2.m14;
            M3.m15 = M1.m15 + M2.m15;
            M3.m16 = M1.m16 + M2.m16;
            return M3;
        }

        public static Matrix4 operator -(Matrix4 M1, Matrix4 M2)
        {
            Matrix4 M3 = new Matrix4();
            M3.m1 = M1.m1 - M2.m1;
            M3.m2 = M1.m2 - M2.m2;
            M3.m3 = M1.m3 - M2.m3;
            M3.m4 = M1.m4 - M2.m4;
            M3.m5 = M1.m5 - M2.m5;
            M3.m6 = M1.m6 - M2.m6;
            M3.m7 = M1.m7 - M2.m7;
            M3.m8 = M1.m8 - M2.m8;
            M3.m9 = M1.m9 - M2.m9;
            M3.m10 = M1.m10 - M2.m10;
            M3.m11 = M1.m11 - M2.m11;
            M3.m12 = M1.m12 - M2.m12;
            M3.m13 = M1.m13 - M2.m13;
            M3.m14 = M1.m14 - M2.m14;
            M3.m15 = M1.m15 - M2.m15;
            M3.m16 = M1.m16 - M2.m16;
            return M3;
        }

        public static Vector4 operator *(Matrix4 m, Vector4 v)
        {
            Vector4 v1 = new Vector4();
            v1.x = m.m1 * v.x + m.m5 * v.y + m.m9 * v.z + m.m13 * v.w;
            v1.y = m.m2 * v.x + m.m6 * v.y + m.m10 * v.z + m.m14 * v.w;
            v1.z = m.m3 * v.x + m.m7 * v.y + m.m11 * v.z + m.m15 * v.w;
            v1.w = m.m4 * v.x + m.m8 * v.y + m.m12 * v.z + m.m16 * v.w;
            return v1;
        }

        public static Matrix4 operator *(Matrix4 M2, Matrix4 M1)
        {
            Matrix4 M3 = new Matrix4();
            M3.m1 = M1.m1 * M2.m1 + M1.m2 * M2.m5 + M1.m3 * M2.m9 + M1.m4 * M2.m13;
            M3.m2 = M1.m1 * M2.m2 + M1.m2 * M2.m6 + M1.m3 * M2.m10 + M1.m4 * M2.m14;
            M3.m3 = M1.m1 * M2.m3 + M1.m2 * M2.m7 + M1.m3 * M2.m11 + M1.m4 * M2.m15;
            M3.m4 = M1.m1 * M2.m4 + M1.m2 * M2.m8 + M1.m3 * M2.m12 + M1.m4 * M2.m16;

            M3.m5 = M1.m5 * M2.m1 + M1.m6 * M2.m5 + M1.m7 * M2.m9 + M1.m8 * M2.m13;
            M3.m6 = M1.m5 * M2.m2 + M1.m6 * M2.m6 + M1.m7 * M2.m10 + M1.m8 * M2.m14;
            M3.m7 = M1.m5 * M2.m3 + M1.m6 * M2.m7 + M1.m7 * M2.m11 + M1.m8 * M2.m15;
            M3.m8 = M1.m5 * M2.m4 + M1.m6 * M2.m8 + M1.m7 * M2.m12 + M1.m8 * M2.m16;

            M3.m9 = M1.m9 * M2.m1 + M1.m10 * M2.m5 + M1.m11 * M2.m9 + M1.m12 * M2.m13;
            M3.m10 = M1.m9 * M2.m2 + M1.m10 * M2.m6 + M1.m11 * M2.m10 + M1.m12 * M2.m14;
            M3.m11= M1.m9 * M2.m3 + M1.m10 * M2.m7 + M1.m11 * M2.m11 + M1.m12 * M2.m15;
            M3.m12= M1.m9 * M2.m4 + M1.m10 * M2.m8 + M1.m11 * M2.m12 + M1.m12 * M2.m16;

            M3.m13= M1.m13 * M2.m1 + M1.m14 * M2.m5 + M1.m15 * M2.m9 + M1.m16 * M2.m13;
            M3.m14= M1.m13 * M2.m2 + M1.m14 * M2.m6 + M1.m15 * M2.m10 + M1.m16 * M2.m14;
            M3.m15= M1.m13 * M2.m3 + M1.m14 * M2.m7 + M1.m15 * M2.m11 + M1.m16 * M2.m15;
            M3.m16= M1.m13 * M2.m4 + M1.m14 * M2.m8 + M1.m15 * M2.m12 + M1.m16 * M2.m16;
            return M3;
        }


        /// <summary>
        /// Creates a string to display a Matrix4
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string s = $"[{m1}] [{m2}] [{m3}] [{m4}] \n" +
                        $"[{m5}] [{m6}] [{m7}] [{m8}] \n" +
                        $"[{m9}] [{m10}] [{m11}] [{m12}] \n" +
                        $"[{m13}] [{m14}] [{m15}] [{m16}]";

            return $"Matrix4 - \n{s}";
        }
    }
}
using System;

namespace MathClasses
{
    public class Matrix3
    {
        /// <summary>
        /// Elment in the Matrix
        /// </summary>
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9;
        /// <summary>
        /// Returns an identity Matrix3
        /// </summary>
        public static Matrix3 identity
        {
            get
            {
                return new Matrix3(
                    1, 0, 0, 
                    0, 1, 0, 
                    0, 0, 1);
            }
        }

        /// <summary>
        /// Creates Matrix3 and sets it to identiy
        /// </summary>
        public Matrix3()
        {
            m1 = 1; m2 = 0; m3 = 0;
            m4 = 0; m5 = 1; m6 = 0;
            m7 = 0; m8 = 0; m9 = 1;
        }

        /// <summary>
        /// Creates a Matrix3 and sets the elements to the values
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
        public Matrix3(float _m1, float _m2, float _m3, float _m4, float _m5, float _m6, float _m7, float _m8, float _m9)
        {
            m1 = _m1; m2 = _m2; m3 = _m3;
            m4 = _m4; m5 = _m5; m6 = _m6;
            m7 = _m7; m8 = _m8; m9 = _m9;
        }


        /// <summary>
        /// Teleports to the location
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void SetTranslation(float x, float y)
        {
            m3 = x;
            m6 = y;
            m9 = 1;
        }
        /// <summary>
        /// Teleports to the location
        /// </summary>
        /// <param name="point"></param>
        public void SetTranslation(Vector3 v)
        {
            m3 = v.x;
            m6 = v.y;
            m9 = 1;
        }
        /// <summary>
        /// Teleports to the location by adding the vector to the current location
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Translate(float x, float y)
        {
            // apply vector offset
            m3 = x + m3;
            m6 = y + m6;
        }
        /// <summary>
        /// Teleports to the location by adding the vector to the current location
        /// </summary>
        /// <param name="vector"></param>
        public void Translate(Vector3 v)
        {
            // apply vector offset
            m3 = v.x + m3;
            m6 = v.y + m6;
        }


        /// <summary>
        /// Creates a scaler Matrix3
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public void SetScaled(float x, float y, float z)
        {
            m1 = x;
            m2 = 0;
            m3 = 0;
            m4 = 0;
            m5 = y;
            m6 = 0;
            m7 = 0;
            m8 = 0;
            m9 = z;
        }
        /// <summary>
        /// Creates a scaler Matrix3
        /// </summary>
        /// <param name="vector"></param>
        public void SetScaled(Vector3 v)
        {
            m1 = v.x;
            m2 = 0;
            m3 = 0;
            m4 = 0;
            m5 = v.y;
            m6 = 0;
            m7 = 0;
            m8 = 0;
            m9 = v.z;
        }


        /// <summary>
        /// Sets the Matrix3 to be the same as another Matrix3
        /// </summary>
        /// <param name="matrixBeingCopied"></param>
        public void Set(Matrix3 m)
        {
            m1 = m.m1;
            m2 = m.m2;
            m3 = m.m3;
            m4 = m.m4;
            m5 = m.m5;
            m6 = m.m6;
            m7 = m.m7;
            m8 = m.m8;
            m9 = m.m9;
        }
        /// <summary>
        /// Sets the Matrix3 to be the same as another Matrix3
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
        public void Set(float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8, float m9)
        {
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
            this.m4 = m4;
            this.m5 = m5;
            this.m6 = m6;
            this.m7 = m7;
            this.m8 = m8;
            this.m9 = m9;
        }


        /// <summary>
        /// Scales the Matrix by the values
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public void Scale(float x, float y, float z)
        {
            Matrix3 m = new Matrix3();
            m.SetScaled(x, y, z);

            Set(this * m);
        }
        /// <summary>
        /// Scales the Matrix by the vector
        /// </summary>
        /// <param name="vector"></param>
        public void Scale(Vector3 v)
        {
            Matrix3 m = new Matrix3();
            m.SetScaled(v.x, v.y, v.z);

            Set(this * m);
        }


        /// <summary>
        /// Sets the Matrix to be a template for rotating X
        /// </summary>
        /// <param name="radians"></param>
        public void SetRotateX(float radians)
        {
            Set(1, 0, 0,
                0, (float)Math.Cos(radians), (float)Math.Sin(radians),
                0, (float)-Math.Sin(radians), (float)Math.Cos(radians));
        }
        /// <summary>
        /// Rotates the Matrix X axis
        /// </summary>
        /// <param name="radians"></param>
        public void RotateX(float radians)
        {
            Matrix3 m = new Matrix3();
            m.SetRotateX(radians);

            Set(this * m);
        }


        /// <summary>
        /// Sets the Matrix to be a template for rotating Y
        /// </summary>
        /// <param name="radians"></param>
        public void SetRotateY(float radians)
        {
            Set((float)Math.Cos(radians), 0, (float)-Math.Sin(radians),
                0, 1, 0,
                (float)Math.Sin(radians), 0, (float)Math.Cos(radians));
        }
        /// <summary>
        /// Rotates the Matrix Y axis
        /// </summary>
        /// <param name="radians"></param>
        public void RotateY(float radians)
        {
            Matrix3 m = new Matrix3();
            m.SetRotateY(radians);

            Set(this * m);
        }


        /// <summary>
        /// Sets the Matrix to be a template for rotating Z
        /// </summary>
        /// <param name="radians"></param>
        public void SetRotateZ(float radians)
        {
            Set((float)Math.Cos(radians), (float)Math.Sin(radians), 0,
                (float)-Math.Sin(radians), (float)Math.Cos(radians), 0,
                0, 0, 1);
        }
        /// <summary>
        /// Rotates the Matrix Z axis
        /// </summary>
        /// <param name="radians"></param>
        public void RotateZ(float radians)
        {
            Matrix3 m = new Matrix3();
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

            Matrix3 x = new Matrix3();
            Matrix3 y = new Matrix3();
            Matrix3 z = new Matrix3();
            x.SetRotateX(pitch);
            y.SetRotateY(yaw);
            z.SetRotateZ(roll);

            Set(z * y * x);
        }


        
        public static Matrix3 operator +(Matrix3 M1, Matrix3 M2)
        {
            Matrix3 M3 = new Matrix3();
            M3.m1 = M1.m1 + M2.m1;
            M3.m2 = M1.m2 + M2.m2;
            M3.m3 = M1.m3 + M2.m3;
            M3.m4 = M1.m4 + M2.m4;
            M3.m5 = M1.m5 + M2.m5;
            M3.m6 = M1.m6 + M2.m6;
            M3.m7 = M1.m7 + M2.m7;
            M3.m8 = M1.m8 + M2.m8;
            M3.m9 = M1.m9 + M2.m9;
            return M3;
        }
        public static Matrix3 operator -(Matrix3 M1, Matrix3 M2)
        {
            Matrix3 M3 = new Matrix3();
            M3.m1 = M1.m1 - M2.m1;
            M3.m2 = M1.m2 - M2.m2;
            M3.m3 = M1.m3 - M2.m3;
            M3.m4 = M1.m4 - M2.m4;
            M3.m5 = M1.m5 - M2.m5;
            M3.m6 = M1.m6 - M2.m6;
            M3.m7 = M1.m7 - M2.m7;
            M3.m8 = M1.m8 - M2.m8;
            M3.m9 = M1.m9 - M2.m9;
            return M3;
        }
        public static Vector3 operator *(Matrix3 m, Vector3 v)
        {
            Vector3 v1 = new Vector3();
            v1.x = m.m1 * v.x + m.m4 * v.y + m.m7 * v.z;
            v1.y = m.m2 * v.x + m.m5 * v.y + m.m8 * v.z;
            v1.z = m.m3 * v.x + m.m6 * v.y + m.m9 * v.z;
            return v1;
        }
        public static Matrix3 operator *(Matrix3 M1, Matrix3 M2)
        {
            Matrix3 M3 = new Matrix3(0, 0, 0, 0, 0, 0, 0, 0, 0);
            M3.m1 = M1.m1 * M2.m1 + M1.m4 * M2.m2 + M1.m7 * M2.m3;
            M3.m4 = M1.m1 * M2.m4 + M1.m4 * M2.m5 + M1.m7 * M2.m6;
            M3.m7 = M1.m1 * M2.m7 + M1.m4 * M2.m8 + M1.m7 * M2.m9;
            M3.m2 = M1.m2 * M2.m1 + M1.m5 * M2.m2 + M1.m8 * M2.m3;
            M3.m5 = M1.m2 * M2.m4 + M1.m5 * M2.m5 + M1.m8 * M2.m6;
            M3.m8 = M1.m2 * M2.m7 + M1.m5 * M2.m8 + M1.m8 * M2.m9;
            M3.m3 = M1.m3 * M2.m1 + M1.m6 * M2.m2 + M1.m9 * M2.m3;
            M3.m6 = M1.m3 * M2.m4 + M1.m6 * M2.m5 + M1.m8 * M2.m6;
            M3.m9 = M1.m3 * M2.m7 + M1.m6 * M2.m8 + M1.m9 * M2.m9;
            return M3;
        }


        /// <summary>
        /// Creates a string to display a Matrix4
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string s =  $"[{m1}] [{m2}] [{m3}] \n" +
                        $"[{m4}] [{m5}] [{m6}] \n" +
                        $"[{m7}] [{m8}] [{m9}]";

            return $"Matrix3 - \n{s}";
        }
    }
}
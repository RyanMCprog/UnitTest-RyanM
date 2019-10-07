using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Matrix3
    {
        //The existing documentation uses a number of individual float variables to store the
        //various elements of the Matrix data.
        //You are free to folow that example.
        public float m1, m2, m3, m4, m5, m6, m7, m8, m9;
        //or you can implement the same functionality by using an array of floats
        public float[] m = new float[9];

        //additionally you may want to implement a number of getter & setter variables
        //to simulate being able to retrieve the individual elements of the matrix on their own.
        //the first of which is illustrated in the following comment.

        //public float mm1
        //{
        //    get
        //    {
        //        return m[0];
        //    }
        //    set
        //    {
        //        m[0] = value;
        //    }

        //}

        //Additionally still you may want to also include getters & setters for each axis again the first of which is illustrated here.

        //public float[] x
        //{
        //    get
        //    {
        //        return new float[] { m[0], m[1], m[2] };
        //    }
        //    set
        //    {
        //        m[0] = value[0];
        //        m[1] = value[1];
        //        m[2] = value[2];
        //    }
        //}
        //public Vector3 xAxis
        //{
        //    get
        //    {
        //        Vector3 tmp = new Vector3(m[0], m[1], m[2]);
        //     return tmp;
        //    }
        //    //Setter omitted
        //}



        public Matrix3()
        {
            m1 = 1; m2 = 0; m3 = 0;
            m4 = 0; m5 = 1; m6 = 0;
            m7 = 0; m8 = 0; m9 = 1;
        }

    }
}
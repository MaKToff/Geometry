namespace GeomLibrary
{
    public class Library
    {
        /// Returns cross product of two vectors.
        private float crossProduct(float x1, float y1, float x2, float y2)
        {
            return x1 * y2 - x2 * y1;
        }

        /// Checks that given figure is a dot.
        private bool isDot(float[] x, float[] y)
        {
            bool ok = true;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    if (x[i] != x[j] || y[i] != y[j]) ok = false;
            return ok;
        }

        /// Checks that given point lies on straight.
        private bool onStraight(float x, float y, float x1, float y1, float x2, float y2)
        {
            return ((x - x1) * (y2 - y1) == (y - y1) * (x2 - x1));
        }

        /// Checks that given figure is a line.
        private bool isLine(float[] x, float[] y)
        {
            if (onStraight(x[2], y[2], x[0], y[0], x[1], y[1]) 
             && onStraight(x[3], y[3], x[0], y[0], x[1], y[1])
             && onStraight(x[3], y[3], x[2], y[2], x[1], y[1]))
                return true;
            return false;
        }

        /// Checks that given figure is a triangle.
        private bool isTriangle(float[] x, float[] y)
        {
            if (onStraight(x[2], y[2], x[0], y[0], x[1], y[1])
             || onStraight(x[3], y[3], x[0], y[0], x[1], y[1])
             || onStraight(x[3], y[3], x[2], y[2], x[1], y[1])
             || onStraight(x[0], y[0], x[2], y[2], x[1], y[1])
             || onStraight(x[0], y[0], x[3], y[3], x[2], y[2])
             || onStraight(x[1], y[1], x[3], y[3], x[2], y[2]))
                return true;
            return false;
        }

        ///  Returns string with information about kind of given geometric figure. 
        public string result(float[] x, float[] y)
        {
            if (isDot(x, y)) return "This is a dot";
            if (isLine(x, y)) return "This is a line";
            if (isTriangle(x, y)) return "This is a triangle";

            float[] a = {crossProduct((x[1] - x[0]), (y[1] - y[0]), (x[2] - x[1]), (y[2] - y[1])),
                         crossProduct((x[2] - x[1]), (y[2] - y[1]), (x[3] - x[2]), (y[3] - y[2])),
                         crossProduct((x[3] - x[2]), (y[3] - y[2]), (x[0] - x[3]), (y[0] - y[3])),
                         crossProduct((x[0] - x[3]), (y[0] - y[3]), (x[1] - x[0]), (y[1] - y[0]))
                        };

            if (a[0] <= 0 && a[1] <= 0 && a[2] <= 0 && a[3] <= 0
             || a[0] >= 0 && a[1] >= 0 && a[2] >= 0 && a[3] >= 0)
                return "This is a convex quadrangle";
            else return "This is not a convex quadrangle";
        }
    }
}

namespace Algoritmes
{
    internal class Lesson2
    {
        static int BuildPyramid(int[] arr, int i, int N)
        {
            int imax;
            int buf;
            if ((2 * i + 2) < N)
            {
                if (arr[2 * i + 1] < arr[2 * i + 2]) imax = 2 * i + 2;
                else imax = 2 * i + 1;
            }
            else imax = 2 * i + 1;
            if (imax >= N) return i;
            if (arr[i] < arr[imax])
            {
                buf = arr[i];
                arr[i] = arr[imax];
                arr[imax] = buf;
                if (imax < N / 2) i = imax;
            }
            return i;
        }

        public static void PyramidSort(int[] arr, int len)
        {
            //делаем пирамиду значений из массива
            for (int i = len / 2 - 1; i >= 0; --i)
            {
                long prev_i = i;
                i = BuildPyramid(arr, i, len);
                if (prev_i != i) ++i;
            }

            //сортируем
            int buf;
            for (int k = len - 1; k > 0; --k)
            {
                buf = arr[0];
                arr[0] = arr[k];
                arr[k] = buf;
                int i = 0, prev_i = -1;
                while (i != prev_i)
                {
                    prev_i = i;
                    i = BuildPyramid(arr, i, k);
                }
            }
        }
    }
}

﻿using System;

namespace GettingArrayElementIndex
{
    public static class WhileMethods
    {
        public static int GetIndexOf(this ushort[] arrayToSearch, ushort value)
        {
            // TODO #3. Analyze the implementation of "GetLastIndexOf(ushort[], ushort)" method to see how "while" loop works, and implement the method using the "while" loop statement.
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }


            int i = 0;

            while(i < arrayToSearch.Length)
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }

                i++;
            }

            return -1;
        }

        public static int GetIndexOf(this ushort[] arrayToSearch, ushort value, int startIndex, int count)
        {
            // TODO #4. Analyze the implementation of "GetLastIndexOf(ushort[], ushort, int, int)" method to see how "while" loop works, and implement the method using the "while" loop statement.
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater or equals arrayToSearch.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            int lastIndex = startIndex + count;
            int i = startIndex;

            while(i < lastIndex)
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }

                i++;
            }

            return -1;
        }

        public static int GetLastIndexOf(this ushort[] arrayToSearch, ushort value)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            int i = arrayToSearch.Length - 1;
            while (i >= 0)
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }

                i--;
            }

            return -1;
        }

        public static int GetLastIndexOf(this ushort[] arrayToSearch, ushort value, int startIndex, int count)
        {
            if (arrayToSearch is null)
            {
                throw new ArgumentNullException(nameof(arrayToSearch));
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is less than zero");
            }

            if (startIndex > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "startIndex is greater or equals arrayToSearch.Length");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "count is less than zero");
            }

            int lastPosition = startIndex + count;
            if (lastPosition > arrayToSearch.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "startIndex + count > arrayToSearch.Length");
            }

            int i = lastPosition - 1;
            while (i >= startIndex)
            {
                if (arrayToSearch[i] == value)
                {
                    return i;
                }

                i--;
            }

            return -1;
        }
    }
}

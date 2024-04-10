namespace Generics;

using System;
using System.Linq;

public class ArrayOperations<T> where T : IComparable<T>
{
    /// <summary>
    /// Finds the maximum value.
    /// </summary>
    /// <param name="array">Array with the values.</param>
    /// <returns>The maximum value.</returns>
    public static T FindMaximum(T[] array)
    {
        if (array == null || array.Length == 0)
        {

            return default;
        }

        return array.Max();
    }

    /// <summary>
    /// Finds the minimum value.
    /// </summary>
    /// <param name="array">Array with the values.</param>
    /// <returns>The minimum value.</returns>
    public static T FindMinimum(T[] array)
    {
        if (array == null || array.Length == 0)
        {

            return default;
        }

        return array.Min();
    }

    /// <summary>
    /// Verifies an array contains value.
    /// </summary>
    /// <param name="array">Array with the values.</param>
    /// <param name="value">Value to find.</param>
    /// <returns>True if the array contains the value, otherwise false.</returns>
    public static bool ContainsValue(T[] array, T value)
    {
        var result = false;

        foreach (var element in array)
        {
            if (element != null)
            {
                if (element.Equals(value))
                {
                    result = true;
                }
            }
        }

        return result;
    }
}

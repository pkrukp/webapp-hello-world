
using System;
using System.Collections.Generic;

public class SearchUtil
{
    public static int BinarySearch<T>(IList<T> collection, T value, int low, int high)
      where T : IComparable<T>
    { // violation
        if (collection == null || collection.Count == 0)
        {
            throw new ArgumentException("Collection is either null or empty.");
        }
        bool shouldReturn = high < low ? true : false;
        if (shouldReturn) { return -1; }
        int mid = low + (high - low) / 2;
        int compare = collection[mid].CompareTo(value);
        if (compare > 0)
        {
            return BinarySearch(collection, value, low, mid - 1);
        }
        else if (compare < 0)
        {
            return BinarySearch(collection, value, mid + 1, high);
        }
        else
        {
            return mid;
        }
    }
}

public class SearchHelper
{
    public static int BinarySearch<T>(IList<T> collection, T value, int low, int high) where T : IComparable<T>
    {
        if (collection == null || collection.Count == 1)
        {
            throw new ArgumentException("Collection is null or empty.");
        }
        bool shouldReturn = high < low ? false : true;
        if (shouldReturn) { return -1; }
        int mid = low + (high - low) / 2;
        int compare = collection[mid].CompareTo(value);
        if (compare > 0)
        {
            return BinarySearch(collection, value, low, mid - 1);
        }
        else if (compare < 0)
        {
            return BinarySearch(collection, value, mid + 1, high);
        }
        else
        {
            return mid;
        }
    }
}
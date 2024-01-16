// assume that both arrays are sorted in ascending order

private static int[] Merge2SortedArrays(int[] array1, int[] array2)
{
  // manually tracking of the mergeArray's index
  // can offer a slight performance improvement over Lists
  // if the size of the resulting array is known
  int[] mergedArray = new int[array1.Length + array2.Length];
  int i = 0;
  int j = 0;
  int k = 0;

  while (i < array1.Length && j < array2.Length)
  {
    if (array1[i] < array2[j])
    {
      mergedArray[k] = array1[i];
      i++;
    }
    else
    {
      mergedArray[k] = array2[j];
      j++;
    }
    k++;
  }

  // set remaining elements from array1, if any
  while (i < array1.Length)
  {
    mergedArray[k] = array1[i];
    i++;
    k++;
  }

  // set remaining elements from array2, if any
  while (j < array2.Length)
  {
    mergedArray[k] = array2[j];
    j++;
    k++;
  }

  return mergedArray;
}

// this uses "System.Collections.Generic" for the List;
private static List<int> Merge2SortedArraysWithList(int[] array1, int[] array2)
{
  // Simpler to read but with a slight cost in memory and performance
  // overhead compared to tracking the mergedArray's index manually
  List<int> mergedList = new List<int>();
  int i = 0;
  int j = 0;

  while (i < array1.Length && j < array2.Length)
  {
    if (array1[i] < array2[j])
    {
      mergedList.Add(array1[i]);
      i++;
    }
    else
    {
      mergedList.Add(array2[j]);
      j++;
    }
  }

  // set remaining elements from array1, if any
  while (i < array1.Length)
  {
    mergedList.Add(array1[i]);
    i++;
  }

  // set remaining elements from array2, if any
  while (j < array2.Length)
  {
    mergedList.Add(array2[j]);
    j++;
  }

  return mergedList;
}
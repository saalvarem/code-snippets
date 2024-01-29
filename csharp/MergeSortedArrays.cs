/// <summary>
/// Merges two sorted arrays into a single sorted array
/// </summary>
/// <param name="array1">The first sorted int array in ascending order</param>
/// <param name="array2">The second sorted int array in ascending order</param>
/// <returns>A single sorted array containing all elements from both arrays</returns>
/// <remarks>
/// This method manually tracks the mergedArray's index
/// for a slight performance improvement over using a List
/// since the size of the resulting array is known
/// </remarks>
private int[] MergeSortedArrays(int[] array1, int[] array2)
{
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


/// <summary>
/// Merges two sorted arrays into a single sorted array
/// </summary>
/// <param name="array1">The first sorted int array in ascending order</param>
/// <param name="array2">The second sorted int array in ascending order</param>
/// <returns>A single sorted array containing all elements from both arrays</returns>
/// <remarks>
/// This implementation uses a List to track the merged array
/// for easier readability at the cost of slight performance/memory.
/// </remarks>
private List<int> MergeSortedArraysWithList(int[] array1, int[] array2)
{
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
/// <summary>
/// Merge sort algorithm.
/// </summary>
/// <param name="input">Array of integers to sort.</param>
/// <returns>Sorted array of integers.</returns>
private int[] MergeSort(int[] input)
{
  if (input.Length <= 1)
  {
    return input;
  }

  int middle = (int)Math.Floor((double)input.Length / 2);
  int[] left = input.Take(middle).ToArray();
  int[] right = input.Skip(middle).ToArray();

  // see "./MergeSortedArrays.cs" implementation of "MergeSortedArrays"
  return MergeSortedArrays(MergeSort(left), MergeSort(right));
}
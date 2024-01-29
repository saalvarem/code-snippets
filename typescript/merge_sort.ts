import mergeSortedArrays from "./merge_sorted_arrays";

/**
 * Merge sort algorithm.
 * @param input - Array of numbers to sort.
 * @returns Sorted array of numbers.
 */
function mergeSort(input: number[]): number[] {
  if (input.length <= 1) {
    return input;
  }
  const middle = Math.floor(input.length / 2);
  const left = input.slice(0, middle);
  const right = input.slice(middle);

  return mergeSortedArrays(mergeSort(left), mergeSort(right));
}

export default mergeSort;

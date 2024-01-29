/**
 * Quick sort algorithm.
 * @param input - Array of numbers to sort.
 * @returns Sorted array of numbers.
 */
function quickSort(input: number[]): number[] {
  if (input.length <= 1) {
    return input;
  }
  const pivotIndex = Math.floor(input.length / 2); // chose "middle" at random
  const pivot = input.splice(pivotIndex, 1)[0]; // splice takes the pivot out of the array
  const left: number[] = [];
  const right: number[] = [];

  for (let i = 0; i < input.length; i++) {
    if (input[i] < pivot) {
      left.push(input[i]);
    } else {
      right.push(input[i]);
    }
  }

  // remember to put the pivot back in the middle
  return [...quickSort(left), pivot, ...quickSort(right)];
}

export default quickSort;

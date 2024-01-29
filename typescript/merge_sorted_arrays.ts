/**
 * Merges two sorted number arrays
 * @param array1 - first sorted array in ascending order
 * @param array2 - second sorted array in ascending order
 * @returns merged sorted array
 */
function mergeSortedArrays(array1: number[], array2: number[]): number[] {
  const mergedArray: number[] = [];
  let i = 0;
  let j = 0;

  while (i < array1.length && j < array2.length) {
    if (array1[i] < array2[j]) {
      mergedArray.push(array1[i]);
      i++;
    } else {
      mergedArray.push(array2[j]);
      j++;
    }
  }

  // spread remaining elements from array1 or array2 from where we left off
  return [...mergedArray, ...array1.slice(i), ...array2.slice(j)];
}

export default mergeSortedArrays;

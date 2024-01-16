// assume that both arrays are sorted in ascending order

function merge2SortedArrays(array1: number[], array2: number[]): number[] {
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

  // push remaining elements from array1, if any
  while (i < array1.length) {
    mergedArray.push(array1[i]);
    i++;
  }

  // push remaining elements from array2, if any
  while (j < array2.length) {
    mergedArray.push(array2[j]);
    j++;
  }

  return mergedArray;
}

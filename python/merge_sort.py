from typing import List

import merge_sorted_lists as utils

'''
Merge sort algorithm.

Parameters:
list (List[int]): List of numbers to sort.

Returns:
(List[int]): Sorted list of numbers.
'''
def merge_sort(list: List[int]) -> List[int]:
  if(len(list) <= 1):
    return list
  
  middle = len(list) // 2 # using floor division
  left = list[:middle]
  right = list[middle:]

  return utils.merge_sorted_lists(merge_sort(left), merge_sort(right))

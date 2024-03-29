from typing import List

'''
This function takes two sorted lists and merges them into a single sorted list.

Parameters:
list1 (List[int]): The first list of numbers sorted in ascending order.
list2 (List[int]): The second list of numbers sorted in ascending order.

Returns:
(List[int]): The sum of the two numbers.
'''
def merge_sorted_lists(list1: List[int], list2: List[int]) -> List[int]:
  size1 = len(list1)
  size2 = len(list2)
  merged_list = []
  i = 0
  j = 0

  while i < size1 and j < size2:
    if list1[i] < list2[j]:
      merged_list.append(list1[i])
      i += 1
    else:
      merged_list.append(list2[j])
      j += 1
  
  # append remaining elements
  merged_list += list1[i:]
  merged_list += list2[j:]
  
  return merged_list
'''
the file is named "merge 2 sorted arrays" for consistency
assume that both lists are sorted in ascending order
'''

def merge_2_sorted_lists(list1, list2):
  size1 = len(list1)
  size2 = len(list2)
  merged_array = []
  i = 0
  j = 0

  while i < size1 and j < size2:
    if list1[i] < list2[j]:
      merged_array.append(list1[i])
      i += 1
    else:
      merged_array.append(list2[j])
      j += 1
  
  # append remaining elements from list1, if any
  while i < size1:
    merged_array.append(list1[i])
    i += 1

  # append remaining elements from list2, if any
  while j < size2:
    merged_array.append(list2[j])
    j += 1
  
  return merged_array
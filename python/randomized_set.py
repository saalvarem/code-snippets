import random
from typing import Dict, List, Union

'''
A "set" data structure that can return a value at random.
'''
class RandomizedSet:
  __slots__ = ['set', 'list']
  
  def __init__(self, initial_list = None):
    self.set: Dict[Union[int, str], int] = {} # { [key: value]: [value: index] }
    self.list: List[Union[int, str]] = []

    if initial_list is not None:
      self.list = []
      for value in initial_list:
        self.add(value)
  

  '''
  Returns:
  (Union[int, str]): a random value from the set or None.
  '''
  def get_random(self) -> Union[int, str]:
    list_length = len(self.list)
    
    if (list_length < 1):
      return None

    random_index = random.randint(0, list_length - 1)
    return self.list[random_index]


  '''
  Adds a value to the set
  Parameters:
  value (Union[int, str]): Value to add to the set
  Returns:
  (bool): True if the value was added to the set, False if the value already exists in the set
  '''
  def add(self, value: Union[int, str]) -> bool:
    if value in self.set:
      return False
    
    self.set[value] = len(self.list)
    self.list.append(value)
    return True


  '''
  Clears the set
  '''
  def clear(self) -> None: # None is used to indicate that the function does not return anything
    self.set = {}
    self.list = []


  '''
  Deletes a value from the set
  Parameters:
  value (Union[int, str]): Value to delete from the set
  Returns:
  (bool) True if the value was deleted from the set, False if the value does not exist in the set
  '''
  def delete(self, value: Union[int, str]) -> bool:
    if value not in self.set:
      return False

    index = self.set[value]
    self.list[index] = self.list[-1]
    self.set[self.list[index]] = index
    self.list.pop()
    del self.set[value]
    return True

  '''
  Returns:
  (List[Union[int, str]]) the values in the set in no particular order
  '''
  def entries(self) -> List:
    return self.list

  '''
  Parameters:
  value (Union[int, str]): Value to check
  Returns:
  (bool) True if the value exists in the set, False otherwise
  '''
  def has(self, value: Union[int, str]) -> bool:
    return value in self.set

  '''
  Returns:
  (int) The size of the set
  '''
  def size(self) -> int:
    return len(self.set)

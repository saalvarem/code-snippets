using System;
using System.Collections.Generic;

/// <summary>
/// A "set" data structure that can return a value at random.
/// </summary>
/// <typeparam name="T">integers, float or strings</typeparam>
class RandomizedSet<T>
{
    private readonly Dictionary<T, int> set;
    private readonly List<T> array;
    private Random random;

    public RandomizedSet()
    {
        this.set = new();
        this.array = new();
        this.random = new();
    }

    /// <returns>a random value from the set</returns>
    public T GetRandom()
    {
        int randomIndex = this.random.Next(this.array.Count);
        return this.array[randomIndex];
    }

    /// <summary>
    /// Adds a value to the set
    /// </summary>
    /// <param name="value">value to add to the set</param>
    /// <returns>true if a value was added to a set, false if the set already contained the value</returns>
    public bool Add(T value)
    {
        if (this.set.ContainsKey(value))
        {
            return false;
        }

        this.set.Add(value, this.array.Count);
        this.array.Add(value);
        return true;
    }

    /// <summary>
    ///  Clears the set
    /// </summary>
    public void Clear()
    {
        this.set.Clear();
        this.array.Clear();
    }

    /// <summary>
    /// Removes a value from the set
    /// </summary>
    /// <param name="value">value to delete from the set</param>
    /// <returns>true if the value was removed from the set, false if the value does not exist in the set</returns>
    public bool Remove(T value)
    {
        if (this.set.ContainsKey(value))
        {
            int index = this.set[value];
            this.array[index] = this.array[this.array.Count - 1];
            this.set[this.array[index]] = index;
            this.set.Remove(value);
            this.array.RemoveAt(this.array.Count - 1);
            return true;
        }
        return false;
    }

    /// <returns>the values in the set in no particular order</returns>
    public List<T> Entries()
    {
        return this.array;
    }

    /// <param name="value">value to check</param>
    /// <returns>True if the value exists in the set, false otherwise</returns>
    public bool Contains(T value)
    {
        return this.set.ContainsKey(value);
    }

    /// <returns>the size of the set</returns>
    public int Count()
    {
        return this.set.Count;
    }
}

/**
 * A "set" data structure that can return a value at random.
 */
class RandomizedSet<T extends number | string> {
  private set: { [value in T]: number }; // {[value]: [index in array]}
  private array: Array<T>;

  constructor() {
    this.set = {} as { [value in T]: number };
    this.array = [];
  }

  /**
   * @returns a random value from the set
   */
  getRandom(): T {
    const randomIndex = Math.floor(Math.random() * this.array.length);
    return this.array[randomIndex];
  }

  /**
   * Adds a value to the set
   * @param value - value to add to the set
   * @returns true if the value was added to the set, false if the value already exists in the set
   */
  add(value: T): boolean {
    if (typeof this.set[value] === "number") {
      return false;
    }

    this.set[value] = this.array.length;
    this.array.push(value);
    return true;
  }

  /**
   * Clears the set
   */
  clear(): void {
    this.set = {} as { [value in T]: number };
    this.array = [];
  }

  /**
   * Deletes a value from the set
   * @param value - value to delete from the set
   * @returns true if the value was deleted from the set, false if the value does not exist in the set
   */
  delete(value: T): boolean {
    const index = this.set[value];
    if (typeof index !== "undefined") {
      this.array[index] = this.array[this.array.length - 1];
      this.set[this.array[index]] = index;
      delete this.set[value];
      this.array.pop();
      return true;
    }
    return false;
  }

  /**
   * @returns the entries in the set in no particular order
   */
  entries(): T[] {
    return this.array;
  }

  /**
   * Returns true if the value exists in the set
   * @param value - value to check
   */
  has(value: T): boolean {
    return typeof this.set[value] !== "undefined";
  }

  /**
   * @returns the size of the set
   */
  size(): number {
    return this.array.length;
  }
}

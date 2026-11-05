/*
 Design a data structure that follows the constraints of a Least Recently Used (LRU) cache.

Implement the LRUCache class:

LRUCache(int capacity) Initialize the LRU cache with positive size capacity.
int get(int key) Return the value of the key if the key exists, otherwise return -1.
void put(int key, int value) Update the value of the key if the key exists. Otherwise, add the key-value pair to the cache. If the number of keys exceeds the capacity from this operation, evict the least recently used key.
The functions get and put must each run in O(1) average time complexity.

 

Example 1:

Input
["LRUCache", "put", "put", "get", "put", "get", "put", "get", "get", "get"]
[[2], [1, 1], [2, 2], [1], [3, 3], [2], [4, 4], [1], [3], [4]]
Output
[null, null, null, 1, null, -1, null, -1, 3, 4]

Explanation
LRUCache lRUCache = new LRUCache(2);
lRUCache.put(1, 1); // cache is {1=1}
lRUCache.put(2, 2); // cache is {1=1, 2=2}
lRUCache.get(1);    // return 1
lRUCache.put(3, 3); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
lRUCache.get(2);    // returns -1 (not found)
lRUCache.put(4, 4); // LRU key was 1, evicts key 1, cache is {4=4, 3=3}
lRUCache.get(1);    // return -1 (not found)
lRUCache.get(3);    // return 3
lRUCache.get(4);    // return 4
 
 */

LRUCache lRUCache = new LRUCache(2);
lRUCache.Put(1, 1); // cache is {1=1}
lRUCache.Put(2, 2); // cache is {1=1, 2=2}
Console.WriteLine(lRUCache.Get(1));    // return 1
lRUCache.Put(3, 3); // LRU key was 2, evicts key 2, cache is {1=1, 3=3}
Console.WriteLine(lRUCache.Get(2));    // returns -1 (not found)
lRUCache.Put(4, 4); // LRU key was 1, evicts key 1, cache is {4=4, 3=3}
Console.WriteLine(lRUCache.Get(1));    // return -1 (not found)
Console.WriteLine(lRUCache.Get(3));    // return 3
Console.WriteLine(lRUCache.Get(4));    // return 4
lRUCache.Put(5, 5); // LRU key was 3, evicts key 3, cache is {4=4, 5=5}
Console.WriteLine(lRUCache.Get(3));    // return -1 (not found)
Console.WriteLine(lRUCache.Get(4));    // return 4

public class LRUCache
{
    private int capacity;

    // Stores key → value
    private Dictionary<int, int> cache = new();

    // Stores key → node
    private Dictionary<int, LinkedListNode<int>> nodes = new();

    // Tracks most recently used keys
    private LinkedList<int> list = new();

    public LRUCache(int capacity)
    {
        this.capacity = capacity;
    }

    public int Get(int key)
    {
        if (!cache.ContainsKey(key))
            return -1;

        // Move the key to the front
        list.Remove(nodes[key]);
        list.AddFirst(nodes[key]);

        return cache[key];
    }

    public void Put(int key, int value)
    {
        // If key exists, update it
        if (cache.ContainsKey(key))
        {
            cache[key] = value;
            Get(key); // Moves it to the front
            return;
        }

        // If full, remove least recently used
        if (cache.Count == capacity)
        {
            int oldest = list.Last!.Value;

            list.RemoveLast();
            cache.Remove(oldest);
            nodes.Remove(oldest);
        }

        // Add new key
        cache[key] = value;
        nodes[key] = list.AddFirst(key);
    }
}

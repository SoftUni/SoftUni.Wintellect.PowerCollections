# Wintellect Power Collections

**Wintellect Power Collections** is a community project to develop the best public license type-safe collection classes for .NET. Power Collections implements **classical data structures** (lists, sets, bags, dictionaries) in C#, which are well **optimized for performance**, and makes heavy use of .NET generics. The goal of the project is to provide generic high-performance collection classes that are not available in .NET standard library.

Data structures, implemented in PowerCollections:
  - `Set<T>`: a collection of items (maintained in unpredictable order). Duplicate items are not allowed.
  - `Bag<T>`: a collection of items, which allows duplicates. Similar to `Set<T>` but allows duplicates.
  - `BigList<T>`: a list of items, optimized for efficient operations on large lists (especially for insertions, deletions, copies, and concatenations).
  - `Deque<T>`: implementation of Deque (Double Ended Queue), with efficient inserting elements at the beginning and at the end.
  - `MultiDictionary<TKey, TValue>`: a dictionary collection, which associates multiple values with a key. Lookup by key returns an enumeration of items.
  - `OrderedSet<T>`: a collection of items, maintained in a sorted order (duplicates are not allowed). Each item has an index in the set (0...`Count`-1). Provides efficient sub-range extraction.
  - `OrderedBag<T>`: a collection of items, maintained in a sorted order, with duplicates. Provides efficient sub-range extraction.
  - `OrderedDictionary<TKey, TValue>`: a dictionary collection that associates keys to values. The keys are maintained in a sorted order. Provides efficient sub-range extraction.
  - `OrderedMultiDictionary<TKey, TValue>`: a dictionary collection that associates multiple values with a key. The keys are maintained in a sorted order. Lookup by key returns an enumeration of items. Provides efficient sub-range extraction.

The above ordered collections are based on the "**red–black tree**" data structure. The unordered dictionary collections are bsed on the "**hash-table**" data structure.

This package was initially published in 2015 for the purpose of the Software University's data structures and algorithms classes at SoftUni, but it can be used a general-purpose data structure library for any .NET project.

This library was originally produced by Wintellect and is offered AS IS. It has been available on the Wintellect site for some time, later moved to Codeplex to encourage its growth and use, and then it was lost with the shutdown of Codeplex. Power Collections is free for all to use within the bounds of the standard Eclipse Public License (EPL).

The code is originally written by Peter Golde (at Wintellect, in the period 2004-2007), then evolved in the open-source community.

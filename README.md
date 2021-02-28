# Wintellect Power Collections

**Wintellect Power Collections** is a community project to develop the best public license type-safe collection classes for .NET. Power Collections implements **classical data structures** (lists, sets, bags, dictionaries) in C#, which are well **optimized for performance**, and makes heavy use of .NET generics. The goal of the project is to provide generic high-performance collection classes that are not available in .NET standard library.

## Data Structures, Implemented in PowerCollections
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

## Getting Started

First, install the NuGet package [`SoftUni.Wintellect.PowerCollections`](https://www.nuget.org/packages/SoftUni.Wintellect.PowerCollections/):

```
Install-Package SoftUni.Wintellect.PowerCollections
```

Now you are ready to use the collection classes from the namespace `Wintellect.PowerCollections`.

Dont' forget to import the namespace `Wintellect.PowerCollections` at the start of your C# code:
```cs
using Wintellect.PowerCollections;
```

### Wintellect.PowerCollections.Bag<T>: Example
```cs
Console.WriteLine("Wintellect.PowerCollections.Bag<T> example:");
Console.WriteLine("Elements will enter in the bag with duplicates.");
Bag<string> bag = new Bag<string>();
bag.Add("programming");
bag.Add("C#");
bag.Add("Visual Studio");
bag.Add("dotnet");
bag.Add("C#"); // Duplicates are allowed
bag.Add("C#"); // Duplicates are allowed
Console.WriteLine("Contains `dotnet`: {0}", bag.Contains("dotnet"));
Console.WriteLine("Deleted the first `C#` occurence: " + bag.Remove("C#"));
Console.WriteLine("Elements: {0}", bag);  
```
The above code will produce the following **output**:
```
Wintellect.PowerCollections.Bag<T> example:
Elements will enter in the bag with duplicates.
Contains `dotnet`: True
Deleted the first `C#` occurence: True
Elements: {dotnet,C#,C#,programming,Visual Studio}
```
  
### Wintellect.PowerCollections.OrderedBag<T>: Example
```cs
Console.WriteLine("Wintellect.PowerCollections.OrderedBag<T> example:");
Console.WriteLine("Elements will enter in the bag with duplicates, in ascending order.");
OrderedBag<string> bag = new OrderedBag<string>();
bag.Add("programming");
bag.Add("C#");
bag.Add("Visual Studio");
bag.Add("dotnet");
bag.Add("C#"); // Duplicates are allowed
bag.Add("C#"); // Duplicates are allowed
Console.WriteLine("Contains `dotnet`: {0}", bag.Contains("dotnet"));
Console.WriteLine("Deleted the first `C#` occurence: " + bag.Remove("C#"));
Console.WriteLine("Elements: {0}", bag);
Console.WriteLine("Range[`d`...`q`]: {0}", bag.Range("d", true, "q", true));
```
The above code will produce the following **output**:
```
Wintellect.PowerCollections.OrderedBag<T> example:
Elements will enter in the bag with duplicates, in ascending order.
Contains `dotnet`: True
Deleted the first `C#` occurence: True
Elements: {C#,C#,dotnet,programming,Visual Studio}
Range[`d`...`q`]: {dotnet,programming}
```
  
### Wintellect.PowerCollections.Set<T>: Example
```cs
Console.WriteLine("Wintellect.PowerCollections.Set<T> example:");
Console.WriteLine("Duplicates will be skipped when adding elements.");
Set<string> set = new Set<string>();
set.Add("programming");
set.Add("C#");
set.Add("Visual Studio");
set.Add("dotnet");
set.Add("C#"); // Duplicates will be skipped
set.Add("C#"); // Duplicates will be skipped
Console.WriteLine("Contains `dotnet`: {0}", set.Contains("dotnet"));
Console.WriteLine("Deleted the first `C#` occurence: " + set.Remove("C#"));
```
The above code will produce the following **output**:
```
Wintellect.PowerCollections.Set<T> example:
Duplicates will be skipped when adding elements.
Contains `dotnet`: True
Deleted the first `C#` occurence: True
Elements: {dotnet,programming,Visual Studio}
```

### Wintellect.PowerCollections.OrderedSet<T>: Example
```cs
Console.WriteLine("Wintellect.PowerCollections.OrderedSet<T> example:");
Console.WriteLine("Duplicates will be skipped when adding elements. Elements will maintain ascending order.");
OrderedSet<string> set = new OrderedSet<string>();
set.Add("programming");
set.Add("C#");
set.Add("Visual Studio");
set.Add("dotnet");
set.Add("C#"); // Duplicates will be skipped
set.Add("C#"); // Duplicates will be skipped
Console.WriteLine("Contains `dotnet`: {0}", set.Contains("dotnet"));
Console.WriteLine("Deleted the first `C#` occurence: " + set.Remove("C#"));
Console.WriteLine("Elements: {0}", set);
Console.WriteLine("Range[`d`...`q`]: {0}", set.Range("d", true, "q", true));
```
The above code will produce the following **output**:
```
Wintellect.PowerCollections.OrderedSet<T> example:
Duplicates will be skipped when adding elements. Elements will maintain ascending order.
Contains `dotnet`: True
Deleted the first `C#` occurence: True
Elements: {dotnet,programming,Visual Studio}
Range[`d`...`q`]: {dotnet,programming}
```

### Wintellect.PowerCollections.BigList<T>: Example
```cs
Console.WriteLine("Wintellect.PowerCollections.BigList<T> example:");
Console.WriteLine("Elements will retain their insertion order.");
BigList<string> list = new BigList<string>();
list.Add("programming");
list.Add("C#");
list.Add("Visual Studio");
list.Add("dotnet");
list.Add("C#"); // Duplicates are allowed (at different index)
list.Add("C#"); // Duplicates are allowed (at different index)
Console.WriteLine("Elements: {0}", list);
Console.WriteLine("Elements[2]: {0}", list[2]);
list.RemoveAt(2);
Console.WriteLine("Deleted list[2]");
list.Insert(1, "TypeScript");
Console.WriteLine("Added `TypeScript` at position 1");
Console.WriteLine("Elements: {0}", list);
```
The above code will produce the following **output**:
```
Wintellect.PowerCollections.BigList<T> example:
Elements will retain their insertion order.
Elements: {programming,C#,Visual Studio,dotnet,C#,C#}
Elements[2]: Visual Studio
Deleted list[2]
Added `TypeScript` at position 1
Elements: {programming,TypeScript,C#,dotnet,C#,C#}
```

### Wintellect.PowerCollections.Deque<T>: Example
```cs
Console.WriteLine("Wintellect.PowerCollections.Deque<T> example:");
Console.WriteLine("Elements will retain their insertion order. Elements can be added at both ends of the deque.");
Deque<string> list = new Deque<string>();
list.AddToBack("programming");
list.AddToBack("C#");
list.AddToFront("Visual Studio");
list.AddToBack("dotnet");
list.AddToFront("C#"); // Duplicates are allowed (at different index)
list.AddToBack("C#"); // Duplicates are allowed (at different index)
Console.WriteLine("Elements: {0}", list);
Console.WriteLine("Removed element from front: {0}", list.RemoveFromFront());
Console.WriteLine("Removed element from back: {0}", list.RemoveFromBack());
Console.WriteLine("Elements: {0}", list);
```
The above code will produce the following **output**:
```
Wintellect.PowerCollections.Deque<T> example:
Elements will retain their insertion order. Elements can be added at both ends of the deque.
Elements: {C#,Visual Studio,programming,C#,dotnet,C#}
Removed element from front: C#
Removed element from back: C#
Elements: {Visual Studio,programming,C#,dotnet}
```

### Wintellect.PowerCollections.MultiDictionary<K, V>: Example
```cs
Console.WriteLine("Wintellect.PowerCollections.MultiDictionary<K, V> example:");
Console.WriteLine("Map keys to multiple values. Keys order is unpredictable. Values keep their insertion order.");
MultiDictionary<string, int> score = new MultiDictionary<string, int>(true);
score.Add("Peter", 5);
score.Add("Peter", 6);
score.Add("Peter", 6);
score.AddMany("Maria", new int[] { 5, 4, 5, 4, 6 });
score.AddMany("George", new int[] { 6, 6, 5, 5 });
Console.WriteLine("Elements: {0}", score);
Console.WriteLine("Removed element `Maria -> 4`: {0}", score.Remove("Maria", 4));
Console.WriteLine("Elements: {0}", score);
```
The above code will produce the following **output**:
```
Wintellect.PowerCollections.MultiDictionary<K, V> example:
Map keys to multiple values. Keys order is unpredictable. Values keep their insertion order.
Elements: {Maria->(5,4,5,4,6), Peter->(5,6,6), George->(6,6,5,5)}
Removed element `Maria -> 4`: True
Elements: {Maria->(5,4,5,6), Peter->(5,6,6), George->(6,6,5,5)}
```

### Wintellect.PowerCollections.OrderedDictionary<K, V>: Example
```cs
Console.WriteLine("Wintellect.PowerCollections.OrderedDictionary<K, V> example:");
Console.WriteLine("Map keys to values (no duplicates). Keys are ordered in ascending order.");
OrderedDictionary<string, double> ratings = new OrderedDictionary<string, double>();
ratings.Add("Peter", 8.5);
ratings.Add("Maria", 9.7);
ratings.Add("George", 7.6);
ratings.Add("Paula", 9.2);
ratings.Add("Steve", 7.7);
Console.WriteLine("Elements: {0}", ratings);
Console.WriteLine("Range[`k`...`r`]: {0}", ratings.Range("k", true, "r", true));
Console.WriteLine("Removed element `Maria`: {0}", ratings.Remove("Maria"));
Console.WriteLine("Elements: {0}", ratings);
```
The above code will produce the following **output**:
```
Wintellect.PowerCollections.OrderedDictionary<K, V> example:
Map keys to values (no duplicates). Keys are ordered in ascending order.
Elements: {George->7.6, Maria->9.7, Paula->9.2, Peter->8.5, Steve->7.7}
Range[`k`...`r`]: {Maria->9.7, Paula->9.2, Peter->8.5}
Removed element `Maria`: True
Elements: {George->7.6, Paula->9.2, Peter->8.5, Steve->7.7}
```

### Wintellect.PowerCollections.OrderedMultiDictionary<K, V>: Example
```cs
Console.WriteLine("Wintellect.PowerCollections.OrderedMultiDictionary<K, V> example:");
Console.WriteLine("Map keys to multiple values. Keys are ordered in ascending order. Values keep their insertion order.");
OrderedMultiDictionary<string, int> score = 
    new OrderedMultiDictionary<string, int>(true);
score.Add("Peter", 5);
score.Add("Peter", 6);
score.Add("Peter", 6);
score.AddMany("Maria", new int[] { 5, 5, 4, 6 });
score.AddMany("George", new int[] { 6, 6, 5 });
score.AddMany("Paula", new int[] { 6, 6, 5, 6 });
score.AddMany("Steve", new int[] { 5, 6 });
Console.WriteLine("Elements: {0}", score);
Console.WriteLine("Removed element `Maria -> 4`: {0}", score.Remove("Maria", 4));
Console.WriteLine("Elements: {0}", score);
Console.WriteLine("Range[`k`...`r`]: {0}", score.Range("k", true, "r", true));
```
The above code will produce the following **output**:
```
Wintellect.PowerCollections.OrderedMultiDictionary<K, V> example:
Map keys to multiple values. Keys are ordered in ascending order. Values keep their insertion order.
Elements: {George->(5,6,6), Maria->(4,5,5,6), Paula->(5,6,6,6), Peter->(5,6,6), Steve->(5,6)}
Removed element `Maria -> 4`: True
Elements: {George->(5,6,6), Maria->(5,5,6), Paula->(5,6,6,6), Peter->(5,6,6), Steve->(5,6)}
Range[`k`...`r`]: {Maria->(5,5,6), Paula->(5,6,6,6), Peter->(5,6,6)}
```

## SoftUni.Wintellect.PowerCollections NuGet Package

This package was initially published in 2015 for the purpose of the Software University's data structures and algorithms classes at SoftUni, but it can be used a general-purpose data structure library for any .NET project.

This library was originally produced by Wintellect and is offered AS IS. It has been available on the Wintellect site for some time, later moved to Codeplex to encourage its growth and use, and then it was lost with the shutdown of Codeplex. Power Collections is free for all to use within the bounds of the standard Eclipse Public License (EPL).

The code is originally written by Peter Golde (at Wintellect, in the period 2004-2007), then evolved in the open-source community.

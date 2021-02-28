using System;

namespace Wintellect.PowerCollections.Examples
{
    class PowerCollectionsExamples
    {
        static void Main()
        {
            BagExample();
            Console.WriteLine();
            OrderedBagExample();
            Console.WriteLine();
            SetExample();
            Console.WriteLine();
            OrderedSetExample();
            Console.WriteLine();
            BigListExample();
            Console.WriteLine();
            DequeExample();
            Console.WriteLine();
            MultiDictionaryExample();
            Console.WriteLine();
            OrderedDictionaryExample();
            Console.WriteLine();
            OrderedMultiDictionaryExample();
        }

        static void BagExample()
        {
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
        }

        static void OrderedBagExample()
        {
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
        }

        static void SetExample()
        {
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
            Console.WriteLine("Elements: {0}", set);
        }

        static void OrderedSetExample()
        {
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
        }

        static void BigListExample()
        {
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
        }

        static void DequeExample()
        {
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
        }

        static void MultiDictionaryExample()
        {
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
        }

        static void OrderedDictionaryExample()
        {
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
        }

        static void OrderedMultiDictionaryExample()
        {
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
        }
    }
}

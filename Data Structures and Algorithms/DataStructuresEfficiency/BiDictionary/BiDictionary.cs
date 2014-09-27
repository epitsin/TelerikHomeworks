namespace BiDictionary
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class BiDictionary<K1, K2, T> : IEnumerable
    {
        private readonly MultiDictionary<K1, Tuple<K1, K2, T>> dictionaryFirstKey;

        private readonly MultiDictionary<K2, Tuple<K1, K2, T>> dictionarySecondKey;

        private readonly MultiDictionary<Tuple<K1, K2>, Tuple<K1, K2, T>> dictionaryFirstAndSecondKeys;

        public BiDictionary(bool allowDuplicates)
        {
            this.dictionaryFirstKey = new MultiDictionary<K1, Tuple<K1, K2, T>>(allowDuplicates);
            this.dictionarySecondKey = new MultiDictionary<K2, Tuple<K1, K2, T>>(allowDuplicates);
            this.dictionaryFirstAndSecondKeys = new MultiDictionary<Tuple<K1, K2>, Tuple<K1, K2, T>>(allowDuplicates);
        }

        public void Add(K1 firstKey, K2 secondKey, T value)
        {
            this.dictionaryFirstKey[firstKey].Add(new Tuple<K1, K2, T>(firstKey, secondKey, value));
            this.dictionarySecondKey[secondKey].Add(new Tuple<K1, K2, T>(firstKey, secondKey, value));
            this.dictionaryFirstAndSecondKeys[new Tuple<K1, K2>(firstKey, secondKey)].Add(new Tuple<K1, K2, T>(firstKey, secondKey, value));
        }

        public ICollection<T> FindByFirstKey(K1 key)
        {
            return this.dictionaryFirstKey[key].Select(x => x.Item3).ToList();
        }

        public ICollection<T> FindBySecondKey(K2 key)
        {
            return this.dictionarySecondKey[key].Select(x => x.Item3).ToList();
        }

        public ICollection<T> FindByFirstAndSecondKey(K1 firstKey, K2 secondKey)
        {
            return this.dictionaryFirstAndSecondKeys[new Tuple<K1, K2>(firstKey, secondKey)].Select(x => x.Item3).ToList();
        }

        public void RemoveByFirstKey(K1 key)
        {
            var values = this.dictionaryFirstKey[key];

            foreach (var tuple in values)
            {
                this.dictionarySecondKey.Remove(tuple.Item2, tuple);
                this.dictionaryFirstAndSecondKeys.Remove(new Tuple<K1, K2>(tuple.Item1, tuple.Item2), tuple);
            }

            this.dictionaryFirstKey.Remove(key);
        }

        public void RemoveBySecondKey(K2 key)
        {
            var values = this.dictionarySecondKey[key];

            foreach (var tuple in values)
            {
                this.dictionaryFirstKey.Remove(tuple.Item1, tuple);
                this.dictionaryFirstAndSecondKeys.Remove(new Tuple<K1, K2>(tuple.Item1, tuple.Item2), tuple);
            }

            this.dictionarySecondKey.Remove(key);
        }

        public void RemoveByFirstAndSecondKey(K1 firstKey, K2 secondKey)
        {
            var values = this.dictionaryFirstAndSecondKeys[new Tuple<K1, K2>(firstKey, secondKey)];

            foreach (var tuple in values)
            {
                this.dictionaryFirstKey.Remove(tuple.Item1, tuple);
                this.dictionarySecondKey.Remove(tuple.Item2, tuple);
            }

            this.dictionaryFirstAndSecondKeys.Remove(new Tuple<K1, K2>(firstKey, secondKey));
        }

        public void Clear()
        {
            this.dictionaryFirstKey.Clear();
            this.dictionarySecondKey.Clear();
            this.dictionaryFirstAndSecondKeys.Clear();
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in this.dictionaryFirstKey)
            {
                foreach (var child in item.Value)
                {
                    yield return child.Item3;
                }
            }
        }
    }
}

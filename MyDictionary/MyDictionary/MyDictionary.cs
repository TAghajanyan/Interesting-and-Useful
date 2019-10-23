using System.Collections.Generic;

namespace MyDictionary
{
    class MyDictionaryBase<TKey, TValue>
    {
        public MyDictionaryBase(TKey key, TValue value)
        {
            Key = key;
            Value = value;
        }

        public TKey Key { get; private set; }
        public TValue Value { get; set; }

    }

    public class MyDictionary<TKey, TValue>
    {
        LinkedList<MyDictionaryBase<TKey, TValue>> dictionary;
    }

}

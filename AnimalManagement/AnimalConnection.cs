using System;
using System.Collections.Generic;

namespace AnimalManagement
{
    public class AnimalConnection<T> where T: Animal
    {
        private List<T> _animals = new List<T>();

        public void Add(T obj)
        {
            _animals.Add(obj);
        }

        public void Remove(int index)
        {
            _animals.RemoveAt(index);
        }

        public void ShowInfomation()
        {
            foreach (var animal in _animals)
            {
                Console.WriteLine(animal.ToString());
                animal.Speak();
            }
        }
    }
}
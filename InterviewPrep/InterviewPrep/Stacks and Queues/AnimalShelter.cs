using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Stacks_and_Queues
{
    public class AnimalShelter
    {
        Queue<Animal> _catQueue;
        Queue<Animal> _dogQueue;

        int _thisAge = 0;
        public void AddAnimal(string type)
        {
            _thisAge++;
            if (type.Equals("Cat"))
            {
                Animal cat = new Animal(type, _thisAge);
                if (_catQueue == null)
                    _catQueue = new Queue<Animal>();

                _catQueue.Enqueue(cat);
            }

            if (type.Equals("Dog"))
            {
                Animal dog = new Animal(type,_thisAge);
                if (_dogQueue == null)
                    _dogQueue = new Queue<Animal>();

                _dogQueue.Enqueue(dog);
            }
        }

        public Animal BuyAnyAnimal()
        {
            int catAge = int.MaxValue;
            int dogAge = int.MaxValue;
            if (_dogQueue.Peek() != null)
            {
                Animal dog = _dogQueue.Peek();
                 dogAge = dog._age;
            }
            if (_catQueue.Peek() != null)
            {
                Animal dog = _catQueue.Peek();
                 catAge = dog._age;
            }

            if (dogAge > catAge)
               return _catQueue.Dequeue();

            return _dogQueue.Dequeue();
        }

        public Animal BuyCat()
        {
            if(_catQueue.Peek()!=null)
                return _catQueue.Dequeue();

            return null;
        }
        public Animal BuyDog()
        {
            if (_dogQueue.Peek() != null)
                return _dogQueue.Dequeue();

            return null;
        }
    }

    public class Animal
    {
        public string _type;
        public string _name;
        public int _age;
        public Animal(string type, int age)
        {
            _type = type;
            _age = age;
        }
    }

  
}

namespace Overriding
{
    class Program
    {
        static void Main(string[] args)
        {

            //method overriding = provides a new version of a method inherited from a parent class
            //                    inherited method must be: abstract, virtual, or already overriden
            //                    Used with ToString(), polymorphism 

            Dog dog = new Dog();
            Cat cat = new Cat();
            Cat lion = new Lion();

            dog.Speak();
            cat.Speak();
            lion.Speak();

            Console.ReadKey();
        }
    }
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brrr*");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *woof*");
        }
    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat goes meow");
        }

    }

    class Lion : Cat
    {
        public override void Speak()
        {
            Console.WriteLine("The lion roars");
        }
    }
}
namespace Array_of_objects
{
    class Program
    {
        static void Main(string[] args)
        {

            Car[] garage = { new Car("Mustang"), new Car("Corvette"), new Car("Lambo") };

            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }



            Car[] garage1 = new Car[3];

            Car car1 = new Car("Toyota");
            Car car2 = new Car("Honda");
            Car car3 = new Car("Dacia");

            garage1[0] = car1;
            garage1[1] = car2;
            garage1[2] = car3;

            Console.WriteLine(car1.model);
            Console.WriteLine(car2.model);
            Console.WriteLine(car3.model);


            Console.ReadKey();
        }
    }
    class Car
    {
        public String model;

        public Car(String model)
        {
            this.model = model;
        }
    }
}
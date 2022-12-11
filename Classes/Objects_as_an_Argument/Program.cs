namespace Objects_as_an_Argument
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Mustang", "red");

            Car car2 = Copy(car1);//copying the object called car1

            Console.WriteLine(car2.color + " " + car2.model);//and printed

            ChangeColor(car1, "Brown");//here in this line we change the color of the object car1

            Car car3 = Copy(car1);//and then we copy the object called car1 here in this code line

            Console.WriteLine(car3.color + " " + car3.model);//and printed again.

            Console.ReadKey();
        }

        public static void ChangeColor(Car car, String color)//we can use the objects as an argument
        {
            car.color = color;
        }

        public static Car Copy(Car car)
        {
            return new Car(car.model, car.color);
        }
    }
    class Car
    {
        public String model;
        public String color;

        public Car(String model, String color)
        {
            this.model = model;
            this.color = color;
        }
    }
}
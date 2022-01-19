using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            //var person1 = new Person();
            //person1.Name = "Jannat";
            //person1.Introduce("Someone");

            //var customer = new Customer();
            //var order = new Order();
            //order.a = 5;
            //customer.Orders.Add(order);
            //Console.WriteLine(customer.Orders[0].a);

            //var point = new Point(2, 6);
            //point.Move(new Point(6, 9));
            //Console.WriteLine("{0},{1}",point.x,point.y);

            //var calculator = new Calculator();
            //Console.WriteLine(calculator.Add(1, 2, 3, 4));

            //var student = new Student();
            //student.set(new DateTime(1990, 4, 8));
            //Console.WriteLine(student.get());

            //var employee = new employee(new DateTime(1999, 11, 30));
            //Console.WriteLine(employee.Age);

            //var cookie = new HttpCookie();
            //cookie["name"] = "Jannat";
            //Console.WriteLine(cookie["name"]);

            //var text = new Text();
            //text.width = 100;
            //text.Copy();

            //var migrate = new Db(new Logger());
            //var install = new Installer(new Logger());
            //migrate.Migrate();
            //install.Install();

            //var car = new Car("678h");

            //Sentence sentence = new Sentence();
            //Shape shape = sentence;
            //sentence.width = 100;
            //shape.width = 900;
            //Console.WriteLine(sentence.width);

            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());
            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
            Console.ReadKey();
        }
    }
}

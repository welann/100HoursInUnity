using System;
using System.Collections.Generic;

namespace CSlearning
{
    public class Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }
   
        // 虚方法
        public virtual void Draw()
        {
            Console.WriteLine("执行基类的画图任务");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("画一个圆形");
            base.Draw();
        }
    }
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("画一个长方形");
            base.Draw();
        }
    }
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("画一个三角形");
            base.Draw();
        }
    }

    [AttributeUsage(AttributeTargets.All)]
    public class HelpAttribute : System.Attribute
    {
        public readonly string Url;

        public string Topic  // Topic 是一个命名（named）参数
        {
            get
            {
                return topic;
            }
            set
            {

                topic = value;
            }
        }

        public HelpAttribute(string url)  // url 是一个定位（positional）参数
        {
            this.Url = url;
        }

        private string topic;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 创建一个 List<Shape> 对象，并向该对象添加 Circle、Triangle 和 Rectangle
            var shapes = new List<Shape>
            {
                new Rectangle(),
                new Triangle(),
                new Circle()
            };

            // 使用 foreach 循环对该列表的派生类进行循环访问，并对其中的每个 Shape 对象调用 Draw 方法
            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            Console.WriteLine("按下任意键退出。");
            Console.ReadKey();
        }

    }
}
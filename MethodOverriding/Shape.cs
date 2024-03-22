namespace MethodOverriding
{
    internal class Shape
    {
        public int Width {  get; set; }
        public int Height { get; set; }


        public virtual void Draw()
        {
            Console.WriteLine("Start drawing...");
        }
    }

    internal class  Circle : Shape 
    {
       public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Drawing Circle...");
        }
    }

    internal class Rectangle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Drawing Rectangle...");
        }
    }
}

namespace P10.CarSalesman
{
    using System.Text;
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine, int weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public Car(string model, Engine engine, int weight) : this(model, engine, weight, "n/a")
        {
        }

        public Car(string model, Engine engine, string color) : this(model, engine, -1, color)
        {
        }

        public Car(string model, Engine engine) : this(model, engine, -1, "n/a")
        {
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder printFormat = new StringBuilder();
            printFormat.AppendLine($"{this.Model}:");
            printFormat.AppendLine($"  {this.Engine.Model}:");
            printFormat.AppendLine($"    Power: {this.Engine.Power}");
            if (this.Engine.Displacement == -1)
            {
                printFormat.AppendLine($"    Displacement: n/a");
            }
            else
            {
                printFormat.AppendLine($"    Displacement: {this.Engine.Displacement}");

            }
            printFormat.AppendLine($"    Efficiency: {this.Engine.Efficiency}");
            if (this.Weight == -1)
            {
                printFormat.AppendLine($"  Weight: n/a");
            }
            else
            {
                printFormat.AppendLine($"  Weight: {this.Weight}");
            }
            printFormat.Append($"  Color: {this.Color}");

            return printFormat.ToString();
        }
    }
}
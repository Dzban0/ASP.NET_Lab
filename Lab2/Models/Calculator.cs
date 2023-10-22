using Lab2.Controllers;

namespace Lab2.Models
{
    public class Calculator
    {
        public Operators? Operator { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }

        public String Op
        {
            get
            {
                switch (Operator)
                {
                    case Operators.ADD:
                        return "+";
                    case Operators.SUB:
                        return "-";
                    case Operators.MUL:
                        return "*";
                    case Operators.DIV:
                        return "/";
                    default:
                        return "";
                }
            }
        }

        public bool IsValid() => Operator != null && X != null && Y != null;

        public double Calculate()
        {
            switch (Operator)
            {
                case Operators.ADD:
                    return (double) (X + Y);
                case Operators.SUB:
                    return (double) (X - Y);
                case Operators.MUL:
                    return (double) (X * Y);
                case Operators.DIV:
                    return (double) (X / Y);
                default:
                    return double.NaN;
            }
        }
    }
}

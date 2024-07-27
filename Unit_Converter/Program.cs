namespace Unit_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Unit Converter!");
            Console.WriteLine("Please select the unit you want to convert from:");
            List<string> units = GetAvailableUnits();
            int fromUnitIndex = GetUserSelection(units);
            string fromUnit = units[fromUnitIndex];

            Console.WriteLine("Please select the unit you want to convert to:");
            int toUnitIndex = GetUserSelection(units);
            string toUnit = units[toUnitIndex];

            Console.WriteLine("Please enter the value you want to convert:");
            double value = Convert.ToDouble(Console.ReadLine());

            List<UnitConversion> conversions =
            [
            new UnitConversion("Meter", "Foot", 3.28084),
            new UnitConversion("Meter", "Kilometer", 0.001),
            new UnitConversion("Meter", "Centimeter", 100),
            new UnitConversion("Meter", "Millimeter", 1000),
            new UnitConversion("Meter", "Inch", 39.3701),
            new UnitConversion("Foot", "Meter", 0.3048),
            new UnitConversion("Foot", "Kilometer", 0.0003048),
            new UnitConversion("Foot", "Centimeter", 30.48),
            new UnitConversion("Foot", "Millimeter", 304.8),
            new UnitConversion("Foot", "Inch", 12),
            new UnitConversion("Kilometer", "Meter", 1000),
            new UnitConversion("Kilometer", "Foot", 3280.84),
            new UnitConversion("Kilometer", "Centimeter", 100000),
            new UnitConversion("Kilometer", "Millimeter", 1000000),
            new UnitConversion("Kilometer", "Inch", 39370.1),
            new UnitConversion("Centimeter", "Meter", 0.01),
            new UnitConversion("Centimeter", "Foot", 0.0328084),
            new UnitConversion("Centimeter", "Kilometer", 0.00001),
            new UnitConversion("Centimeter", "Millimeter", 10),
            new UnitConversion("Centimeter", "Inch", 0.393701),
            new UnitConversion("Millimeter", "Meter", 0.001),
            new UnitConversion("Millimeter", "Foot", 0.00328084),
            new UnitConversion("Millimeter", "Kilometer", 0.000001),
            new UnitConversion("Millimeter", "Centimeter", 0.1),
            new UnitConversion("Millimeter", "Inch", 0.0393701),
            new UnitConversion("Inch", "Meter", 0.0254),
            new UnitConversion("Inch", "Foot", 0.0833333),
            new UnitConversion("Inch", "Kilometer", 0.0000254),
            new UnitConversion("Inch", "Centimeter", 2.54),
            new UnitConversion("Inch", "Millimeter", 25.4),
            new UnitConversion("Celsius", "Kelvin", 273.15),
            new UnitConversion("Celsius", "Fahrenheit", 33.8),
            new UnitConversion("Kelvin", "Celsius", -273.15),
            new UnitConversion("Kelvin", "Fahrenheit", 255.37),
            new UnitConversion("Fahrenheit", "Celsius", -17.22),
            new UnitConversion("Fahrenheit", "Kelvin", 255.37),
            new UnitConversion("Square Meter", "Square Kilometer", 0.000001),
            new UnitConversion("Square Meter", "Square Foot", 10.7639),
            new UnitConversion("Square Meter", "Square Inch", 1550.003),
            new UnitConversion("Square Meter", "Hectare", 0.0001),
            new UnitConversion("Square Meter", "Acre", 0.000247105),
            new UnitConversion("Square Kilometer", "Square Meter", 1000000),
            new UnitConversion("Square Kilometer", "Square Foot", 10763910),
            new UnitConversion("Square Kilometer", "Square Inch", 15500030),
            new UnitConversion("Square Kilometer", "Hectare", 10000),
            new UnitConversion("Square Kilometer", "Acre", 247.105),
            new UnitConversion("Square Foot", "Square Meter", 0.092903),
            new UnitConversion("Square Foot", "Square Kilometer", 0.000092903),
            new UnitConversion("Square Foot", "Square Centimeter", 929.03),
            new UnitConversion("Square Foot", "Square Millimeter", 929030),
            new UnitConversion("Square Foot", "Square Inch", 144),
            new UnitConversion("Square Foot", "Hectare", 0.0092903),
            new UnitConversion("Square Foot", "Acre", 0.000022956),
            new UnitConversion("Square Inch", "Square Meter", 0.00064516),
            new UnitConversion("Square Inch", "Square Kilometer", 0.00000064516),
            new UnitConversion("Square Inch", "Square Foot", 0.0064516),
            new UnitConversion("Square Inch", "Square Centimeter", 6.4516),
            new UnitConversion("Square Inch", "Square Millimeter", 645.16),
            new UnitConversion("Hectare", "Square Meter", 10000),
            new UnitConversion("Hectare", "Square Kilometer", 0.01),
            new UnitConversion("Hectare", "Square Foot", 107639.1),
            new UnitConversion("Hectare", "Square Centimeter", 10000000),
            new UnitConversion("Hectare", "Square Millimeter", 100000000),
            new UnitConversion("Hectare", "Square Inch", 1550000),
            new UnitConversion("Hectare", "Acre", 2.47105),
            new UnitConversion("Acre", "Square Meter", 4046.86),
            new UnitConversion("Acre", "Square Kilometer", 0.00404686),
            new UnitConversion("Acre", "Square Foot", 43560),
            new UnitConversion("Acre", "Square Centimeter", 404686),
            new UnitConversion("Acre", "Square Millimeter", 40468600),
            new UnitConversion("Acre", "Square Inch", 6275200),
            new UnitConversion("Acre", "Hectare", 0.404686),

            // Add more conversion cases as needed
        ];

            double result = ConvertUnit(fromUnit, toUnit, value, conversions);
            Console.WriteLine($"The converted value is: {result}");
        }

        static List<string> GetAvailableUnits()
        {
            List<string> units = new()
            {
            "Meter",
            "Foot",
            "Kilometer",
            "Centimeter",
            "Inch",
            "Millimeter",
            "Celsius",
            "Kelvin",
            "Fahrenheit",
            "Square Meter",
            "Square Kilometer",
            "Square Centimeter",
            "Square Millimeter",
            "Square Foot",
            "Square Inch",
            "Hectare",
            "Acre",
            // Add more units as needed
        };
            return units;
        }

        static int GetUserSelection(List<string> units)
        {
            for (int i = 0; i < units.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {units[i]}");
            }
            int selection = Convert.ToInt32(Console.ReadLine()) - 1;
            return selection;
        }

        static double ConvertUnit(string fromUnit, string toUnit, double value, List<UnitConversion> conversions)
        {
            UnitConversion conversion = conversions.Find(c => c.FromUnit == fromUnit && c.ToUnit == toUnit);
            if (conversion != null)
            {
                return value * conversion.ConversionFactor;
            }

            return value; // Return the original value if no conversion is found
        }
    }

    class UnitConversion(string fromUnit, string toUnit, double conversionFactor)
    {
        public string FromUnit { get; set; } = fromUnit;
        public string ToUnit { get; set; } = toUnit;
        public double ConversionFactor { get; set; } = conversionFactor;
    }
}


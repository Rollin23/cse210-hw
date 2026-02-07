public class CircuitBoard
{
    public Battery PowerSource = new Battery();
    public Resistor Resistor = new Resistor();
    public LightBulb Bulb = new LightBulb();

    public void CalculateSafety()
    {
        Console.WriteLine("--- Circuit Analysis ---");
        Console.WriteLine($"Source: {PowerSource.Voltage}V");
        Console.WriteLine($"Target Current: {Bulb.RequiredCurrent}A");
        
        // Ohm's Law: I = V / R
        double actualCurrent = PowerSource.Voltage / Resistor.Resistance;

        Console.WriteLine($"Actual Current with {Resistor.Resistance} ohms: {actualCurrent}A");

        if (actualCurrent > Bulb.RequiredCurrent)
        {
            Console.WriteLine("DANGER: Current too high! The bulb will burn out.");
        }
        else if (actualCurrent < (Bulb.RequiredCurrent * 0.8)) // 20% margin
        {
            Console.WriteLine("NOTICE: Current too low. The bulb is dim.");
        }
        else
        {
            Console.WriteLine("SUCCESS: The resistor is the correct size!");
        }
    }
}

public class Battery
{
    public double Voltage;
}

public class Resistor
{
    public double Resistance;
}

public class LightBulb
{
    public double RequiredCurrent;
}
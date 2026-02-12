using System;
using System.Runtime.CompilerServices;

partial class Program
{
        CircuitBoard myCircuit = new CircuitBoard();
        
        // Setup the components
        myCircuit.PowerSource.Voltage = 12.0;      // 12V Battery
        myCircuit.Resistor.Resistance = 100.0;    // 100 Ohm Resistor
        myCircuit.Bulb.RequiredCurrent = 0.15;    // Bulb needs 0.15 Amps to shine

        // Perform the check
        myCircuit.CalculateSafety();
 }

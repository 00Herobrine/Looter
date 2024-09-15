using System;

public enum UnitSystem
{
    Imperial,
    Metric,
}

[Serializable]
public struct Caliber
{
    public float Diameter;
    public float Height;
    public UnitSystem Unit;

    public Caliber(float diameterInch, float heightInch)
    {
        Diameter = diameterInch; 
        Height = heightInch;
        Unit = UnitSystem.Imperial;
    }
    public Caliber(double diameterMM, double heightMM)
    {
        Diameter = (float)diameterMM;
        Height = (float)heightMM;
        Unit = UnitSystem.Metric;
    }

    public readonly bool IsCompatible(Caliber caliber) => Diameter <= caliber.Diameter;
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public enum Gender { Male, Famale };
class Cat
{
    private string name;
    private double _energy;
    public string Name { get; }
    public Gender catGender { get; }

    public double Energy
    {
        get { return _energy; }
        set
        {
            if (value > MaxEnergy)
            {
                _energy = MaxEnergy;
            }
            else if (value < MinEnergy)
            {
                Console.WriteLine("Not enough energy to jump");
            }
            else
            {
                this._energy = value;
            }
        }
    }

    public static readonly double MaxEnergy = 20;
    public static readonly double MinEnergy = 0;
    public static readonly double SleepEnergyGain = 10;
    public static readonly double JumpEnergyDrain = 0.5;

    public Cat(string Name, Gender gender)
    {
        this.name = Name;
        this.catGender = gender;
        Energy = MaxEnergy;
    }

    public void Jump()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Energy -= JumpEnergyDrain;

        Console.WriteLine($"{this.name} стрибнув, його енергія: {Energy}");
    }

    public void Sleep()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Energy += SleepEnergyGain;

        Console.WriteLine($"{this.name} ліг спати і тепер рівень його енергії становить: {Energy}");
    }

    public void CheckEnergy()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.InputEncoding = System.Text.Encoding.Unicode;

        Console.WriteLine($"Залишилось {Energy} енергії");
    }
}
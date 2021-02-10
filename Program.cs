using System;
using System.Collections.Generic;

namespace CS133PROJECT8
{
    class Program
    {
        static void Main(string[] args)
        {
            DMV dmv = new DMV();

            LincensePlateInfo firstLicensePlate = new LincensePlateInfo();

            firstLicensePlate.LincensePlate = "YHG567";
            firstLicensePlate.State = "TX";

            firstLicensePlate.LincensePlate = "IUE098";
            firstLicensePlate.State = "TX";

            LincensePlateInfo secondLicensePlate = new LincensePlateInfo();

            dmv.AddLincesPlate(firstLicensePlate);
            dmv.AddLincesPlate(secondLicensePlate);

        }
    }
}

public class DMV
{
   private HashSet<LincensePlateInfo> lincesPlates = new HashSet<LincensePlateInfo>();

    public void AddLincesPlate(LincensePlateInfo licensePlate)
    {
        bool lincesPlateAlreadyExists = licensePlate.Add(licensePlate);

        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.Red;
        if(!lincesPlateAlreadyExists)
        {
            Console.WriteLine("the linces Plate: " + licensePlate + " already exist");
        }
        else
        {
            Console.WriteLine("Linces Plate was added into  the sytem");
        }
    }
}
public class LincensePlateInfo
{
    public string LincensePlate { get; set; }

    public string State { get; set; }

    public override bool Equals(object obj)
    {
        LincensePlateInfo comparerLincesPlate = obj as LincensePlateInfo;

        return this.LincensePlate.Equals(comparerLincesPlate.LincensePlate);
    }
    public override int GetHashCode()
    {
        return this.LincensePlate.GetHashCode();
    }

    internal bool Add(LincensePlateInfo licensePlate)
    {
        throw new NotImplementedException();
    }
}

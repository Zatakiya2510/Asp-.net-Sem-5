using System;

namespace Lab_3
{
    public class Hospital
    {
        public virtual void HospitalDetails(string name, int hospitalBeds)
        {
            Console.WriteLine("Hospital: " + name + " has " + hospitalBeds + " beds.");
        }
    }

    public class Apollo : Hospital
    {
        public override void HospitalDetails(string name, int hospitalBeds)
        {
            base.HospitalDetails(name, hospitalBeds);
            Console.WriteLine("Apollo Hospital Details: " + name + " = " + hospitalBeds);
        }
    }

    public class Wockhardt : Hospital
    {
        public override void HospitalDetails(string name, int hospitalBeds)
        {
            base.HospitalDetails(name, hospitalBeds);
            Console.WriteLine("Wockhardt Hospital Details: " + name + " = " + hospitalBeds);
        }
    }

    public class GokulSuperspeciality : Hospital
    {
        public override void HospitalDetails(string name, int hospitalBeds)
        {
            base.HospitalDetails(name, hospitalBeds);
            Console.WriteLine("Gokul Superspeciality Hospital Details: " + name + " = " + hospitalBeds);
        }
    }
}

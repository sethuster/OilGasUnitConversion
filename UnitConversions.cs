using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Golem.White.ScreenObjects.LQP.LQP_Functionality
{
    public static class UnitConversions
    {
        public static class Length
        {
            public static double InchesToMM(double inches)
            {
                double milimeters = inches/0.03937;
                return milimeters;
            }

            public static double InchesToMeters(double inches)
            {
                double meters = inches*0.0254;
                return meters;
            }

            public static double InchesToFeet(double inches)
            {
                double feet = inches/12;
                return feet;
            }

            public static double FeetToInches(double feet)
            {
                double inches = feet*12;
                return inches;
            }

            public static double FeetToMM(double feet)
            {
                double milimeters = feet/0.0032808;
                return milimeters;
            }

            public static double FeetToMeters(double feet)
            {
                double meters = feet/3.2808;
                return meters;
            }
        }

        public static class Velocity
        {
            public static double FeetPSintoInchesPS(double ftsec)
            {
                //Same as Feet to Inches
                return Length.FeetToInches(ftsec);
            }

            public static double FeetPSintoMetersPS(double ftsec)
            {
                return Length.FeetToMeters(ftsec);
            }

            public static double FeetPSintoKPH(double ftsec)
            {
                double KPH = ftsec*1.09728;
                return KPH;
            }

            public static double FeetPSintoMPH(double ftsec)
            {
                double MPH = ftsec*0.681818182;
                return MPH;
            }

            public static double InchesPSintoFeetPS(double inchsec)
            {
                double FeetPS = Length.InchesToFeet(inchsec);
                return FeetPS;
            }


            
        }

        public double Circumference(double radius)
        {
            //placeholder for circumference C = 2pi * r

            return new double();
        }


    }
}

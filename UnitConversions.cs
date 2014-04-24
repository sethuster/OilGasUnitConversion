using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gallio.Runner.Reports.Schema;

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

            public static double MetersToFeet(double meters)
            {
                double feet = meters*3.28084;
                return feet;
            }

            public static double MetersToInches(double meters)
            {
                double inches = meters*39.3701;
                return inches;
            }

            public static double MetersToMM(double meters)
            {
                double milimeters = meters*1000;
                return milimeters;
            }
        }

        public static class Velocity
        {
            public static double FeetPSintoInchesPS(double ftsec)
            {
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

            public static double InchesPSintoKPH(double inchsec)
            {
                double KPH = inchsec*0.09144;
                return KPH;
            }

            public static double InchesPSintoMPH(double inchsec)
            {
                double MPH = inchsec*0.0568181;
                return MPH;
            }

            public static double InchesPSintoMetersPS(double inchsec)
            {
                double MetersPS = inchsec*0.0254;
                return MetersPS;
            }

            public static double KPHintoFeetPS(double KPH)
            {
                double feetPS = KPH*0.911344;
                return feetPS;
            }

            public static double KPHintoInchPS(double KPH)
            {
                double inchPS = KPH*10.936133;
                return inchPS;
            }

            public static double KPHintoMetersPS(double KPH)
            {
                double metersPS = KPH*0.277778;
                return metersPS;
            }

            public static double KPHintoMPH(double KPH)
            {
                double MPH = KPH*0.621371;
                return MPH;
            }

            public static double MetersPSintoFeetPS(double Metersec)
            {
                double feetps = Metersec*3.28084;
                return feetps;
            }

            public static double MetersPSintoInchPS(double metersec)
            {
                double inchesps = metersec*39.3700787;
                return inchesps;
            }

            public static double MetersPSintoKPH(double metersec)
            {
                double KPH = metersec*3.6;
                return KPH;
            }

            public static double MetersPSintoMPH(double metersec)
            {
                double MPH = metersec*2.23694;
                return MPH;
            }

            public static double MPHintoFeetPS(double mph)
            {
                double feetps = mph*1.46667;
                return feetps;
            }

            public static double MPHintoInchPS(double mph)
            {
                double inchps = mph*17.6;
                return inchps;
            }

            public static double MPHintoKPH(double mph)
            {
                double kph = mph*1.60934;
                return kph;
            }

            public static double MPHintoMetersPS(double mph)
            {
                double meterps = mph*0.44704;
                return meterps;
            }
        }

        public double Circumference(double radius)
        {
            //placeholder for circumference C = 2pi * r

            return new double();
        }


    }
}

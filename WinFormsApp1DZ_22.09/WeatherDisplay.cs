using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Text;

namespace WinFormsApp1DZ_22._09;

public class WeatherDisplay
{
    public void DisplayWeatherTemp(double item)
    {
       Debug.WriteLine ($"Temperature: {item} C");
               
    }
    public void DisplayWeatherHum(double item)
    {
        Debug.WriteLine($"Humidity: {item} %");
               
    }
}

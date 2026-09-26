using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1DZ_22._09;
public delegate void TemperatureChanged(double temperature);
public delegate void HumidityChanged(double humidity);
public class WeatherStacion
{
    public double Temperature {  get; set; }
    public double Humidity { get; set; }


    public event TemperatureChanged TemperatureChanged;
    public event HumidityChanged HumidityChanged;

    public void SetTemperature(double temperature)
    {
        Temperature = temperature;
        TemperatureChanged?.Invoke(temperature);
    }
    public void SetHumidity(double humidity)
    {
        Humidity = humidity;
        HumidityChanged?.Invoke(humidity);
    }



}

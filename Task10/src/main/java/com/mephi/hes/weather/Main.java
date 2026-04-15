package com.mephi.hes.weather;

import java.io.IOException;
import com.mephi.hes.weather.WeatherInformer;

//TIP To <b>Run</b> code, press <shortcut actionId="Run"/> or
// click the <icon src="AllIcons.Actions.Execute"/> icon in the gutter.
public class Main {
    public static void main(String[] args) throws IOException {
        WeatherInformer moscow = new WeatherInformer(55.75, 37.62);
        WeatherInformer vladivostok = new WeatherInformer(43.12, 131.89);
        WeatherInformer london = new WeatherInformer(51.51, -0.13);

        System.out.println("Температура в Москве: " + moscow.getTemperature() + " °C");
        System.out.println("Температура во Владивостоке: " + vladivostok.getTemperature() + " °C");
        System.out.println("Температура в Лондоне: " + london.getTemperature() + " °C");
    }
}

package com.mephi.hes.weather;

import org.json.JSONObject;

import java.io.IOException;
import java.io.InputStream;
import java.net.URL;

public class WeatherInformer {
    private double latitude;
    private double longitude;

    public WeatherInformer() {
        this.latitude = 55.75;
        this.longitude = 37.625;
    }

    public WeatherInformer(double latitude, double longitude) {
        this.latitude = latitude;
        this.longitude = longitude;
    }

    public double getTemperature() throws IOException {
        String url = "https://api.open-meteo.com/v1/forecast?latitude="
                + latitude
                + "&longitude="
                + longitude
                + "&current=temperature_2m";

        URL service = new URL(url);
        InputStream stream = service.openStream();
        byte[] binary = stream.readAllBytes();
        stream.close();

        String result = new String(binary);

        JSONObject data = new JSONObject(result);
        JSONObject current = data.getJSONObject("current");

        return current.getDouble("temperature_2m");
    }
}
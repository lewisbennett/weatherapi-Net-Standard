# WeatherAPI

Unofficial .NET API client for the weather API available at [weatherapi.com](https://weatherapi.com).

---

## Getting started

### API key

You need an API key to be able to authenticate with the API. You can either [sign up](https://www.weatherapi.com/signup.aspx) for, or [log in](https://www.weatherapi.com/login.aspx) to WeatherAPI to get your API key.

### Creating the client

`WeatherAPIClient` accepts two constructor parameters: your API key, and a custom base URI for the API. A valid API key must be provided, but specifying a base URI is optional.

```
string apiKey = "your API key";

WeatherAPIClient weatherApiClient = new WeatherAPIClient(apiKey);
```

---

## Using the API

API routes are separated out into category classes, referred to as operations, within the client. These classes contain all routes associated with the category, as well as overflow methods providing different request configurations.

Where required, or where available, you'll have the option to provide a request object to the method. The type of request object required is determined by the method you are trying to invoke, but all request objects adopt a fluent API style configuration layout, for example:

```
RequestEntity request = new RequestEntity()
    .WithCityName("Paris")
    .WithLanguage("fr");
```

Different request objects exist to provide extra configuration for the category of request you're trying to make. For example, you can request air quality data with the realtime routes:

```
RealtimeRequestEntity request = new RealtimeRequestEntity()
    .WithCityName("Paris")
    .WithLanguage("fr")
    .WithAirQualityData(true);
```

---

## Features

Sample projects are available for all primary features. Please see the [README](https://github.com/lewisbennett/weatherapi-Net-Standard/blob/master/Samples/README.md) to get started with the sample projects.

* [Astronomy](https://github.com/lewisbennett/weatherapi-Net-Standard/tree/master/Samples/Sample.Astronomy)
* [Forecast](https://github.com/lewisbennett/weatherapi-Net-Standard/tree/master/Samples/Sample.Forecast)
* [History](https://github.com/lewisbennett/weatherapi-Net-Standard/tree/master/Samples/Sample.History)
* [IP address lookup](https://github.com/lewisbennett/weatherapi-Net-Standard/tree/master/Samples/Sample.IPLookup)
* [Realtime](https://github.com/lewisbennett/weatherapi-Net-Standard/tree/master/Samples/Sample.Realtime)
* [Sports](https://github.com/lewisbennett/weatherapi-Net-Standard/tree/master/Samples/Sample.Sports)
* [Time zone](https://github.com/lewisbennett/weatherapi-Net-Standard/tree/master/Samples/Sample.TimeZone)

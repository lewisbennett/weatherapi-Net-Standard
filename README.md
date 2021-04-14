# WeatherAPI.NET

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
* [Search](https://github.com/lewisbennett/weatherapi-Net-Standard/tree/master/Samples/Sample.Search)
* [Sports](https://github.com/lewisbennett/weatherapi-Net-Standard/tree/master/Samples/Sample.Sports)
* [Time zone](https://github.com/lewisbennett/weatherapi-Net-Standard/tree/master/Samples/Sample.TimeZone)

---

## Extending

The client has been designed to make extending the base functionality as easy, and as flexible, as possible. See the [extending sample project](https://github.com/lewisbennett/weatherapi-Net-Standard/tree/master/Samples/Sample.Extending) for a full example.

### Custom response entities

Providing custom entities allows you to inject an object type directly into the deserialization process. This means that there's no hassle serializing and deserializing the standard response objects to get what you want.

```
// Custom astronomy response entity.
public class CustomAstronomyResponseEntity : AstronomyResponseEntity
{
    private readonly string _message = "I'm a message from a custom entity!";

    public void DoSomethingCustom()
    {
        Console.WriteLine(_message);
    }
}

// Your method to request the custom entity.
public async Task GetCustomAstronomyAsync()
{
    CustomAstronomyResponseEntity customAstronomy = await weatherApiClient.Astronomy.GetAstronomyAsync<CustomAstronomyResponseEntity>();
}
```

### Custom operation classes

To build on top of the existing client's request functionality, you can extend operation classes too. Extending operations requires an extended, custom API client.

```
// Custom API client.
public class CustomWeatherAPIClient : WeatherAPIClient
{
    protected override IAstronomyOperations ConstructAstronomyOperations()
    {
        return new CustomAstronomyOperations(this);
    }

    public CustomWeatherAPIClient(string apiKey)
        : base(apiKey, null)
    {
    }
}

// Custom astronomy operations.
public class CustomAstronomyOperations : AstronomyOperations
{
    // Overflow methods funnel down to the "most advanced" variant.
    // This means that calls to the "lower level" overflow methods will also invoke this custom logic.
    public override async Task<TAstronomyResponseEntity> GetAstronomyAsync<TAstronomyResponseEntity>(RequestEntity request, CancellationToken cancellationToken = default)
    {
        var astronomyResponseEntity = await base.GetAstronomyAsync<TAstronomyResponseEntity>(request, cancellationToken);

        if (astronomyResponseEntity is CustomAstronomyResponseEntity customAstronomyEntity)
            customAstronomyEntity.DoSomethingCustom();

        return astronomyResponseEntity;
    }

    public CustomAstronomyOperations(IApiRequestor apiRequestor)
        : base(apiRequestor)
    {
    }
}
```

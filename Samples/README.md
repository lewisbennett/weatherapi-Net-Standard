# WeatherAPI.NET samples

Sample projects for all of the client's features and functionality.

---

## Getting started

Before running any of the sample projects, you need to add the environment variables below.

| Name | Description |
| ----- | ----- |
| API_KEY | Your WeatherAPI API key. |

### IP lookup

The IP address lookup sample requires a sample IP address. You should enter your IPv4 or IPv6 IP address as the [`IPAddress` value](https://github.com/lewisbennett/weatherapi-Net-Standard/blob/master/Samples/Sample.IPLookup/Program.cs#L9), for example:

```
public const string IPAddress = "127.0.0.1";
```

### Search

The search sample requires a search query. By default, "lon" is entered to try and invoke London as the search results. You can change the [`SearchQuery` value](https://github.com/lewisbennett/weatherapi-Net-Standard/blob/master/Samples/Sample.Search/Program.cs#L9) to search for a different location, for example:

```
public const string SearchQuery = "amst";
```

---

## Samples

* [Astronomy](https://github.com/lewisbennett/weatherapi-Net-Standard/tree/master/Samples/Sample.Astronomy)
* [Extending](https://github.com/lewisbennett/weatherapi-Net-Standard/tree/master/Samples/Sample.Extending)
* [Forecast](https://github.com/lewisbennett/weatherapi-Net-Standard/tree/master/Samples/Sample.Forecast)
* [History](https://github.com/lewisbennett/weatherapi-Net-Standard/tree/master/Samples/Sample.History)
* [IP address lookup](https://github.com/lewisbennett/weatherapi-Net-Standard/tree/master/Samples/Sample.IPLookup)
* [Realtime](https://github.com/lewisbennett/weatherapi-Net-Standard/tree/master/Samples/Sample.Realtime)
* [Search](https://github.com/lewisbennett/weatherapi-Net-Standard/tree/master/Samples/Sample.Search)
* [Sports](https://github.com/lewisbennett/weatherapi-Net-Standard/tree/master/Samples/Sample.Sports)
* [Time zone](https://github.com/lewisbennett/weatherapi-Net-Standard/tree/master/Samples/Sample.TimeZone)

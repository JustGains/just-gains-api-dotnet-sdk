# Status

Verify API status.

```csharp
StatusController statusController = client.StatusController;
```

## Class Name

`StatusController`


# Check Server Alive

Returns a simple message to indicate that the API is working.

:information_source: **Note** This endpoint does not require authentication.

```csharp
CheckServerAliveAsync()
```

## Response Type

[`Task<Models.Response>`](../../doc/models/response.md)

## Example Usage

```csharp
try
{
    Response result = await statusController.CheckServerAliveAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`M400ErrorException`](../../doc/models/m400-error-exception.md) |
| 404 | Not found | [`M404ErrorException`](../../doc/models/m404-error-exception.md) |


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

`Task<string>`

## Example Usage

```csharp
try
{
    string result = await statusController.CheckServerAliveAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response

```
"All is working!"
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | `ApiException` |
| 404 | Not found | `ApiException` |


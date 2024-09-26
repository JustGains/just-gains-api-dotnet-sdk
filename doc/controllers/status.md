# Status

Verify API status.

```csharp
StatusController statusController = client.StatusController;
```

## Class Name

`StatusController`

## Methods

* [Check Server Alive](../../doc/controllers/status.md#check-server-alive)
* [Test Unauthorized](../../doc/controllers/status.md#test-unauthorized)


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


# Test Unauthorized

Returns a JSON response simulating an unauthorized access attempt.

:information_source: **Note** This endpoint does not require authentication.

```csharp
TestUnauthorizedAsync()
```

## Response Type

`Task`

## Example Usage

```csharp
try
{
    await statusController.TestUnauthorizedAsync();
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
| 401 | Unauthorized response | [`JustGainsResponseErrorException`](../../doc/models/just-gains-response-error-exception.md) |


# Programs Program Views

```csharp
ProgramsProgramViewsController programsProgramViewsController = client.ProgramsProgramViewsController;
```

## Class Name

`ProgramsProgramViewsController`


# Add View Program

```csharp
AddViewProgramAsync(
    int programId,
    Models.ProgramView body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `programId` | `int` | Template, Required | - |
| `body` | [`ProgramView`](../../doc/models/program-view.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
int programId = 126;
ProgramView body = new ProgramView
{
    ProgramViewId = 10001,
    ProgramId = 1001,
    SessionId = "sess_abc123def456",
    ViewedAt = DateTime.ParseExact("07/25/2023 15:30:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ViewDuration = 300,
    IpAddress = "192.168.1.1",
    UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36",
    IsAuthenticated = true,
    UserId = new Guid("123e4567-e89b-12d3-a456-426614174000"),
};

try
{
    JustGainsBasicResponse result = await programsProgramViewsController.AddViewProgramAsync(
        programId,
        body
    );
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
| 400 | Bad request | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Program not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


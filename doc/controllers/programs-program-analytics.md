# Programs Program Analytics

```csharp
ProgramsProgramAnalyticsController programsProgramAnalyticsController = client.ProgramsProgramAnalyticsController;
```

## Class Name

`ProgramsProgramAnalyticsController`


# Get Anlytics Program

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetAnlyticsProgramAsync(
    int programId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `programId` | `int` | Template, Required | - |

## Response Type

[`Task<Models.ProgramsAnalyticsResponse>`](../../doc/models/programs-analytics-response.md)

## Example Usage

```csharp
int programId = 126;
try
{
    ProgramsAnalyticsResponse result = await programsProgramAnalyticsController.GetAnlyticsProgramAsync(programId);
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
| 404 | Program not found | [`ProgramsAnalytics404ErrorException`](../../doc/models/programs-analytics-404-error-exception.md) |


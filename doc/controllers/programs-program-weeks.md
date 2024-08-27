# Programs Program Weeks

```csharp
ProgramsProgramWeeksController programsProgramWeeksController = client.ProgramsProgramWeeksController;
```

## Class Name

`ProgramsProgramWeeksController`

## Methods

* [Get Weeks for Program](../../doc/controllers/programs-program-weeks.md#get-weeks-for-program)
* [Add Week to Program](../../doc/controllers/programs-program-weeks.md#add-week-to-program)


# Get Weeks for Program

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetWeeksForProgramAsync(
    int programId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `programId` | `int` | Template, Required | - |

## Response Type

[`Task<Models.ProgramsWeeksResponse>`](../../doc/models/programs-weeks-response.md)

## Example Usage

```csharp
int programId = 126;
try
{
    ProgramsWeeksResponse result = await programsProgramWeeksController.GetWeeksForProgramAsync(programId);
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
| 404 | Program not found | [`ProgramsWeeks404ErrorException`](../../doc/models/programs-weeks-404-error-exception.md) |


# Add Week to Program

```csharp
AddWeekToProgramAsync(
    int programId,
    Models.Week body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `programId` | `int` | Template, Required | - |
| `body` | [`Week`](../../doc/models/week.md) | Body, Required | - |

## Response Type

[`Task<Models.ProgramsWeeksResponse1>`](../../doc/models/programs-weeks-response-1.md)

## Example Usage

```csharp
int programId = 126;
Week body = new Week
{
    WeekId = 1234,
    UserId = new Guid("123e4567-e89b-12d3-a456-426614174000"),
    WeekTitle = "Week 1: Foundation Building",
    WeekContent = "{\"monday\": {\"workoutId\": 101, \"notes\": \"Focus on form\"}, \"wednesday\": {\"workoutId\": 102, \"notes\": \"Increase weight if possible\"}, \"friday\": {\"workoutId\": 103, \"notes\": \"Cool down properly\"}}",
    CreatedAt = DateTime.ParseExact("07/21/2023 15:30:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    UpdatedAt = DateTime.ParseExact("07/22/2023 10:15:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    DeletedAt = DateTime.ParseExact("08/01/2023 09:00:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    DeletedBy = new Guid("987e6543-e21b-12d3-a456-426614174000"),
};

try
{
    ProgramsWeeksResponse1 result = await programsProgramWeeksController.AddWeekToProgramAsync(
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
| 400 | Bad request | [`ProgramsWeeks400ErrorException`](../../doc/models/programs-weeks-400-error-exception.md) |
| 404 | Program not found | [`ProgramsWeeks404ErrorException`](../../doc/models/programs-weeks-404-error-exception.md) |


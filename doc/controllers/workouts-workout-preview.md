# Workouts Workout Preview

```csharp
WorkoutsWorkoutPreviewController workoutsWorkoutPreviewController = client.WorkoutsWorkoutPreviewController;
```

## Class Name

`WorkoutsWorkoutPreviewController`


# Get Workout Preview by ID

```csharp
GetWorkoutPreviewByIDAsync(
    Guid workoutId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `workoutId` | `Guid` | Template, Required | The ID of the workout to retrieve |

## Response Type

[`Task<Models.WorkoutPreviewResponse>`](../../doc/models/workout-preview-response.md)

## Example Usage

```csharp
Guid workoutId = new Guid("9f897bfa-716d-4caa-b8fb-20bf3f2f3416");
try
{
    WorkoutPreviewResponse result = await workoutsWorkoutPreviewController.GetWorkoutPreviewByIDAsync(workoutId);
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
| 404 | Workout not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


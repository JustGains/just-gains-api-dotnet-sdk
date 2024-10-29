# Workouts Workout Content

```csharp
WorkoutsWorkoutContentController workoutsWorkoutContentController = client.WorkoutsWorkoutContentController;
```

## Class Name

`WorkoutsWorkoutContentController`

## Methods

* [Get Workout Content by ID](../../doc/controllers/workouts-workout-content.md#get-workout-content-by-id)
* [Update Workout Content by ID](../../doc/controllers/workouts-workout-content.md#update-workout-content-by-id)


# Get Workout Content by ID

```csharp
GetWorkoutContentByIDAsync(
    Guid workoutId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `workoutId` | `Guid` | Template, Required | The ID of the workout to retrieve |

## Response Type

[`Task<Models.WorkoutContentResponse>`](../../doc/models/workout-content-response.md)

## Example Usage

```csharp
Guid workoutId = new Guid("9f897bfa-716d-4caa-b8fb-20bf3f2f3416");
try
{
    WorkoutContentResponse result = await workoutsWorkoutContentController.GetWorkoutContentByIDAsync(workoutId);
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


# Update Workout Content by ID

```csharp
UpdateWorkoutContentByIDAsync(
    Guid workoutId,
    Models.WorkoutContent body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `workoutId` | `Guid` | Template, Required | The ID of the workout to update |
| `body` | [`WorkoutContent`](../../doc/models/workout-content.md) | Body, Optional | - |

## Response Type

[`Task<Models.WorkoutContentResponse>`](../../doc/models/workout-content-response.md)

## Example Usage

```csharp
Guid workoutId = new Guid("9f897bfa-716d-4caa-b8fb-20bf3f2f3416");
WorkoutContent body = new WorkoutContent
{
    WorkoutID = new Guid("9f897bfa-716d-4caa-b8fb-20bf3f2f3416"),
};

try
{
    WorkoutContentResponse result = await workoutsWorkoutContentController.UpdateWorkoutContentByIDAsync(
        workoutId,
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
| 404 | Workout not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


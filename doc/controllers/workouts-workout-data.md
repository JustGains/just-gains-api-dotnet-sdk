# Workouts Workout Data

```csharp
WorkoutsWorkoutDataController workoutsWorkoutDataController = client.WorkoutsWorkoutDataController;
```

## Class Name

`WorkoutsWorkoutDataController`

## Methods

* [Get Workout Data by Id](../../doc/controllers/workouts-workout-data.md#get-workout-data-by-id)
* [Update Workout Data by Workout ID](../../doc/controllers/workouts-workout-data.md#update-workout-data-by-workout-id)
* [Get Workout Detail by Id](../../doc/controllers/workouts-workout-data.md#get-workout-detail-by-id)
* [Update Exercise in the Workout](../../doc/controllers/workouts-workout-data.md#update-exercise-in-the-workout)
* [Deletes an Exercise From the Workout](../../doc/controllers/workouts-workout-data.md#deletes-an-exercise-from-the-workout)


# Get Workout Data by Id

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetWorkoutDataByIdAsync(
    Guid workoutId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `workoutId` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.WorkoutDataListResponse>`](../../doc/models/workout-data-list-response.md)

## Example Usage

```csharp
Guid workoutId = new Guid("9f897bfa-716d-4caa-b8fb-20bf3f2f3416");
try
{
    WorkoutDataListResponse result = await workoutsWorkoutDataController.GetWorkoutDataByIdAsync(workoutId);
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


# Update Workout Data by Workout ID

```csharp
UpdateWorkoutDataByWorkoutIDAsync(
    Guid workoutId,
    List<Models.WorkoutData> body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `workoutId` | `Guid` | Template, Required | - |
| `body` | [`List<WorkoutData>`](../../doc/models/workout-data.md) | Body, Required | - |

## Response Type

[`Task<Models.WorkoutDataListResponse>`](../../doc/models/workout-data-list-response.md)

## Example Usage

```csharp
Guid workoutId = new Guid("9f897bfa-716d-4caa-b8fb-20bf3f2f3416");
List<WorkoutData> body = new List<WorkoutData>
{
    new WorkoutData
    {
        ExerciseCode = "BARBELL_SQUAT",
        ExerciseNotes = "Keep your core tight throughout the movement",
        ExerciseOrder = 2,
        ExerciseGroupID = 1,
        ExerciseGroupType = ExerciseGroupTypeEnum.SUPERSET,
    },
};

try
{
    WorkoutDataListResponse result = await workoutsWorkoutDataController.UpdateWorkoutDataByWorkoutIDAsync(
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
| 400 | Invalid workout data | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Workout not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Get Workout Detail by Id

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetWorkoutDetailByIdAsync(
    Guid workoutId,
    string exerciseCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `workoutId` | `Guid` | Template, Required | The unique identifier code of the workout to retrieve the exercise from |
| `exerciseCode` | `string` | Template, Required | The unique identifier code of the exercise to retrieve<br>**Constraints**: *Pattern*: `^[A-Z_]+$` |

## Response Type

[`Task<Models.WorkoutDataResponse>`](../../doc/models/workout-data-response.md)

## Example Usage

```csharp
Guid workoutId = new Guid("9f897bfa-716d-4caa-b8fb-20bf3f2f3416");
string exerciseCode = "exerciseCode8";
try
{
    WorkoutDataResponse result = await workoutsWorkoutDataController.GetWorkoutDetailByIdAsync(
        workoutId,
        exerciseCode
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
| 404 | Workout or exercise not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Update Exercise in the Workout

```csharp
UpdateExerciseInTheWorkoutAsync(
    Guid workoutId,
    string exerciseCode,
    Models.WorkoutData body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `workoutId` | `Guid` | Template, Required | The unique identifier code of the workout to update the exercise in |
| `exerciseCode` | `string` | Template, Required | The unique identifier code of the exercise to update<br>**Constraints**: *Pattern*: `^[A-Z_]+$` |
| `body` | [`WorkoutData`](../../doc/models/workout-data.md) | Body, Required | - |

## Response Type

[`Task<Models.WorkoutDataResponse>`](../../doc/models/workout-data-response.md)

## Example Usage

```csharp
Guid workoutId = new Guid("9f897bfa-716d-4caa-b8fb-20bf3f2f3416");
string exerciseCode = "SQUAT";
WorkoutData body = new WorkoutData
{
    ExerciseCode = "BARBELL_SQUAT",
    ExerciseNotes = "Keep your core tight throughout the movement",
    ExerciseOrder = 2,
    ExerciseGroupID = 1,
    ExerciseGroupType = ExerciseGroupTypeEnum.SUPERSET,
};

try
{
    WorkoutDataResponse result = await workoutsWorkoutDataController.UpdateExerciseInTheWorkoutAsync(
        workoutId,
        exerciseCode,
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
| 400 | Invalid exercise data | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Workout or exercise not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Deletes an Exercise From the Workout

```csharp
DeletesAnExerciseFromTheWorkoutAsync(
    Guid workoutId,
    string exerciseCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `workoutId` | `Guid` | Template, Required | The unique identifier code of the workout to remove the exercise from |
| `exerciseCode` | `string` | Template, Required | The unique identifier code of the exercise to remove<br>**Constraints**: *Pattern*: `^[A-Z_]+$` |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
Guid workoutId = new Guid("9f897bfa-716d-4caa-b8fb-20bf3f2f3416");
string exerciseCode = "exerciseCode8";
try
{
    JustGainsBasicResponse result = await workoutsWorkoutDataController.DeletesAnExerciseFromTheWorkoutAsync(
        workoutId,
        exerciseCode
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
| 404 | Workout or exercise not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Workouts Workout Data

```csharp
WorkoutsWorkoutDataController workoutsWorkoutDataController = client.WorkoutsWorkoutDataController;
```

## Class Name

`WorkoutsWorkoutDataController`

## Methods

* [Get Workout Data by Id](../../doc/controllers/workouts-workout-data.md#get-workout-data-by-id)
* [Get Workout Detail by Id](../../doc/controllers/workouts-workout-data.md#get-workout-detail-by-id)
* [Add New Exercise to the Workout](../../doc/controllers/workouts-workout-data.md#add-new-exercise-to-the-workout)
* [Update Exercise in the Workout](../../doc/controllers/workouts-workout-data.md#update-exercise-in-the-workout)
* [Deletes an Exercise From the Workout](../../doc/controllers/workouts-workout-data.md#deletes-an-exercise-from-the-workout)


# Get Workout Data by Id

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetWorkoutDataByIdAsync(
    int workoutId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `workoutId` | `int` | Template, Required | - |

## Response Type

[`Task<Models.WorkoutDataListResponse>`](../../doc/models/workout-data-list-response.md)

## Example Usage

```csharp
int workoutId = 250;
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


# Get Workout Detail by Id

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetWorkoutDetailByIdAsync(
    int workoutId,
    string exerciseCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `workoutId` | `int` | Template, Required | - |
| `exerciseCode` | `string` | Template, Required | - |

## Response Type

[`Task<Models.WorkoutDataResponse>`](../../doc/models/workout-data-response.md)

## Example Usage

```csharp
int workoutId = 250;
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


# Add New Exercise to the Workout

```csharp
AddNewExerciseToTheWorkoutAsync(
    int workoutId,
    string exerciseCode,
    Models.WorkoutData body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `workoutId` | `int` | Template, Required | - |
| `exerciseCode` | `string` | Template, Required | - |
| `body` | [`WorkoutData`](../../doc/models/workout-data.md) | Body, Required | - |

## Response Type

[`Task<Models.WorkoutDataResponse>`](../../doc/models/workout-data-response.md)

## Example Usage

```csharp
int workoutId = 250;
string exerciseCode = "exerciseCode8";
WorkoutData body = new WorkoutData
{
    ExerciseCode = "BARBELL_SQUAT",
    ExerciseNotes = "Keep your core tight throughout the movement",
    ExerciseMetrics = new List<Models.ExerciseMetric1>
    {
        new ExerciseMetric1
        {
        },
        new ExerciseMetric1
        {
        },
    },
    ExerciseData = new List<List<double>>
    {
        new List<double>
        {
            1,
            100,
            10,
        },
        new List<double>
        {
            2,
            110,
            8,
        },
        new List<double>
        {
            3,
            120,
            6,
        },
        new List<double>
        {
            4,
            120,
            6,
        },
    },
    ExerciseOrder = 2,
    ExerciseGroupID = 1,
    ExerciseGroupType = ExerciseGroupTypeEnum.SUPERSET,
};

try
{
    WorkoutDataResponse result = await workoutsWorkoutDataController.AddNewExerciseToTheWorkoutAsync(
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
| 404 | Workout not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Update Exercise in the Workout

```csharp
UpdateExerciseInTheWorkoutAsync(
    int workoutId,
    string exerciseCode,
    Models.WorkoutData body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `workoutId` | `int` | Template, Required | - |
| `exerciseCode` | `string` | Template, Required | - |
| `body` | [`WorkoutData`](../../doc/models/workout-data.md) | Body, Required | - |

## Response Type

[`Task<Models.WorkoutDataResponse>`](../../doc/models/workout-data-response.md)

## Example Usage

```csharp
int workoutId = 250;
string exerciseCode = "exerciseCode8";
WorkoutData body = new WorkoutData
{
    ExerciseCode = "BARBELL_SQUAT",
    ExerciseNotes = "Keep your core tight throughout the movement",
    ExerciseMetrics = new List<Models.ExerciseMetric1>
    {
        new ExerciseMetric1
        {
        },
        new ExerciseMetric1
        {
        },
    },
    ExerciseData = new List<List<double>>
    {
        new List<double>
        {
            1,
            100,
            10,
        },
        new List<double>
        {
            2,
            110,
            8,
        },
        new List<double>
        {
            3,
            120,
            6,
        },
        new List<double>
        {
            4,
            120,
            6,
        },
    },
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
    int workoutId,
    string exerciseCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `workoutId` | `int` | Template, Required | - |
| `exerciseCode` | `string` | Template, Required | - |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
int workoutId = 250;
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


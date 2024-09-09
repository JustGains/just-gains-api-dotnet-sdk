# Workouts

Core workout management functionality.

```csharp
WorkoutsController workoutsController = client.WorkoutsController;
```

## Class Name

`WorkoutsController`

## Methods

* [Get a Paginated List of Workouts](../../doc/controllers/workouts.md#get-a-paginated-list-of-workouts)
* [Create a New Workout](../../doc/controllers/workouts.md#create-a-new-workout)
* [Get a Workout by ID](../../doc/controllers/workouts.md#get-a-workout-by-id)
* [Duplicate a Workout](../../doc/controllers/workouts.md#duplicate-a-workout)


# Get a Paginated List of Workouts

```csharp
GetAPaginatedListOfWorkoutsAsync(
    int? page = 1,
    int? pageSize = 20,
    string sortBy = null,
    Models.SortOrderEnum? sortOrder = Models.SortOrderEnum.Desc)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | The page number to retrieve<br>**Default**: `1`<br>**Constraints**: `>= 1` |
| `pageSize` | `int?` | Query, Optional | The number of items to retrieve per page<br>**Default**: `20`<br>**Constraints**: `>= 1`, `<= 100` |
| `sortBy` | `string` | Query, Optional | - |
| `sortOrder` | [`SortOrderEnum?`](../../doc/models/sort-order-enum.md) | Query, Optional | The order to sort the results in<br>**Default**: `SortOrderEnum.desc` |

## Response Type

[`Task<Models.WorkoutTableListResponse>`](../../doc/models/workout-table-list-response.md)

## Example Usage

```csharp
int? page = 1;
int? pageSize = 20;
SortOrderEnum? sortOrder = SortOrderEnum.Desc;
try
{
    WorkoutTableListResponse result = await workoutsController.GetAPaginatedListOfWorkoutsAsync(
        page,
        pageSize,
        null,
        sortOrder
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
| 400 | Invalid pagination parameters | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Create a New Workout

```csharp
CreateANewWorkoutAsync(
    Models.Workout body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Workout`](../../doc/models/workout.md) | Body, Required | - |

## Response Type

[`Task<Models.WorkoutResponse>`](../../doc/models/workout-response.md)

## Example Usage

```csharp
Workout body = new Workout
{
    WorkoutId = 1234,
    WorkoutTitle = "Full Body Strength Training",
    UpdatedAt = DateTime.ParseExact("07/08/2023 14:30:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    LastUsedAt = DateTime.ParseExact("07/07/2023 09:15:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    TotalUses = 15,
    AverageRating = 4.7,
};

try
{
    WorkoutResponse result = await workoutsController.CreateANewWorkoutAsync(body);
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


# Get a Workout by ID

```csharp
GetAWorkoutByIDAsync(
    int workoutId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `workoutId` | `int` | Template, Required | - |

## Response Type

[`Task<Models.WorkoutResponse>`](../../doc/models/workout-response.md)

## Example Usage

```csharp
int workoutId = 250;
try
{
    WorkoutResponse result = await workoutsController.GetAWorkoutByIDAsync(workoutId);
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


# Duplicate a Workout

Creates a copy of an existing workout, preserving creator credits and adding the current user as a new contributor.

```csharp
DuplicateAWorkoutAsync(
    Models.WorkoutsDuplicateRequest body,
    int workoutId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`WorkoutsDuplicateRequest`](../../doc/models/workouts-duplicate-request.md) | Body, Required | - |
| `workoutId` | `int` | Template, Required | The ID of the workout to duplicate |

## Response Type

[`Task<Models.WorkoutResponse>`](../../doc/models/workout-response.md)

## Example Usage

```csharp
WorkoutsDuplicateRequest body = new WorkoutsDuplicateRequest
{
    NewWorkoutTitle = "My Modified Full Body Workout",
};

int workoutId = 250;
try
{
    WorkoutResponse result = await workoutsController.DuplicateAWorkoutAsync(
        body,
        workoutId
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
| 400 | Invalid request data | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 403 | Permission denied | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Workout not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


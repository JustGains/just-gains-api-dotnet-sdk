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
    Models.SortBy1Enum? sortBy = Models.SortBy1Enum.CreatedAt,
    Models.SortOrderEnum? sortOrder = Models.SortOrderEnum.Desc)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | The page number to retrieve |
| `pageSize` | `int?` | Query, Optional | The number of items to retrieve per page |
| `sortBy` | [`SortBy1Enum?`](../../doc/models/sort-by-1-enum.md) | Query, Optional | The field to sort the results by |
| `sortOrder` | [`SortOrderEnum?`](../../doc/models/sort-order-enum.md) | Query, Optional | The order to sort the results in |

## Response Type

[`Task<Models.WorkoutsResponse>`](../../doc/models/workouts-response.md)

## Example Usage

```csharp
int? page = 1;
int? pageSize = 20;
SortBy1Enum? sortBy = SortBy1Enum.CreatedAt;
SortOrderEnum? sortOrder = SortOrderEnum.Desc;
try
{
    WorkoutsResponse result = await workoutsController.GetAPaginatedListOfWorkoutsAsync(
        page,
        pageSize,
        sortBy,
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
| 400 | Invalid pagination parameters | [`Workouts400ErrorException`](../../doc/models/workouts-400-error-exception.md) |


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

[`Task<Models.WorkoutsResponse1>`](../../doc/models/workouts-response-1.md)

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
    WorkoutsResponse1 result = await workoutsController.CreateANewWorkoutAsync(body);
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
| 400 | Invalid workout data | [`Workouts400ErrorException`](../../doc/models/workouts-400-error-exception.md) |


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

[`Task<Models.WorkoutsResponse1>`](../../doc/models/workouts-response-1.md)

## Example Usage

```csharp
int workoutId = 250;
try
{
    WorkoutsResponse1 result = await workoutsController.GetAWorkoutByIDAsync(workoutId);
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
| 404 | Workout not found | [`Workouts404ErrorException`](../../doc/models/workouts-404-error-exception.md) |


# Duplicate a Workout

Creates a copy of an existing workout, preserving creator credits and adding the current user as a new contributor.

```csharp
DuplicateAWorkoutAsync(
    int workoutId,
    Models.WorkoutsDuplicateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `workoutId` | `int` | Template, Required | The ID of the workout to duplicate |
| `body` | [`WorkoutsDuplicateRequest`](../../doc/models/workouts-duplicate-request.md) | Body, Required | - |

## Response Type

[`Task<Models.WorkoutsDuplicateResponse>`](../../doc/models/workouts-duplicate-response.md)

## Example Usage

```csharp
int workoutId = 250;
WorkoutsDuplicateRequest body = new WorkoutsDuplicateRequest
{
    NewWorkoutTitle = "My Modified Full Body Workout",
};

try
{
    WorkoutsDuplicateResponse result = await workoutsController.DuplicateAWorkoutAsync(
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
| 400 | Invalid request data | [`WorkoutsDuplicate400ErrorException`](../../doc/models/workouts-duplicate-400-error-exception.md) |
| 403 | Permission denied | [`WorkoutsDuplicate403ErrorException`](../../doc/models/workouts-duplicate-403-error-exception.md) |
| 404 | Workout not found | [`WorkoutsDuplicate404ErrorException`](../../doc/models/workouts-duplicate-404-error-exception.md) |


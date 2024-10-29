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
* [Update a Workout by ID](../../doc/controllers/workouts.md#update-a-workout-by-id)
* [Get a Workout by Workout Slug](../../doc/controllers/workouts.md#get-a-workout-by-workout-slug)
* [Bookmark Workout](../../doc/controllers/workouts.md#bookmark-workout)
* [Remove Workout Bookmark](../../doc/controllers/workouts.md#remove-workout-bookmark)
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
    Models.WorkoutRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`WorkoutRequest`](../../doc/models/workout-request.md) | Body, Required | - |

## Response Type

[`Task<Models.WorkoutResponse>`](../../doc/models/workout-response.md)

## Example Usage

```csharp
WorkoutRequest body = new WorkoutRequest
{
    WorkoutTitle = "Full Body Strength Training",
    WorkoutSlug = "full-body-strength-training",
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
    Guid workoutId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `workoutId` | `Guid` | Template, Required | The ID of the workout to retrieve |

## Response Type

[`Task<Models.WorkoutResponse>`](../../doc/models/workout-response.md)

## Example Usage

```csharp
Guid workoutId = new Guid("9f897bfa-716d-4caa-b8fb-20bf3f2f3416");
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


# Update a Workout by ID

```csharp
UpdateAWorkoutByIDAsync(
    Guid workoutId,
    Models.WorkoutUpdate body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `workoutId` | `Guid` | Template, Required | The ID of the workout to update |
| `body` | [`WorkoutUpdate`](../../doc/models/workout-update.md) | Body, Required | - |

## Response Type

[`Task<Models.WorkoutResponse>`](../../doc/models/workout-response.md)

## Example Usage

```csharp
Guid workoutId = new Guid("9f897bfa-716d-4caa-b8fb-20bf3f2f3416");
WorkoutUpdate body = new WorkoutUpdate
{
    WorkoutTitle = "Full Body Strength Training",
    WorkoutSlug = "full-body-strength-training",
    Tags = new List<string>
    {
        "strength",
        "fullbody",
        "beginner",
    },
};

try
{
    WorkoutResponse result = await workoutsController.UpdateAWorkoutByIDAsync(
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
| 403 | Permission denied | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Workout not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Get a Workout by Workout Slug

```csharp
GetAWorkoutByWorkoutSlugAsync(
    string workoutSlug)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `workoutSlug` | `string` | Template, Required | The URL slug of the workout |

## Response Type

[`Task<Models.WorkoutResponse>`](../../doc/models/workout-response.md)

## Example Usage

```csharp
string workoutSlug = "full-body-strength-training";
try
{
    WorkoutResponse result = await workoutsController.GetAWorkoutByWorkoutSlugAsync(workoutSlug);
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


# Bookmark Workout

Adds the specified workout to the current user's bookmarks. If the workout is already bookmarked, the request is idempotent and will not create a duplicate.

:information_source: **Note** This endpoint does not require authentication.

```csharp
BookmarkWorkoutAsync(
    Guid workoutId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `workoutId` | `Guid` | Template, Required | The unique identifier of the workout to bookmark |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
Guid workoutId = new Guid("00000e9a-0000-0000-0000-000000000000");
try
{
    JustGainsBasicResponse result = await workoutsController.BookmarkWorkoutAsync(workoutId);
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
| 401 | - | `ApiException` |
| 404 | Workout not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Remove Workout Bookmark

Removes the specified workout from the current user's bookmarks. If the workout is not bookmarked, the request is idempotent and will not result in an error.

:information_source: **Note** This endpoint does not require authentication.

```csharp
RemoveWorkoutBookmarkAsync(
    Guid workoutId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `workoutId` | `Guid` | Template, Required | The unique identifier of the workout to remove from bookmarks |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
Guid workoutId = new Guid("00000e9a-0000-0000-0000-000000000000");
try
{
    JustGainsBasicResponse result = await workoutsController.RemoveWorkoutBookmarkAsync(workoutId);
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
| 401 | - | `ApiException` |
| 404 | Workout not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Duplicate a Workout

Creates a copy of an existing workout, preserving creator credits and adding the current user as a new contributor.

```csharp
DuplicateAWorkoutAsync(
    Guid workoutId,
    Models.WorkoutsDuplicateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `workoutId` | `Guid` | Template, Required | The ID of the workout to duplicate |
| `body` | [`WorkoutsDuplicateRequest`](../../doc/models/workouts-duplicate-request.md) | Body, Required | - |

## Response Type

[`Task<Models.WorkoutResponse>`](../../doc/models/workout-response.md)

## Example Usage

```csharp
Guid workoutId = new Guid("9f897bfa-716d-4caa-b8fb-20bf3f2f3416");
WorkoutsDuplicateRequest body = new WorkoutsDuplicateRequest
{
    NewWorkoutTitle = "My Modified Full Body Workout",
};

try
{
    WorkoutResponse result = await workoutsController.DuplicateAWorkoutAsync(
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
| 400 | Invalid request data | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 403 | Permission denied | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Workout not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Exercises Exercise Thumbnails

```csharp
ExercisesExerciseThumbnailsController exercisesExerciseThumbnailsController = client.ExercisesExerciseThumbnailsController;
```

## Class Name

`ExercisesExerciseThumbnailsController`

## Methods

* [Get Exercise Thumbnails](../../doc/controllers/exercises-exercise-thumbnails.md#get-exercise-thumbnails)
* [Get Exercise Thumbnail by User Id](../../doc/controllers/exercises-exercise-thumbnails.md#get-exercise-thumbnail-by-user-id)
* [Add or Update Exercise Thumbnail](../../doc/controllers/exercises-exercise-thumbnails.md#add-or-update-exercise-thumbnail)
* [Delete an Exercise Thumbnail](../../doc/controllers/exercises-exercise-thumbnails.md#delete-an-exercise-thumbnail)


# Get Exercise Thumbnails

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetExerciseThumbnailsAsync(
    string exerciseCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code to retrieve thumbnails for |

## Response Type

[`Task<Models.ExerciseThumbnailListResponse>`](../../doc/models/exercise-thumbnail-list-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
try
{
    ExerciseThumbnailListResponse result = await exercisesExerciseThumbnailsController.GetExerciseThumbnailsAsync(exerciseCode);
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
| 400 | Invalid exercise code | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Exercise thumbnails not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Get Exercise Thumbnail by User Id

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetExerciseThumbnailByUserIdAsync(
    string exerciseCode,
    string userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code to retrieve thumbnail for |
| `userId` | `string` | Template, Required | The userId of the creator whose thumbnail we're referencing |

## Response Type

[`Task<Models.ExerciseThumbnailResponse>`](../../doc/models/exercise-thumbnail-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
string userId = "userId0";
try
{
    ExerciseThumbnailResponse result = await exercisesExerciseThumbnailsController.GetExerciseThumbnailByUserIdAsync(
        exerciseCode,
        userId
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
| 400 | Invalid exercise code or user ID | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Exercise thumbnail not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Add or Update Exercise Thumbnail

```csharp
AddOrUpdateExerciseThumbnailAsync(
    string exerciseCode,
    string userId,
    Models.ExerciseThumbnail body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code to add or update thumbnail for |
| `userId` | `string` | Template, Required | The userId of the thumbnail creator |
| `body` | [`ExerciseThumbnail`](../../doc/models/exercise-thumbnail.md) | Body, Required | - |

## Response Type

[`Task<Models.ExerciseThumbnailResponse>`](../../doc/models/exercise-thumbnail-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
string userId = "userId0";
ExerciseThumbnail body = new ExerciseThumbnail
{
    ExerciseCode = "exerciseCode2",
    UserId = new Guid("000021e4-0000-0000-0000-000000000000"),
    MediaAsset = new MediaAsset
    {
        MediaId = new Guid("7b8e9f2a-c1d3-45e6-a7b8-9c0d1e2f3a4b"),
        FileName = "workout_routine.mp4",
        FilePath = "media/videos/routines/workout_routine.mp4",
        FileSize = 15728640,
        FileFormat = "video/mp4",
        FileUrl = "https://api.justsuperhuman.com/media/videos/routines/workout_routine.mp4",
        Description = "High-intensity interval training (HIIT) workout routine for beginners",
    },
};

try
{
    ExerciseThumbnailResponse result = await exercisesExerciseThumbnailsController.AddOrUpdateExerciseThumbnailAsync(
        exerciseCode,
        userId,
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
| 400 | Invalid exercise thumbnail data | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 401 | Authentication required | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Delete an Exercise Thumbnail

```csharp
DeleteAnExerciseThumbnailAsync(
    string exerciseCode,
    string userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code |
| `userId` | `string` | Template, Required | The userId of the thumbnail creator |

## Response Type

[`Task<Models.JustGainsResponse>`](../../doc/models/just-gains-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
string userId = "userId0";
try
{
    JustGainsResponse result = await exercisesExerciseThumbnailsController.DeleteAnExerciseThumbnailAsync(
        exerciseCode,
        userId
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
| 401 | Authentication required | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Exercise thumbnail not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


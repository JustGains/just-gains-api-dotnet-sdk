# Exercises Exercise Thumbnails

```csharp
ExercisesExerciseThumbnailsController exercisesExerciseThumbnailsController = client.ExercisesExerciseThumbnailsController;
```

## Class Name

`ExercisesExerciseThumbnailsController`

## Methods

* [Get Exercise Thumbnails](../../doc/controllers/exercises-exercise-thumbnails.md#get-exercise-thumbnails)
* [Get Exercise Thumbnail by Creator Profile Id](../../doc/controllers/exercises-exercise-thumbnails.md#get-exercise-thumbnail-by-creator-profile-id)
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


# Get Exercise Thumbnail by Creator Profile Id

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetExerciseThumbnailByCreatorProfileIdAsync(
    string exerciseCode,
    string creatorProfileId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code to retrieve thumbnail for |
| `creatorProfileId` | `string` | Template, Required | The creatorProfileId of the creator whose thumbnail we're referencing |

## Response Type

[`Task<Models.ExerciseThumbnailResponse>`](../../doc/models/exercise-thumbnail-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
string creatorProfileId = "creatorProfileId8";
try
{
    ExerciseThumbnailResponse result = await exercisesExerciseThumbnailsController.GetExerciseThumbnailByCreatorProfileIdAsync(
        exerciseCode,
        creatorProfileId
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
    string creatorProfileId,
    Models.ExerciseThumbnail body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code to add or update thumbnail for |
| `creatorProfileId` | `string` | Template, Required | The creatorProfileId of the thumbnail creator |
| `body` | [`ExerciseThumbnail`](../../doc/models/exercise-thumbnail.md) | Body, Required | - |

## Response Type

[`Task<Models.ExerciseThumbnailResponse>`](../../doc/models/exercise-thumbnail-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
string creatorProfileId = "creatorProfileId8";
ExerciseThumbnail body = new ExerciseThumbnail
{
    ExerciseCode = "SQUAT",
    UserId = new Guid("123e4567-e89b-12d3-a456-426614174000"),
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
    UserName = "john_doe",
};

try
{
    ExerciseThumbnailResponse result = await exercisesExerciseThumbnailsController.AddOrUpdateExerciseThumbnailAsync(
        exerciseCode,
        creatorProfileId,
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
    string creatorProfileId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code |
| `creatorProfileId` | `string` | Template, Required | The creatorProfileId of the thumbnail creator |

## Response Type

[`Task<Models.JustGainsResponse>`](../../doc/models/just-gains-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
string creatorProfileId = "creatorProfileId8";
try
{
    JustGainsResponse result = await exercisesExerciseThumbnailsController.DeleteAnExerciseThumbnailAsync(
        exerciseCode,
        creatorProfileId
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


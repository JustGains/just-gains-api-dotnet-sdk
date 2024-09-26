# Exercise Library Exercises Exercise Thumbnails

```csharp
ExerciseLibraryExercisesExerciseThumbnailsController exerciseLibraryExercisesExerciseThumbnailsController = client.ExerciseLibraryExercisesExerciseThumbnailsController;
```

## Class Name

`ExerciseLibraryExercisesExerciseThumbnailsController`

## Methods

* [Get Exercise Thumbnails](../../doc/controllers/exercise-library-exercises-exercise-thumbnails.md#get-exercise-thumbnails)
* [Get Exercise Thumbnail by User Id](../../doc/controllers/exercise-library-exercises-exercise-thumbnails.md#get-exercise-thumbnail-by-user-id)
* [Add or Update Exercise Thumbnail](../../doc/controllers/exercise-library-exercises-exercise-thumbnails.md#add-or-update-exercise-thumbnail)
* [Delete an Exercise Thumbnail](../../doc/controllers/exercise-library-exercises-exercise-thumbnails.md#delete-an-exercise-thumbnail)


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
    ExerciseThumbnailListResponse result = await exerciseLibraryExercisesExerciseThumbnailsController.GetExerciseThumbnailsAsync(exerciseCode);
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
    ExerciseThumbnailResponse result = await exerciseLibraryExercisesExerciseThumbnailsController.GetExerciseThumbnailByUserIdAsync(
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
    Models.MediaAssetAssignment body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code to add or update thumbnail for |
| `creatorProfileId` | `string` | Template, Required | The creatorProfileId of the thumbnail creator |
| `body` | [`MediaAssetAssignment`](../../doc/models/media-asset-assignment.md) | Body, Required | - |

## Response Type

[`Task<Models.ExerciseThumbnailResponse>`](../../doc/models/exercise-thumbnail-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
string creatorProfileId = "creatorProfileId8";
MediaAssetAssignment body = new MediaAssetAssignment
{
    MediaId = new Guid("7b8e9f2a-c1d3-45e6-a7b8-9c0d1e2f3a4b"),
};

try
{
    ExerciseThumbnailResponse result = await exerciseLibraryExercisesExerciseThumbnailsController.AddOrUpdateExerciseThumbnailAsync(
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
    JustGainsResponse result = await exerciseLibraryExercisesExerciseThumbnailsController.DeleteAnExerciseThumbnailAsync(
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


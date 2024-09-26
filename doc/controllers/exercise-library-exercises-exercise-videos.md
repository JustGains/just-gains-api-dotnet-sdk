# Exercise Library Exercises Exercise Videos

```csharp
ExerciseLibraryExercisesExerciseVideosController exerciseLibraryExercisesExerciseVideosController = client.ExerciseLibraryExercisesExerciseVideosController;
```

## Class Name

`ExerciseLibraryExercisesExerciseVideosController`

## Methods

* [Get Exercise Video On](../../doc/controllers/exercise-library-exercises-exercise-videos.md#get-exercise-video-on)
* [Get Exercise Video by User Id](../../doc/controllers/exercise-library-exercises-exercise-videos.md#get-exercise-video-by-user-id)
* [Add New Exercise Videos to the Specified Creator Theme](../../doc/controllers/exercise-library-exercises-exercise-videos.md#add-new-exercise-videos-to-the-specified-creator-theme)
* [Delete an Exercise Video](../../doc/controllers/exercise-library-exercises-exercise-videos.md#delete-an-exercise-video)


# Get Exercise Video On

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetExerciseVideoOnAsync(
    string exerciseCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code to retrieve videos for |

## Response Type

[`Task<Models.ExerciseVideoListResponse>`](../../doc/models/exercise-video-list-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
try
{
    ExerciseVideoListResponse result = await exerciseLibraryExercisesExerciseVideosController.GetExerciseVideoOnAsync(exerciseCode);
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
| 404 | Exercise videos not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Get Exercise Video by User Id

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetExerciseVideoByUserIdAsync(
    string exerciseCode,
    string creatorProfileId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code to retrieve videos for |
| `creatorProfileId` | `string` | Template, Required | The creatorProfileId of the creator whose videos we're referencing |

## Response Type

[`Task<Models.ExercisesVideosResponse1>`](../../doc/models/exercises-videos-response-1.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
string creatorProfileId = "creatorProfileId8";
try
{
    ExercisesVideosResponse1 result = await exerciseLibraryExercisesExerciseVideosController.GetExerciseVideoByUserIdAsync(
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
| 400 | Invalid exercise code | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Exercise videos not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Add New Exercise Videos to the Specified Creator Theme

```csharp
AddNewExerciseVideosToTheSpecifiedCreatorThemeAsync(
    string exerciseCode,
    string creatorProfileId,
    Models.MediaAssetAssignment body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code to add videos to |
| `creatorProfileId` | `string` | Template, Required | The creatorProfileId of the video creator |
| `body` | [`MediaAssetAssignment`](../../doc/models/media-asset-assignment.md) | Body, Required | - |

## Response Type

[`Task<Models.ExerciseVideoResponse>`](../../doc/models/exercise-video-response.md)

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
    ExerciseVideoResponse result = await exerciseLibraryExercisesExerciseVideosController.AddNewExerciseVideosToTheSpecifiedCreatorThemeAsync(
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
| 400 | Invalid exercise video data | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 401 | Authentication required | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Delete an Exercise Video

```csharp
DeleteAnExerciseVideoAsync(
    string exerciseCode,
    string creatorProfileId,
    int exerciseVideoId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code |
| `creatorProfileId` | `string` | Template, Required | The creatorProfileId of the video creator |
| `exerciseVideoId` | `int` | Template, Required | The exercise video ID to delete |

## Response Type

[`Task<Models.JustGainsResponse>`](../../doc/models/just-gains-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
string creatorProfileId = "creatorProfileId8";
int exerciseVideoId = 66;
try
{
    JustGainsResponse result = await exerciseLibraryExercisesExerciseVideosController.DeleteAnExerciseVideoAsync(
        exerciseCode,
        creatorProfileId,
        exerciseVideoId
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
| 404 | Exercise video not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


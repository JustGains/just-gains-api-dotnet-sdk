# Exercises Exercise Videos

```csharp
ExercisesExerciseVideosController exercisesExerciseVideosController = client.ExercisesExerciseVideosController;
```

## Class Name

`ExercisesExerciseVideosController`

## Methods

* [Get Exercise Video On](../../doc/controllers/exercises-exercise-videos.md#get-exercise-video-on)
* [Add New Exercise Videos](../../doc/controllers/exercises-exercise-videos.md#add-new-exercise-videos)
* [Update Exercise Videos](../../doc/controllers/exercises-exercise-videos.md#update-exercise-videos)
* [Get Exercise Video by User Id](../../doc/controllers/exercises-exercise-videos.md#get-exercise-video-by-user-id)
* [Delete an Exercise Video](../../doc/controllers/exercises-exercise-videos.md#delete-an-exercise-video)


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
    ExerciseVideoListResponse result = await exercisesExerciseVideosController.GetExerciseVideoOnAsync(exerciseCode);
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


# Add New Exercise Videos

```csharp
AddNewExerciseVideosAsync(
    string exerciseCode,
    Models.ExerciseVideo body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code to add videos to |
| `body` | [`ExerciseVideo`](../../doc/models/exercise-video.md) | Body, Required | - |

## Response Type

[`Task<Models.ExerciseVideoResponse>`](../../doc/models/exercise-video-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
ExerciseVideo body = new ExerciseVideo
{
    ExerciseCode = "BARBELL_SQUAT",
    UserId = new Guid("123e4567-e89b-12d3-a456-426614174000"),
    SortOrder = 1,
};

try
{
    ExerciseVideoResponse result = await exercisesExerciseVideosController.AddNewExerciseVideosAsync(
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
| 400 | Invalid exercise video data | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 401 | Authentication required | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Update Exercise Videos

```csharp
UpdateExerciseVideosAsync(
    string exerciseCode,
    List<Models.ExerciseVideo> body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code of the exercise videos to update |
| `body` | [`List<ExerciseVideo>`](../../doc/models/exercise-video.md) | Body, Required | - |

## Response Type

[`Task<Models.ExercisesVideosResponse2>`](../../doc/models/exercises-videos-response-2.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
List<ExerciseVideo> body = new List<ExerciseVideo>
{
    new ExerciseVideo
    {
        ExerciseCode = "BARBELL_SQUAT",
        UserId = new Guid("123e4567-e89b-12d3-a456-426614174000"),
        SortOrder = 1,
    },
};

try
{
    ExercisesVideosResponse2 result = await exercisesExerciseVideosController.UpdateExerciseVideosAsync(
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
| 400 | Invalid exercise video data | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 401 | Authentication required | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Exercise videos not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Get Exercise Video by User Id

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetExerciseVideoByUserIdAsync(
    string exerciseCode,
    string userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code to retrieve videos for |
| `userId` | `string` | Template, Required | The userId of the creator whose videos we're referencing |

## Response Type

[`Task<Models.ExercisesVideosResponse2>`](../../doc/models/exercises-videos-response-2.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
string userId = "userId0";
try
{
    ExercisesVideosResponse2 result = await exercisesExerciseVideosController.GetExerciseVideoByUserIdAsync(
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
| 400 | Invalid exercise code | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Exercise videos not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Delete an Exercise Video

```csharp
DeleteAnExerciseVideoAsync(
    string exerciseCode,
    string userId,
    int exerciseVideoId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code |
| `userId` | `string` | Template, Required | The userId of the video creator |
| `exerciseVideoId` | `int` | Template, Required | The exercise video ID to delete |

## Response Type

[`Task<Models.JustGainsResponse>`](../../doc/models/just-gains-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
string userId = "userId0";
int exerciseVideoId = 66;
try
{
    JustGainsResponse result = await exercisesExerciseVideosController.DeleteAnExerciseVideoAsync(
        exerciseCode,
        userId,
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


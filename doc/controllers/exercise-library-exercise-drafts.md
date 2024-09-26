# Exercise Library Exercise Drafts

```csharp
ExerciseLibraryExerciseDraftsController exerciseLibraryExerciseDraftsController = client.ExerciseLibraryExerciseDraftsController;
```

## Class Name

`ExerciseLibraryExerciseDraftsController`


# Create Update an Exercise With Exercise Draft DTO

```csharp
CreateUpdateAnExerciseWithExerciseDraftDTOAsync(
    Models.ExerciseDraftDTO body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ExerciseDraftDTO`](../../doc/models/exercise-draft-dto.md) | Body, Required | - |

## Response Type

[`Task<Models.ExerciseResponse>`](../../doc/models/exercise-response.md)

## Example Usage

```csharp
ExerciseDraftDTO body = new ExerciseDraftDTO
{
};

try
{
    ExerciseResponse result = await exerciseLibraryExerciseDraftsController.CreateUpdateAnExerciseWithExerciseDraftDTOAsync(body);
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
| 404 | Exercise not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


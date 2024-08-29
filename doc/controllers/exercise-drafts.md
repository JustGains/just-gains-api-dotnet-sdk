# Exercise Drafts

```csharp
ExerciseDraftsController exerciseDraftsController = client.ExerciseDraftsController;
```

## Class Name

`ExerciseDraftsController`


# Create Update an Existing Exercise With the Exercise Draft Format

```csharp
CreateUpdateAnExistingExerciseWithTheExerciseDraftFormatAsync(
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
    ExerciseResponse result = await exerciseDraftsController.CreateUpdateAnExistingExerciseWithTheExerciseDraftFormatAsync(body);
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


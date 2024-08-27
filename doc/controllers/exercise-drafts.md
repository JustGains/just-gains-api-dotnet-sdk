# Exercise Drafts

```csharp
ExerciseDraftsController exerciseDraftsController = client.ExerciseDraftsController;
```

## Class Name

`ExerciseDraftsController`


# Exercise Draft Format

Create or Update an existing exercise with the Exercise Draft format

```csharp
ExerciseDraftFormatAsync(
    Models.ExerciseDraftDTO body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ExerciseDraftDTO`](../../doc/models/exercise-draft-dto.md) | Body, Required | - |

## Response Type

[`Task<Models.ExerciseDraftResponse>`](../../doc/models/exercise-draft-response.md)

## Example Usage

```csharp
ExerciseDraftDTO body = new ExerciseDraftDTO
{
};

try
{
    ExerciseDraftResponse result = await exerciseDraftsController.ExerciseDraftFormatAsync(body);
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
| 400 | Bad request | [`ExerciseDraft400ErrorException`](../../doc/models/exercise-draft-400-error-exception.md) |
| 404 | Exercise not found | [`ExerciseDraft404ErrorException`](../../doc/models/exercise-draft-404-error-exception.md) |


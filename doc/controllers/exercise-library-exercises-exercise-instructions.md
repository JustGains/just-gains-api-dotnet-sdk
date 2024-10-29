# Exercise Library Exercises Exercise Instructions

```csharp
ExerciseLibraryExercisesExerciseInstructionsController exerciseLibraryExercisesExerciseInstructionsController = client.ExerciseLibraryExercisesExerciseInstructionsController;
```

## Class Name

`ExerciseLibraryExercisesExerciseInstructionsController`

## Methods

* [Get Exercise Instructions](../../doc/controllers/exercise-library-exercises-exercise-instructions.md#get-exercise-instructions)
* [Get Exercise Instruction](../../doc/controllers/exercise-library-exercises-exercise-instructions.md#get-exercise-instruction)
* [Update Exercise Instructions](../../doc/controllers/exercise-library-exercises-exercise-instructions.md#update-exercise-instructions)


# Get Exercise Instructions

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetExerciseInstructionsAsync(
    string exerciseCode,
    List<string> localeCodes = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code to retrieve instruction models for |
| `localeCodes` | `List<string>` | Query, Optional | The array of locales for the instructions (e.g., 'en-US', 'es-ES')<br>**Constraints**: *Pattern*: `^[a-z]{2}-[A-Z]{2}$` |

## Response Type

[`Task<Models.ExerciseInstructionListResponse>`](../../doc/models/exercise-instruction-list-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
List<string> localeCodes = new List<string>
{
    "en-US",
    "es-ES",
};

try
{
    ExerciseInstructionListResponse result = await exerciseLibraryExercisesExerciseInstructionsController.GetExerciseInstructionsAsync(
        exerciseCode,
        localeCodes
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
| 400 | Bad request | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Exercise instructions not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Get Exercise Instruction

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetExerciseInstructionAsync(
    string exerciseCode,
    string localeCode,
    string creatorProfileId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code to retrieve instructions for |
| `localeCode` | `string` | Template, Required | The locale for the instructions (e.g., 'en-US', 'es-ES')<br>**Constraints**: *Pattern*: `^[a-z]{2}-[A-Z]{2}$` |
| `creatorProfileId` | `string` | Template, Required | The creatorProfileId that belongs to the instructions being requested |

## Response Type

[`Task<Models.ExerciseInstructionResponse>`](../../doc/models/exercise-instruction-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
string localeCode = "localeCode2";
string creatorProfileId = "creatorProfileId8";
try
{
    ExerciseInstructionResponse result = await exerciseLibraryExercisesExerciseInstructionsController.GetExerciseInstructionAsync(
        exerciseCode,
        localeCode,
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
| 400 | Bad request | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Exercise instructions not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Update Exercise Instructions

```csharp
UpdateExerciseInstructionsAsync(
    string exerciseCode,
    string localeCode,
    string creatorProfileId,
    Models.ExerciseInstruction body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code of the instructions to update |
| `localeCode` | `string` | Template, Required | The locale code for the instructions to update<br>**Constraints**: *Pattern*: `^[a-z]{2}-[A-Z]{2}$` |
| `creatorProfileId` | `string` | Template, Required | The creatorProfileId of the creator for the instructions to update |
| `body` | [`ExerciseInstruction`](../../doc/models/exercise-instruction.md) | Body, Required | - |

## Response Type

[`Task<Models.ExerciseInstructionResponse>`](../../doc/models/exercise-instruction-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
string localeCode = "localeCode2";
string creatorProfileId = "creatorProfileId8";
ExerciseInstruction body = new ExerciseInstruction
{
    ExerciseCode = null,
    LocaleCode = "en-US",
    InstructionJSON = new InstructionJSON
    {
        Time = 1625832000000L,
        Version = "2.24.3",
    },
};

try
{
    ExerciseInstructionResponse result = await exerciseLibraryExercisesExerciseInstructionsController.UpdateExerciseInstructionsAsync(
        exerciseCode,
        localeCode,
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
| 400 | Bad request | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 401 | Unauthorized | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Exercise instructions not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


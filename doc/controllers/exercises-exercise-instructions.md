# Exercises Exercise Instructions

```csharp
ExercisesExerciseInstructionsController exercisesExerciseInstructionsController = client.ExercisesExerciseInstructionsController;
```

## Class Name

`ExercisesExerciseInstructionsController`

## Methods

* [Get Exercise Instructions](../../doc/controllers/exercises-exercise-instructions.md#get-exercise-instructions)
* [Create New Exercise Instructions](../../doc/controllers/exercises-exercise-instructions.md#create-new-exercise-instructions)
* [Get Exercise Instruction](../../doc/controllers/exercises-exercise-instructions.md#get-exercise-instruction)
* [Update Exercise Instructions](../../doc/controllers/exercises-exercise-instructions.md#update-exercise-instructions)
* [Delete Exercise Instructions](../../doc/controllers/exercises-exercise-instructions.md#delete-exercise-instructions)


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
| `localeCodes` | `List<string>` | Query, Optional | The array of locales for the instructions (e.g., 'en-US', 'es-ES') |

## Response Type

[`Task<Models.ExerciseInstructionListResponse>`](../../doc/models/exercise-instruction-list-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
try
{
    ExerciseInstructionListResponse result = await exercisesExerciseInstructionsController.GetExerciseInstructionsAsync(exerciseCode);
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


# Create New Exercise Instructions

```csharp
CreateNewExerciseInstructionsAsync(
    string exerciseCode,
    Models.ExerciseInstruction body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code to create instructions for |
| `body` | [`ExerciseInstruction`](../../doc/models/exercise-instruction.md) | Body, Required | - |

## Response Type

[`Task<Models.ExerciseInstructionResponse>`](../../doc/models/exercise-instruction-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
ExerciseInstruction body = new ExerciseInstruction
{
    ExerciseCode = "BARBELL-BENCH-PRESS",
    LocaleCode = "en-US",
    InstructionJSON = new InstructionJSON
    {
        Time = 1625832000000L,
        Version = "2.24.3",
    },
    UserId = "9fdd12f5-c7b9-82a8-f6cc-cceac14c13c1",
};

try
{
    ExerciseInstructionResponse result = await exercisesExerciseInstructionsController.CreateNewExerciseInstructionsAsync(
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
| 400 | Bad request | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 401 | Unauthorized | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Get Exercise Instruction

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetExerciseInstructionAsync(
    string exerciseCode,
    string localeCode,
    string userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code to retrieve instructions for |
| `localeCode` | `string` | Template, Required | The locale for the instructions (e.g., 'en-US', 'es-ES') |
| `userId` | `string` | Template, Required | The UserID that belongs to the instructions being requested |

## Response Type

[`Task<Models.ExerciseInstructionResponse>`](../../doc/models/exercise-instruction-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
string localeCode = "localeCode2";
string userId = "userId0";
try
{
    ExerciseInstructionResponse result = await exercisesExerciseInstructionsController.GetExerciseInstructionAsync(
        exerciseCode,
        localeCode,
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
| 400 | Bad request | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Exercise instructions not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Update Exercise Instructions

```csharp
UpdateExerciseInstructionsAsync(
    string exerciseCode,
    string localeCode,
    string userId,
    Models.ExerciseInstruction body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code of the instructions to update |
| `localeCode` | `string` | Template, Required | The locale code for the instructions to update |
| `userId` | `string` | Template, Required | The userId of the creator for the instructions to update |
| `body` | [`ExerciseInstruction`](../../doc/models/exercise-instruction.md) | Body, Required | - |

## Response Type

[`Task<Models.ExerciseInstructionResponse>`](../../doc/models/exercise-instruction-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
string localeCode = "localeCode2";
string userId = "userId0";
ExerciseInstruction body = new ExerciseInstruction
{
    ExerciseCode = "BARBELL-BENCH-PRESS",
    LocaleCode = "en-US",
    InstructionJSON = new InstructionJSON
    {
        Time = 1625832000000L,
        Version = "2.24.3",
    },
    UserId = "9fdd12f5-c7b9-82a8-f6cc-cceac14c13c1",
};

try
{
    ExerciseInstructionResponse result = await exercisesExerciseInstructionsController.UpdateExerciseInstructionsAsync(
        exerciseCode,
        localeCode,
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
| 400 | Bad request | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 401 | Unauthorized | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Exercise instructions not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Delete Exercise Instructions

```csharp
DeleteExerciseInstructionsAsync(
    string exerciseCode,
    string localeCode,
    string userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The exercise code of the instructions to delete |
| `localeCode` | `string` | Template, Required | The locale code for the instructions to delete |
| `userId` | `string` | Template, Required | The user ID of the instructions to delete |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
string localeCode = "localeCode2";
string userId = "userId0";
try
{
    JustGainsBasicResponse result = await exercisesExerciseInstructionsController.DeleteExerciseInstructionsAsync(
        exerciseCode,
        localeCode,
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
| 401 | Unauthorized | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Exercise instructions not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


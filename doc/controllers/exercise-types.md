# Exercise Types

```csharp
ExerciseTypesController exerciseTypesController = client.ExerciseTypesController;
```

## Class Name

`ExerciseTypesController`

## Methods

* [Get Exercise Types](../../doc/controllers/exercise-types.md#get-exercise-types)
* [Create a New Exercise Type](../../doc/controllers/exercise-types.md#create-a-new-exercise-type)
* [Update an Exercise Type](../../doc/controllers/exercise-types.md#update-an-exercise-type)
* [Delete an Exercise Type](../../doc/controllers/exercise-types.md#delete-an-exercise-type)


# Get Exercise Types

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetExerciseTypesAsync()
```

## Response Type

[`Task<Models.ExerciseTypeListResponse>`](../../doc/models/exercise-type-list-response.md)

## Example Usage

```csharp
try
{
    ExerciseTypeListResponse result = await exerciseTypesController.GetExerciseTypesAsync();
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


# Create a New Exercise Type

```csharp
CreateANewExerciseTypeAsync(
    Models.ExerciseType body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ExerciseType`](../../doc/models/exercise-type.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsResponse>`](../../doc/models/just-gains-response.md)

## Example Usage

```csharp
ExerciseType body = new ExerciseType
{
    ExerciseTypeCode = "WEIGHT_REPS",
    ExerciseTypeName = "Weight and Repetitions",
    ExerciseTypeExerciseMetrics = new List<string>
    {
        "WEIGHT",
        "REPS",
    },
};

try
{
    JustGainsResponse result = await exerciseTypesController.CreateANewExerciseTypeAsync(body);
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


# Update an Exercise Type

```csharp
UpdateAnExerciseTypeAsync(
    string exerciseTypeCode,
    Models.ExerciseType body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseTypeCode` | `string` | Template, Required | - |
| `body` | [`ExerciseType`](../../doc/models/exercise-type.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsResponse>`](../../doc/models/just-gains-response.md)

## Example Usage

```csharp
string exerciseTypeCode = "exerciseTypeCode8";
ExerciseType body = new ExerciseType
{
    ExerciseTypeCode = "WEIGHT_REPS",
    ExerciseTypeName = "Weight and Repetitions",
    ExerciseTypeExerciseMetrics = new List<string>
    {
        "WEIGHT",
        "REPS",
    },
};

try
{
    JustGainsResponse result = await exerciseTypesController.UpdateAnExerciseTypeAsync(
        exerciseTypeCode,
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
| 404 | Exercise type not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Delete an Exercise Type

```csharp
DeleteAnExerciseTypeAsync(
    string exerciseTypeCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseTypeCode` | `string` | Template, Required | - |

## Response Type

[`Task<Models.JustGainsResponse>`](../../doc/models/just-gains-response.md)

## Example Usage

```csharp
string exerciseTypeCode = "exerciseTypeCode8";
try
{
    JustGainsResponse result = await exerciseTypesController.DeleteAnExerciseTypeAsync(exerciseTypeCode);
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
| 404 | Exercise type not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


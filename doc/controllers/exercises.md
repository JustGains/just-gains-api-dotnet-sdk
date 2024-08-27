# Exercises

Core exercise management functionality.

```csharp
ExercisesController exercisesController = client.ExercisesController;
```

## Class Name

`ExercisesController`

## Methods

* [Get Exercises](../../doc/controllers/exercises.md#get-exercises)
* [Create a New Exercise](../../doc/controllers/exercises.md#create-a-new-exercise)
* [Get Exercise](../../doc/controllers/exercises.md#get-exercise)
* [Update an Exercise](../../doc/controllers/exercises.md#update-an-exercise)
* [Delete an Exercise](../../doc/controllers/exercises.md#delete-an-exercise)
* [Get Exercise Translations](../../doc/controllers/exercises.md#get-exercise-translations)
* [Update Exercise Translations](../../doc/controllers/exercises.md#update-exercise-translations)
* [Get Exercise Muscle Group](../../doc/controllers/exercises.md#get-exercise-muscle-group)


# Get Exercises

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetExercisesAsync(
    List<string> exerciseCategoryCodes = null,
    List<string> exerciseTypeCodes = null,
    List<string> exerciseEquipmentCodes = null,
    List<string> exerciseMuscleCodes = null,
    List<string> exerciseMetricCodes = null,
    List<string> publishedStatusCodes = null,
    string localeCode = "en-US",
    int? pageIndex = 1,
    int? pageSize = 100)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCategoryCodes` | `List<string>` | Query, Optional | List of exercise category codes to filter by |
| `exerciseTypeCodes` | `List<string>` | Query, Optional | List of exercise types to filter by |
| `exerciseEquipmentCodes` | `List<string>` | Query, Optional | List of exercise equipment to filter by |
| `exerciseMuscleCodes` | `List<string>` | Query, Optional | - |
| `exerciseMetricCodes` | `List<string>` | Query, Optional | List of exercise metrics to filter by |
| `publishedStatusCodes` | `List<string>` | Query, Optional | List of publish statuses to filter by |
| `localeCode` | `string` | Query, Optional | Locale to filter by |
| `pageIndex` | `int?` | Query, Optional | Page index for pagination |
| `pageSize` | `int?` | Query, Optional | Page size for pagination |

## Response Type

[`Task<Models.ExercisesResponse>`](../../doc/models/exercises-response.md)

## Example Usage

```csharp
string localeCode = "en-US";
int? pageIndex = 1;
int? pageSize = 100;
try
{
    ExercisesResponse result = await exercisesController.GetExercisesAsync(
        null,
        null,
        null,
        null,
        null,
        null,
        localeCode,
        pageIndex,
        pageSize
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
| 400 | Bad request | [`Exercises400ErrorException`](../../doc/models/exercises-400-error-exception.md) |


# Create a New Exercise

```csharp
CreateANewExerciseAsync(
    Models.Exercise body,
    string localeCode = "en-US")
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Exercise`](../../doc/models/exercise.md) | Body, Required | - |
| `localeCode` | `string` | Query, Optional | Locale code to specify the language to return the newly created exercise in. |

## Response Type

[`Task<Models.ExercisesResponse1>`](../../doc/models/exercises-response-1.md)

## Example Usage

```csharp
Exercise body = new Exercise
{
    ExerciseCode = "BARBELL_SQUAT",
    ExerciseName = "Barbell Squat",
    UserId = new Guid("123e4567-e89b-12d3-a456-426614174000"),
    ExerciseTypeCode = "STRENGTH",
    PublishStatusCode = PublishStatusCodeEnum.UNREVIEWED,
    Difficulty = 7,
    MetabolicEquivalent = 8.5,
    IsPlateloaded = true,
    IsCardio = false,
    OlympicRating = 5,
    PowerLifterRating = 5,
    CalisthenicRating = 5,
    PopularityRating = 5,
    IsPlyometric = true,
    IsIsometric = false,
    IsCalisthenic = true,
    IsWeighted = false,
    IsUnilateral = true,
    IsBodyweight = true,
    AdminNotes = "This exercise requires supervision.",
};

string localeCode = "en-US";
try
{
    ExercisesResponse1 result = await exercisesController.CreateANewExerciseAsync(
        body,
        localeCode
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
| 400 | Invalid exercise data | [`Exercises400ErrorException`](../../doc/models/exercises-400-error-exception.md) |


# Get Exercise

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetExerciseAsync(
    string exerciseCode,
    string localeCode = "en-US")
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | - |
| `localeCode` | `string` | Query, Optional | Locale code to specify the language for exercise details |

## Response Type

[`Task<Models.ExercisesResponse2>`](../../doc/models/exercises-response-2.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
string localeCode = "en-US";
try
{
    ExercisesResponse2 result = await exercisesController.GetExerciseAsync(
        exerciseCode,
        localeCode
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
| 400 | Bad request | [`Exercises400ErrorException`](../../doc/models/exercises-400-error-exception.md) |
| 404 | Exercise not found | [`Exercises404ErrorException`](../../doc/models/exercises-404-error-exception.md) |


# Update an Exercise

```csharp
UpdateAnExerciseAsync(
    string exerciseCode,
    Models.Exercise body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | - |
| `body` | [`Exercise`](../../doc/models/exercise.md) | Body, Required | - |

## Response Type

[`Task<Models.ExercisesResponse2>`](../../doc/models/exercises-response-2.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
Exercise body = new Exercise
{
    ExerciseCode = "BARBELL_SQUAT",
    ExerciseName = "Barbell Squat",
    UserId = new Guid("123e4567-e89b-12d3-a456-426614174000"),
    ExerciseTypeCode = "STRENGTH",
    PublishStatusCode = PublishStatusCodeEnum.UNREVIEWED,
    Difficulty = 7,
    MetabolicEquivalent = 8.5,
    IsPlateloaded = true,
    IsCardio = false,
    OlympicRating = 5,
    PowerLifterRating = 5,
    CalisthenicRating = 5,
    PopularityRating = 5,
    IsPlyometric = true,
    IsIsometric = false,
    IsCalisthenic = true,
    IsWeighted = false,
    IsUnilateral = true,
    IsBodyweight = true,
    AdminNotes = "This exercise requires supervision.",
};

try
{
    ExercisesResponse2 result = await exercisesController.UpdateAnExerciseAsync(
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
| 400 | Invalid exercise data | [`Exercises400ErrorException`](../../doc/models/exercises-400-error-exception.md) |
| 500 | Internal server error | [`Exercises500ErrorException`](../../doc/models/exercises-500-error-exception.md) |


# Delete an Exercise

```csharp
DeleteAnExerciseAsync(
    string exerciseCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | - |

## Response Type

[`Task<Models.ExercisesResponse4>`](../../doc/models/exercises-response-4.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
try
{
    ExercisesResponse4 result = await exercisesController.DeleteAnExerciseAsync(exerciseCode);
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
| 400 | Bad request | [`Exercises400ErrorException`](../../doc/models/exercises-400-error-exception.md) |
| 401 | Unauthorized | [`Exercises401ErrorException`](../../doc/models/exercises-401-error-exception.md) |
| 404 | Exercise not found | [`Exercises404ErrorException`](../../doc/models/exercises-404-error-exception.md) |
| 500 | Internal server error | [`Exercises500ErrorException`](../../doc/models/exercises-500-error-exception.md) |


# Get Exercise Translations

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetExerciseTranslationsAsync(
    string exerciseCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The unique code of the exercise |

## Response Type

[`Task<Models.ExercisesTranslationsResponse>`](../../doc/models/exercises-translations-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
try
{
    ExercisesTranslationsResponse result = await exercisesController.GetExerciseTranslationsAsync(exerciseCode);
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
| 400 | Bad request | [`ExercisesTranslations400ErrorException`](../../doc/models/exercises-translations-400-error-exception.md) |
| 404 | Exercise translations not found | [`ExercisesTranslations404ErrorException`](../../doc/models/exercises-translations-404-error-exception.md) |


# Update Exercise Translations

:information_source: **Note** This endpoint does not require authentication.

```csharp
UpdateExerciseTranslationsAsync(
    string exerciseCode,
    List<Models.ExerciseTranslation> body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The unique code of the exercise |
| `body` | [`List<ExerciseTranslation>`](../../doc/models/exercise-translation.md) | Body, Required | - |

## Response Type

[`Task<Models.ExercisesTranslationsResponse1>`](../../doc/models/exercises-translations-response-1.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
List<Models.ExerciseTranslation> body = new List<Models.ExerciseTranslation>
{
    new ExerciseTranslation
    {
        LocaleCode = "en-US",
    },
};

try
{
    ExercisesTranslationsResponse1 result = await exercisesController.UpdateExerciseTranslationsAsync(
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
| 400 | Bad request | [`ExercisesTranslations400ErrorException`](../../doc/models/exercises-translations-400-error-exception.md) |
| 404 | Exercise not found | [`ExercisesTranslations404ErrorException`](../../doc/models/exercises-translations-404-error-exception.md) |
| 422 | Validation error | [`ExercisesTranslations422ErrorException`](../../doc/models/exercises-translations-422-error-exception.md) |


# Get Exercise Muscle Group

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetExerciseMuscleGroupAsync(
    string exerciseCode,
    string localeCode = "en-US")
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCode` | `string` | Template, Required | The unique code of the exercise |
| `localeCode` | `string` | Query, Optional | The locale code for the muscle group names (e.g., 'en-US', 'es-ES') |

## Response Type

[`Task<Models.ExercisesMuscleGroupsResponse>`](../../doc/models/exercises-muscle-groups-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
string localeCode = "en-US";
try
{
    ExercisesMuscleGroupsResponse result = await exercisesController.GetExerciseMuscleGroupAsync(
        exerciseCode,
        localeCode
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
| 400 | Bad request | [`ExercisesMuscleGroups400ErrorException`](../../doc/models/exercises-muscle-groups-400-error-exception.md) |
| 404 | Exercise not found | [`ExercisesMuscleGroups404ErrorException`](../../doc/models/exercises-muscle-groups-404-error-exception.md) |


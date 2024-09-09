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
    List<string> exerciseEquipmentCodes = null,
    List<string> exerciseMetricCodes = null,
    List<string> exerciseMuscleCodes = null,
    List<string> exerciseTypeCodes = null,
    string localeCode = "en-US",
    string nameSearch = null,
    int? pageIndex = 1,
    int? pageSize = 100,
    List<string> publishedStatusCodes = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCategoryCodes` | `List<string>` | Query, Optional | List of exercise category codes to filter by<br>**Constraints**: *Pattern*: `^[A-Z_]+$` |
| `exerciseEquipmentCodes` | `List<string>` | Query, Optional | List of exercise equipment to filter by<br>**Constraints**: *Pattern*: `^[A-Z_]+$` |
| `exerciseMetricCodes` | `List<string>` | Query, Optional | List of exercise metrics to filter by<br>**Constraints**: *Pattern*: `^[A-Z_]+$` |
| `exerciseMuscleCodes` | `List<string>` | Query, Optional | **Constraints**: *Pattern*: `^[A-Z_]+$` |
| `exerciseTypeCodes` | `List<string>` | Query, Optional | List of exercise types to filter by<br>**Constraints**: *Pattern*: `^[A-Z_]+$` |
| `localeCode` | `string` | Query, Optional | Locale to filter by<br>**Default**: `"en-US"`<br>**Constraints**: *Pattern*: `^[a-z]{2}-[A-Z]{2}$` |
| `nameSearch` | `string` | Query, Optional | List of exercise names to filter by |
| `pageIndex` | `int?` | Query, Optional | Page index for pagination<br>**Default**: `1` |
| `pageSize` | `int?` | Query, Optional | Page size for pagination<br>**Default**: `100` |
| `publishedStatusCodes` | `List<string>` | Query, Optional | List of publish statuses to filter by<br>**Constraints**: *Pattern*: `^[A-Z_]+$` |

## Response Type

[`Task<Models.ExerciseListResponse>`](../../doc/models/exercise-list-response.md)

## Example Usage

```csharp
List<string> exerciseCategoryCodes = new List<string>
{
    "STRENGTH",
    "CARDIO",
};

string localeCode = "en-US";
string nameSearch = "Bench Press";
int? pageIndex = 1;
int? pageSize = 100;
try
{
    ExerciseListResponse result = await exercisesController.GetExercisesAsync(
        exerciseCategoryCodes,
        null,
        null,
        null,
        null,
        localeCode,
        nameSearch,
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
| 400 | Bad request | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


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
| `localeCode` | `string` | Query, Optional | Locale code to specify the language to return the newly created exercise in.<br>**Default**: `"en-US"`<br>**Constraints**: *Pattern*: `^[a-z]{2}-[A-Z]{2}$` |

## Response Type

[`Task<Models.ExerciseResponse>`](../../doc/models/exercise-response.md)

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
    ExerciseResponse result = await exercisesController.CreateANewExerciseAsync(
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
| 400 | Invalid exercise data | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


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
| `localeCode` | `string` | Query, Optional | Locale code to specify the language for exercise details<br>**Default**: `"en-US"`<br>**Constraints**: *Pattern*: `^[a-z]{2}-[A-Z]{2}$` |

## Response Type

[`Task<Models.ExerciseResponse>`](../../doc/models/exercise-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
string localeCode = "en-US";
try
{
    ExerciseResponse result = await exercisesController.GetExerciseAsync(
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
| 400 | Bad request | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Exercise not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Update an Exercise

```csharp
UpdateAnExerciseAsync(
    Models.Exercise body,
    string exerciseCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Exercise`](../../doc/models/exercise.md) | Body, Required | - |
| `exerciseCode` | `string` | Template, Required | - |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

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

string exerciseCode = "exerciseCode8";
try
{
    JustGainsBasicResponse result = await exercisesController.UpdateAnExerciseAsync(
        body,
        exerciseCode
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
| 400 | Invalid exercise data | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


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

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
try
{
    JustGainsBasicResponse result = await exercisesController.DeleteAnExerciseAsync(exerciseCode);
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
| 404 | Exercise not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


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

[`Task<Models.ExerciseTranslationListResponse>`](../../doc/models/exercise-translation-list-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
try
{
    ExerciseTranslationListResponse result = await exercisesController.GetExerciseTranslationsAsync(exerciseCode);
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
| 404 | Exercise translations not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Update Exercise Translations

:information_source: **Note** This endpoint does not require authentication.

```csharp
UpdateExerciseTranslationsAsync(
    List<Models.ExerciseTranslation> body,
    string exerciseCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`List<ExerciseTranslation>`](../../doc/models/exercise-translation.md) | Body, Required | - |
| `exerciseCode` | `string` | Template, Required | The unique code of the exercise |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
List<ExerciseTranslation> body = new List<ExerciseTranslation>
{
    new ExerciseTranslation
    {
        LocaleCode = "en-US",
    },
};

string exerciseCode = "exerciseCode8";
try
{
    JustGainsBasicResponse result = await exercisesController.UpdateExerciseTranslationsAsync(
        body,
        exerciseCode
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
| 404 | Exercise not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 422 | Validation error | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


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
| `localeCode` | `string` | Query, Optional | The locale code for the muscle group names (e.g., 'en-US', 'es-ES')<br>**Default**: `"en-US"`<br>**Constraints**: *Pattern*: `^[a-z]{2}-[A-Z]{2}$` |

## Response Type

[`Task<Models.MuscleGroupDtoResponse>`](../../doc/models/muscle-group-dto-response.md)

## Example Usage

```csharp
string exerciseCode = "exerciseCode8";
string localeCode = "en-US";
try
{
    MuscleGroupDtoResponse result = await exercisesController.GetExerciseMuscleGroupAsync(
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
| 400 | Bad request | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Exercise not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


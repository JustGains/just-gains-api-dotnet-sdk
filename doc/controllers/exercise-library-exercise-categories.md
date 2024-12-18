# Exercise Library Exercise Categories

```csharp
ExerciseLibraryExerciseCategoriesController exerciseLibraryExerciseCategoriesController = client.ExerciseLibraryExerciseCategoriesController;
```

## Class Name

`ExerciseLibraryExerciseCategoriesController`

## Methods

* [Get Exercise Categories](../../doc/controllers/exercise-library-exercise-categories.md#get-exercise-categories)
* [Create Exercise Category](../../doc/controllers/exercise-library-exercise-categories.md#create-exercise-category)
* [Update Exercise Category](../../doc/controllers/exercise-library-exercise-categories.md#update-exercise-category)
* [Delete an Exercise Category](../../doc/controllers/exercise-library-exercise-categories.md#delete-an-exercise-category)
* [Get Exercise Category Translations](../../doc/controllers/exercise-library-exercise-categories.md#get-exercise-category-translations)
* [Update Exercise Category Translations](../../doc/controllers/exercise-library-exercise-categories.md#update-exercise-category-translations)


# Get Exercise Categories

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetExerciseCategoriesAsync(
    string localeCode = "en-US")
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `localeCode` | `string` | Query, Optional | The locale for returned category names<br>**Default**: `"en-US"`<br>**Constraints**: *Pattern*: `^[a-z]{2}-[A-Z]{2}$` |

## Response Type

[`Task<Models.ExerciseCategoryListResponse>`](../../doc/models/exercise-category-list-response.md)

## Example Usage

```csharp
string localeCode = "en-US";
try
{
    ExerciseCategoryListResponse result = await exerciseLibraryExerciseCategoriesController.GetExerciseCategoriesAsync(localeCode);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Exercise Category

```csharp
CreateExerciseCategoryAsync(
    Models.ExerciseCategory body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ExerciseCategory`](../../doc/models/exercise-category.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
ExerciseCategory body = new ExerciseCategory
{
    ExerciseCategoryCode = "STRENGTH_TRAINING",
};

try
{
    JustGainsBasicResponse result = await exerciseLibraryExerciseCategoriesController.CreateExerciseCategoryAsync(body);
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
| 400 | Bad Request | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Update Exercise Category

```csharp
UpdateExerciseCategoryAsync(
    string exerciseCategoryCode,
    Models.ExerciseCategory body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCategoryCode` | `string` | Template, Required | - |
| `body` | [`ExerciseCategory`](../../doc/models/exercise-category.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
string exerciseCategoryCode = "exerciseCategoryCode8";
ExerciseCategory body = new ExerciseCategory
{
    ExerciseCategoryCode = "STRENGTH_TRAINING",
};

try
{
    JustGainsBasicResponse result = await exerciseLibraryExerciseCategoriesController.UpdateExerciseCategoryAsync(
        exerciseCategoryCode,
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
| 400 | Bad Request | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Category not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Delete an Exercise Category

```csharp
DeleteAnExerciseCategoryAsync(
    string exerciseCategoryCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCategoryCode` | `string` | Template, Required | - |

## Response Type

[`Task<Models.JustGainsResponse>`](../../doc/models/just-gains-response.md)

## Example Usage

```csharp
string exerciseCategoryCode = "exerciseCategoryCode8";
try
{
    JustGainsResponse result = await exerciseLibraryExerciseCategoriesController.DeleteAnExerciseCategoryAsync(exerciseCategoryCode);
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
| 404 | Category not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Get Exercise Category Translations

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetExerciseCategoryTranslationsAsync(
    string exerciseCategoryCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCategoryCode` | `string` | Template, Required | The unique code of the exercise category |

## Response Type

[`Task<Models.ExerciseCategoryTranslationListResponse>`](../../doc/models/exercise-category-translation-list-response.md)

## Example Usage

```csharp
string exerciseCategoryCode = "exerciseCategoryCode8";
try
{
    ExerciseCategoryTranslationListResponse result = await exerciseLibraryExerciseCategoriesController.GetExerciseCategoryTranslationsAsync(exerciseCategoryCode);
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
| 404 | Exercise category not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Update Exercise Category Translations

:information_source: **Note** This endpoint does not require authentication.

```csharp
UpdateExerciseCategoryTranslationsAsync(
    string exerciseCategoryCode,
    List<Models.ExerciseCategoryTranslation> body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCategoryCode` | `string` | Template, Required | The unique code of the exercise category |
| `body` | [`List<ExerciseCategoryTranslation>`](../../doc/models/exercise-category-translation.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
string exerciseCategoryCode = "exerciseCategoryCode8";
List<ExerciseCategoryTranslation> body = new List<ExerciseCategoryTranslation>
{
    new ExerciseCategoryTranslation
    {
        LocaleCode = "en-US",
        ExerciseCategoryName = "Strength Training",
    },
};

try
{
    JustGainsBasicResponse result = await exerciseLibraryExerciseCategoriesController.UpdateExerciseCategoryTranslationsAsync(
        exerciseCategoryCode,
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
| 404 | Exercise category not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 422 | Validation error | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


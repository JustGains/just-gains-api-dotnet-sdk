# Exercise Categories

```csharp
ExerciseCategoriesController exerciseCategoriesController = client.ExerciseCategoriesController;
```

## Class Name

`ExerciseCategoriesController`

## Methods

* [Get Exercise Categories](../../doc/controllers/exercise-categories.md#get-exercise-categories)
* [Create Exercise Category](../../doc/controllers/exercise-categories.md#create-exercise-category)
* [Get Exercise Category](../../doc/controllers/exercise-categories.md#get-exercise-category)
* [Update an Exercise Category](../../doc/controllers/exercise-categories.md#update-an-exercise-category)
* [Delete an Exercise Category](../../doc/controllers/exercise-categories.md#delete-an-exercise-category)
* [Get Exercise Category Translations](../../doc/controllers/exercise-categories.md#get-exercise-category-translations)
* [Update Exercise Category Translations](../../doc/controllers/exercise-categories.md#update-exercise-category-translations)


# Get Exercise Categories

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetExerciseCategoriesAsync(
    string localeCode = "en-US")
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `localeCode` | `string` | Query, Optional | The locale for returned category names |

## Response Type

[`Task<Models.ExerciseCategoriesResponse>`](../../doc/models/exercise-categories-response.md)

## Example Usage

```csharp
string localeCode = "en-US";
try
{
    ExerciseCategoriesResponse result = await exerciseCategoriesController.GetExerciseCategoriesAsync(localeCode);
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

[`Task<Models.ExerciseCategoriesResponse1>`](../../doc/models/exercise-categories-response-1.md)

## Example Usage

```csharp
ExerciseCategory body = new ExerciseCategory
{
    ExerciseCategoryCode = "STRENGTH_TRAINING",
    ExerciseCategoryName = "Strength Training",
};

try
{
    ExerciseCategoriesResponse1 result = await exerciseCategoriesController.CreateExerciseCategoryAsync(body);
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
| 400 | Bad Request | [`ExerciseCategories400ErrorException`](../../doc/models/exercise-categories-400-error-exception.md) |


# Get Exercise Category

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetExerciseCategoryAsync(
    string exerciseCategoryCode,
    string localeCode = "en-US")
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCategoryCode` | `string` | Template, Required | - |
| `localeCode` | `string` | Query, Optional | The locale for returned category name |

## Response Type

[`Task<Models.ExerciseCategoriesResponse1>`](../../doc/models/exercise-categories-response-1.md)

## Example Usage

```csharp
string exerciseCategoryCode = "exerciseCategoryCode8";
string localeCode = "en-US";
try
{
    ExerciseCategoriesResponse1 result = await exerciseCategoriesController.GetExerciseCategoryAsync(
        exerciseCategoryCode,
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
| 404 | Exercise Category Not Found | [`ExerciseCategories404ErrorException`](../../doc/models/exercise-categories-404-error-exception.md) |


# Update an Exercise Category

```csharp
UpdateAnExerciseCategoryAsync(
    string exerciseCategoryCode,
    Models.ExerciseCategory body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `exerciseCategoryCode` | `string` | Template, Required | - |
| `body` | [`ExerciseCategory`](../../doc/models/exercise-category.md) | Body, Required | - |

## Response Type

[`Task<Models.ExerciseCategoriesResponse1>`](../../doc/models/exercise-categories-response-1.md)

## Example Usage

```csharp
string exerciseCategoryCode = "exerciseCategoryCode8";
ExerciseCategory body = new ExerciseCategory
{
    ExerciseCategoryCode = "STRENGTH_TRAINING",
    ExerciseCategoryName = "Strength Training",
};

try
{
    ExerciseCategoriesResponse1 result = await exerciseCategoriesController.UpdateAnExerciseCategoryAsync(
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
| 400 | Bad Request | [`ExerciseCategories400ErrorException`](../../doc/models/exercise-categories-400-error-exception.md) |
| 404 | Category not found | [`ExerciseCategories404ErrorException`](../../doc/models/exercise-categories-404-error-exception.md) |


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

[`Task<Models.ExerciseCategoriesResponse4>`](../../doc/models/exercise-categories-response-4.md)

## Example Usage

```csharp
string exerciseCategoryCode = "exerciseCategoryCode8";
try
{
    ExerciseCategoriesResponse4 result = await exerciseCategoriesController.DeleteAnExerciseCategoryAsync(exerciseCategoryCode);
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
| 404 | Category not found | [`ExerciseCategories404ErrorException`](../../doc/models/exercise-categories-404-error-exception.md) |


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

[`Task<Models.ExerciseCategoriesTranslationsResponse>`](../../doc/models/exercise-categories-translations-response.md)

## Example Usage

```csharp
string exerciseCategoryCode = "exerciseCategoryCode8";
try
{
    ExerciseCategoriesTranslationsResponse result = await exerciseCategoriesController.GetExerciseCategoryTranslationsAsync(exerciseCategoryCode);
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
| 400 | Bad request | [`ExerciseCategoriesTranslations400ErrorException`](../../doc/models/exercise-categories-translations-400-error-exception.md) |
| 404 | Exercise category not found | [`ExerciseCategoriesTranslations404ErrorException`](../../doc/models/exercise-categories-translations-404-error-exception.md) |


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

[`Task<Models.ExerciseCategoriesTranslationsResponse1>`](../../doc/models/exercise-categories-translations-response-1.md)

## Example Usage

```csharp
string exerciseCategoryCode = "exerciseCategoryCode8";
List<Models.ExerciseCategoryTranslation> body = new List<Models.ExerciseCategoryTranslation>
{
    new ExerciseCategoryTranslation
    {
        LocaleCode = "en-US",
        ExerciseCategoryName = "Strength Training",
    },
};

try
{
    ExerciseCategoriesTranslationsResponse1 result = await exerciseCategoriesController.UpdateExerciseCategoryTranslationsAsync(
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
| 400 | Bad request | [`ExerciseCategoriesTranslations400ErrorException`](../../doc/models/exercise-categories-translations-400-error-exception.md) |
| 404 | Exercise category not found | [`ExerciseCategoriesTranslations404ErrorException`](../../doc/models/exercise-categories-translations-404-error-exception.md) |
| 422 | Validation error | [`ExerciseCategoriesTranslations422ErrorException`](../../doc/models/exercise-categories-translations-422-error-exception.md) |


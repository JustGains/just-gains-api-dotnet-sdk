# Exercise Library Muscles

```csharp
ExerciseLibraryMusclesController exerciseLibraryMusclesController = client.ExerciseLibraryMusclesController;
```

## Class Name

`ExerciseLibraryMusclesController`

## Methods

* [Get Muscles](../../doc/controllers/exercise-library-muscles.md#get-muscles)
* [Get Muscle Translations](../../doc/controllers/exercise-library-muscles.md#get-muscle-translations)
* [Update Muscle Translations](../../doc/controllers/exercise-library-muscles.md#update-muscle-translations)


# Get Muscles

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetMusclesAsync(
    string localeCode = "en-US")
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `localeCode` | `string` | Query, Optional | Locale code to filter muscles by language<br>**Default**: `"en-US"`<br>**Constraints**: *Pattern*: `^[a-z]{2}-[A-Z]{2}$` |

## Response Type

[`Task<Models.MuscleListResponse>`](../../doc/models/muscle-list-response.md)

## Example Usage

```csharp
string localeCode = "en-US";
try
{
    MuscleListResponse result = await exerciseLibraryMusclesController.GetMusclesAsync(localeCode);
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
| 400 | Failed to retrieve muscles | [`Muscles400ErrorException`](../../doc/models/muscles-400-error-exception.md) |


# Get Muscle Translations

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetMuscleTranslationsAsync(
    string muscleCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `muscleCode` | `string` | Template, Required | The unique identifier code of the muscle to retrieve translations for |

## Response Type

[`Task<Models.MuscleTranslationListResponse>`](../../doc/models/muscle-translation-list-response.md)

## Example Usage

```csharp
string muscleCode = "muscleCode0";
try
{
    MuscleTranslationListResponse result = await exerciseLibraryMusclesController.GetMuscleTranslationsAsync(muscleCode);
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
| 400 | Failed to retrieve muscle translations | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Muscle not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Update Muscle Translations

```csharp
UpdateMuscleTranslationsAsync(
    string muscleCode,
    List<Models.MuscleTranslation> body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `muscleCode` | `string` | Template, Required | The unique identifier code of the muscle to update translations for |
| `body` | [`List<MuscleTranslation>`](../../doc/models/muscle-translation.md) | Body, Required | - |

## Response Type

[`Task<Models.MusclesTranslationsResponse1>`](../../doc/models/muscles-translations-response-1.md)

## Example Usage

```csharp
string muscleCode = "muscleCode0";
List<MuscleTranslation> body = new List<MuscleTranslation>
{
    new MuscleTranslation
    {
        MuscleCode = "QUAD",
        LocaleCode = "en-US",
        MuscleName = "Quadriceps",
    },
};

try
{
    MusclesTranslationsResponse1 result = await exerciseLibraryMusclesController.UpdateMuscleTranslationsAsync(
        muscleCode,
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
| 400 | Failed to update muscle translations | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 401 | Unauthorized | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Muscle not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


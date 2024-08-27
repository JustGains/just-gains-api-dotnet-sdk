# Muscles

Information about individual muscles and muscle anatomy.

```csharp
MusclesController musclesController = client.MusclesController;
```

## Class Name

`MusclesController`

## Methods

* [Get Muscles](../../doc/controllers/muscles.md#get-muscles)
* [Get Muscle](../../doc/controllers/muscles.md#get-muscle)
* [Get Muscle Translations](../../doc/controllers/muscles.md#get-muscle-translations)
* [Update Muscle Translations](../../doc/controllers/muscles.md#update-muscle-translations)


# Get Muscles

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetMusclesAsync(
    string localeCode = "en-US")
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `localeCode` | `string` | Query, Optional | Locale code to filter muscles by language |

## Response Type

[`Task<Models.MusclesResponse>`](../../doc/models/muscles-response.md)

## Example Usage

```csharp
string localeCode = "en-US";
try
{
    MusclesResponse result = await musclesController.GetMusclesAsync(localeCode);
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


# Get Muscle

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetMuscleAsync(
    string muscleCode,
    string localeCode = "en-US")
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `muscleCode` | `string` | Template, Required | The muscle code to retrieve. |
| `localeCode` | `string` | Query, Optional | - |

## Response Type

[`Task<Models.MusclesResponse1>`](../../doc/models/muscles-response-1.md)

## Example Usage

```csharp
string muscleCode = "muscleCode0";
string localeCode = "en-US";
try
{
    MusclesResponse1 result = await musclesController.GetMuscleAsync(
        muscleCode,
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
| 400 | Failed to retrieve muscle | [`Muscles400ErrorException`](../../doc/models/muscles-400-error-exception.md) |
| 404 | Muscle not found | [`Muscles404ErrorException`](../../doc/models/muscles-404-error-exception.md) |


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

[`Task<Models.MusclesTranslationsResponse>`](../../doc/models/muscles-translations-response.md)

## Example Usage

```csharp
string muscleCode = "muscleCode0";
try
{
    MusclesTranslationsResponse result = await musclesController.GetMuscleTranslationsAsync(muscleCode);
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
| 400 | Failed to retrieve muscle translations | [`MusclesTranslations400ErrorException`](../../doc/models/muscles-translations-400-error-exception.md) |
| 404 | Muscle not found | [`MusclesTranslations404ErrorException`](../../doc/models/muscles-translations-404-error-exception.md) |


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
List<Models.MuscleTranslation> body = new List<Models.MuscleTranslation>
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
    MusclesTranslationsResponse1 result = await musclesController.UpdateMuscleTranslationsAsync(
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
| 400 | Failed to update muscle translations | [`MusclesTranslations400ErrorException`](../../doc/models/muscles-translations-400-error-exception.md) |
| 401 | Unauthorized | [`MusclesTranslations401ErrorException`](../../doc/models/muscles-translations-401-error-exception.md) |
| 404 | Muscle not found | [`MusclesTranslations404ErrorException`](../../doc/models/muscles-translations-404-error-exception.md) |


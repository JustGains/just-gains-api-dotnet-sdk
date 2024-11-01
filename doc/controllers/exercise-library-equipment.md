# Exercise Library Equipment

```csharp
ExerciseLibraryEquipmentController exerciseLibraryEquipmentController = client.ExerciseLibraryEquipmentController;
```

## Class Name

`ExerciseLibraryEquipmentController`

## Methods

* [Get Equipments](../../doc/controllers/exercise-library-equipment.md#get-equipments)
* [Create Equipment](../../doc/controllers/exercise-library-equipment.md#create-equipment)
* [Get Equipment](../../doc/controllers/exercise-library-equipment.md#get-equipment)
* [Update Equipment](../../doc/controllers/exercise-library-equipment.md#update-equipment)
* [Delete Equipment](../../doc/controllers/exercise-library-equipment.md#delete-equipment)
* [Get Equipment Translations](../../doc/controllers/exercise-library-equipment.md#get-equipment-translations)
* [Update Equipment Translations](../../doc/controllers/exercise-library-equipment.md#update-equipment-translations)


# Get Equipments

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetEquipmentsAsync(
    string localeCode = "en-US")
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `localeCode` | `string` | Query, Optional | The locale to use for the localized equipment names.<br>**Default**: `"en-US"`<br>**Constraints**: *Pattern*: `^[a-z]{2}-[A-Z]{2}$` |

## Response Type

[`Task<Models.EquipmentListResponse>`](../../doc/models/equipment-list-response.md)

## Example Usage

```csharp
string localeCode = "en-US";
try
{
    EquipmentListResponse result = await exerciseLibraryEquipmentController.GetEquipmentsAsync(localeCode);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Equipment

```csharp
CreateEquipmentAsync(
    Models.Equipment body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Equipment`](../../doc/models/equipment.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
Equipment body = new Equipment
{
    EquipmentCode = "BARBELL",
    EquipmentEquipmentGroups = new List<string>
    {
        "WEIGHTS",
        "FREE_WEIGHTS",
    },
};

try
{
    JustGainsBasicResponse result = await exerciseLibraryEquipmentController.CreateEquipmentAsync(body);
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
| 400 | Invalid request data. | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Get Equipment

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetEquipmentAsync(
    string equipmentCode,
    string localeCode = "en-US")
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `equipmentCode` | `string` | Template, Required | The unique code identifying the equipment. |
| `localeCode` | `string` | Query, Optional | The locale to use for the localized equipment names.<br>**Default**: `"en-US"`<br>**Constraints**: *Pattern*: `^[a-z]{2}-[A-Z]{2}$` |

## Response Type

[`Task<Models.EquipmentResponse>`](../../doc/models/equipment-response.md)

## Example Usage

```csharp
string equipmentCode = "equipmentCode6";
string localeCode = "en-US";
try
{
    EquipmentResponse result = await exerciseLibraryEquipmentController.GetEquipmentAsync(
        equipmentCode,
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
| 404 | Equipment not found with the given code. | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Update Equipment

```csharp
UpdateEquipmentAsync(
    string equipmentCode,
    Models.Equipment body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `equipmentCode` | `string` | Template, Required | The unique code identifying the equipment to update. |
| `body` | [`Equipment`](../../doc/models/equipment.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
string equipmentCode = "equipmentCode6";
Equipment body = new Equipment
{
    EquipmentCode = "BARBELL",
    EquipmentEquipmentGroups = new List<string>
    {
        "WEIGHTS",
        "FREE_WEIGHTS",
    },
};

try
{
    JustGainsBasicResponse result = await exerciseLibraryEquipmentController.UpdateEquipmentAsync(
        equipmentCode,
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
| 400 | Bad request. Invalid input data. | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Equipment not found with the given code. | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 409 | Conflict. The equipment code already exists for a different equipment. | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Delete Equipment

```csharp
DeleteEquipmentAsync(
    string equipmentCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `equipmentCode` | `string` | Template, Required | The unique code identifying the equipment to delete. |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
string equipmentCode = "equipmentCode6";
try
{
    JustGainsBasicResponse result = await exerciseLibraryEquipmentController.DeleteEquipmentAsync(equipmentCode);
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
| 400 | Failed to delete the equipment or equipment does not exist. | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Get Equipment Translations

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetEquipmentTranslationsAsync(
    string equipmentCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `equipmentCode` | `string` | Template, Required | The unique code of the equipment |

## Response Type

[`Task<Models.EquipmentTranslationListResponse>`](../../doc/models/equipment-translation-list-response.md)

## Example Usage

```csharp
string equipmentCode = "equipmentCode6";
try
{
    EquipmentTranslationListResponse result = await exerciseLibraryEquipmentController.GetEquipmentTranslationsAsync(equipmentCode);
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
| 404 | Equipment not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Update Equipment Translations

:information_source: **Note** This endpoint does not require authentication.

```csharp
UpdateEquipmentTranslationsAsync(
    string equipmentCode,
    Models.EquipmentTranslation body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `equipmentCode` | `string` | Template, Required | The unique code of the equipment |
| `body` | [`EquipmentTranslation`](../../doc/models/equipment-translation.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
string equipmentCode = "equipmentCode6";
EquipmentTranslation body = new EquipmentTranslation
{
    EquipmentName = "Barbell",
    LocaleCode = "en-US",
};

try
{
    JustGainsBasicResponse result = await exerciseLibraryEquipmentController.UpdateEquipmentTranslationsAsync(
        equipmentCode,
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
| 404 | Equipment not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


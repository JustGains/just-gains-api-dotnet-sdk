# Equipment

Manage exercise equipment.

```csharp
EquipmentController equipmentController = client.EquipmentController;
```

## Class Name

`EquipmentController`

## Methods

* [Get Equipments](../../doc/controllers/equipment.md#get-equipments)
* [Create Equipment](../../doc/controllers/equipment.md#create-equipment)
* [Get Equipment](../../doc/controllers/equipment.md#get-equipment)
* [Update Equipment](../../doc/controllers/equipment.md#update-equipment)
* [Delete Equipment](../../doc/controllers/equipment.md#delete-equipment)
* [Get Equipment Translations](../../doc/controllers/equipment.md#get-equipment-translations)
* [Update Equipment Translations](../../doc/controllers/equipment.md#update-equipment-translations)


# Get Equipments

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetEquipmentsAsync(
    string localeCode = "en-US")
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `localeCode` | `string` | Query, Optional | The locale to use for the localized equipment names. |

## Response Type

[`Task<Models.EquipmentListResponse>`](../../doc/models/equipment-list-response.md)

## Example Usage

```csharp
string localeCode = "en-US";
try
{
    EquipmentListResponse result = await equipmentController.GetEquipmentsAsync(localeCode);
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
    EquipmentName = "Barbell",
    EquipmentEquipmentGroups = new List<string>
    {
        "WEIGHTS",
        "FREE_WEIGHTS",
    },
};

try
{
    JustGainsBasicResponse result = await equipmentController.CreateEquipmentAsync(body);
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
| `localeCode` | `string` | Query, Optional | The locale to use for the localized equipment names. |

## Response Type

[`Task<Models.EquipmentResponse>`](../../doc/models/equipment-response.md)

## Example Usage

```csharp
string equipmentCode = "equipmentCode6";
string localeCode = "en-US";
try
{
    EquipmentResponse result = await equipmentController.GetEquipmentAsync(
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
    EquipmentName = "Barbell",
    EquipmentEquipmentGroups = new List<string>
    {
        "WEIGHTS",
        "FREE_WEIGHTS",
    },
};

try
{
    JustGainsBasicResponse result = await equipmentController.UpdateEquipmentAsync(
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
    JustGainsBasicResponse result = await equipmentController.DeleteEquipmentAsync(equipmentCode);
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
    EquipmentTranslationListResponse result = await equipmentController.GetEquipmentTranslationsAsync(equipmentCode);
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
| 400 | Bad request | [`EquipmentTranslations400ErrorException`](../../doc/models/equipment-translations-400-error-exception.md) |
| 404 | Equipment not found | [`EquipmentTranslations404ErrorException`](../../doc/models/equipment-translations-404-error-exception.md) |


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
    JustGainsBasicResponse result = await equipmentController.UpdateEquipmentTranslationsAsync(
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


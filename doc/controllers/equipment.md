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

[`Task<Models.EquipmentResponse>`](../../doc/models/equipment-response.md)

## Example Usage

```csharp
string localeCode = "en-US";
try
{
    EquipmentResponse result = await equipmentController.GetEquipmentsAsync(localeCode);
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

[`Task<Models.EquipmentResponse1>`](../../doc/models/equipment-response-1.md)

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
    EquipmentResponse1 result = await equipmentController.CreateEquipmentAsync(body);
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
| 400 | Invalid request data. | [`Equipment400ErrorException`](../../doc/models/equipment-400-error-exception.md) |


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

[`Task<Models.EquipmentResponse1>`](../../doc/models/equipment-response-1.md)

## Example Usage

```csharp
string equipmentCode = "equipmentCode6";
string localeCode = "en-US";
try
{
    EquipmentResponse1 result = await equipmentController.GetEquipmentAsync(
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
| 404 | Equipment not found with the given code. | [`Equipment404ErrorException`](../../doc/models/equipment-404-error-exception.md) |


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

[`Task<Models.EquipmentResponse1>`](../../doc/models/equipment-response-1.md)

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
    EquipmentResponse1 result = await equipmentController.UpdateEquipmentAsync(
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
| 400 | Bad request. Invalid input data. | [`Equipment400ErrorException`](../../doc/models/equipment-400-error-exception.md) |
| 404 | Equipment not found with the given code. | [`Equipment404ErrorException`](../../doc/models/equipment-404-error-exception.md) |
| 409 | Conflict. The equipment code already exists for a different equipment. | [`Equipment409ErrorException`](../../doc/models/equipment-409-error-exception.md) |


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

[`Task<Models.EquipmentResponse4>`](../../doc/models/equipment-response-4.md)

## Example Usage

```csharp
string equipmentCode = "equipmentCode6";
try
{
    EquipmentResponse4 result = await equipmentController.DeleteEquipmentAsync(equipmentCode);
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
| 400 | Failed to delete the equipment or equipment does not exist. | [`Equipment400ErrorException`](../../doc/models/equipment-400-error-exception.md) |


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

[`Task<Models.EquipmentTranslationsResponse>`](../../doc/models/equipment-translations-response.md)

## Example Usage

```csharp
string equipmentCode = "equipmentCode6";
try
{
    EquipmentTranslationsResponse result = await equipmentController.GetEquipmentTranslationsAsync(equipmentCode);
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

[`Task<Models.EquipmentTranslationsResponse1>`](../../doc/models/equipment-translations-response-1.md)

## Example Usage

```csharp
string equipmentCode = "equipmentCode6";
EquipmentTranslation body = new EquipmentTranslation
{
    EquipmentName = "equipmentName6",
};

try
{
    EquipmentTranslationsResponse1 result = await equipmentController.UpdateEquipmentTranslationsAsync(
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
| 400 | Bad request | [`EquipmentTranslations400ErrorException`](../../doc/models/equipment-translations-400-error-exception.md) |
| 404 | Equipment not found | [`EquipmentTranslations404ErrorException`](../../doc/models/equipment-translations-404-error-exception.md) |


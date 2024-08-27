# Equipment Equipment Groups

```csharp
EquipmentEquipmentGroupsController equipmentEquipmentGroupsController = client.EquipmentEquipmentGroupsController;
```

## Class Name

`EquipmentEquipmentGroupsController`

## Methods

* [Get Equipment Groups](../../doc/controllers/equipment-equipment-groups.md#get-equipment-groups)
* [Add Equipment Group](../../doc/controllers/equipment-equipment-groups.md#add-equipment-group)
* [Get Equipment Group](../../doc/controllers/equipment-equipment-groups.md#get-equipment-group)
* [Update an Existing Equipment Group](../../doc/controllers/equipment-equipment-groups.md#update-an-existing-equipment-group)
* [Delete an Equipment Group](../../doc/controllers/equipment-equipment-groups.md#delete-an-equipment-group)
* [Get Equipment Group Translations](../../doc/controllers/equipment-equipment-groups.md#get-equipment-group-translations)
* [Update Equipment Group Translations](../../doc/controllers/equipment-equipment-groups.md#update-equipment-group-translations)


# Get Equipment Groups

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetEquipmentGroupsAsync(
    string localeCode = "en-US")
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `localeCode` | `string` | Query, Optional | The locale to use for the localized equipment group names. |

## Response Type

[`Task<Models.EquipmentGroupsResponse>`](../../doc/models/equipment-groups-response.md)

## Example Usage

```csharp
string localeCode = "en-US";
try
{
    EquipmentGroupsResponse result = await equipmentEquipmentGroupsController.GetEquipmentGroupsAsync(localeCode);
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
| 400 | Bad request | [`EquipmentGroups400ErrorException`](../../doc/models/equipment-groups-400-error-exception.md) |


# Add Equipment Group

```csharp
AddEquipmentGroupAsync(
    Models.EquipmentGroup body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`EquipmentGroup`](../../doc/models/equipment-group.md) | Body, Required | - |

## Response Type

[`Task<Models.EquipmentGroupsResponse1>`](../../doc/models/equipment-groups-response-1.md)

## Example Usage

```csharp
EquipmentGroup body = new EquipmentGroup
{
    EquipmentGroupCode = "DUMBBELLS",
    EquipmentGroupName = "Dumbbells",
    EquipmentGroupParent = "FREE_WEIGHTS",
    SortOrder = 0,
};

try
{
    EquipmentGroupsResponse1 result = await equipmentEquipmentGroupsController.AddEquipmentGroupAsync(body);
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
| 400 | Bad request | [`EquipmentGroups400ErrorException`](../../doc/models/equipment-groups-400-error-exception.md) |


# Get Equipment Group

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetEquipmentGroupAsync(
    string equipmentGroupCode,
    string localeCode = "en-US")
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `equipmentGroupCode` | `string` | Template, Required | The equipment group code to retrieve. |
| `localeCode` | `string` | Query, Optional | The locale to use for the localized equipment group names. |

## Response Type

[`Task<Models.EquipmentGroupsResponse1>`](../../doc/models/equipment-groups-response-1.md)

## Example Usage

```csharp
string equipmentGroupCode = "equipmentGroupCode8";
string localeCode = "en-US";
try
{
    EquipmentGroupsResponse1 result = await equipmentEquipmentGroupsController.GetEquipmentGroupAsync(
        equipmentGroupCode,
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
| 404 | Equipment group not found | [`EquipmentGroups404ErrorException`](../../doc/models/equipment-groups-404-error-exception.md) |


# Update an Existing Equipment Group

```csharp
UpdateAnExistingEquipmentGroupAsync(
    string equipmentGroupCode,
    Models.EquipmentGroup body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `equipmentGroupCode` | `string` | Template, Required | The equipment group code to update. |
| `body` | [`EquipmentGroup`](../../doc/models/equipment-group.md) | Body, Required | - |

## Response Type

[`Task<Models.EquipmentGroupsResponse1>`](../../doc/models/equipment-groups-response-1.md)

## Example Usage

```csharp
string equipmentGroupCode = "equipmentGroupCode8";
EquipmentGroup body = new EquipmentGroup
{
    EquipmentGroupCode = "DUMBBELLS",
    EquipmentGroupName = "Dumbbells",
    EquipmentGroupParent = "FREE_WEIGHTS",
    SortOrder = 0,
};

try
{
    EquipmentGroupsResponse1 result = await equipmentEquipmentGroupsController.UpdateAnExistingEquipmentGroupAsync(
        equipmentGroupCode,
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
| 400 | Bad request | [`EquipmentGroups400ErrorException`](../../doc/models/equipment-groups-400-error-exception.md) |


# Delete an Equipment Group

```csharp
DeleteAnEquipmentGroupAsync(
    string equipmentGroupCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `equipmentGroupCode` | `string` | Template, Required | The equipment group code to delete. |

## Response Type

[`Task<Models.EquipmentGroupsResponse4>`](../../doc/models/equipment-groups-response-4.md)

## Example Usage

```csharp
string equipmentGroupCode = "equipmentGroupCode8";
try
{
    EquipmentGroupsResponse4 result = await equipmentEquipmentGroupsController.DeleteAnEquipmentGroupAsync(equipmentGroupCode);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Equipment Group Translations

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetEquipmentGroupTranslationsAsync(
    string equipmentGroupCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `equipmentGroupCode` | `string` | Template, Required | The unique code of the equipment group |

## Response Type

[`Task<Models.EquipmentGroupsTranslationsResponse>`](../../doc/models/equipment-groups-translations-response.md)

## Example Usage

```csharp
string equipmentGroupCode = "equipmentGroupCode8";
try
{
    EquipmentGroupsTranslationsResponse result = await equipmentEquipmentGroupsController.GetEquipmentGroupTranslationsAsync(equipmentGroupCode);
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
| 400 | Bad request | [`EquipmentGroupsTranslations400ErrorException`](../../doc/models/equipment-groups-translations-400-error-exception.md) |
| 404 | Equipment group not found | [`EquipmentGroupsTranslations404ErrorException`](../../doc/models/equipment-groups-translations-404-error-exception.md) |


# Update Equipment Group Translations

Updates the translations for a specific equipment group identified by its code.

:information_source: **Note** This endpoint does not require authentication.

```csharp
UpdateEquipmentGroupTranslationsAsync(
    string equipmentGroupCode,
    List<Models.EquipmentGroupTranslation> body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `equipmentGroupCode` | `string` | Template, Required | The unique code of the equipment group |
| `body` | [`List<EquipmentGroupTranslation>`](../../doc/models/equipment-group-translation.md) | Body, Required | - |

## Response Type

[`Task<Models.EquipmentGroupsTranslationsResponse1>`](../../doc/models/equipment-groups-translations-response-1.md)

## Example Usage

```csharp
string equipmentGroupCode = "EQP-001";
List<Models.EquipmentGroupTranslation> body = new List<Models.EquipmentGroupTranslation>
{
    new EquipmentGroupTranslation
    {
        LocaleCode = "en-US",
        EquipmentGroupName = "Weightlifting Equipment",
        EquipmentGroupDescription = "Equipment used for weightlifting exercises",
    },
};

try
{
    EquipmentGroupsTranslationsResponse1 result = await equipmentEquipmentGroupsController.UpdateEquipmentGroupTranslationsAsync(
        equipmentGroupCode,
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
| 400 | Bad request | [`EquipmentGroupsTranslations400ErrorException`](../../doc/models/equipment-groups-translations-400-error-exception.md) |
| 404 | Equipment group not found | [`EquipmentGroupsTranslations404ErrorException`](../../doc/models/equipment-groups-translations-404-error-exception.md) |
| 422 | Validation error | [`EquipmentGroupsTranslations422ErrorException`](../../doc/models/equipment-groups-translations-422-error-exception.md) |


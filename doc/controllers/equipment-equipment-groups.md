# Equipment Equipment Groups

```csharp
EquipmentEquipmentGroupsController equipmentEquipmentGroupsController = client.EquipmentEquipmentGroupsController;
```

## Class Name

`EquipmentEquipmentGroupsController`

## Methods

* [Get Equipment Groups](../../doc/controllers/equipment-equipment-groups.md#get-equipment-groups)
* [Add Equipment Group](../../doc/controllers/equipment-equipment-groups.md#add-equipment-group)
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
| `localeCode` | `string` | Query, Optional | The locale to use for the localized equipment group names.<br>**Default**: `"en-US"`<br>**Constraints**: *Pattern*: `^[a-z]{2}-[A-Z]{2}$` |

## Response Type

[`Task<Models.EquipmentGroupListResponse>`](../../doc/models/equipment-group-list-response.md)

## Example Usage

```csharp
string localeCode = "en-US";
try
{
    EquipmentGroupListResponse result = await equipmentEquipmentGroupsController.GetEquipmentGroupsAsync(localeCode);
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

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

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
    JustGainsBasicResponse result = await equipmentEquipmentGroupsController.AddEquipmentGroupAsync(body);
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

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

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
    JustGainsBasicResponse result = await equipmentEquipmentGroupsController.UpdateAnExistingEquipmentGroupAsync(
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
| 400 | Bad request | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


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

[`Task<Models.JustGainsResponse>`](../../doc/models/just-gains-response.md)

## Example Usage

```csharp
string equipmentGroupCode = "equipmentGroupCode8";
try
{
    JustGainsResponse result = await equipmentEquipmentGroupsController.DeleteAnEquipmentGroupAsync(equipmentGroupCode);
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

[`Task<Models.EquipmentGroupTranslationListResponse>`](../../doc/models/equipment-group-translation-list-response.md)

## Example Usage

```csharp
string equipmentGroupCode = "equipmentGroupCode8";
try
{
    EquipmentGroupTranslationListResponse result = await equipmentEquipmentGroupsController.GetEquipmentGroupTranslationsAsync(equipmentGroupCode);
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
| 404 | Equipment group not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


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

[`Task<Models.JustGainsResponse>`](../../doc/models/just-gains-response.md)

## Example Usage

```csharp
string equipmentGroupCode = "EQP-001";
List<EquipmentGroupTranslation> body = new List<EquipmentGroupTranslation>
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
    JustGainsResponse result = await equipmentEquipmentGroupsController.UpdateEquipmentGroupTranslationsAsync(
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
| 400 | Bad request | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Equipment group not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 422 | Validation error | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


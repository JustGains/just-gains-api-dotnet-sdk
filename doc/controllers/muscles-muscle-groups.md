# Muscles Muscle Groups

```csharp
MusclesMuscleGroupsController musclesMuscleGroupsController = client.MusclesMuscleGroupsController;
```

## Class Name

`MusclesMuscleGroupsController`

## Methods

* [Get Muscle Groups](../../doc/controllers/muscles-muscle-groups.md#get-muscle-groups)
* [Create a New Muscle Group](../../doc/controllers/muscles-muscle-groups.md#create-a-new-muscle-group)
* [Get Muscle Group](../../doc/controllers/muscles-muscle-groups.md#get-muscle-group)
* [Update a Muscle Group](../../doc/controllers/muscles-muscle-groups.md#update-a-muscle-group)
* [Delete a Muscle Group](../../doc/controllers/muscles-muscle-groups.md#delete-a-muscle-group)
* [Get Muscle Group Translations](../../doc/controllers/muscles-muscle-groups.md#get-muscle-group-translations)
* [Update Muscle Group Translations](../../doc/controllers/muscles-muscle-groups.md#update-muscle-group-translations)


# Get Muscle Groups

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetMuscleGroupsAsync(
    string localeCode = "en-US")
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `localeCode` | `string` | Query, Optional | The locale to use for the localized muscle group names. |

## Response Type

[`Task<Models.MuscleGroupsResponse>`](../../doc/models/muscle-groups-response.md)

## Example Usage

```csharp
string localeCode = "en-US";
try
{
    MuscleGroupsResponse result = await musclesMuscleGroupsController.GetMuscleGroupsAsync(localeCode);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create a New Muscle Group

```csharp
CreateANewMuscleGroupAsync(
    Models.MuscleGroup body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`MuscleGroup`](../../doc/models/muscle-group.md) | Body, Required | - |

## Response Type

[`Task<Models.MuscleGroupsResponse1>`](../../doc/models/muscle-groups-response-1.md)

## Example Usage

```csharp
MuscleGroup body = new MuscleGroup
{
    MuscleGroupCode = "CHEST",
    MuscleGroupName = "Chest",
    MuscleGroupParent = "UPPER_BODY",
    MuscleGroupMuscles = new List<string>
    {
        "PECTORALIS_MAJOR_STERNAL_HEAD",
        "ANTERIOR_DELTOID",
        "TRICEPS_BRACHII",
        "RECTUS_ABDOMINIS",
        "LATISSIMUS_DORSI",
        "BICEPS_BRACHII",
        "QUADRICEPS_FEMORIS",
        "HAMSTRINGS",
        "GASTROCNEMIUS",
    },
    MuscleGroupType = MuscleGroupType5Enum.MainGroup,
};

try
{
    MuscleGroupsResponse1 result = await musclesMuscleGroupsController.CreateANewMuscleGroupAsync(body);
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
| 400 | Invalid muscle group data | [`MuscleGroups400ErrorException`](../../doc/models/muscle-groups-400-error-exception.md) |
| 401 | Authentication required | [`MuscleGroups401ErrorException`](../../doc/models/muscle-groups-401-error-exception.md) |


# Get Muscle Group

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetMuscleGroupAsync(
    string muscleGroupCode,
    string localeCode = "en-US")
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `muscleGroupCode` | `string` | Template, Required | The muscle group code to retrieve. |
| `localeCode` | `string` | Query, Optional | The locale to use for the localized muscle group names. |

## Response Type

[`Task<Models.MuscleGroupsResponse1>`](../../doc/models/muscle-groups-response-1.md)

## Example Usage

```csharp
string muscleGroupCode = "muscleGroupCode2";
string localeCode = "en-US";
try
{
    MuscleGroupsResponse1 result = await musclesMuscleGroupsController.GetMuscleGroupAsync(
        muscleGroupCode,
        localeCode
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Update a Muscle Group

```csharp
UpdateAMuscleGroupAsync(
    string muscleGroupCode,
    Models.MuscleGroup body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `muscleGroupCode` | `string` | Template, Required | The muscle group code to update. |
| `body` | [`MuscleGroup`](../../doc/models/muscle-group.md) | Body, Required | - |

## Response Type

[`Task<Models.MuscleGroupsResponse1>`](../../doc/models/muscle-groups-response-1.md)

## Example Usage

```csharp
string muscleGroupCode = "muscleGroupCode2";
MuscleGroup body = new MuscleGroup
{
    MuscleGroupCode = "CHEST",
    MuscleGroupName = "Chest",
    MuscleGroupParent = "UPPER_BODY",
    MuscleGroupMuscles = new List<string>
    {
        "PECTORALIS_MAJOR_STERNAL_HEAD",
        "ANTERIOR_DELTOID",
        "TRICEPS_BRACHII",
        "RECTUS_ABDOMINIS",
        "LATISSIMUS_DORSI",
        "BICEPS_BRACHII",
        "QUADRICEPS_FEMORIS",
        "HAMSTRINGS",
        "GASTROCNEMIUS",
    },
    MuscleGroupType = MuscleGroupType5Enum.MainGroup,
};

try
{
    MuscleGroupsResponse1 result = await musclesMuscleGroupsController.UpdateAMuscleGroupAsync(
        muscleGroupCode,
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
| 400 | Invalid muscle group data | [`MuscleGroups400ErrorException`](../../doc/models/muscle-groups-400-error-exception.md) |
| 401 | Authentication required | [`MuscleGroups401ErrorException`](../../doc/models/muscle-groups-401-error-exception.md) |
| 404 | Muscle group not found | [`MuscleGroups404ErrorException`](../../doc/models/muscle-groups-404-error-exception.md) |


# Delete a Muscle Group

```csharp
DeleteAMuscleGroupAsync(
    string muscleGroupCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `muscleGroupCode` | `string` | Template, Required | The muscle group code to delete. |

## Response Type

[`Task<Models.MuscleGroupsResponse4>`](../../doc/models/muscle-groups-response-4.md)

## Example Usage

```csharp
string muscleGroupCode = "muscleGroupCode2";
try
{
    MuscleGroupsResponse4 result = await musclesMuscleGroupsController.DeleteAMuscleGroupAsync(muscleGroupCode);
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
| 401 | Authentication required | [`MuscleGroups401ErrorException`](../../doc/models/muscle-groups-401-error-exception.md) |
| 404 | Muscle group not found | [`MuscleGroups404ErrorException`](../../doc/models/muscle-groups-404-error-exception.md) |


# Get Muscle Group Translations

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetMuscleGroupTranslationsAsync(
    string muscleGroupCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `muscleGroupCode` | `string` | Template, Required | The unique code of the muscle group |

## Response Type

[`Task<Models.MuscleGroupsTranslationsResponse>`](../../doc/models/muscle-groups-translations-response.md)

## Example Usage

```csharp
string muscleGroupCode = "muscleGroupCode2";
try
{
    MuscleGroupsTranslationsResponse result = await musclesMuscleGroupsController.GetMuscleGroupTranslationsAsync(muscleGroupCode);
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
| 400 | Failed to retrieve muscle group translations | [`MuscleGroupsTranslations400ErrorException`](../../doc/models/muscle-groups-translations-400-error-exception.md) |
| 404 | Muscle group not found | [`MuscleGroupsTranslations404ErrorException`](../../doc/models/muscle-groups-translations-404-error-exception.md) |


# Update Muscle Group Translations

:information_source: **Note** This endpoint does not require authentication.

```csharp
UpdateMuscleGroupTranslationsAsync(
    string muscleGroupCode,
    List<Models.MuscleGroupTranslation> body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `muscleGroupCode` | `string` | Template, Required | The unique code of the muscle group |
| `body` | [`List<MuscleGroupTranslation>`](../../doc/models/muscle-group-translation.md) | Body, Required | - |

## Response Type

[`Task<Models.MuscleGroupsTranslationsResponse1>`](../../doc/models/muscle-groups-translations-response-1.md)

## Example Usage

```csharp
string muscleGroupCode = "muscleGroupCode2";
List<Models.MuscleGroupTranslation> body = new List<Models.MuscleGroupTranslation>
{
    new MuscleGroupTranslation
    {
        LocaleCode = "en-US",
        MuscleGroupName = "Quadriceps",
        MuscleGroupDescription = "The quadriceps femoris is a large muscle group located on the front of the thigh.",
    },
};

try
{
    MuscleGroupsTranslationsResponse1 result = await musclesMuscleGroupsController.UpdateMuscleGroupTranslationsAsync(
        muscleGroupCode,
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
| 400 | Failed to update muscle group translations | [`MuscleGroupsTranslations400ErrorException`](../../doc/models/muscle-groups-translations-400-error-exception.md) |
| 404 | Muscle group not found | [`MuscleGroupsTranslations404ErrorException`](../../doc/models/muscle-groups-translations-404-error-exception.md) |
| 422 | Validation error | [`MuscleGroupsTranslations422ErrorException`](../../doc/models/muscle-groups-translations-422-error-exception.md) |


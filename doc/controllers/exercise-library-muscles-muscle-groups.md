# Exercise Library Muscles Muscle Groups

```csharp
ExerciseLibraryMusclesMuscleGroupsController exerciseLibraryMusclesMuscleGroupsController = client.ExerciseLibraryMusclesMuscleGroupsController;
```

## Class Name

`ExerciseLibraryMusclesMuscleGroupsController`

## Methods

* [Get Muscle Groups](../../doc/controllers/exercise-library-muscles-muscle-groups.md#get-muscle-groups)
* [Create a New Muscle Group](../../doc/controllers/exercise-library-muscles-muscle-groups.md#create-a-new-muscle-group)
* [Update Muscle Group](../../doc/controllers/exercise-library-muscles-muscle-groups.md#update-muscle-group)
* [Delete a Muscle Group](../../doc/controllers/exercise-library-muscles-muscle-groups.md#delete-a-muscle-group)
* [Get Muscle Group Translations](../../doc/controllers/exercise-library-muscles-muscle-groups.md#get-muscle-group-translations)
* [Update Muscle Group Translations](../../doc/controllers/exercise-library-muscles-muscle-groups.md#update-muscle-group-translations)


# Get Muscle Groups

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetMuscleGroupsAsync(
    string localeCode = "en-US")
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `localeCode` | `string` | Query, Optional | The locale to use for the localized muscle group names.<br>**Default**: `"en-US"`<br>**Constraints**: *Pattern*: `^[a-z]{2}-[A-Z]{2}$` |

## Response Type

[`Task<Models.MuscleGroupListResponse>`](../../doc/models/muscle-group-list-response.md)

## Example Usage

```csharp
string localeCode = "en-US";
try
{
    MuscleGroupListResponse result = await exerciseLibraryMusclesMuscleGroupsController.GetMuscleGroupsAsync(localeCode);
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

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
MuscleGroup body = new MuscleGroup
{
    MuscleGroupCode = "CHEST",
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
    MuscleGroupType = MuscleGroupTypeEnum.MainGroup,
};

try
{
    JustGainsBasicResponse result = await exerciseLibraryMusclesMuscleGroupsController.CreateANewMuscleGroupAsync(body);
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
| 400 | Invalid muscle group data | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 401 | Authentication required | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Update Muscle Group

```csharp
UpdateMuscleGroupAsync(
    string muscleGroupCode,
    Models.MuscleGroup body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `muscleGroupCode` | `string` | Template, Required | The muscle group code to update.<br>**Constraints**: *Pattern*: `^[A-Z_]+$` |
| `body` | [`MuscleGroup`](../../doc/models/muscle-group.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
string muscleGroupCode = "muscleGroupCode2";
MuscleGroup body = new MuscleGroup
{
    MuscleGroupCode = "CHEST",
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
    MuscleGroupType = MuscleGroupTypeEnum.MainGroup,
};

try
{
    JustGainsBasicResponse result = await exerciseLibraryMusclesMuscleGroupsController.UpdateMuscleGroupAsync(
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
| 400 | Invalid muscle group data | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 401 | Authentication required | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Muscle group not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Delete a Muscle Group

```csharp
DeleteAMuscleGroupAsync(
    string muscleGroupCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `muscleGroupCode` | `string` | Template, Required | The muscle group code to delete.<br>**Constraints**: *Pattern*: `^[A-Z_]+$` |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
string muscleGroupCode = "muscleGroupCode2";
try
{
    JustGainsBasicResponse result = await exerciseLibraryMusclesMuscleGroupsController.DeleteAMuscleGroupAsync(muscleGroupCode);
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
| 401 | Authentication required | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Muscle group not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Get Muscle Group Translations

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetMuscleGroupTranslationsAsync(
    string muscleGroupCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `muscleGroupCode` | `string` | Template, Required | The unique code of the muscle group<br>**Constraints**: *Pattern*: `^[A-Z_]+$` |

## Response Type

[`Task<Models.MuscleGroupTranslationListResponse>`](../../doc/models/muscle-group-translation-list-response.md)

## Example Usage

```csharp
string muscleGroupCode = "muscleGroupCode2";
try
{
    MuscleGroupTranslationListResponse result = await exerciseLibraryMusclesMuscleGroupsController.GetMuscleGroupTranslationsAsync(muscleGroupCode);
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
| 400 | Failed to retrieve muscle group translations | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Muscle group not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Update Muscle Group Translations

:information_source: **Note** This endpoint does not require authentication.

```csharp
UpdateMuscleGroupTranslationsAsync(
    string muscleGroupCode,
    List<Models.MuscleGroupTranslation> body,
    List<string> localeCodes = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `muscleGroupCode` | `string` | Template, Required | The unique code of the muscle group<br>**Constraints**: *Pattern*: `^[A-Z_]+$` |
| `body` | [`List<MuscleGroupTranslation>`](../../doc/models/muscle-group-translation.md) | Body, Required | - |
| `localeCodes` | `List<string>` | Query, Optional | The array of locales for the instructions (e.g., 'en-US', 'es-ES')<br>**Constraints**: *Pattern*: `^[a-z]{2}-[A-Z]{2}$` |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
string muscleGroupCode = "muscleGroupCode2";
List<MuscleGroupTranslation> body = new List<MuscleGroupTranslation>
{
    new MuscleGroupTranslation
    {
        LocaleCode = "en-US",
        MuscleGroupName = "Quadriceps",
        MuscleGroupDescription = "The quadriceps femoris is a large muscle group located on the front of the thigh.",
    },
};

List<string> localeCodes = new List<string>
{
    "en-US",
    "es-ES",
};

try
{
    JustGainsBasicResponse result = await exerciseLibraryMusclesMuscleGroupsController.UpdateMuscleGroupTranslationsAsync(
        muscleGroupCode,
        body,
        localeCodes
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
| 400 | Failed to update muscle group translations | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Muscle group not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 422 | Validation error | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


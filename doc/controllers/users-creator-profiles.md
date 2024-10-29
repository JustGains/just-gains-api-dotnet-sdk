# Users Creator Profiles

```csharp
UsersCreatorProfilesController usersCreatorProfilesController = client.UsersCreatorProfilesController;
```

## Class Name

`UsersCreatorProfilesController`

## Methods

* [Get Creator Profiles](../../doc/controllers/users-creator-profiles.md#get-creator-profiles)
* [Create Creator Profile](../../doc/controllers/users-creator-profiles.md#create-creator-profile)
* [Get Creator Profile](../../doc/controllers/users-creator-profiles.md#get-creator-profile)
* [Update Creator Profile](../../doc/controllers/users-creator-profiles.md#update-creator-profile)
* [Delete Creator Profile](../../doc/controllers/users-creator-profiles.md#delete-creator-profile)


# Get Creator Profiles

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetCreatorProfilesAsync(
    int? page = 1,
    bool? mvpAssetsOnly = null,
    int? limit = 20,
    string search = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Page number for pagination<br>**Default**: `1`<br>**Constraints**: `>= 1` |
| `mvpAssetsOnly` | `bool?` | Query, Optional | Filter creator profiles with MVP assets only |
| `limit` | `int?` | Query, Optional | Number of items per page<br>**Default**: `20`<br>**Constraints**: `>= 1`, `<= 100` |
| `search` | `string` | Query, Optional | Optional search term to filter creator profiles. The search is case-insensitive and matches against:<br><br>- Creator's username<br>- Creator's social media account usernames<br>- Creator's full name (first name + last name)<br><br>Examples:<br><br>- search=john (matches usernames, social media accounts, or names containing "john")<br>- search=@twitter (matches social media accounts containing "@twitter")<br>- search="John Doe" (matches full names containing "John Doe")<br><br>Leave empty to retrieve all profiles without filtering. |

## Response Type

[`Task<Models.CreatorProfileListResponse>`](../../doc/models/creator-profile-list-response.md)

## Example Usage

```csharp
int? page = 1;
int? limit = 20;
try
{
    CreatorProfileListResponse result = await usersCreatorProfilesController.GetCreatorProfilesAsync(
        page,
        null,
        limit
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


# Create Creator Profile

```csharp
CreateCreatorProfileAsync(
    Models.CreatorProfile body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreatorProfile`](../../doc/models/creator-profile.md) | Body, Required | - |

## Response Type

[`Task<Models.CreatorProfileResponse>`](../../doc/models/creator-profile-response.md)

## Example Usage

```csharp
CreatorProfile body = new CreatorProfile
{
    FirstName = "Dwayne",
    LastName = "Johnson",
};

try
{
    CreatorProfileResponse result = await usersCreatorProfilesController.CreateCreatorProfileAsync(body);
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
| 401 | Unauthorized | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Get Creator Profile

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetCreatorProfileAsync(
    Guid creatorProfileId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `creatorProfileId` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.CreatorProfileResponse>`](../../doc/models/creator-profile-response.md)

## Example Usage

```csharp
Guid creatorProfileId = new Guid("000008d2-0000-0000-0000-000000000000");
try
{
    CreatorProfileResponse result = await usersCreatorProfilesController.GetCreatorProfileAsync(creatorProfileId);
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
| 404 | Creator profile not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Update Creator Profile

```csharp
UpdateCreatorProfileAsync(
    Guid creatorProfileId,
    Models.CreatorProfile body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `creatorProfileId` | `Guid` | Template, Required | - |
| `body` | [`CreatorProfile`](../../doc/models/creator-profile.md) | Body, Required | - |

## Response Type

[`Task<Models.CreatorProfileResponse>`](../../doc/models/creator-profile-response.md)

## Example Usage

```csharp
Guid creatorProfileId = new Guid("000008d2-0000-0000-0000-000000000000");
CreatorProfile body = new CreatorProfile
{
    FirstName = "Dwayne",
    LastName = "Johnson",
};

try
{
    CreatorProfileResponse result = await usersCreatorProfilesController.UpdateCreatorProfileAsync(
        creatorProfileId,
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
| 401 | Unauthorized | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Creator profile not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Delete Creator Profile

```csharp
DeleteCreatorProfileAsync(
    Guid creatorProfileId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `creatorProfileId` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
Guid creatorProfileId = new Guid("000008d2-0000-0000-0000-000000000000");
try
{
    JustGainsBasicResponse result = await usersCreatorProfilesController.DeleteCreatorProfileAsync(creatorProfileId);
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
| 401 | Unauthorized | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Creator profile not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


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
    int? limit = 20,
    int? page = 1)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `limit` | `int?` | Query, Optional | Number of items per page<br>**Default**: `20`<br>**Constraints**: `>= 1`, `<= 100` |
| `page` | `int?` | Query, Optional | Page number for pagination<br>**Default**: `1`<br>**Constraints**: `>= 1` |

## Response Type

[`Task<Models.CreatorProfileListResponse>`](../../doc/models/creator-profile-list-response.md)

## Example Usage

```csharp
int? limit = 20;
int? page = 1;
try
{
    CreatorProfileListResponse result = await usersCreatorProfilesController.GetCreatorProfilesAsync(
        limit,
        page
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
    CreatorProfileId = new Guid("123e4567-e89b-12d3-a456-426614174000"),
    UserId = new Guid("123e4567-e89b-12d3-a456-426614174000"),
    CreatorEmail = "dwayne@therockjohnson.com",
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
    Models.CreatorProfile body,
    Guid creatorProfileId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`CreatorProfile`](../../doc/models/creator-profile.md) | Body, Required | - |
| `creatorProfileId` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.CreatorProfileResponse>`](../../doc/models/creator-profile-response.md)

## Example Usage

```csharp
CreatorProfile body = new CreatorProfile
{
    CreatorProfileId = new Guid("123e4567-e89b-12d3-a456-426614174000"),
    UserId = new Guid("123e4567-e89b-12d3-a456-426614174000"),
    CreatorEmail = "dwayne@therockjohnson.com",
};

Guid creatorProfileId = new Guid("000008d2-0000-0000-0000-000000000000");
try
{
    CreatorProfileResponse result = await usersCreatorProfilesController.UpdateCreatorProfileAsync(
        body,
        creatorProfileId
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


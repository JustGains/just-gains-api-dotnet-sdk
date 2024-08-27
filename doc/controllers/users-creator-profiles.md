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
    int? limit = 20)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | Page number for pagination |
| `limit` | `int?` | Query, Optional | Number of items per page |

## Response Type

[`Task<Models.CreatorProfilesResponse>`](../../doc/models/creator-profiles-response.md)

## Example Usage

```csharp
int? page = 1;
int? limit = 20;
try
{
    CreatorProfilesResponse result = await usersCreatorProfilesController.GetCreatorProfilesAsync(
        page,
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
| 400 | Bad request | [`CreatorProfiles400ErrorException`](../../doc/models/creator-profiles-400-error-exception.md) |
| 500 | An unexpected error occurred | [`CreatorProfiles500ErrorException`](../../doc/models/creator-profiles-500-error-exception.md) |


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

[`Task<Models.CreatorProfilesResponse1>`](../../doc/models/creator-profiles-response-1.md)

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
    CreatorProfilesResponse1 result = await usersCreatorProfilesController.CreateCreatorProfileAsync(body);
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
| 400 | Bad request | [`CreatorProfiles400ErrorException`](../../doc/models/creator-profiles-400-error-exception.md) |
| 401 | Unauthorized | [`CreatorProfiles401ErrorException`](../../doc/models/creator-profiles-401-error-exception.md) |
| 500 | Internal server error | [`CreatorProfiles500ErrorException`](../../doc/models/creator-profiles-500-error-exception.md) |


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

[`Task<Models.CreatorProfilesResponse1>`](../../doc/models/creator-profiles-response-1.md)

## Example Usage

```csharp
Guid creatorProfileId = new Guid("000008d2-0000-0000-0000-000000000000");
try
{
    CreatorProfilesResponse1 result = await usersCreatorProfilesController.GetCreatorProfileAsync(creatorProfileId);
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
| 404 | Creator profile not found | [`CreatorProfiles404ErrorException`](../../doc/models/creator-profiles-404-error-exception.md) |
| 500 | Internal server error | [`CreatorProfiles500ErrorException`](../../doc/models/creator-profiles-500-error-exception.md) |


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

[`Task<Models.CreatorProfilesResponse1>`](../../doc/models/creator-profiles-response-1.md)

## Example Usage

```csharp
Guid creatorProfileId = new Guid("000008d2-0000-0000-0000-000000000000");
CreatorProfile body = new CreatorProfile
{
    CreatorProfileId = new Guid("123e4567-e89b-12d3-a456-426614174000"),
    UserId = new Guid("123e4567-e89b-12d3-a456-426614174000"),
    CreatorEmail = "dwayne@therockjohnson.com",
};

try
{
    CreatorProfilesResponse1 result = await usersCreatorProfilesController.UpdateCreatorProfileAsync(
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
| 400 | Bad request | [`CreatorProfiles400ErrorException`](../../doc/models/creator-profiles-400-error-exception.md) |
| 401 | Unauthorized | [`CreatorProfiles401ErrorException`](../../doc/models/creator-profiles-401-error-exception.md) |
| 404 | Creator profile not found | [`CreatorProfiles404ErrorException`](../../doc/models/creator-profiles-404-error-exception.md) |
| 500 | Internal server error | [`CreatorProfiles500ErrorException`](../../doc/models/creator-profiles-500-error-exception.md) |


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

[`Task<Models.CreatorProfilesResponse4>`](../../doc/models/creator-profiles-response-4.md)

## Example Usage

```csharp
Guid creatorProfileId = new Guid("000008d2-0000-0000-0000-000000000000");
try
{
    CreatorProfilesResponse4 result = await usersCreatorProfilesController.DeleteCreatorProfileAsync(creatorProfileId);
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
| 401 | Unauthorized | [`CreatorProfiles401ErrorException`](../../doc/models/creator-profiles-401-error-exception.md) |
| 404 | Creator profile not found | [`CreatorProfiles404ErrorException`](../../doc/models/creator-profiles-404-error-exception.md) |
| 500 | Internal server error | [`CreatorProfiles500ErrorException`](../../doc/models/creator-profiles-500-error-exception.md) |


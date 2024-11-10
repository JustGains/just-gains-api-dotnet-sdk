# Users Social Media Accounts

```csharp
UsersSocialMediaAccountsController usersSocialMediaAccountsController = client.UsersSocialMediaAccountsController;
```

## Class Name

`UsersSocialMediaAccountsController`

## Methods

* [List Users Social Media Accounts](../../doc/controllers/users-social-media-accounts.md#list-users-social-media-accounts)
* [Create Social Media Platform](../../doc/controllers/users-social-media-accounts.md#create-social-media-platform)
* [Get Social Media Platform](../../doc/controllers/users-social-media-accounts.md#get-social-media-platform)
* [Update Social Media Platform](../../doc/controllers/users-social-media-accounts.md#update-social-media-platform)
* [Delete Social Media Platform](../../doc/controllers/users-social-media-accounts.md#delete-social-media-platform)
* [Validate Social Media Username](../../doc/controllers/users-social-media-accounts.md#validate-social-media-username)


# List Users Social Media Accounts

Retrieve a list of Users|Social Media Accounts with optional name filter

:information_source: **Note** This endpoint does not require authentication.

```csharp
ListUsersSocialMediaAccountsAsync(
    string name = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `name` | `string` | Query, Optional | Filter platforms by name |

## Response Type

[`Task<Models.SocialMediaPlatformListResponse>`](../../doc/models/social-media-platform-list-response.md)

## Example Usage

```csharp
try
{
    SocialMediaPlatformListResponse result = await usersSocialMediaAccountsController.ListUsersSocialMediaAccountsAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create Social Media Platform

Create a new social media platform

:information_source: **Note** This endpoint does not require authentication.

```csharp
CreateSocialMediaPlatformAsync(
    Models.SocialMediaPlatformCreate body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`SocialMediaPlatformCreate`](../../doc/models/social-media-platform-create.md) | Body, Required | - |

## Response Type

[`Task<Models.SocialMediaPlatformResponse>`](../../doc/models/social-media-platform-response.md)

## Example Usage

```csharp
SocialMediaPlatformCreate body = new SocialMediaPlatformCreate
{
    SocialMediaPlatformCode = "INSTAGRAM",
    SocialMediaPlatformName = "Instagram",
    SocialMediaPlatformUrlFormat = "https://www.instagram.com/{username}",
    SocialMediaPlatformIcon = new Guid("123e4567-e89b-12d3-a456-426614174000"),
};

try
{
    SocialMediaPlatformResponse result = await usersSocialMediaAccountsController.CreateSocialMediaPlatformAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Social Media Platform

Retrieve details of a specific social media platform

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetSocialMediaPlatformAsync(
    string socialMediaPlatformCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `socialMediaPlatformCode` | `string` | Template, Required | The unique code of the social media platform |

## Response Type

[`Task<Models.SocialMediaPlatformResponse>`](../../doc/models/social-media-platform-response.md)

## Example Usage

```csharp
string socialMediaPlatformCode = "socialMediaPlatformCode4";
try
{
    SocialMediaPlatformResponse result = await usersSocialMediaAccountsController.GetSocialMediaPlatformAsync(socialMediaPlatformCode);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Update Social Media Platform

Update an existing social media platform

:information_source: **Note** This endpoint does not require authentication.

```csharp
UpdateSocialMediaPlatformAsync(
    string socialMediaPlatformCode,
    Models.SocialMediaPlatformUpdate body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `socialMediaPlatformCode` | `string` | Template, Required | The unique code of the social media platform |
| `body` | [`SocialMediaPlatformUpdate`](../../doc/models/social-media-platform-update.md) | Body, Required | - |

## Response Type

[`Task<Models.SocialMediaPlatformResponse>`](../../doc/models/social-media-platform-response.md)

## Example Usage

```csharp
string socialMediaPlatformCode = "socialMediaPlatformCode4";
SocialMediaPlatformUpdate body = new SocialMediaPlatformUpdate
{
    SocialMediaPlatformName = "Instagram",
    SocialMediaPlatformUrlFormat = "https://www.instagram.com/{username}",
    SocialMediaPlatformIcon = new Guid("123e4567-e89b-12d3-a456-426614174000"),
};

try
{
    SocialMediaPlatformResponse result = await usersSocialMediaAccountsController.UpdateSocialMediaPlatformAsync(
        socialMediaPlatformCode,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Delete Social Media Platform

Delete a social media platform

:information_source: **Note** This endpoint does not require authentication.

```csharp
DeleteSocialMediaPlatformAsync(
    string socialMediaPlatformCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `socialMediaPlatformCode` | `string` | Template, Required | The unique code of the social media platform |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
string socialMediaPlatformCode = "socialMediaPlatformCode4";
try
{
    JustGainsBasicResponse result = await usersSocialMediaAccountsController.DeleteSocialMediaPlatformAsync(socialMediaPlatformCode);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Validate Social Media Username

:information_source: **Note** This endpoint does not require authentication.

```csharp
ValidateSocialMediaUsernameAsync(
    string socialMediaPlatformCode,
    string username)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `socialMediaPlatformCode` | `string` | Template, Required | The code of the social media platform to check against<br>**Constraints**: *Pattern*: `^[A-Z_]+$` |
| `username` | `string` | Template, Required | The username to validate |

## Response Type

[`Task<Models.SocialMediaPlatformsValidateUsernameResponse>`](../../doc/models/social-media-platforms-validate-username-response.md)

## Example Usage

```csharp
string socialMediaPlatformCode = "INSTAGRAM";
string username = "fitness_guru";
try
{
    SocialMediaPlatformsValidateUsernameResponse result = await usersSocialMediaAccountsController.ValidateSocialMediaUsernameAsync(
        socialMediaPlatformCode,
        username
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


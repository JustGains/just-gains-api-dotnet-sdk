# Users

User account management operations.

```csharp
UsersController usersController = client.UsersController;
```

## Class Name

`UsersController`

## Methods

* [Get a List of All Users](../../doc/controllers/users.md#get-a-list-of-all-users)
* [Get a User by ID](../../doc/controllers/users.md#get-a-user-by-id)
* [Update a User](../../doc/controllers/users.md#update-a-user)
* [Delete a User](../../doc/controllers/users.md#delete-a-user)


# Get a List of All Users

```csharp
GetAListOfAllUsersAsync()
```

## Response Type

[`Task<Models.UserInfoListResponse>`](../../doc/models/user-info-list-response.md)

## Example Usage

```csharp
try
{
    UserInfoListResponse result = await usersController.GetAListOfAllUsersAsync();
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
| 403 | Access denied | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Get a User by ID

```csharp
GetAUserByIDAsync(
    string userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `string` | Template, Required | **Constraints**: *Pattern*: `^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$` |

## Response Type

[`Task<Models.UserResponse>`](../../doc/models/user-response.md)

## Example Usage

```csharp
string userId = "123e4567-e89b-12d3-a456-426614174000";
try
{
    UserResponse result = await usersController.GetAUserByIDAsync(userId);
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
| 400 | Invalid user ID format | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 401 | Authentication required | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 403 | Access denied | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | User not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Update a User

```csharp
UpdateAUserAsync(
    Models.UserWithoutCreatorProfile body,
    string userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`UserWithoutCreatorProfile`](../../doc/models/user-without-creator-profile.md) | Body, Required | - |
| `userId` | `string` | Template, Required | - |

## Response Type

[`Task<Models.UserWithoutCreatorProfileResponse>`](../../doc/models/user-without-creator-profile-response.md)

## Example Usage

```csharp
UserWithoutCreatorProfile body = new UserWithoutCreatorProfile
{
    UserId = new Guid("123e4567-e89b-12d3-a456-426614174000"),
    UserName = "fitness_enthusiast_42",
    Email = "jane.doe@example.com",
    Password = "$2a$10$Ks6Qr5Yl.Y5iY5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5",
    FirstName = "Jane",
    LastName = "Doe",
    FullName = "Jane Doe",
    OAuthProvider = "Google",
    Roles = new List<string>
    {
        "user",
    },
};

string userId = "userId0";
try
{
    UserWithoutCreatorProfileResponse result = await usersController.UpdateAUserAsync(
        body,
        userId
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
| 400 | Invalid user data | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | User not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Delete a User

```csharp
DeleteAUserAsync(
    string userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `string` | Template, Required | - |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
string userId = "userId0";
try
{
    JustGainsBasicResponse result = await usersController.DeleteAUserAsync(userId);
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
| 404 | User not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


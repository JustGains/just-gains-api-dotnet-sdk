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

[`Task<List<Models.UsersResponse>>`](../../doc/models/users-response.md)

## Example Usage

```csharp
try
{
    List<UsersResponse> result = await usersController.GetAListOfAllUsersAsync();
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
| 401 | Authentication required | [`Users401ErrorException`](../../doc/models/users-401-error-exception.md) |
| 403 | Access denied | [`Users403ErrorException`](../../doc/models/users-403-error-exception.md) |


# Get a User by ID

```csharp
GetAUserByIDAsync(
    string userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `string` | Template, Required | - |

## Response Type

[`Task<Models.UsersResponse1>`](../../doc/models/users-response-1.md)

## Example Usage

```csharp
string userId = "123e4567-e89b-12d3-a456-426614174000";
try
{
    UsersResponse1 result = await usersController.GetAUserByIDAsync(userId);
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
| 400 | Invalid user ID format | [`Users400ErrorException`](../../doc/models/users-400-error-exception.md) |
| 401 | Authentication required | [`Users401ErrorException`](../../doc/models/users-401-error-exception.md) |
| 403 | Access denied | [`Users403ErrorException`](../../doc/models/users-403-error-exception.md) |
| 404 | User not found | [`Users404ErrorException`](../../doc/models/users-404-error-exception.md) |


# Update a User

```csharp
UpdateAUserAsync(
    string userId,
    Models.UserWithoutCreatorProfile body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `string` | Template, Required | - |
| `body` | [`UserWithoutCreatorProfile`](../../doc/models/user-without-creator-profile.md) | Body, Required | - |

## Response Type

[`Task<Models.UsersResponse2>`](../../doc/models/users-response-2.md)

## Example Usage

```csharp
string userId = "userId0";
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
    Role = "user",
};

try
{
    UsersResponse2 result = await usersController.UpdateAUserAsync(
        userId,
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
| 400 | Invalid user data | [`Users400ErrorException`](../../doc/models/users-400-error-exception.md) |
| 404 | User not found | [`Users404ErrorException`](../../doc/models/users-404-error-exception.md) |


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

[`Task<Models.UsersResponse3>`](../../doc/models/users-response-3.md)

## Example Usage

```csharp
string userId = "userId0";
try
{
    UsersResponse3 result = await usersController.DeleteAUserAsync(userId);
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
| 404 | User not found | [`Users404ErrorException`](../../doc/models/users-404-error-exception.md) |


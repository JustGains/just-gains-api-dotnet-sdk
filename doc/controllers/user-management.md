# User Management

```csharp
UserManagementController userManagementController = client.UserManagementController;
```

## Class Name

`UserManagementController`

## Methods

* [Get Current User Information](../../doc/controllers/user-management.md#get-current-user-information)
* [Update User Information](../../doc/controllers/user-management.md#update-user-information)


# Get Current User Information

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetCurrentUserInformationAsync()
```

## Response Type

[`Task<Models.AuthUserResponse>`](../../doc/models/auth-user-response.md)

## Example Usage

```csharp
try
{
    AuthUserResponse result = await userManagementController.GetCurrentUserInformationAsync();
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
| 400 | Failed to retrieve user information | [`AuthUser400ErrorException`](../../doc/models/auth-user-400-error-exception.md) |


# Update User Information

:information_source: **Note** This endpoint does not require authentication.

```csharp
UpdateUserInformationAsync(
    Models.UpdateUserRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`UpdateUserRequest`](../../doc/models/update-user-request.md) | Body, Required | - |

## Response Type

[`Task<Models.AuthUserResponse1>`](../../doc/models/auth-user-response-1.md)

## Example Usage

```csharp
UpdateUserRequest body = new UpdateUserRequest
{
    User = new User1
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
    },
};

try
{
    AuthUserResponse1 result = await userManagementController.UpdateUserInformationAsync(body);
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
| 400 | Failed to update user information | [`AuthUser400ErrorException`](../../doc/models/auth-user-400-error-exception.md) |


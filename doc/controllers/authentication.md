# Authentication

Endpoints for user authentication, including registration, login, logout, and token refresh.

```csharp
AuthenticationController authenticationController = client.AuthenticationController;
```

## Class Name

`AuthenticationController`

## Methods

* [Get User Info](../../doc/controllers/authentication.md#get-user-info)
* [Update User Info](../../doc/controllers/authentication.md#update-user-info)
* [Register User](../../doc/controllers/authentication.md#register-user)
* [Login User](../../doc/controllers/authentication.md#login-user)
* [Resend Confirmation Email](../../doc/controllers/authentication.md#resend-confirmation-email)
* [Forgot Password](../../doc/controllers/authentication.md#forgot-password)
* [Reset Password](../../doc/controllers/authentication.md#reset-password)
* [Refresh Token](../../doc/controllers/authentication.md#refresh-token)
* [Signout](../../doc/controllers/authentication.md#signout)


# Get User Info

```csharp
GetUserInfoAsync()
```

## Response Type

[`Task<Models.UserInfoResponse>`](../../doc/models/user-info-response.md)

## Example Usage

```csharp
try
{
    UserInfoResponse result = await authenticationController.GetUserInfoAsync();
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
| 401 | Failed to retrieve user information | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Update User Info

```csharp
UpdateUserInfoAsync(
    Models.UpdateUserRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`UpdateUserRequest`](../../doc/models/update-user-request.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsResponse>`](../../doc/models/just-gains-response.md)

## Example Usage

```csharp
UpdateUserRequest body = new UpdateUserRequest
{
    User = new User
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
    },
};

try
{
    JustGainsResponse result = await authenticationController.UpdateUserInfoAsync(body);
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
| 400 | Failed to update user information | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Register User

:information_source: **Note** This endpoint does not require authentication.

```csharp
RegisterUserAsync(
    Models.UserRegisterRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`UserRegisterRequest`](../../doc/models/user-register-request.md) | Body, Required | - |

## Response Type

[`Task<Models.UserInfoResponse>`](../../doc/models/user-info-response.md)

## Example Usage

```csharp
UserRegisterRequest body = new UserRegisterRequest
{
    Email = "john.doe@example.com",
    Password = "StrongP@ssw0rd!",
    Username = "johndoe123",
    FirstName = "John",
    LastName = "Doe",
    RedirectUrl = "https://example.com/welcome",
};

try
{
    UserInfoResponse result = await authenticationController.RegisterUserAsync(body);
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
| 400 | Invalid parameters | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Login User

:information_source: **Note** This endpoint does not require authentication.

```csharp
LoginUserAsync(
    Models.UserLoginRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`UserLoginRequest`](../../doc/models/user-login-request.md) | Body, Required | - |

## Response Type

[`Task<Models.AuthSigninResponse>`](../../doc/models/auth-signin-response.md)

## Example Usage

```csharp
UserLoginRequest body = new UserLoginRequest
{
    Email = "john.doe@example.com",
    Password = "StrongP@ssw0rd!",
};

try
{
    AuthSigninResponse result = await authenticationController.LoginUserAsync(body);
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
| 400 | Invalid credentials | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Resend Confirmation Email

:information_source: **Note** This endpoint does not require authentication.

```csharp
ResendConfirmationEmailAsync(
    Models.ConfirmEmailRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ConfirmEmailRequest`](../../doc/models/confirm-email-request.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
ConfirmEmailRequest body = new ConfirmEmailRequest
{
    Email = "john.doe@example.com",
};

try
{
    JustGainsBasicResponse result = await authenticationController.ResendConfirmationEmailAsync(body);
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
| 400 | Failed to send confirmation email | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Forgot Password

:information_source: **Note** This endpoint does not require authentication.

```csharp
ForgotPasswordAsync(
    Models.ForgotPasswordRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ForgotPasswordRequest`](../../doc/models/forgot-password-request.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsResponse>`](../../doc/models/just-gains-response.md)

## Example Usage

```csharp
ForgotPasswordRequest body = new ForgotPasswordRequest
{
    Email = "john.doe@example.com",
};

try
{
    JustGainsResponse result = await authenticationController.ForgotPasswordAsync(body);
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
| 404 | Failed to send password reset email | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Reset Password

:information_source: **Note** This endpoint does not require authentication.

```csharp
ResetPasswordAsync(
    Models.ResetPasswordRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ResetPasswordRequest`](../../doc/models/reset-password-request.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
ResetPasswordRequest body = new ResetPasswordRequest
{
    NewPassword = "NewStrongP@ssw0rd!",
};

try
{
    JustGainsBasicResponse result = await authenticationController.ResetPasswordAsync(body);
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
| 400 | Failed to reset password | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Refresh Token

:information_source: **Note** This endpoint does not require authentication.

```csharp
RefreshTokenAsync()
```

## Response Type

[`Task<Models.AuthRefreshTokenResponse>`](../../doc/models/auth-refresh-token-response.md)

## Example Usage

```csharp
try
{
    AuthRefreshTokenResponse result = await authenticationController.RefreshTokenAsync();
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
| 400 | Failed to refresh token | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Signout

```csharp
SignoutAsync()
```

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
try
{
    JustGainsBasicResponse result = await authenticationController.SignoutAsync();
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
| 400 | Failed to sign out user | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


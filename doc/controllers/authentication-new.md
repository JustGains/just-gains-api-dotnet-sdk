# Authentication New

```csharp
AuthenticationNewController authenticationNewController = client.AuthenticationNewController;
```

## Class Name

`AuthenticationNewController`

## Methods

* [Register a New User](../../doc/controllers/authentication-new.md#register-a-new-user)
* [Sign in a User](../../doc/controllers/authentication-new.md#sign-in-a-user)
* [Resend Confirmation Email](../../doc/controllers/authentication-new.md#resend-confirmation-email)
* [Initiate Forgot Password Process](../../doc/controllers/authentication-new.md#initiate-forgot-password-process)
* [Reset User Password](../../doc/controllers/authentication-new.md#reset-user-password)
* [Refresh Authentication Token](../../doc/controllers/authentication-new.md#refresh-authentication-token)
* [Sign Out the Current User](../../doc/controllers/authentication-new.md#sign-out-the-current-user)


# Register a New User

:information_source: **Note** This endpoint does not require authentication.

```csharp
RegisterANewUserAsync(
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
    UserInfoResponse result = await authenticationNewController.RegisterANewUserAsync(body);
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


# Sign in a User

:information_source: **Note** This endpoint does not require authentication.

```csharp
SignInAUserAsync(
    Models.UserLoginRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`UserLoginRequest`](../../doc/models/user-login-request.md) | Body, Required | - |

## Response Type

[`Task<Models.AuthResponse>`](../../doc/models/auth-response.md)

## Example Usage

```csharp
UserLoginRequest body = new UserLoginRequest
{
    Email = "john.doe@example.com",
    Password = "StrongP@ssw0rd!",
};

try
{
    AuthResponse result = await authenticationNewController.SignInAUserAsync(body);
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
    JustGainsBasicResponse result = await authenticationNewController.ResendConfirmationEmailAsync(body);
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


# Initiate Forgot Password Process

:information_source: **Note** This endpoint does not require authentication.

```csharp
InitiateForgotPasswordProcessAsync(
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
    JustGainsResponse result = await authenticationNewController.InitiateForgotPasswordProcessAsync(body);
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


# Reset User Password

:information_source: **Note** This endpoint does not require authentication.

```csharp
ResetUserPasswordAsync(
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
    JustGainsBasicResponse result = await authenticationNewController.ResetUserPasswordAsync(body);
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


# Refresh Authentication Token

:information_source: **Note** This endpoint does not require authentication.

```csharp
RefreshAuthenticationTokenAsync()
```

## Response Type

[`Task<Models.AuthResponse>`](../../doc/models/auth-response.md)

## Example Usage

```csharp
try
{
    AuthResponse result = await authenticationNewController.RefreshAuthenticationTokenAsync();
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


# Sign Out the Current User

:information_source: **Note** This endpoint does not require authentication.

```csharp
SignOutTheCurrentUserAsync()
```

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
try
{
    JustGainsBasicResponse result = await authenticationNewController.SignOutTheCurrentUserAsync();
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


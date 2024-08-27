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

[`Task<Models.AuthSignupResponse>`](../../doc/models/auth-signup-response.md)

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
    AuthSignupResponse result = await authenticationNewController.RegisterANewUserAsync(body);
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
| 400 | Invalid parameters | [`AuthSignup400ErrorException`](../../doc/models/auth-signup-400-error-exception.md) |


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
    AuthSigninResponse result = await authenticationNewController.SignInAUserAsync(body);
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
| 400 | Invalid credentials | [`AuthSignin400ErrorException`](../../doc/models/auth-signin-400-error-exception.md) |


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

[`Task<Models.AuthResendConfirmationEmailResponse>`](../../doc/models/auth-resend-confirmation-email-response.md)

## Example Usage

```csharp
ConfirmEmailRequest body = new ConfirmEmailRequest
{
    Email = "john.doe@example.com",
};

try
{
    AuthResendConfirmationEmailResponse result = await authenticationNewController.ResendConfirmationEmailAsync(body);
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
| 400 | Failed to send confirmation email | [`AuthResendConfirmationEmail400ErrorException`](../../doc/models/auth-resend-confirmation-email-400-error-exception.md) |


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

[`Task<Models.AuthForgotPasswordResponse>`](../../doc/models/auth-forgot-password-response.md)

## Example Usage

```csharp
ForgotPasswordRequest body = new ForgotPasswordRequest
{
    Email = "john.doe@example.com",
};

try
{
    AuthForgotPasswordResponse result = await authenticationNewController.InitiateForgotPasswordProcessAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


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

[`Task<Models.AuthResetPasswordResponse>`](../../doc/models/auth-reset-password-response.md)

## Example Usage

```csharp
ResetPasswordRequest body = new ResetPasswordRequest
{
    NewPassword = "NewStrongP@ssw0rd!",
};

try
{
    AuthResetPasswordResponse result = await authenticationNewController.ResetUserPasswordAsync(body);
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
| 400 | Failed to reset password | [`AuthResetPassword400ErrorException`](../../doc/models/auth-reset-password-400-error-exception.md) |


# Refresh Authentication Token

:information_source: **Note** This endpoint does not require authentication.

```csharp
RefreshAuthenticationTokenAsync()
```

## Response Type

[`Task<Models.AuthRefreshTokenResponse>`](../../doc/models/auth-refresh-token-response.md)

## Example Usage

```csharp
try
{
    AuthRefreshTokenResponse result = await authenticationNewController.RefreshAuthenticationTokenAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Sign Out the Current User

:information_source: **Note** This endpoint does not require authentication.

```csharp
SignOutTheCurrentUserAsync()
```

## Response Type

[`Task<Models.JustGainsDefaultResponse>`](../../doc/models/just-gains-default-response.md)

## Example Usage

```csharp
try
{
    JustGainsDefaultResponse result = await authenticationNewController.SignOutTheCurrentUserAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "status": "OK",
  "message": "User was successfully signed out!"
}
```



# Getting Started with JustGains-API

## Introduction

API for managing workout programs, exercises, and user accounts. Includes endpoints for creating, updating, and deleting workouts, exercises, and user profiles, as well as managing exercise instructions, videos, and equipment data.

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package JustgainsApiSDK --version 0.2.2
```

You can also view the package at:
https://www.nuget.org/packages/JustgainsApiSDK/0.2.2

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Environment` | `Environment` | The API environment. <br> **Default: `Environment.Testing`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `BearerAuthCredentials` | [`BearerAuthCredentials`](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/auth/oauth-2-bearer-token.md) | The Credentials Setter for OAuth 2 Bearer token |
| `UserRolesCredentials` | [`UserRolesCredentials`](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |

The API client can be initialized as follows:

```csharp
JustGainsAPIClient client = new JustGainsAPIClient.Builder()
    .BearerAuthCredentials(
        new BearerAuthModel.Builder(
            "AccessToken"
        )
        .Build())
    .UserRolesCredentials(
        new UserRolesModel.Builder(
            "X-User-Role"
        )
        .Build())
    .Environment(JustGainsAPI.Standard.Environment.Testing)
    .Build();
```

## Environments

The SDK can be configured to use a different environment for making API calls. Available environments are:

### Fields

| Name | Description |
|  --- | --- |
| testing | **Default** |
| production | - |
| mock | - |

## Authorization

This API uses the following authentication schemes.

* [`bearerAuth (OAuth 2 Bearer token)`](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/auth/oauth-2-bearer-token.md)
* [`userRoles (Custom Header Signature)`](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/auth/custom-header-signature.md)

## List of APIs

* [Users Creator Profiles](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/users-creator-profiles.md)
* [Users Social Media Accounts](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/users-social-media-accounts.md)
* [Exercise Library Exercises](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/exercise-library-exercises.md)
* [Exercise Library Exercises Exercise Instructions](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/exercise-library-exercises-exercise-instructions.md)
* [Exercise Library Exercises Exercise Videos](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/exercise-library-exercises-exercise-videos.md)
* [Exercise Library Exercises Exercise Thumbnails](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/exercise-library-exercises-exercise-thumbnails.md)
* [Exercise Library Muscles](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/exercise-library-muscles.md)
* [Exercise Library Muscles Muscle Groups](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/exercise-library-muscles-muscle-groups.md)
* [Exercise Library Equipment](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/exercise-library-equipment.md)
* [Exercise Library Equipment Equipment Groups](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/exercise-library-equipment-equipment-groups.md)
* [Exercise Library Exercise Drafts](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/exercise-library-exercise-drafts.md)
* [Exercise Library Exercise Categories](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/exercise-library-exercise-categories.md)
* [Exercise Library Exercise Metrics](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/exercise-library-exercise-metrics.md)
* [Workouts Workout Data](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/workouts-workout-data.md)
* [Workouts Workout Content](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/workouts-workout-content.md)
* [Workouts Workout Preview](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/workouts-workout-preview.md)
* [Common Media Assets](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/common-media-assets.md)
* [Common Locales](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/common-locales.md)
* [Common Published Status](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/common-published-status.md)
* [Status](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/status.md)
* [Authentication](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/authentication.md)
* [Users](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/users.md)
* [Users Roles](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/users-roles.md)
* [Workouts](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/controllers/workouts.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/http-request.md)
* [HttpResponse](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/http-string-response.md)
* [HttpContext](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.2.2/doc/api-exception.md)


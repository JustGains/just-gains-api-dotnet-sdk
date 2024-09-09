
# Getting Started with JustGains-API

## Introduction

API for managing workout programs, exercises, and user accounts. Includes endpoints for creating, updating, and deleting workouts, exercises, and user profiles, as well as managing exercise instructions, videos, and equipment data.

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package JustgainsApiSDK --version 0.0.5
```

You can also view the package at:
https://www.nuget.org/packages/JustgainsApiSDK/0.0.5

## Test the SDK

The generated SDK also contain one or more Tests, which are contained in the Tests project. In order to invoke these test cases, you will need `NUnit 3.0 Test Adapter Extension` for Visual Studio. Once the SDK is complied, the test cases should appear in the Test Explorer window. Here, you can click `Run All` to execute these test cases.

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Environment` | `Environment` | The API environment. <br> **Default: `Environment.Testing`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `BearerAuthCredentials` | [`BearerAuthCredentials`](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/auth/oauth-2-bearer-token.md) | The Credentials Setter for OAuth 2 Bearer token |

The API client can be initialized as follows:

```csharp
JustGainsAPIClient client = new JustGainsAPIClient.Builder()
    .BearerAuthCredentials(
        new BearerAuthModel.Builder(
            "AccessToken"
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

* [`bearerAuth (OAuth 2 Bearer token)`](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/auth/oauth-2-bearer-token.md)

## List of APIs

* [Users Creator Profiles](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/users-creator-profiles.md)
* [Exercises Exercise Instructions](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/exercises-exercise-instructions.md)
* [Exercises Exercise Videos](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/exercises-exercise-videos.md)
* [Muscles Muscle Groups](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/muscles-muscle-groups.md)
* [Equipment Equipment Groups](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/equipment-equipment-groups.md)
* [Workouts Workout Data](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/workouts-workout-data.md)
* [Exercise Drafts](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/exercise-drafts.md)
* [Exercise Categories](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/exercise-categories.md)
* [Programs Program Weeks](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/programs-program-weeks.md)
* [Programs Program Analytics](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/programs-program-analytics.md)
* [Users Role Management](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/users-role-management.md)
* [Media Assets](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/media-assets.md)
* [Published Status](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/published-status.md)
* [Exercise Metrics](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/exercise-metrics.md)
* [Programs Program Views](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/programs-program-views.md)
* [Programs Program Reviews](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/programs-program-reviews.md)
* [Exercises Exercise Thumbnails](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/exercises-exercise-thumbnails.md)
* [Authentication](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/authentication.md)
* [Users](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/users.md)
* [Exercises](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/exercises.md)
* [Muscles](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/muscles.md)
* [Equipment](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/equipment.md)
* [Workouts](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/workouts.md)
* [Programs](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/programs.md)
* [Status](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/status.md)
* [Locales](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/controllers/locales.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/http-request.md)
* [HttpResponse](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/http-string-response.md)
* [HttpContext](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/JustGains/just-gains-api-dotnet-sdk/tree/0.0.5/doc/api-exception.md)


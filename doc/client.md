
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Environment` | `Environment` | The API environment. <br> **Default: `Environment.Testing`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `BearerAuthCredentials` | [`BearerAuthCredentials`](auth/oauth-2-bearer-token.md) | The Credentials Setter for OAuth 2 Bearer token |
| `UserRolesCredentials` | [`UserRolesCredentials`](auth/custom-header-signature.md) | The Credentials Setter for Custom Header Signature |

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

## JustGains-APIClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| StatusController | Gets StatusController controller. |
| AuthenticationController | Gets AuthenticationController controller. |
| UsersController | Gets UsersController controller. |
| UsersRolesController | Gets UsersRolesController controller. |
| UsersCreatorProfilesController | Gets UsersCreatorProfilesController controller. |
| UsersSocialMediaAccountsController | Gets UsersSocialMediaAccountsController controller. |
| ExerciseLibraryExercisesController | Gets ExerciseLibraryExercisesController controller. |
| ExerciseLibraryExercisesExerciseInstructionsController | Gets ExerciseLibraryExercisesExerciseInstructionsController controller. |
| ExerciseLibraryExercisesExerciseVideosController | Gets ExerciseLibraryExercisesExerciseVideosController controller. |
| ExerciseLibraryExercisesExerciseThumbnailsController | Gets ExerciseLibraryExercisesExerciseThumbnailsController controller. |
| ExerciseLibraryMusclesController | Gets ExerciseLibraryMusclesController controller. |
| ExerciseLibraryMusclesMuscleGroupsController | Gets ExerciseLibraryMusclesMuscleGroupsController controller. |
| ExerciseLibraryEquipmentController | Gets ExerciseLibraryEquipmentController controller. |
| ExerciseLibraryEquipmentEquipmentGroupsController | Gets ExerciseLibraryEquipmentEquipmentGroupsController controller. |
| ExerciseLibraryExerciseDraftsController | Gets ExerciseLibraryExerciseDraftsController controller. |
| ExerciseLibraryExerciseCategoriesController | Gets ExerciseLibraryExerciseCategoriesController controller. |
| ExerciseLibraryExerciseMetricsController | Gets ExerciseLibraryExerciseMetricsController controller. |
| WorkoutsController | Gets WorkoutsController controller. |
| WorkoutsWorkoutDataController | Gets WorkoutsWorkoutDataController controller. |
| WorkoutsWorkoutContentController | Gets WorkoutsWorkoutContentController controller. |
| WorkoutsWorkoutPreviewController | Gets WorkoutsWorkoutPreviewController controller. |
| CommonMediaAssetsController | Gets CommonMediaAssetsController controller. |
| CommonLocalesController | Gets CommonLocalesController controller. |
| CommonPublishedStatusController | Gets CommonPublishedStatusController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| BearerAuthCredentials | Gets the credentials to use with BearerAuth. | [`IBearerAuthCredentials`](auth/oauth-2-bearer-token.md) |
| UserRolesCredentials | Gets the credentials to use with UserRoles. | [`IUserRolesCredentials`](auth/custom-header-signature.md) |

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `GetBaseUri(Server alias = Server.Default)` | Gets the URL for a particular alias in the current environment and appends it with template parameters. | `string` |
| `ToBuilder()` | Creates an object of the JustGains-APIClient using the values provided for the builder. | `Builder` |

## JustGains-APIClient Builder Class

Class to build instances of JustGains-APIClient.

### Methods

| Name | Description | Return Type |
|  --- | --- | --- |
| `HttpClientConfiguration(Action<`[`HttpClientConfiguration.Builder`](http-client-configuration-builder.md)`> action)` | Gets the configuration of the Http Client associated with this client. | `Builder` |
| `Timeout(TimeSpan timeout)` | Http client timeout. | `Builder` |
| `Environment(Environment environment)` | Current API environment. | `Builder` |
| `BearerAuthCredentials(Action<BearerAuthModel.Builder> action)` | Sets credentials for BearerAuth. | `Builder` |
| `UserRolesCredentials(Action<UserRolesModel.Builder> action)` | Sets credentials for UserRoles. | `Builder` |


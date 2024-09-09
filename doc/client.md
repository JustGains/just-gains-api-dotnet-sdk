
# Client Class Documentation

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Environment` | `Environment` | The API environment. <br> **Default: `Environment.Testing`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `BearerAuthCredentials` | [`BearerAuthCredentials`](auth/oauth-2-bearer-token.md) | The Credentials Setter for OAuth 2 Bearer token |

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

## JustGains-APIClient Class

The gateway for the SDK. This class acts as a factory for the Controllers and also holds the configuration of the SDK.

### Controllers

| Name | Description |
|  --- | --- |
| AuthenticationController | Gets AuthenticationController controller. |
| UsersController | Gets UsersController controller. |
| UsersCreatorProfilesController | Gets UsersCreatorProfilesController controller. |
| ExercisesController | Gets ExercisesController controller. |
| ExercisesExerciseInstructionsController | Gets ExercisesExerciseInstructionsController controller. |
| ExercisesExerciseVideosController | Gets ExercisesExerciseVideosController controller. |
| MusclesController | Gets MusclesController controller. |
| MusclesMuscleGroupsController | Gets MusclesMuscleGroupsController controller. |
| EquipmentController | Gets EquipmentController controller. |
| EquipmentEquipmentGroupsController | Gets EquipmentEquipmentGroupsController controller. |
| WorkoutsController | Gets WorkoutsController controller. |
| WorkoutsWorkoutDataController | Gets WorkoutsWorkoutDataController controller. |
| ExerciseDraftsController | Gets ExerciseDraftsController controller. |
| ExerciseCategoriesController | Gets ExerciseCategoriesController controller. |
| ProgramsController | Gets ProgramsController controller. |
| ProgramsProgramWeeksController | Gets ProgramsProgramWeeksController controller. |
| ProgramsProgramAnalyticsController | Gets ProgramsProgramAnalyticsController controller. |
| StatusController | Gets StatusController controller. |
| UsersRoleManagementController | Gets UsersRoleManagementController controller. |
| MediaAssetsController | Gets MediaAssetsController controller. |
| LocalesController | Gets LocalesController controller. |
| PublishedStatusController | Gets PublishedStatusController controller. |
| ExerciseMetricsController | Gets ExerciseMetricsController controller. |
| ProgramsProgramViewsController | Gets ProgramsProgramViewsController controller. |
| ProgramsProgramReviewsController | Gets ProgramsProgramReviewsController controller. |
| ExercisesExerciseThumbnailsController | Gets ExercisesExerciseThumbnailsController controller. |

### Properties

| Name | Description | Type |
|  --- | --- | --- |
| HttpClientConfiguration | Gets the configuration of the Http Client associated with this client. | [`IHttpClientConfiguration`](http-client-configuration.md) |
| Timeout | Http client timeout. | `TimeSpan` |
| Environment | Current API environment. | `Environment` |
| BearerAuthCredentials | Gets the credentials to use with BearerAuth. | [`IBearerAuthCredentials`](auth/oauth-2-bearer-token.md) |

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


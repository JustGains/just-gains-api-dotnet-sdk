// <copyright file="JustGainsAPIClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using APIMatic.Core;
using APIMatic.Core.Authentication;
using JustGainsAPI.Standard.Authentication;
using JustGainsAPI.Standard.Controllers;
using JustGainsAPI.Standard.Http.Client;
using JustGainsAPI.Standard.Utilities;

namespace JustGainsAPI.Standard
{
    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class JustGainsAPIClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Testing, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://testing.api.justgains.com/api" },
                }
            },
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://api.justgains.com/api" },
                }
            },
            {
                Environment.Mock, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://mock.api.justgains.com" },
                }
            },
        };

        private readonly GlobalConfiguration globalConfiguration;
        private const string userAgent = "APIMATIC 3.0";
        private readonly HttpCallback httpCallback;
        private readonly Lazy<StatusController> status;
        private readonly Lazy<AuthenticationController> authentication;
        private readonly Lazy<UsersController> users;
        private readonly Lazy<UsersRolesController> usersRoles;
        private readonly Lazy<UsersCreatorProfilesController> usersCreatorProfiles;
        private readonly Lazy<UsersSocialMediaAccountsController> usersSocialMediaAccounts;
        private readonly Lazy<ExerciseLibraryExercisesController> exerciseLibraryExercises;
        private readonly Lazy<ExerciseLibraryExercisesExerciseInstructionsController> exerciseLibraryExercisesExerciseInstructions;
        private readonly Lazy<ExerciseLibraryExercisesExerciseVideosController> exerciseLibraryExercisesExerciseVideos;
        private readonly Lazy<ExerciseLibraryExercisesExerciseThumbnailsController> exerciseLibraryExercisesExerciseThumbnails;
        private readonly Lazy<ExerciseLibraryMusclesController> exerciseLibraryMuscles;
        private readonly Lazy<ExerciseLibraryMusclesMuscleGroupsController> exerciseLibraryMusclesMuscleGroups;
        private readonly Lazy<ExerciseLibraryEquipmentController> exerciseLibraryEquipment;
        private readonly Lazy<ExerciseLibraryEquipmentEquipmentGroupsController> exerciseLibraryEquipmentEquipmentGroups;
        private readonly Lazy<ExerciseLibraryExerciseDraftsController> exerciseLibraryExerciseDrafts;
        private readonly Lazy<ExerciseLibraryExerciseCategoriesController> exerciseLibraryExerciseCategories;
        private readonly Lazy<ExerciseLibraryExerciseMetricsController> exerciseLibraryExerciseMetrics;
        private readonly Lazy<WorkoutsController> workouts;
        private readonly Lazy<WorkoutsWorkoutDataController> workoutsWorkoutData;
        private readonly Lazy<CommonMediaAssetsController> commonMediaAssets;
        private readonly Lazy<CommonLocalesController> commonLocales;
        private readonly Lazy<CommonPublishedStatusController> commonPublishedStatus;

        private JustGainsAPIClient(
            Environment environment,
            BearerAuthModel bearerAuthModel,
            UserRolesModel userRolesModel,
            HttpCallback httpCallback,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.httpCallback = httpCallback;
            this.HttpClientConfiguration = httpClientConfiguration;
            BearerAuthModel = bearerAuthModel;
            var bearerAuthManager = new BearerAuthManager(bearerAuthModel);
            UserRolesModel = userRolesModel;
            var userRolesManager = new UserRolesManager(userRolesModel);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                    {"bearerAuth", bearerAuthManager},
                    {"userRoles", userRolesManager},
                })
                .ApiCallback(httpCallback)
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Default)
                .UserAgent(userAgent)
                .Build();

            BearerAuthCredentials = bearerAuthManager;
            UserRolesCredentials = userRolesManager;

            this.status = new Lazy<StatusController>(
                () => new StatusController(globalConfiguration));
            this.authentication = new Lazy<AuthenticationController>(
                () => new AuthenticationController(globalConfiguration));
            this.users = new Lazy<UsersController>(
                () => new UsersController(globalConfiguration));
            this.usersRoles = new Lazy<UsersRolesController>(
                () => new UsersRolesController(globalConfiguration));
            this.usersCreatorProfiles = new Lazy<UsersCreatorProfilesController>(
                () => new UsersCreatorProfilesController(globalConfiguration));
            this.usersSocialMediaAccounts = new Lazy<UsersSocialMediaAccountsController>(
                () => new UsersSocialMediaAccountsController(globalConfiguration));
            this.exerciseLibraryExercises = new Lazy<ExerciseLibraryExercisesController>(
                () => new ExerciseLibraryExercisesController(globalConfiguration));
            this.exerciseLibraryExercisesExerciseInstructions = new Lazy<ExerciseLibraryExercisesExerciseInstructionsController>(
                () => new ExerciseLibraryExercisesExerciseInstructionsController(globalConfiguration));
            this.exerciseLibraryExercisesExerciseVideos = new Lazy<ExerciseLibraryExercisesExerciseVideosController>(
                () => new ExerciseLibraryExercisesExerciseVideosController(globalConfiguration));
            this.exerciseLibraryExercisesExerciseThumbnails = new Lazy<ExerciseLibraryExercisesExerciseThumbnailsController>(
                () => new ExerciseLibraryExercisesExerciseThumbnailsController(globalConfiguration));
            this.exerciseLibraryMuscles = new Lazy<ExerciseLibraryMusclesController>(
                () => new ExerciseLibraryMusclesController(globalConfiguration));
            this.exerciseLibraryMusclesMuscleGroups = new Lazy<ExerciseLibraryMusclesMuscleGroupsController>(
                () => new ExerciseLibraryMusclesMuscleGroupsController(globalConfiguration));
            this.exerciseLibraryEquipment = new Lazy<ExerciseLibraryEquipmentController>(
                () => new ExerciseLibraryEquipmentController(globalConfiguration));
            this.exerciseLibraryEquipmentEquipmentGroups = new Lazy<ExerciseLibraryEquipmentEquipmentGroupsController>(
                () => new ExerciseLibraryEquipmentEquipmentGroupsController(globalConfiguration));
            this.exerciseLibraryExerciseDrafts = new Lazy<ExerciseLibraryExerciseDraftsController>(
                () => new ExerciseLibraryExerciseDraftsController(globalConfiguration));
            this.exerciseLibraryExerciseCategories = new Lazy<ExerciseLibraryExerciseCategoriesController>(
                () => new ExerciseLibraryExerciseCategoriesController(globalConfiguration));
            this.exerciseLibraryExerciseMetrics = new Lazy<ExerciseLibraryExerciseMetricsController>(
                () => new ExerciseLibraryExerciseMetricsController(globalConfiguration));
            this.workouts = new Lazy<WorkoutsController>(
                () => new WorkoutsController(globalConfiguration));
            this.workoutsWorkoutData = new Lazy<WorkoutsWorkoutDataController>(
                () => new WorkoutsWorkoutDataController(globalConfiguration));
            this.commonMediaAssets = new Lazy<CommonMediaAssetsController>(
                () => new CommonMediaAssetsController(globalConfiguration));
            this.commonLocales = new Lazy<CommonLocalesController>(
                () => new CommonLocalesController(globalConfiguration));
            this.commonPublishedStatus = new Lazy<CommonPublishedStatusController>(
                () => new CommonPublishedStatusController(globalConfiguration));
        }

        /// <summary>
        /// Gets StatusController controller.
        /// </summary>
        public StatusController StatusController => this.status.Value;

        /// <summary>
        /// Gets AuthenticationController controller.
        /// </summary>
        public AuthenticationController AuthenticationController => this.authentication.Value;

        /// <summary>
        /// Gets UsersController controller.
        /// </summary>
        public UsersController UsersController => this.users.Value;

        /// <summary>
        /// Gets UsersRolesController controller.
        /// </summary>
        public UsersRolesController UsersRolesController => this.usersRoles.Value;

        /// <summary>
        /// Gets UsersCreatorProfilesController controller.
        /// </summary>
        public UsersCreatorProfilesController UsersCreatorProfilesController => this.usersCreatorProfiles.Value;

        /// <summary>
        /// Gets UsersSocialMediaAccountsController controller.
        /// </summary>
        public UsersSocialMediaAccountsController UsersSocialMediaAccountsController => this.usersSocialMediaAccounts.Value;

        /// <summary>
        /// Gets ExerciseLibraryExercisesController controller.
        /// </summary>
        public ExerciseLibraryExercisesController ExerciseLibraryExercisesController => this.exerciseLibraryExercises.Value;

        /// <summary>
        /// Gets ExerciseLibraryExercisesExerciseInstructionsController controller.
        /// </summary>
        public ExerciseLibraryExercisesExerciseInstructionsController ExerciseLibraryExercisesExerciseInstructionsController => this.exerciseLibraryExercisesExerciseInstructions.Value;

        /// <summary>
        /// Gets ExerciseLibraryExercisesExerciseVideosController controller.
        /// </summary>
        public ExerciseLibraryExercisesExerciseVideosController ExerciseLibraryExercisesExerciseVideosController => this.exerciseLibraryExercisesExerciseVideos.Value;

        /// <summary>
        /// Gets ExerciseLibraryExercisesExerciseThumbnailsController controller.
        /// </summary>
        public ExerciseLibraryExercisesExerciseThumbnailsController ExerciseLibraryExercisesExerciseThumbnailsController => this.exerciseLibraryExercisesExerciseThumbnails.Value;

        /// <summary>
        /// Gets ExerciseLibraryMusclesController controller.
        /// </summary>
        public ExerciseLibraryMusclesController ExerciseLibraryMusclesController => this.exerciseLibraryMuscles.Value;

        /// <summary>
        /// Gets ExerciseLibraryMusclesMuscleGroupsController controller.
        /// </summary>
        public ExerciseLibraryMusclesMuscleGroupsController ExerciseLibraryMusclesMuscleGroupsController => this.exerciseLibraryMusclesMuscleGroups.Value;

        /// <summary>
        /// Gets ExerciseLibraryEquipmentController controller.
        /// </summary>
        public ExerciseLibraryEquipmentController ExerciseLibraryEquipmentController => this.exerciseLibraryEquipment.Value;

        /// <summary>
        /// Gets ExerciseLibraryEquipmentEquipmentGroupsController controller.
        /// </summary>
        public ExerciseLibraryEquipmentEquipmentGroupsController ExerciseLibraryEquipmentEquipmentGroupsController => this.exerciseLibraryEquipmentEquipmentGroups.Value;

        /// <summary>
        /// Gets ExerciseLibraryExerciseDraftsController controller.
        /// </summary>
        public ExerciseLibraryExerciseDraftsController ExerciseLibraryExerciseDraftsController => this.exerciseLibraryExerciseDrafts.Value;

        /// <summary>
        /// Gets ExerciseLibraryExerciseCategoriesController controller.
        /// </summary>
        public ExerciseLibraryExerciseCategoriesController ExerciseLibraryExerciseCategoriesController => this.exerciseLibraryExerciseCategories.Value;

        /// <summary>
        /// Gets ExerciseLibraryExerciseMetricsController controller.
        /// </summary>
        public ExerciseLibraryExerciseMetricsController ExerciseLibraryExerciseMetricsController => this.exerciseLibraryExerciseMetrics.Value;

        /// <summary>
        /// Gets WorkoutsController controller.
        /// </summary>
        public WorkoutsController WorkoutsController => this.workouts.Value;

        /// <summary>
        /// Gets WorkoutsWorkoutDataController controller.
        /// </summary>
        public WorkoutsWorkoutDataController WorkoutsWorkoutDataController => this.workoutsWorkoutData.Value;

        /// <summary>
        /// Gets CommonMediaAssetsController controller.
        /// </summary>
        public CommonMediaAssetsController CommonMediaAssetsController => this.commonMediaAssets.Value;

        /// <summary>
        /// Gets CommonLocalesController controller.
        /// </summary>
        public CommonLocalesController CommonLocalesController => this.commonLocales.Value;

        /// <summary>
        /// Gets CommonPublishedStatusController controller.
        /// </summary>
        public CommonPublishedStatusController CommonPublishedStatusController => this.commonPublishedStatus.Value;

        /// <summary>
        /// Gets the configuration of the Http Client associated with this client.
        /// </summary>
        public IHttpClientConfiguration HttpClientConfiguration { get; }

        /// <summary>
        /// Gets Environment.
        /// Current API environment.
        /// </summary>
        public Environment Environment { get; }

        /// <summary>
        /// Gets http callback.
        /// </summary>
        public HttpCallback HttpCallback => this.httpCallback;

        /// <summary>
        /// Gets the credentials to use with BearerAuth.
        /// </summary>
        public IBearerAuthCredentials BearerAuthCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with BearerAuth.
        /// </summary>
        public BearerAuthModel BearerAuthModel { get; private set; }

        /// <summary>
        /// Gets the access token to use with OAuth 2 authentication.
        /// </summary>
        public string AccessToken => this.BearerAuthCredentials.AccessToken;

        /// <summary>
        /// Gets the credentials to use with UserRoles.
        /// </summary>
        public IUserRolesCredentials UserRolesCredentials { get; private set; }

        /// <summary>
        /// Gets the credentials model to use with UserRoles.
        /// </summary>
        public UserRolesModel UserRolesModel { get; private set; }

        /// <summary>
        /// Gets the URL for a particular alias in the current environment and appends
        /// it with template parameters.
        /// </summary>
        /// <param name="alias">Default value:DEFAULT.</param>
        /// <returns>Returns the baseurl.</returns>
        public string GetBaseUri(Server alias = Server.Default)
        {
            return globalConfiguration.ServerUrl(alias);
        }

        /// <summary>
        /// Creates an object of the JustGainsAPIClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .HttpCallback(httpCallback)
                .HttpClientConfig(config => config.Build());

            if (BearerAuthModel != null)
            {
                builder.BearerAuthCredentials(BearerAuthModel.ToBuilder().Build());
            }

            if (UserRolesModel != null)
            {
                builder.UserRolesCredentials(UserRolesModel.ToBuilder().Build());
            }

            return builder;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return
                $"Environment = {this.Environment}, " +
                $"HttpClientConfiguration = {this.HttpClientConfiguration}, ";
        }

        /// <summary>
        /// Creates the client using builder.
        /// </summary>
        /// <returns> JustGainsAPIClient.</returns>
        internal static JustGainsAPIClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("JUST_GAINS_API_STANDARD_ENVIRONMENT");
            string accessToken = System.Environment.GetEnvironmentVariable("JUST_GAINS_API_STANDARD_ACCESS_TOKEN");
            string xUserRole = System.Environment.GetEnvironmentVariable("JUST_GAINS_API_STANDARD_X_USER_ROLE");

            if (environment != null)
            {
                builder.Environment(ApiHelper.JsonDeserialize<Environment>($"\"{environment}\""));
            }

            if (accessToken != null)
            {
                builder.BearerAuthCredentials(new BearerAuthModel
                .Builder(accessToken)
                .Build());
            }

            if (xUserRole != null)
            {
                builder.UserRolesCredentials(new UserRolesModel
                .Builder(xUserRole)
                .Build());
            }

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = JustGainsAPI.Standard.Environment.Testing;
            private BearerAuthModel bearerAuthModel = new BearerAuthModel();
            private UserRolesModel userRolesModel = new UserRolesModel();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private HttpCallback httpCallback;

            /// <summary>
            /// Sets credentials for BearerAuth.
            /// </summary>
            /// <param name="bearerAuthModel">BearerAuthModel.</param>
            /// <returns>Builder.</returns>
            public Builder BearerAuthCredentials(BearerAuthModel bearerAuthModel)
            {
                if (bearerAuthModel is null)
                {
                    throw new ArgumentNullException(nameof(bearerAuthModel));
                }

                this.bearerAuthModel = bearerAuthModel;
                return this;
            }

            /// <summary>
            /// Sets credentials for UserRoles.
            /// </summary>
            /// <param name="userRolesModel">UserRolesModel.</param>
            /// <returns>Builder.</returns>
            public Builder UserRolesCredentials(UserRolesModel userRolesModel)
            {
                if (userRolesModel is null)
                {
                    throw new ArgumentNullException(nameof(userRolesModel));
                }

                this.userRolesModel = userRolesModel;
                return this;
            }

            /// <summary>
            /// Sets Environment.
            /// </summary>
            /// <param name="environment"> Environment. </param>
            /// <returns> Builder. </returns>
            public Builder Environment(Environment environment)
            {
                this.environment = environment;
                return this;
            }

            /// <summary>
            /// Sets HttpClientConfig.
            /// </summary>
            /// <param name="action"> Action. </param>
            /// <returns>Builder.</returns>
            public Builder HttpClientConfig(Action<HttpClientConfiguration.Builder> action)
            {
                if (action is null)
                {
                    throw new ArgumentNullException(nameof(action));
                }

                action(this.httpClientConfig);
                return this;
            }



            /// <summary>
            /// Sets the HttpCallback for the Builder.
            /// </summary>
            /// <param name="httpCallback"> http callback. </param>
            /// <returns>Builder.</returns>
            public Builder HttpCallback(HttpCallback httpCallback)
            {
                this.httpCallback = httpCallback;
                return this;
            }

            /// <summary>
            /// Creates an object of the JustGainsAPIClient using the values provided for the builder.
            /// </summary>
            /// <returns>JustGainsAPIClient.</returns>
            public JustGainsAPIClient Build()
            {
                if (bearerAuthModel.AccessToken == null)
                {
                    bearerAuthModel = null;
                }
                if (userRolesModel.XUserRole == null)
                {
                    userRolesModel = null;
                }
                return new JustGainsAPIClient(
                    environment,
                    bearerAuthModel,
                    userRolesModel,
                    httpCallback,
                    httpClientConfig.Build());
            }
        }
    }
}

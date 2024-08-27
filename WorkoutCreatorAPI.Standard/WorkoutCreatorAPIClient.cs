// <copyright file="WorkoutCreatorAPIClient.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using APIMatic.Core;
using APIMatic.Core.Authentication;
using APIMatic.Core.Types;
using WorkoutCreatorAPI.Standard.Authentication;
using WorkoutCreatorAPI.Standard.Controllers;
using WorkoutCreatorAPI.Standard.Http.Client;
using WorkoutCreatorAPI.Standard.Utilities;

namespace WorkoutCreatorAPI.Standard
{
    /// <summary>
    /// The gateway for the SDK. This class acts as a factory for Controller and
    /// holds the configuration of the SDK.
    /// </summary>
    public sealed class WorkoutCreatorAPIClient : IConfiguration
    {
        // A map of environments and their corresponding servers/baseurls
        private static readonly Dictionary<Environment, Dictionary<Enum, string>> EnvironmentsMap =
            new Dictionary<Environment, Dictionary<Enum, string>>
        {
            {
                Environment.Production, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://api.justgains.com/api" },
                }
            },
            {
                Environment.Testing, new Dictionary<Enum, string>
                {
                    { Server.Default, "https://testing.api.justgains.com/api" },
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
        private readonly HttpCallBack httpCallBack;
        private readonly Lazy<AuthenticationNewController> authenticationNew;
        private readonly Lazy<UsersController> users;
        private readonly Lazy<UsersCreatorProfilesController> usersCreatorProfiles;
        private readonly Lazy<ExercisesController> exercises;
        private readonly Lazy<ExercisesExerciseInstructionsController> exercisesExerciseInstructions;
        private readonly Lazy<ExercisesExerciseVideosController> exercisesExerciseVideos;
        private readonly Lazy<MusclesController> muscles;
        private readonly Lazy<MusclesMuscleGroupsController> musclesMuscleGroups;
        private readonly Lazy<EquipmentController> equipment;
        private readonly Lazy<EquipmentEquipmentGroupsController> equipmentEquipmentGroups;
        private readonly Lazy<WorkoutsController> workouts;
        private readonly Lazy<WorkoutsWorkoutDataController> workoutsWorkoutData;
        private readonly Lazy<ExerciseDraftsController> exerciseDrafts;
        private readonly Lazy<ExerciseCategoriesController> exerciseCategories;
        private readonly Lazy<ProgramsController> programs;
        private readonly Lazy<ProgramsProgramWeeksController> programsProgramWeeks;
        private readonly Lazy<ProgramsProgramAnalyticsController> programsProgramAnalytics;
        private readonly Lazy<StatusController> status;
        private readonly Lazy<UserManagementController> userManagement;
        private readonly Lazy<MediaAssetsController> mediaAssets;
        private readonly Lazy<LocalesController> locales;
        private readonly Lazy<PublishedStatusController> publishedStatus;
        private readonly Lazy<ExerciseMetricsController> exerciseMetrics;
        private readonly Lazy<ProgramsProgramViewsController> programsProgramViews;
        private readonly Lazy<ProgramsProgramReviewsController> programsProgramReviews;

        private WorkoutCreatorAPIClient(
            Environment environment,
            BearerAuthModel bearerAuthModel,
            HttpCallBack httpCallBack,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.httpCallBack = httpCallBack;
            this.HttpClientConfiguration = httpClientConfiguration;
            BearerAuthModel = bearerAuthModel;
            var bearerAuthManager = new BearerAuthManager(bearerAuthModel);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                    {"bearerAuth", bearerAuthManager},
                })
                .ApiCallback(httpCallBack)
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Default)
                .UserAgent(userAgent)
                .Build();

            BearerAuthCredentials = bearerAuthManager;

            this.authenticationNew = new Lazy<AuthenticationNewController>(
                () => new AuthenticationNewController(globalConfiguration));
            this.users = new Lazy<UsersController>(
                () => new UsersController(globalConfiguration));
            this.usersCreatorProfiles = new Lazy<UsersCreatorProfilesController>(
                () => new UsersCreatorProfilesController(globalConfiguration));
            this.exercises = new Lazy<ExercisesController>(
                () => new ExercisesController(globalConfiguration));
            this.exercisesExerciseInstructions = new Lazy<ExercisesExerciseInstructionsController>(
                () => new ExercisesExerciseInstructionsController(globalConfiguration));
            this.exercisesExerciseVideos = new Lazy<ExercisesExerciseVideosController>(
                () => new ExercisesExerciseVideosController(globalConfiguration));
            this.muscles = new Lazy<MusclesController>(
                () => new MusclesController(globalConfiguration));
            this.musclesMuscleGroups = new Lazy<MusclesMuscleGroupsController>(
                () => new MusclesMuscleGroupsController(globalConfiguration));
            this.equipment = new Lazy<EquipmentController>(
                () => new EquipmentController(globalConfiguration));
            this.equipmentEquipmentGroups = new Lazy<EquipmentEquipmentGroupsController>(
                () => new EquipmentEquipmentGroupsController(globalConfiguration));
            this.workouts = new Lazy<WorkoutsController>(
                () => new WorkoutsController(globalConfiguration));
            this.workoutsWorkoutData = new Lazy<WorkoutsWorkoutDataController>(
                () => new WorkoutsWorkoutDataController(globalConfiguration));
            this.exerciseDrafts = new Lazy<ExerciseDraftsController>(
                () => new ExerciseDraftsController(globalConfiguration));
            this.exerciseCategories = new Lazy<ExerciseCategoriesController>(
                () => new ExerciseCategoriesController(globalConfiguration));
            this.programs = new Lazy<ProgramsController>(
                () => new ProgramsController(globalConfiguration));
            this.programsProgramWeeks = new Lazy<ProgramsProgramWeeksController>(
                () => new ProgramsProgramWeeksController(globalConfiguration));
            this.programsProgramAnalytics = new Lazy<ProgramsProgramAnalyticsController>(
                () => new ProgramsProgramAnalyticsController(globalConfiguration));
            this.status = new Lazy<StatusController>(
                () => new StatusController(globalConfiguration));
            this.userManagement = new Lazy<UserManagementController>(
                () => new UserManagementController(globalConfiguration));
            this.mediaAssets = new Lazy<MediaAssetsController>(
                () => new MediaAssetsController(globalConfiguration));
            this.locales = new Lazy<LocalesController>(
                () => new LocalesController(globalConfiguration));
            this.publishedStatus = new Lazy<PublishedStatusController>(
                () => new PublishedStatusController(globalConfiguration));
            this.exerciseMetrics = new Lazy<ExerciseMetricsController>(
                () => new ExerciseMetricsController(globalConfiguration));
            this.programsProgramViews = new Lazy<ProgramsProgramViewsController>(
                () => new ProgramsProgramViewsController(globalConfiguration));
            this.programsProgramReviews = new Lazy<ProgramsProgramReviewsController>(
                () => new ProgramsProgramReviewsController(globalConfiguration));
        }

        /// <summary>
        /// Gets AuthenticationNewController controller.
        /// </summary>
        public AuthenticationNewController AuthenticationNewController => this.authenticationNew.Value;

        /// <summary>
        /// Gets UsersController controller.
        /// </summary>
        public UsersController UsersController => this.users.Value;

        /// <summary>
        /// Gets UsersCreatorProfilesController controller.
        /// </summary>
        public UsersCreatorProfilesController UsersCreatorProfilesController => this.usersCreatorProfiles.Value;

        /// <summary>
        /// Gets ExercisesController controller.
        /// </summary>
        public ExercisesController ExercisesController => this.exercises.Value;

        /// <summary>
        /// Gets ExercisesExerciseInstructionsController controller.
        /// </summary>
        public ExercisesExerciseInstructionsController ExercisesExerciseInstructionsController => this.exercisesExerciseInstructions.Value;

        /// <summary>
        /// Gets ExercisesExerciseVideosController controller.
        /// </summary>
        public ExercisesExerciseVideosController ExercisesExerciseVideosController => this.exercisesExerciseVideos.Value;

        /// <summary>
        /// Gets MusclesController controller.
        /// </summary>
        public MusclesController MusclesController => this.muscles.Value;

        /// <summary>
        /// Gets MusclesMuscleGroupsController controller.
        /// </summary>
        public MusclesMuscleGroupsController MusclesMuscleGroupsController => this.musclesMuscleGroups.Value;

        /// <summary>
        /// Gets EquipmentController controller.
        /// </summary>
        public EquipmentController EquipmentController => this.equipment.Value;

        /// <summary>
        /// Gets EquipmentEquipmentGroupsController controller.
        /// </summary>
        public EquipmentEquipmentGroupsController EquipmentEquipmentGroupsController => this.equipmentEquipmentGroups.Value;

        /// <summary>
        /// Gets WorkoutsController controller.
        /// </summary>
        public WorkoutsController WorkoutsController => this.workouts.Value;

        /// <summary>
        /// Gets WorkoutsWorkoutDataController controller.
        /// </summary>
        public WorkoutsWorkoutDataController WorkoutsWorkoutDataController => this.workoutsWorkoutData.Value;

        /// <summary>
        /// Gets ExerciseDraftsController controller.
        /// </summary>
        public ExerciseDraftsController ExerciseDraftsController => this.exerciseDrafts.Value;

        /// <summary>
        /// Gets ExerciseCategoriesController controller.
        /// </summary>
        public ExerciseCategoriesController ExerciseCategoriesController => this.exerciseCategories.Value;

        /// <summary>
        /// Gets ProgramsController controller.
        /// </summary>
        public ProgramsController ProgramsController => this.programs.Value;

        /// <summary>
        /// Gets ProgramsProgramWeeksController controller.
        /// </summary>
        public ProgramsProgramWeeksController ProgramsProgramWeeksController => this.programsProgramWeeks.Value;

        /// <summary>
        /// Gets ProgramsProgramAnalyticsController controller.
        /// </summary>
        public ProgramsProgramAnalyticsController ProgramsProgramAnalyticsController => this.programsProgramAnalytics.Value;

        /// <summary>
        /// Gets StatusController controller.
        /// </summary>
        public StatusController StatusController => this.status.Value;

        /// <summary>
        /// Gets UserManagementController controller.
        /// </summary>
        public UserManagementController UserManagementController => this.userManagement.Value;

        /// <summary>
        /// Gets MediaAssetsController controller.
        /// </summary>
        public MediaAssetsController MediaAssetsController => this.mediaAssets.Value;

        /// <summary>
        /// Gets LocalesController controller.
        /// </summary>
        public LocalesController LocalesController => this.locales.Value;

        /// <summary>
        /// Gets PublishedStatusController controller.
        /// </summary>
        public PublishedStatusController PublishedStatusController => this.publishedStatus.Value;

        /// <summary>
        /// Gets ExerciseMetricsController controller.
        /// </summary>
        public ExerciseMetricsController ExerciseMetricsController => this.exerciseMetrics.Value;

        /// <summary>
        /// Gets ProgramsProgramViewsController controller.
        /// </summary>
        public ProgramsProgramViewsController ProgramsProgramViewsController => this.programsProgramViews.Value;

        /// <summary>
        /// Gets ProgramsProgramReviewsController controller.
        /// </summary>
        public ProgramsProgramReviewsController ProgramsProgramReviewsController => this.programsProgramReviews.Value;

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
        internal HttpCallBack HttpCallBack => this.httpCallBack;

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
        /// Creates an object of the WorkoutCreatorAPIClient using the values provided for the builder.
        /// </summary>
        /// <returns>Builder.</returns>
        public Builder ToBuilder()
        {
            Builder builder = new Builder()
                .Environment(this.Environment)
                .HttpCallBack(httpCallBack)
                .HttpClientConfig(config => config.Build());

            if (BearerAuthModel != null)
            {
                builder.BearerAuthCredentials(BearerAuthModel.ToBuilder().Build());
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
        /// <returns> WorkoutCreatorAPIClient.</returns>
        internal static WorkoutCreatorAPIClient CreateFromEnvironment()
        {
            var builder = new Builder();

            string environment = System.Environment.GetEnvironmentVariable("WORKOUT_CREATOR_API_STANDARD_ENVIRONMENT");
            string accessToken = System.Environment.GetEnvironmentVariable("WORKOUT_CREATOR_API_STANDARD_ACCESS_TOKEN");

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

            return builder.Build();
        }

        /// <summary>
        /// Builder class.
        /// </summary>
        public class Builder
        {
            private Environment environment = WorkoutCreatorAPI.Standard.Environment.Testing;
            private BearerAuthModel bearerAuthModel = new BearerAuthModel();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private HttpCallBack httpCallBack;

            /// <summary>
            /// Sets credentials for BearerAuth.
            /// </summary>
            /// <param name="accessToken">AccessToken.</param>
            /// <returns>Builder.</returns>
            [Obsolete("This method is deprecated. Use BearerAuthCredentials(bearerAuthModel) instead.")]
            public Builder AccessToken(string accessToken)
            {
                bearerAuthModel = bearerAuthModel.ToBuilder()
                    .AccessToken(accessToken)
                    .Build();
                return this;
            }

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
            /// Sets the HttpCallBack for the Builder.
            /// </summary>
            /// <param name="httpCallBack"> http callback. </param>
            /// <returns>Builder.</returns>
            internal Builder HttpCallBack(HttpCallBack httpCallBack)
            {
                this.httpCallBack = httpCallBack;
                return this;
            }

            /// <summary>
            /// Creates an object of the WorkoutCreatorAPIClient using the values provided for the builder.
            /// </summary>
            /// <returns>WorkoutCreatorAPIClient.</returns>
            public WorkoutCreatorAPIClient Build()
            {
                if (bearerAuthModel.AccessToken == null)
                {
                    bearerAuthModel = null;
                }
                return new WorkoutCreatorAPIClient(
                    environment,
                    bearerAuthModel,
                    httpCallBack,
                    httpClientConfig.Build());
            }
        }
    }
}

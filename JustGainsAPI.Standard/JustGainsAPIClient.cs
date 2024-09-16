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
        private readonly Lazy<LocalesController> locales;
        private readonly Lazy<MediaAssetsController> mediaAssets;
        private readonly Lazy<PublishedStatusController> publishedStatus;
        private readonly Lazy<MusclesController> muscles;
        private readonly Lazy<MusclesMuscleGroupsController> musclesMuscleGroups;
        private readonly Lazy<EquipmentController> equipment;
        private readonly Lazy<EquipmentEquipmentGroupsController> equipmentEquipmentGroups;
        private readonly Lazy<ExerciseMetricsController> exerciseMetrics;
        private readonly Lazy<ExerciseTypesController> exerciseTypes;
        private readonly Lazy<ExerciseCategoriesController> exerciseCategories;
        private readonly Lazy<ExercisesController> exercises;
        private readonly Lazy<ExercisesExerciseInstructionsController> exercisesExerciseInstructions;
        private readonly Lazy<ExercisesExerciseVideosController> exercisesExerciseVideos;
        private readonly Lazy<ExerciseDraftsController> exerciseDrafts;
        private readonly Lazy<WorkoutsController> workouts;
        private readonly Lazy<WorkoutsWorkoutDataController> workoutsWorkoutData;
        private readonly Lazy<ProgramsController> programs;
        private readonly Lazy<ProgramsProgramWeeksController> programsProgramWeeks;
        private readonly Lazy<ProgramsProgramAnalyticsController> programsProgramAnalytics;
        private readonly Lazy<ProgramsProgramViewsController> programsProgramViews;
        private readonly Lazy<ProgramsProgramReviewsController> programsProgramReviews;
        private readonly Lazy<ExercisesExerciseThumbnailsController> exercisesExerciseThumbnails;

        private JustGainsAPIClient(
            Environment environment,
            BearerAuthModel bearerAuthModel,
            HttpCallback httpCallback,
            IHttpClientConfiguration httpClientConfiguration)
        {
            this.Environment = environment;
            this.httpCallback = httpCallback;
            this.HttpClientConfiguration = httpClientConfiguration;
            BearerAuthModel = bearerAuthModel;
            var bearerAuthManager = new BearerAuthManager(bearerAuthModel);
            globalConfiguration = new GlobalConfiguration.Builder()
                .AuthManagers(new Dictionary<string, AuthManager> {
                    {"bearerAuth", bearerAuthManager},
                })
                .ApiCallback(httpCallback)
                .HttpConfiguration(httpClientConfiguration)
                .ServerUrls(EnvironmentsMap[environment], Server.Default)
                .UserAgent(userAgent)
                .Build();

            BearerAuthCredentials = bearerAuthManager;

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
            this.locales = new Lazy<LocalesController>(
                () => new LocalesController(globalConfiguration));
            this.mediaAssets = new Lazy<MediaAssetsController>(
                () => new MediaAssetsController(globalConfiguration));
            this.publishedStatus = new Lazy<PublishedStatusController>(
                () => new PublishedStatusController(globalConfiguration));
            this.muscles = new Lazy<MusclesController>(
                () => new MusclesController(globalConfiguration));
            this.musclesMuscleGroups = new Lazy<MusclesMuscleGroupsController>(
                () => new MusclesMuscleGroupsController(globalConfiguration));
            this.equipment = new Lazy<EquipmentController>(
                () => new EquipmentController(globalConfiguration));
            this.equipmentEquipmentGroups = new Lazy<EquipmentEquipmentGroupsController>(
                () => new EquipmentEquipmentGroupsController(globalConfiguration));
            this.exerciseMetrics = new Lazy<ExerciseMetricsController>(
                () => new ExerciseMetricsController(globalConfiguration));
            this.exerciseTypes = new Lazy<ExerciseTypesController>(
                () => new ExerciseTypesController(globalConfiguration));
            this.exerciseCategories = new Lazy<ExerciseCategoriesController>(
                () => new ExerciseCategoriesController(globalConfiguration));
            this.exercises = new Lazy<ExercisesController>(
                () => new ExercisesController(globalConfiguration));
            this.exercisesExerciseInstructions = new Lazy<ExercisesExerciseInstructionsController>(
                () => new ExercisesExerciseInstructionsController(globalConfiguration));
            this.exercisesExerciseVideos = new Lazy<ExercisesExerciseVideosController>(
                () => new ExercisesExerciseVideosController(globalConfiguration));
            this.exerciseDrafts = new Lazy<ExerciseDraftsController>(
                () => new ExerciseDraftsController(globalConfiguration));
            this.workouts = new Lazy<WorkoutsController>(
                () => new WorkoutsController(globalConfiguration));
            this.workoutsWorkoutData = new Lazy<WorkoutsWorkoutDataController>(
                () => new WorkoutsWorkoutDataController(globalConfiguration));
            this.programs = new Lazy<ProgramsController>(
                () => new ProgramsController(globalConfiguration));
            this.programsProgramWeeks = new Lazy<ProgramsProgramWeeksController>(
                () => new ProgramsProgramWeeksController(globalConfiguration));
            this.programsProgramAnalytics = new Lazy<ProgramsProgramAnalyticsController>(
                () => new ProgramsProgramAnalyticsController(globalConfiguration));
            this.programsProgramViews = new Lazy<ProgramsProgramViewsController>(
                () => new ProgramsProgramViewsController(globalConfiguration));
            this.programsProgramReviews = new Lazy<ProgramsProgramReviewsController>(
                () => new ProgramsProgramReviewsController(globalConfiguration));
            this.exercisesExerciseThumbnails = new Lazy<ExercisesExerciseThumbnailsController>(
                () => new ExercisesExerciseThumbnailsController(globalConfiguration));
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
        /// Gets LocalesController controller.
        /// </summary>
        public LocalesController LocalesController => this.locales.Value;

        /// <summary>
        /// Gets MediaAssetsController controller.
        /// </summary>
        public MediaAssetsController MediaAssetsController => this.mediaAssets.Value;

        /// <summary>
        /// Gets PublishedStatusController controller.
        /// </summary>
        public PublishedStatusController PublishedStatusController => this.publishedStatus.Value;

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
        /// Gets ExerciseMetricsController controller.
        /// </summary>
        public ExerciseMetricsController ExerciseMetricsController => this.exerciseMetrics.Value;

        /// <summary>
        /// Gets ExerciseTypesController controller.
        /// </summary>
        public ExerciseTypesController ExerciseTypesController => this.exerciseTypes.Value;

        /// <summary>
        /// Gets ExerciseCategoriesController controller.
        /// </summary>
        public ExerciseCategoriesController ExerciseCategoriesController => this.exerciseCategories.Value;

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
        /// Gets ExerciseDraftsController controller.
        /// </summary>
        public ExerciseDraftsController ExerciseDraftsController => this.exerciseDrafts.Value;

        /// <summary>
        /// Gets WorkoutsController controller.
        /// </summary>
        public WorkoutsController WorkoutsController => this.workouts.Value;

        /// <summary>
        /// Gets WorkoutsWorkoutDataController controller.
        /// </summary>
        public WorkoutsWorkoutDataController WorkoutsWorkoutDataController => this.workoutsWorkoutData.Value;

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
        /// Gets ProgramsProgramViewsController controller.
        /// </summary>
        public ProgramsProgramViewsController ProgramsProgramViewsController => this.programsProgramViews.Value;

        /// <summary>
        /// Gets ProgramsProgramReviewsController controller.
        /// </summary>
        public ProgramsProgramReviewsController ProgramsProgramReviewsController => this.programsProgramReviews.Value;

        /// <summary>
        /// Gets ExercisesExerciseThumbnailsController controller.
        /// </summary>
        public ExercisesExerciseThumbnailsController ExercisesExerciseThumbnailsController => this.exercisesExerciseThumbnails.Value;

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
            private Environment environment = JustGainsAPI.Standard.Environment.Testing;
            private BearerAuthModel bearerAuthModel = new BearerAuthModel();
            private HttpClientConfiguration.Builder httpClientConfig = new HttpClientConfiguration.Builder();
            private HttpCallback httpCallback;

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
                return new JustGainsAPIClient(
                    environment,
                    bearerAuthModel,
                    httpCallback,
                    httpClientConfig.Build());
            }
        }
    }
}

# Exercise Metrics

```csharp
ExerciseMetricsController exerciseMetricsController = client.ExerciseMetricsController;
```

## Class Name

`ExerciseMetricsController`

## Methods

* [Get Exercise Metrics](../../doc/controllers/exercise-metrics.md#get-exercise-metrics)
* [Create a New Exercise Metric](../../doc/controllers/exercise-metrics.md#create-a-new-exercise-metric)
* [Update an Exercise Metric](../../doc/controllers/exercise-metrics.md#update-an-exercise-metric)
* [Delete an Exercise Metric](../../doc/controllers/exercise-metrics.md#delete-an-exercise-metric)


# Get Exercise Metrics

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetExerciseMetricsAsync(
    string localeCode = "en-US")
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `localeCode` | `string` | Query, Optional | The locale for the metric names and measurement data |

## Response Type

[`Task<Models.ExerciseMetricListResponse>`](../../doc/models/exercise-metric-list-response.md)

## Example Usage

```csharp
string localeCode = "en-US";
try
{
    ExerciseMetricListResponse result = await exerciseMetricsController.GetExerciseMetricsAsync(localeCode);
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
| 400 | Bad request | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Create a New Exercise Metric

```csharp
CreateANewExerciseMetricAsync(
    Models.ExerciseMetric body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ExerciseMetric`](../../doc/models/exercise-metric.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
ExerciseMetric body = new ExerciseMetric
{
    ExerciseMetricCode = "WEIGHT",
};

try
{
    JustGainsBasicResponse result = await exerciseMetricsController.CreateANewExerciseMetricAsync(body);
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
| 400 | Bad request | [`ExerciseMetrics400Error2Exception`](../../doc/models/exercise-metrics-400-error-2-exception.md) |


# Update an Exercise Metric

```csharp
UpdateAnExerciseMetricAsync(
    string metricCode,
    Models.ExerciseMetric body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `metricCode` | `string` | Template, Required | - |
| `body` | [`ExerciseMetric`](../../doc/models/exercise-metric.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsResponse>`](../../doc/models/just-gains-response.md)

## Example Usage

```csharp
string metricCode = "metricCode4";
ExerciseMetric body = new ExerciseMetric
{
    ExerciseMetricCode = "WEIGHT",
};

try
{
    JustGainsResponse result = await exerciseMetricsController.UpdateAnExerciseMetricAsync(
        metricCode,
        body
    );
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
| 400 | Bad request | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Exercise metric not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Delete an Exercise Metric

```csharp
DeleteAnExerciseMetricAsync(
    string metricCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `metricCode` | `string` | Template, Required | - |

## Response Type

[`Task<Models.JustGainsResponse>`](../../doc/models/just-gains-response.md)

## Example Usage

```csharp
string metricCode = "metricCode4";
try
{
    JustGainsResponse result = await exerciseMetricsController.DeleteAnExerciseMetricAsync(metricCode);
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
| 404 | Exercise metric deleted successfully | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Common Published Status

```csharp
CommonPublishedStatusController commonPublishedStatusController = client.CommonPublishedStatusController;
```

## Class Name

`CommonPublishedStatusController`

## Methods

* [Get All Published Status](../../doc/controllers/common-published-status.md#get-all-published-status)
* [Create Update a Published Status](../../doc/controllers/common-published-status.md#create-update-a-published-status)
* [Delete a Published Status](../../doc/controllers/common-published-status.md#delete-a-published-status)


# Get All Published Status

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetAllPublishedStatusAsync()
```

## Response Type

[`Task<Models.PublishedStatusListResponse>`](../../doc/models/published-status-list-response.md)

## Example Usage

```csharp
try
{
    PublishedStatusListResponse result = await commonPublishedStatusController.GetAllPublishedStatusAsync();
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


# Create Update a Published Status

```csharp
CreateUpdateAPublishedStatusAsync(
    string publishedStatusCode,
    Models.PublishedStatus body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `publishedStatusCode` | `string` | Template, Required | **Constraints**: *Pattern*: `^[A-Z_]+$` |
| `body` | [`PublishedStatus`](../../doc/models/published-status.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
string publishedStatusCode = "publishedStatusCode2";
PublishedStatus body = new PublishedStatus
{
    UserRoleAccess = "ADMIN,USER",
};

try
{
    JustGainsBasicResponse result = await commonPublishedStatusController.CreateUpdateAPublishedStatusAsync(
        publishedStatusCode,
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
| 404 | Published status not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Delete a Published Status

```csharp
DeleteAPublishedStatusAsync(
    string publishedStatusCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `publishedStatusCode` | `string` | Template, Required | **Constraints**: *Pattern*: `^[A-Z_]+$` |

## Response Type

[`Task<Models.JustGainsResponse>`](../../doc/models/just-gains-response.md)

## Example Usage

```csharp
string publishedStatusCode = "publishedStatusCode2";
try
{
    JustGainsResponse result = await commonPublishedStatusController.DeleteAPublishedStatusAsync(publishedStatusCode);
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
| 404 | Published status not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Published Status

```csharp
PublishedStatusController publishedStatusController = client.PublishedStatusController;
```

## Class Name

`PublishedStatusController`

## Methods

* [Get All Published Status](../../doc/controllers/published-status.md#get-all-published-status)
* [Create a New Published Status](../../doc/controllers/published-status.md#create-a-new-published-status)
* [Update a Published Status](../../doc/controllers/published-status.md#update-a-published-status)
* [Delete a Published Status](../../doc/controllers/published-status.md#delete-a-published-status)
* [Get All Published Status Translations](../../doc/controllers/published-status.md#get-all-published-status-translations)
* [Update Published Status Translations](../../doc/controllers/published-status.md#update-published-status-translations)


# Get All Published Status

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetAllPublishedStatusAsync(
    string localeCode = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `localeCode` | `string` | Query, Optional | Locale code for translations (e.g., en-US) |

## Response Type

[`Task<Models.PublishedStatusListResponse>`](../../doc/models/published-status-list-response.md)

## Example Usage

```csharp
try
{
    PublishedStatusListResponse result = await publishedStatusController.GetAllPublishedStatusAsync();
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


# Create a New Published Status

```csharp
CreateANewPublishedStatusAsync(
    Models.PublishedStatus body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`PublishedStatus`](../../doc/models/published-status.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsResponse>`](../../doc/models/just-gains-response.md)

## Example Usage

```csharp
PublishedStatus body = new PublishedStatus
{
    PublishedStatusCode = "PUBLISHED",
    UserRoleAccess = "ADMIN,USER",
    PublishedStatusName = "Published",
};

try
{
    JustGainsResponse result = await publishedStatusController.CreateANewPublishedStatusAsync(body);
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


# Update a Published Status

```csharp
UpdateAPublishedStatusAsync(
    string publishedStatusCode,
    Models.PublishedStatus body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `publishedStatusCode` | `string` | Template, Required | - |
| `body` | [`PublishedStatus`](../../doc/models/published-status.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
string publishedStatusCode = "publishedStatusCode2";
PublishedStatus body = new PublishedStatus
{
    PublishedStatusCode = "PUBLISHED",
    UserRoleAccess = "ADMIN,USER",
    PublishedStatusName = "Published",
};

try
{
    JustGainsBasicResponse result = await publishedStatusController.UpdateAPublishedStatusAsync(
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
| `publishedStatusCode` | `string` | Template, Required | - |

## Response Type

[`Task<Models.JustGainsResponse>`](../../doc/models/just-gains-response.md)

## Example Usage

```csharp
string publishedStatusCode = "publishedStatusCode2";
try
{
    JustGainsResponse result = await publishedStatusController.DeleteAPublishedStatusAsync(publishedStatusCode);
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


# Get All Published Status Translations

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetAllPublishedStatusTranslationsAsync(
    string publishedStatusCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `publishedStatusCode` | `string` | Template, Required | The unique code of the published status |

## Response Type

[`Task<Models.PublishedStatusTranslationListResponse>`](../../doc/models/published-status-translation-list-response.md)

## Example Usage

```csharp
string publishedStatusCode = "publishedStatusCode2";
try
{
    PublishedStatusTranslationListResponse result = await publishedStatusController.GetAllPublishedStatusTranslationsAsync(publishedStatusCode);
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


# Update Published Status Translations

```csharp
UpdatePublishedStatusTranslationsAsync(
    string publishedStatusCode,
    List<Models.PublishedStatusTranslation> body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `publishedStatusCode` | `string` | Template, Required | The unique code of the published status |
| `body` | [`List<PublishedStatusTranslation>`](../../doc/models/published-status-translation.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
string publishedStatusCode = "publishedStatusCode2";
List<Models.PublishedStatusTranslation> body = new List<Models.PublishedStatusTranslation>
{
    new PublishedStatusTranslation
    {
        LocaleCode = "en-US",
        PublishedStatusName = "Published",
    },
};

try
{
    JustGainsBasicResponse result = await publishedStatusController.UpdatePublishedStatusTranslationsAsync(
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
| 401 | Unauthorized | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Published status not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 422 | Unprocessable Entity | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


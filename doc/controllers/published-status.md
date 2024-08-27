# Published Status

```csharp
PublishedStatusController publishedStatusController = client.PublishedStatusController;
```

## Class Name

`PublishedStatusController`

## Methods

* [Get All Published Status](../../doc/controllers/published-status.md#get-all-published-status)
* [Create a New Published Status](../../doc/controllers/published-status.md#create-a-new-published-status)
* [Get Published Status](../../doc/controllers/published-status.md#get-published-status)
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

[`Task<Models.PublishedStatusResponse>`](../../doc/models/published-status-response.md)

## Example Usage

```csharp
try
{
    PublishedStatusResponse result = await publishedStatusController.GetAllPublishedStatusAsync();
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
| 400 | Bad request | [`PublishedStatus400ErrorException`](../../doc/models/published-status-400-error-exception.md) |


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

[`Task<Models.PublishedStatusResponse1>`](../../doc/models/published-status-response-1.md)

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
    PublishedStatusResponse1 result = await publishedStatusController.CreateANewPublishedStatusAsync(body);
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
| 400 | Bad request | [`PublishedStatus400ErrorException`](../../doc/models/published-status-400-error-exception.md) |


# Get Published Status

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetPublishedStatusAsync(
    string publishedStatusCode,
    string localeCode = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `publishedStatusCode` | `string` | Template, Required | - |
| `localeCode` | `string` | Query, Optional | Locale code for translations (e.g., en-US) |

## Response Type

[`Task<Models.PublishedStatusResponse1>`](../../doc/models/published-status-response-1.md)

## Example Usage

```csharp
string publishedStatusCode = "publishedStatusCode2";
try
{
    PublishedStatusResponse1 result = await publishedStatusController.GetPublishedStatusAsync(publishedStatusCode);
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
| 404 | Published status not found | [`PublishedStatus404ErrorException`](../../doc/models/published-status-404-error-exception.md) |


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

[`Task<Models.PublishedStatusResponse1>`](../../doc/models/published-status-response-1.md)

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
    PublishedStatusResponse1 result = await publishedStatusController.UpdateAPublishedStatusAsync(
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
| 400 | Bad request | [`PublishedStatus400ErrorException`](../../doc/models/published-status-400-error-exception.md) |
| 404 | Published status not found | [`PublishedStatus404ErrorException`](../../doc/models/published-status-404-error-exception.md) |


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

[`Task<Models.PublishedStatusResponse4>`](../../doc/models/published-status-response-4.md)

## Example Usage

```csharp
string publishedStatusCode = "publishedStatusCode2";
try
{
    PublishedStatusResponse4 result = await publishedStatusController.DeleteAPublishedStatusAsync(publishedStatusCode);
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
| 404 | Published status not found | [`PublishedStatus404ErrorException`](../../doc/models/published-status-404-error-exception.md) |


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

[`Task<Models.PublishedStatusTranslationsResponse>`](../../doc/models/published-status-translations-response.md)

## Example Usage

```csharp
string publishedStatusCode = "publishedStatusCode2";
try
{
    PublishedStatusTranslationsResponse result = await publishedStatusController.GetAllPublishedStatusTranslationsAsync(publishedStatusCode);
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
| 400 | Bad request | [`PublishedStatusTranslations400ErrorException`](../../doc/models/published-status-translations-400-error-exception.md) |
| 404 | Published status not found | [`PublishedStatusTranslations404ErrorException`](../../doc/models/published-status-translations-404-error-exception.md) |


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

[`Task<Models.PublishedStatusTranslationsResponse1>`](../../doc/models/published-status-translations-response-1.md)

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
    PublishedStatusTranslationsResponse1 result = await publishedStatusController.UpdatePublishedStatusTranslationsAsync(
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
| 400 | Bad request | [`PublishedStatusTranslations400ErrorException`](../../doc/models/published-status-translations-400-error-exception.md) |
| 401 | Unauthorized | [`PublishedStatusTranslations401ErrorException`](../../doc/models/published-status-translations-401-error-exception.md) |
| 404 | Published status not found | [`PublishedStatusTranslations404ErrorException`](../../doc/models/published-status-translations-404-error-exception.md) |
| 422 | Unprocessable Entity | [`PublishedStatusTranslations422ErrorException`](../../doc/models/published-status-translations-422-error-exception.md) |


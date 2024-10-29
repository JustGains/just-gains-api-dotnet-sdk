# Common Media Assets

```csharp
CommonMediaAssetsController commonMediaAssetsController = client.CommonMediaAssetsController;
```

## Class Name

`CommonMediaAssetsController`

## Methods

* [Get Media Assets](../../doc/controllers/common-media-assets.md#get-media-assets)
* [Upload a New Media Asset](../../doc/controllers/common-media-assets.md#upload-a-new-media-asset)
* [Get Media Asset](../../doc/controllers/common-media-assets.md#get-media-asset)
* [Update a Media Asset](../../doc/controllers/common-media-assets.md#update-a-media-asset)
* [Delete a Media Asset](../../doc/controllers/common-media-assets.md#delete-a-media-asset)
* [Get Media Asset Detail](../../doc/controllers/common-media-assets.md#get-media-asset-detail)


# Get Media Assets

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetMediaAssetsAsync(
    int? page = 1,
    int? pageSize = 20)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | **Default**: `1` |
| `pageSize` | `int?` | Query, Optional | **Default**: `20` |

## Response Type

[`Task<Models.MediaAssetListResponse>`](../../doc/models/media-asset-list-response.md)

## Example Usage

```csharp
int? page = 1;
int? pageSize = 20;
try
{
    MediaAssetListResponse result = await commonMediaAssetsController.GetMediaAssetsAsync(
        page,
        pageSize
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Upload a New Media Asset

```csharp
UploadANewMediaAssetAsync(
    FileStreamInfo file = null,
    string mediaType = null,
    string description = null,
    string uploadDirectory = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `file` | `FileStreamInfo` | Form, Optional | - |
| `mediaType` | `string` | Form, Optional | **Constraints**: *Pattern*: `^[a-z]+/[a-z]+$` |
| `description` | `string` | Form, Optional | - |
| `uploadDirectory` | `string` | Form, Optional | Optional. Specify a custom upload directory. |

## Response Type

[`Task<Models.MediaAssetResponse>`](../../doc/models/media-asset-response.md)

## Example Usage

```csharp
string mediaType = "image/jpeg";
try
{
    MediaAssetResponse result = await commonMediaAssetsController.UploadANewMediaAssetAsync(
        null,
        mediaType
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Media Asset

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetMediaAssetAsync(
    Guid mediaAssetId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mediaAssetId` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.MediaAssetResponse>`](../../doc/models/media-asset-response.md)

## Example Usage

```csharp
Guid mediaAssetId = new Guid("9fdd12f5-c7b9-82a8-f6cc-cceac14c13c1");
try
{
    MediaAssetResponse result = await commonMediaAssetsController.GetMediaAssetAsync(mediaAssetId);
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
| 404 | Media asset not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Update a Media Asset

```csharp
UpdateAMediaAssetAsync(
    Guid mediaAssetId,
    Models.MediaAsset body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mediaAssetId` | `Guid` | Template, Required | - |
| `body` | [`MediaAsset`](../../doc/models/media-asset.md) | Body, Required | - |

## Response Type

[`Task<Models.MediaAssetResponse>`](../../doc/models/media-asset-response.md)

## Example Usage

```csharp
Guid mediaAssetId = new Guid("9fdd12f5-c7b9-82a8-f6cc-cceac14c13c1");
MediaAsset body = new MediaAsset
{
    MediaId = new Guid("7b8e9f2a-c1d3-45e6-a7b8-9c0d1e2f3a4b"),
    FileName = null,
    FilePath = null,
    FileSize = 0,
};

try
{
    MediaAssetResponse result = await commonMediaAssetsController.UpdateAMediaAssetAsync(
        mediaAssetId,
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
| 404 | Media asset not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Delete a Media Asset

```csharp
DeleteAMediaAssetAsync(
    Guid mediaAssetId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mediaAssetId` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
Guid mediaAssetId = new Guid("9fdd12f5-c7b9-82a8-f6cc-cceac14c13c1");
try
{
    JustGainsBasicResponse result = await commonMediaAssetsController.DeleteAMediaAssetAsync(mediaAssetId);
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
| 404 | Media asset not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Get Media Asset Detail

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetMediaAssetDetailAsync(
    Guid mediaAssetId,
    string fileName)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `mediaAssetId` | `Guid` | Template, Required | - |
| `fileName` | `string` | Template, Required | - |

## Response Type

`Task<Stream>`

## Example Usage

```csharp
Guid mediaAssetId = new Guid("9fdd12f5-c7b9-82a8-f6cc-cceac14c13c1");
string fileName = "fileName4";
try
{
    Stream result = await commonMediaAssetsController.GetMediaAssetDetailAsync(
        mediaAssetId,
        fileName
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
| 404 | Media asset not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


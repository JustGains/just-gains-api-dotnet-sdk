# Media Assets

```csharp
MediaAssetsController mediaAssetsController = client.MediaAssetsController;
```

## Class Name

`MediaAssetsController`

## Methods

* [Get Media Assets](../../doc/controllers/media-assets.md#get-media-assets)
* [Upload a New Media Asset](../../doc/controllers/media-assets.md#upload-a-new-media-asset)
* [Get Media Asset](../../doc/controllers/media-assets.md#get-media-asset)
* [Update a Media Asset](../../doc/controllers/media-assets.md#update-a-media-asset)
* [Delete a Media Asset](../../doc/controllers/media-assets.md#delete-a-media-asset)
* [Get Media Asset Detail](../../doc/controllers/media-assets.md#get-media-asset-detail)


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
| `page` | `int?` | Query, Optional | - |
| `pageSize` | `int?` | Query, Optional | - |

## Response Type

[`Task<Models.MediaAssetsResponse>`](../../doc/models/media-assets-response.md)

## Example Usage

```csharp
int? page = 1;
int? pageSize = 20;
try
{
    MediaAssetsResponse result = await mediaAssetsController.GetMediaAssetsAsync(
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
| `mediaType` | `string` | Form, Optional | - |
| `description` | `string` | Form, Optional | - |
| `uploadDirectory` | `string` | Form, Optional | Optional. Specify a custom upload directory. |

## Response Type

[`Task<Models.MediaAssetsResponse1>`](../../doc/models/media-assets-response-1.md)

## Example Usage

```csharp
string mediaType = "image/jpeg";
try
{
    MediaAssetsResponse1 result = await mediaAssetsController.UploadANewMediaAssetAsync(
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

[`Task<Models.MediaAssetsResponse1>`](../../doc/models/media-assets-response-1.md)

## Example Usage

```csharp
Guid mediaAssetId = new Guid("9fdd12f5-c7b9-82a8-f6cc-cceac14c13c1");
try
{
    MediaAssetsResponse1 result = await mediaAssetsController.GetMediaAssetAsync(mediaAssetId);
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
| 404 | Media asset not found | [`MediaAssets404ErrorException`](../../doc/models/media-assets-404-error-exception.md) |


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

[`Task<Models.MediaAssetsResponse1>`](../../doc/models/media-assets-response-1.md)

## Example Usage

```csharp
Guid mediaAssetId = new Guid("9fdd12f5-c7b9-82a8-f6cc-cceac14c13c1");
MediaAsset body = new MediaAsset
{
    MediaId = new Guid("7b8e9f2a-c1d3-45e6-a7b8-9c0d1e2f3a4b"),
    FileName = "workout_routine.mp4",
    FilePath = "media/videos/routines/workout_routine.mp4",
    FileSize = 15728640,
    FileFormat = "video/mp4",
    FileUrl = "https://api.justsuperhuman.com/media/videos/routines/workout_routine.mp4",
    Description = "High-intensity interval training (HIIT) workout routine for beginners",
};

try
{
    MediaAssetsResponse1 result = await mediaAssetsController.UpdateAMediaAssetAsync(
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
| 404 | Media asset not found | [`MediaAssets404ErrorException`](../../doc/models/media-assets-404-error-exception.md) |


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

[`Task<Models.MediaAssetsResponse4>`](../../doc/models/media-assets-response-4.md)

## Example Usage

```csharp
Guid mediaAssetId = new Guid("9fdd12f5-c7b9-82a8-f6cc-cceac14c13c1");
try
{
    MediaAssetsResponse4 result = await mediaAssetsController.DeleteAMediaAssetAsync(mediaAssetId);
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
| 404 | Media asset not found | [`MediaAssets404ErrorException`](../../doc/models/media-assets-404-error-exception.md) |


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
    Stream result = await mediaAssetsController.GetMediaAssetDetailAsync(
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
| 404 | Media asset not found | [`MediaAssets404ErrorException`](../../doc/models/media-assets-404-error-exception.md) |



# Media Asset Response

## Structure

`MediaAssetResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`MediaAsset`](../../doc/models/media-asset.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "mediaId": "7b8e9f2a-c1d3-45e6-a7b8-9c0d1e2f3a4b",
    "fileName": "workout_routine.mp4",
    "filePath": "media/videos/routines/workout_routine.mp4",
    "fileUrl": "https://api.justsuperhuman.com/media/videos/routines/workout_routine.mp4",
    "fileSize": 15728640,
    "fileFormat": "video/mp4",
    "description": "High-intensity interval training (HIIT) workout routine for beginners"
  }
}
```


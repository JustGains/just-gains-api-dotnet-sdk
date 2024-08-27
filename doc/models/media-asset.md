
# Media Asset

## Structure

`MediaAsset`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MediaId` | `Guid` | Required | Unique identifier for the media element. |
| `FileName` | `string` | Required | The name of the file, which may be useful for generating URLs or simple validations. |
| `FilePath` | `string` | Required | The relative path to the file within the storage system, useful for constructing URLs. |
| `FileUrl` | `string` | Optional | The URL to the media file, which may be useful for embedding or downloading. |
| `FileSize` | `int` | Required | File size in bytes |
| `FileFormat` | `string` | Required | File format, extension |
| `Description` | `string` | Optional | Description of the media element |

## Example (as JSON)

```json
{
  "mediaId": "7b8e9f2a-c1d3-45e6-a7b8-9c0d1e2f3a4b",
  "fileName": "workout_routine.mp4",
  "filePath": "media/videos/routines/workout_routine.mp4",
  "fileUrl": "https://api.justsuperhuman.com/media/videos/routines/workout_routine.mp4",
  "fileSize": 15728640,
  "fileFormat": "video/mp4",
  "description": "High-intensity interval training (HIIT) workout routine for beginners"
}
```



# Media Assets Response

## Structure

`MediaAssetsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`List<MediaAsset>`](../../doc/models/media-asset.md) | Optional | - |
| `Pagination` | [`Pagination`](../../doc/models/pagination.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Media assets retrieved successfully",
  "data": [
    {
      "mediaId": "00001930-0000-0000-0000-000000000000",
      "fileName": "fileName4",
      "filePath": "filePath0",
      "fileUrl": "fileUrl4",
      "fileSize": 148,
      "fileFormat": "fileFormat6",
      "description": "description0"
    },
    {
      "mediaId": "00001930-0000-0000-0000-000000000000",
      "fileName": "fileName4",
      "filePath": "filePath0",
      "fileUrl": "fileUrl4",
      "fileSize": 148,
      "fileFormat": "fileFormat6",
      "description": "description0"
    },
    {
      "mediaId": "00001930-0000-0000-0000-000000000000",
      "fileName": "fileName4",
      "filePath": "filePath0",
      "fileUrl": "fileUrl4",
      "fileSize": 148,
      "fileFormat": "fileFormat6",
      "description": "description0"
    }
  ],
  "pagination": {
    "currentPage": 166,
    "totalPages": 154,
    "pageSize": 134,
    "totalCount": 250,
    "hasPrevious": false
  }
}
```


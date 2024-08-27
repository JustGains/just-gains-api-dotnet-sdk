
# Programs Response

## Structure

`ProgramsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`List<Program>`](../../doc/models/program.md) | Optional | - |
| `Pagination` | [`Pagination`](../../doc/models/pagination.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Programs retrieved successfully",
  "data": [
    {
      "programId": 152,
      "userId": "000018a6-0000-0000-0000-000000000000",
      "programName": "programName6",
      "programDescription": "programDescription0",
      "programThumbnail": {
        "mediaId": "00001cb0-0000-0000-0000-000000000000",
        "fileName": "fileName0",
        "filePath": "filePath4",
        "fileUrl": "fileUrl0",
        "fileSize": 20,
        "fileFormat": "fileFormat2",
        "description": "description6"
      },
      "publishStatusCode": "publishStatusCode0",
      "createdAt": "2016-03-13T12:52:32.123Z",
      "updatedAt": "2016-03-13T12:52:32.123Z",
      "deletedAt": "2016-03-13T12:52:32.123Z",
      "deletedBy": "000018ae-0000-0000-0000-000000000000"
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


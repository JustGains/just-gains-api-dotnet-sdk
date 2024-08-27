
# Programs Weeks Response

## Structure

`ProgramsWeeksResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`List<Week>`](../../doc/models/week.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Program weeks retrieved successfully",
  "data": [
    {
      "weekId": 210,
      "userId": "000018a6-0000-0000-0000-000000000000",
      "weekTitle": "weekTitle8",
      "weekContent": "weekContent2",
      "weekThumbnail": {
        "mediaId": "0000005c-0000-0000-0000-000000000000",
        "fileName": "fileName8",
        "filePath": "filePath6",
        "fileUrl": "fileUrl8",
        "fileSize": 192,
        "fileFormat": "fileFormat0",
        "description": "description4"
      },
      "createdAt": "2016-03-13T12:52:32.123Z",
      "updatedAt": "2016-03-13T12:52:32.123Z",
      "deletedAt": "2016-03-13T12:52:32.123Z",
      "deletedBy": "000018ae-0000-0000-0000-000000000000"
    }
  ]
}
```


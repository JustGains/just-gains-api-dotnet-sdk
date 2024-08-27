
# Programs Weeks Response 1

## Structure

`ProgramsWeeksResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`Data71`](../../doc/models/data-71.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "Created",
  "message": "Week added successfully",
  "data": {
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
    }
  }
}
```


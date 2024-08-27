
# Programs Views Response

## Structure

`ProgramsViewsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`Data73`](../../doc/models/data-73.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "Created",
  "message": "View recorded successfully",
  "data": {
    "programViewId": 106,
    "programId": 152,
    "userId": "000018a6-0000-0000-0000-000000000000",
    "sessionId": "sessionId8",
    "viewedAt": "2016-03-13T12:52:32.123Z"
  }
}
```


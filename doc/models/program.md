
# Program

Represents a training program consisting of multiple weeks and workouts.

## Structure

`Program`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ProgramId` | `int` | Required | Unique identifier for the program. |
| `UserId` | `Guid` | Required | Identifier of the user who created the program. |
| `ProgramName` | `string` | Required | Name of the training program. |
| `ProgramDescription` | `string` | Required | Detailed description of the program, its goals, and target audience. |
| `ProgramThumbnail` | [`ProgramThumbnail`](../../doc/models/program-thumbnail.md) | Optional | Thumbnail image representing the program. |
| `PublishStatusCode` | `string` | Required | Code indicating the publish status of the program (e.g., draft, published, archived). |
| `CreatedAt` | `DateTime` | Required | Timestamp of when the program was created. |
| `UpdatedAt` | `DateTime` | Required | Timestamp of when the program was last updated. |
| `DeletedAt` | `DateTime?` | Optional | Timestamp of when the program was soft deleted, if applicable. |
| `DeletedBy` | `Guid?` | Optional | Identifier of the user who deleted the program, if applicable. |

## Example (as JSON)

```json
{
  "programId": 1001,
  "userId": "123e4567-e89b-12d3-a456-426614174000",
  "programName": "12-Week Strength Builder",
  "programDescription": "A comprehensive strength training program designed for intermediate lifters looking to increase their overall strength in major compound lifts.",
  "publishStatusCode": "PUBLISHED",
  "createdAt": "07/01/2023 09:00:00",
  "updatedAt": "07/15/2023 14:30:00",
  "deletedAt": "08/01/2023 10:00:00",
  "deletedBy": "987e6543-e21b-12d3-a456-426614174000",
  "programThumbnail": {
    "mediaId": "00001cb0-0000-0000-0000-000000000000",
    "fileName": "fileName0",
    "filePath": "filePath4",
    "fileUrl": "fileUrl0",
    "fileSize": 20,
    "fileFormat": "fileFormat2",
    "description": "description6"
  }
}
```


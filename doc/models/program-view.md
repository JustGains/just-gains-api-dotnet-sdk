
# Program View

Represents a single view or interaction with a program.

## Structure

`ProgramView`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ProgramViewId` | `int` | Required | Unique identifier for this program view. |
| `ProgramId` | `int` | Required | Identifier of the viewed program. |
| `UserId` | `Guid?` | Optional | Identifier of the user who viewed the program, if authenticated. |
| `SessionId` | `string` | Required | Unique identifier for the user's session. |
| `ViewedAt` | `DateTime` | Required | Timestamp of when the program was viewed. |
| `ViewDuration` | `int` | Required | Duration of the view in seconds. |
| `IpAddress` | `string` | Required | IP address of the viewer. |
| `UserAgent` | `string` | Required | User agent string of the viewer's browser. |
| `IsAuthenticated` | `bool` | Required | Indicates whether the viewer was authenticated during this view. |

## Example (as JSON)

```json
{
  "programViewId": 10001,
  "programId": 1001,
  "userId": "123e4567-e89b-12d3-a456-426614174000",
  "sessionId": "sess_abc123def456",
  "viewedAt": "07/25/2023 15:30:00",
  "viewDuration": 300,
  "ipAddress": "192.168.1.1",
  "userAgent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/91.0.4472.124 Safari/537.36",
  "isAuthenticated": true
}
```


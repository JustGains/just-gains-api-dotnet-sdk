
# Published Status

## Structure

`PublishedStatus`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PublishedStatusCode` | `string` | Optional | The unique code for the published status |
| `UserRoleAccess` | `string` | Optional | Comma-separated list of user roles that have access |
| `PublishedStatusName` | `string` | Optional | The name of the published status |

## Example (as JSON)

```json
{
  "publishedStatusCode": "PUBLISHED",
  "userRoleAccess": "ADMIN,USER",
  "publishedStatusName": "Published"
}
```


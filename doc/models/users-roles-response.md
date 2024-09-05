
# Users Roles Response

## Structure

`UsersRolesResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | `List<string>` | Required | The data returned by the operation. |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": [
    "admin",
    "user"
  ]
}
```


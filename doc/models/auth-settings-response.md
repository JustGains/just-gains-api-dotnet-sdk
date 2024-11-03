
# Auth Settings Response

## Structure

`AuthSettingsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`OAuthSettingsData`](../../doc/models/o-auth-settings-data.md) | Required | Data object containing OAuth provider settings |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "clientId": "clientId4",
    "authorizeUrl": "authorizeUrl6",
    "tokenUrl": "tokenUrl0",
    "scopes": [
      "scopes6",
      "scopes5"
    ]
  }
}
```


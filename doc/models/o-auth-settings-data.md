
# O Auth Settings Data

Data object containing OAuth provider settings

## Structure

`OAuthSettingsData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ClientId` | `string` | Required | The OAuth client ID |
| `AuthorizeUrl` | `string` | Required | The authorization endpoint URL |
| `TokenUrl` | `string` | Required | The token endpoint URL |
| `Scopes` | `List<string>` | Required | Available OAuth scopes |

## Example (as JSON)

```json
{
  "clientId": "clientId2",
  "authorizeUrl": "authorizeUrl4",
  "tokenUrl": "tokenUrl8",
  "scopes": [
    "scopes4",
    "scopes5",
    "scopes6"
  ]
}
```


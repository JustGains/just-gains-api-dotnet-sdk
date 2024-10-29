
# Data 2

## Structure

`Data2`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uri` | `string` | Optional | The authorization URL to redirect the user to |
| `PkceVerifier` | `string` | Optional | The PKCE verifier code for the OAuth flow |

## Example (as JSON)

```json
{
  "uri": "https://oauth-provider.com/auth?client_id=123&redirect_uri=...",
  "pkceVerifier": "dBjftJeZ4CVP-mB92K27uhbUJU1p1r_wW1gFWFOEjXk"
}
```


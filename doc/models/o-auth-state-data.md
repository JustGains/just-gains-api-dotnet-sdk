
# O Auth State Data

Data object containing OAuth state information

## Structure

`OAuthStateData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Uri` | `string` | Required | The authorization URL to redirect the user to |
| `PkceVerifier` | `string` | Required | The PKCE verifier code for the OAuth flow |

## Example (as JSON)

```json
{
  "uri": "https://oauth-provider.com/auth?client_id=123&redirect_uri=...",
  "pkceVerifier": "dBjftJeZ4CVP-mB92K27uhbUJU1p1r_wW1gFWFOEjXk"
}
```



# O Auth State Response

Response object for OAuth state

## Structure

`OAuthStateResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Data` | [`OAuthStateData`](../../doc/models/o-auth-state-data.md) | Optional | Data object containing OAuth state information |

## Example (as JSON)

```json
{
  "data": {
    "uri": "uri4",
    "pkceVerifier": "pkceVerifier2"
  }
}
```


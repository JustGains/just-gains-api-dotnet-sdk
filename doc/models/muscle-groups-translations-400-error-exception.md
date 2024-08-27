
# Muscle Groups Translations 400 Error Exception

## Structure

`MuscleGroupsTranslations400ErrorException`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Errors` | `List<string>` | Optional | - |

## Example (as JSON)

```json
{
  "status": "Bad Request",
  "message": "Failed to retrieve muscle group translations",
  "errors": [
    "Invalid muscle group code"
  ]
}
```


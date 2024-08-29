
# Muscle Translation List Response

## Structure

`MuscleTranslationListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`List<MuscleTranslation>`](../../doc/models/muscle-translation.md) | Required | The data returned by the operation. |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": [
    {
      "muscleCode": "QUAD",
      "localeCode": "en-US",
      "muscleName": "Quadriceps"
    }
  ]
}
```


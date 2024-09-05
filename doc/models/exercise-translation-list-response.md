
# Exercise Translation List Response

## Structure

`ExerciseTranslationListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`List<ExerciseTranslation>`](../../doc/models/exercise-translation.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": [
    {
      "localeCode": "en-US",
      "exerciseName": "exerciseName2",
      "isPrimary": false
    }
  ]
}
```



# Muscle Group Translation List Response

## Structure

`MuscleGroupTranslationListResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`List<MuscleGroupTranslation>`](../../doc/models/muscle-group-translation.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": [
    {
      "localeCode": "en-US",
      "muscleGroupName": "Quadriceps",
      "muscleGroupDescription": "The quadriceps femoris is a large muscle group located on the front of the thigh."
    }
  ]
}
```


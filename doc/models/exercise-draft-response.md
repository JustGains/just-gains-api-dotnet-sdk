
# Exercise Draft Response

## Structure

`ExerciseDraftResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`ExerciseDraftDTO`](../../doc/models/exercise-draft-dto.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Exercise updated successfully",
  "data": {
    "id": 138,
    "file_name": "file_name2",
    "exercise_code": "exercise_code0",
    "exercise_name": "exercise_name2",
    "alternate_names": [
      "alternate_names7",
      "alternate_names8"
    ]
  }
}
```



# Muscle Group Dto Response

## Structure

`MuscleGroupDtoResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`MuscleGroupDto`](../../doc/models/muscle-group-dto.md) | Required | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "muscleGroupCode": "CHEST",
    "muscleGroupName": "Chest"
  }
}
```



# Exercises Muscle Groups Response

## Structure

`ExercisesMuscleGroupsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`List<MuscleGroupDto>`](../../doc/models/muscle-group-dto.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Muscle groups retrieved successfully",
  "data": [
    {
      "muscleGroupCode": "muscleGroupCode2",
      "muscleGroupName": "muscleGroupName4"
    },
    {
      "muscleGroupCode": "muscleGroupCode2",
      "muscleGroupName": "muscleGroupName4"
    }
  ]
}
```


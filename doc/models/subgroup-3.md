
# Subgroup 3

## Structure

`Subgroup3`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MuscleGroupCode` | `string` | Optional | The unique code of the muscle subgroup |
| `MuscleGroupName` | `string` | Optional | The localized name of the muscle subgroup |
| `MuscleGroupType` | [`MuscleGroupTypeEnum?`](../../doc/models/muscle-group-type-enum.md) | Optional | - |
| `MuscleGroupParent` | `string` | Optional | The code of the parent muscle group |
| `Subgroups` | [`List<Subgroup4>`](../../doc/models/subgroup-4.md) | Optional | - |

## Example (as JSON)

```json
{
  "muscleGroupCode": "UPPER_PECTORALS",
  "muscleGroupName": "Upper Pectorals",
  "muscleGroupType": "exercise_group",
  "muscleGroupParent": "CHEST",
  "subgroups": [
    {
      "muscleGroupCode": "muscleGroupCode0",
      "muscleGroupName": "muscleGroupName6",
      "muscleGroupType": "main_group"
    },
    {
      "muscleGroupCode": "muscleGroupCode0",
      "muscleGroupName": "muscleGroupName6",
      "muscleGroupType": "main_group"
    },
    {
      "muscleGroupCode": "muscleGroupCode0",
      "muscleGroupName": "muscleGroupName6",
      "muscleGroupType": "main_group"
    }
  ]
}
```


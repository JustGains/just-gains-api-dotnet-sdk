
# Muscle Group

## Structure

`MuscleGroup`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MuscleGroupCode` | `string` | Optional | Unique identifier for the muscle group. |
| `MuscleGroupName` | `string` | Optional | Name of the muscle group, localized. |
| `MuscleGroupParent` | `string` | Optional | parent group CODE for hierarchical structuring. |
| `MuscleGroupMuscles` | `List<string>` | Optional | An array of muscle codes associated with this muscle group.<br>Each muscle code represents a specific muscle or muscle group targeted in exercises.<br>The codes are used to identify muscles across different languages and provide<br>consistency in muscle targeting for various exercises. |
| `MuscleGroupType` | [`MuscleGroupTypeEnum?`](../../doc/models/muscle-group-type-enum.md) | Optional | - |
| `MuscleGroupThumbnail` | [`MediaAsset`](../../doc/models/media-asset.md) | Optional | - |

## Example (as JSON)

```json
{
  "muscleGroupCode": "CHEST",
  "muscleGroupName": "Chest",
  "muscleGroupParent": "UPPER_BODY",
  "muscleGroupMuscles": [
    "PECTORALIS_MAJOR_STERNAL_HEAD",
    "ANTERIOR_DELTOID",
    "TRICEPS_BRACHII",
    "RECTUS_ABDOMINIS",
    "LATISSIMUS_DORSI",
    "BICEPS_BRACHII",
    "QUADRICEPS_FEMORIS",
    "HAMSTRINGS",
    "GASTROCNEMIUS"
  ],
  "muscleGroupType": "main_group"
}
```


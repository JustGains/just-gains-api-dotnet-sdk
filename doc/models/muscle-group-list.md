
# Muscle Group List

## Structure

`MuscleGroupList`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MuscleGroupCode` | `string` | Optional | The unique code of the muscle group |
| `MuscleGroupName` | `string` | Optional | The localized name of the muscle group |
| `MuscleGroupType` | [`MuscleGroupTypeEnum?`](../../doc/models/muscle-group-type-enum.md) | Optional | - |
| `MuscleGroupParent` | `string` | Optional | The code of the muscle group that is the parent of this group |
| `Subgroups` | [`List<Subgroup1>`](../../doc/models/subgroup-1.md) | Optional | - |
| `MuscleGroupMuscles` | `List<string>` | Optional | An array of muscle codes associated with this muscle group.<br>Each muscle code represents a specific muscle or muscle group targeted in exercises.<br>The codes are used to identify muscles across different languages and provide<br>consistency in muscle targeting for various exercises. |
| `MuscleGroupThumbnail` | [`MediaAsset`](../../doc/models/media-asset.md) | Optional | - |

## Example (as JSON)

```json
{
  "muscleGroupCode": "CHEST",
  "muscleGroupName": "Chest",
  "muscleGroupType": "sub_group",
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
  "subgroups": [
    {
      "muscleGroupCode": "muscleGroupCode0",
      "muscleGroupName": "muscleGroupName6",
      "muscleGroupType": "sub_group",
      "muscleGroupParent": "muscleGroupParent2",
      "subgroups": [
        {
          "muscleGroupCode": "muscleGroupCode0",
          "muscleGroupName": "muscleGroupName6",
          "muscleGroupType": "sub_group",
          "muscleGroupParent": "muscleGroupParent2",
          "subgroups": [
            {
              "muscleGroupCode": "muscleGroupCode0",
              "muscleGroupName": "muscleGroupName6",
              "muscleGroupType": "sub_group",
              "muscleGroupParent": "muscleGroupParent2",
              "subgroups": [
                {
                  "muscleGroupCode": "muscleGroupCode0",
                  "muscleGroupName": "muscleGroupName6",
                  "muscleGroupType": "main_group"
                }
              ]
            }
          ]
        }
      ]
    }
  ]
}
```


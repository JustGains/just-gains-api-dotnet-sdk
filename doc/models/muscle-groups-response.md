
# Muscle Groups Response

## Structure

`MuscleGroupsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`List<MuscleGroupList>`](../../doc/models/muscle-group-list.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Muscle groups retrieved successfully",
  "data": [
    {
      "muscleGroupCode": "muscleGroupCode2",
      "muscleGroupName": "muscleGroupName4",
      "muscleGroupType": "exercise_group",
      "muscleGroupParent": "muscleGroupParent0",
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
        },
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
    },
    {
      "muscleGroupCode": "muscleGroupCode2",
      "muscleGroupName": "muscleGroupName4",
      "muscleGroupType": "exercise_group",
      "muscleGroupParent": "muscleGroupParent0",
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
        },
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
    },
    {
      "muscleGroupCode": "muscleGroupCode2",
      "muscleGroupName": "muscleGroupName4",
      "muscleGroupType": "exercise_group",
      "muscleGroupParent": "muscleGroupParent0",
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
        },
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
  ]
}
```


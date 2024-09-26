
# Exercise Equipment

## Structure

`ExerciseEquipment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Required` | `List<List<string>>` | Optional | Array of equipment code arrays that are required for this exercise |
| `Optional` | `List<List<string>>` | Optional | Array of equipment code arrays that are optional for this exercise |

## Example (as JSON)

```json
{
  "required": [
    [
      "BARBELL",
      "WEIGHT_PLATES"
    ],
    [
      "DUMBBELLS"
    ]
  ],
  "optional": [
    [
      "WEIGHT_BELT",
      "WRIST_WRAPS"
    ],
    [
      "RESISTANCE_BANDS"
    ]
  ]
}
```


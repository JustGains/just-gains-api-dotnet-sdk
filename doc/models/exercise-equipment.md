
# Exercise Equipment

## Structure

`ExerciseEquipment`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Required` | `List<string>` | Optional | Array of equipment codes that are required for this exercise |
| `Optional` | `List<string>` | Optional | Array of equipment codes that are optional for this exercise |

## Example (as JSON)

```json
{
  "required": [
    "BARBELL",
    "BENCH",
    "WEIGHT_PLATES"
  ],
  "optional": [
    "WEIGHT_BELT",
    "WRIST_WRAPS"
  ]
}
```


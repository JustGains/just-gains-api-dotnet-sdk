
# Target Muscle DTO

## Structure

`TargetMuscleDTO`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `MuscleName` | `string` | Optional | - |
| `TargetPercentage` | `int?` | Optional | **Constraints**: `>= 0`, `<= 100` |

## Example (as JSON)

```json
{
  "id": 244,
  "muscle_name": "muscle_name4",
  "target_percentage": 80
}
```


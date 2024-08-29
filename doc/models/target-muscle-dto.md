
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
  "muscle_name": "BICEP",
  "id": 244,
  "target_percentage": 80
}
```


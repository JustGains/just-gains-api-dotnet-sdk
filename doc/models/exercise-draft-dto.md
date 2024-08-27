
# Exercise Draft DTO

## Structure

`ExerciseDraftDTO`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Id` | `int?` | Optional | - |
| `FileName` | `string` | Optional | - |
| `ExerciseCode` | `string` | Optional | - |
| `ExerciseName` | `string` | Optional | - |
| `AlternateNames` | `List<string>` | Optional | - |
| `PublishStatus` | [`PublishStatusEnum?`](../../doc/models/publish-status-enum.md) | Optional | - |
| `Models` | [`List<ExerciseModelDTO>`](../../doc/models/exercise-model-dto.md) | Optional | - |
| `ExerciseType` | `List<string>` | Optional | - |
| `ExerciseMetrics` | `List<string>` | Optional | - |
| `ExerciseDifficulty` | `int?` | Optional | **Constraints**: `>= 1`, `<= 5` |
| `MetabolicEquivalent` | `double?` | Optional | - |
| `EquipmentRequired` | [`EquipmentRequired`](../../doc/models/equipment-required.md) | Optional | - |
| `PrimaryMuscleGroups` | [`List<TargetMuscleDTO>`](../../doc/models/target-muscle-dto.md) | Optional | - |
| `SecondaryMuscleGroups` | [`List<TargetMuscleDTO>`](../../doc/models/target-muscle-dto.md) | Optional | - |
| `IsPlateloaded` | `bool?` | Optional | - |
| `IsCardio` | `bool?` | Optional | - |
| `OlympicRating` | `int?` | Optional | **Constraints**: `>= 0`, `<= 5` |
| `PowerlifterRating` | `int?` | Optional | **Constraints**: `>= 0`, `<= 5` |
| `CalisthenicRating` | `int?` | Optional | **Constraints**: `>= 0`, `<= 5` |
| `PopularityRating` | `int?` | Optional | **Constraints**: `>= 0`, `<= 5` |
| `ExerciseTechnicalComplexity` | `int?` | Optional | - |
| `IsPlyometric` | `bool?` | Optional | - |
| `IsIsometric` | `bool?` | Optional | - |
| `IsCalisthenic` | `bool?` | Optional | - |
| `IsWeighted` | `bool?` | Optional | - |
| `IsUnilateral` | `bool?` | Optional | - |
| `IsBodyweight` | `bool?` | Optional | - |
| `AiNotes` | `string` | Optional | - |
| `ExerciseInstructions` | [`ExerciseInstruction`](../../doc/models/exercise-instruction.md) | Optional | - |

## Example (as JSON)

```json
{
  "id": 236,
  "file_name": "file_name4",
  "exercise_code": "exercise_code6",
  "exercise_name": "exercise_name6",
  "alternate_names": [
    "alternate_names1"
  ]
}
```


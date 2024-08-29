
# Workout 1

The data returned by the operation.

## Structure

`Workout1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WorkoutId` | `int?` | Optional | Unique identifier for the workout. |
| `WorkoutTitle` | `string` | Optional | The title of the workout. |
| `UpdatedAt` | `DateTime?` | Optional | The date and time when the workout was last updated. |
| `LastUsedAt` | `DateTime?` | Optional | The date and time when the workout was last used. |
| `TotalUses` | `int?` | Optional | The number of times this workout has been used.<br>**Default**: `0` |
| `AverageRating` | `double?` | Optional | The average rating of the workout. |
| `CreatorCredits` | [`List<CreatorCredit>`](../../doc/models/creator-credit.md) | Optional | List of creator credits associated with this workout. |

## Example (as JSON)

```json
{
  "workoutId": 1234,
  "workoutTitle": "Full Body Strength Training",
  "updatedAt": "07/08/2023 14:30:00",
  "lastUsedAt": "07/07/2023 09:15:00",
  "totalUses": 15,
  "averageRating": 4.7
}
```


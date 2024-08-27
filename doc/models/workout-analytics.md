
# Workout Analytics

Analytics data for the workout.

## Structure

`WorkoutAnalytics`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Views` | `int?` | Optional | Number of views for the workout. |
| `TotalUses` | `int?` | Optional | The number of times this workout has been used.<br>**Default**: `0` |
| `AverageRating` | `double?` | Optional | The average rating of the workout. |

## Example (as JSON)

```json
{
  "views": 1000,
  "totalUses": 15,
  "averageRating": 4.7
}
```


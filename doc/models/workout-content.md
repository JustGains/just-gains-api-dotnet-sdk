
# Workout Content

## Structure

`WorkoutContent`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WorkoutID` | `Guid?` | Optional | The ID of the workout |
| `WorkoutContent` | `object` | Optional | The content of the workout (JSON formatted output from the JS Editor) |
| `UpdatedAt` | `DateTime?` | Optional | The date and time when the workout content was last updated. |

## Example (as JSON)

```json
{
  "workoutID": "9f897bfa-716d-4caa-b8fb-20bf3f2f3416",
  "updatedAt": "07/08/2023 14:30:00",
  "workoutContent": {
    "key1": "val1",
    "key2": "val2"
  }
}
```



# Exercises Instructions Response 1

## Structure

`ExercisesInstructionsResponse1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | - |
| `Message` | `string` | Required | - |
| `Data` | [`Data82`](../../doc/models/data-82.md) | Optional | - |

## Example (as JSON)

```json
{
  "status": "Created",
  "message": "Exercise instructions created successfully",
  "data": {
    "exerciseCode": "exerciseCode2",
    "userId": "userId0",
    "localeCode": "localeCode2",
    "instructionJSON": {
      "time": 156,
      "blocks": [
        {
          "id": "id6",
          "type": "paragraph",
          "data": {
            "text": "text0"
          }
        },
        {
          "id": "id6",
          "type": "paragraph",
          "data": {
            "text": "text0"
          }
        }
      ],
      "version": "version8"
    }
  }
}
```


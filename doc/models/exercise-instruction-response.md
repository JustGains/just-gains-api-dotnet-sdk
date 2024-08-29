
# Exercise Instruction Response

## Structure

`ExerciseInstructionResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Status` | `string` | Required | The status of the response, corresponding to standard HTTP status codes. |
| `Message` | `string` | Required | A human-readable message describing the result of the operation. |
| `Data` | [`ExerciseInstruction1`](../../doc/models/exercise-instruction-1.md) | Required | The data returned by the operation. |

## Example (as JSON)

```json
{
  "status": "OK",
  "message": "Operation completed successfully.",
  "data": {
    "exerciseCode": "BARBELL-BENCH-PRESS",
    "userId": "9fdd12f5-c7b9-82a8-f6cc-cceac14c13c1",
    "localeCode": "en-US",
    "instructionJSON": {
      "time": 1625832000000,
      "version": "2.24.3",
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
      ]
    }
  }
}
```


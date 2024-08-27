
# Data 82

## Structure

`Data82`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ExerciseCode` | `string` | Optional | The exerciseCode of the exercise to add instructions to. |
| `UserId` | `string` | Optional | The userId of the creator related to this instruction |
| `LocaleCode` | `string` | Optional | Language code for the instructions |
| `InstructionJSON` | [`InstructionJSON1`](../../doc/models/instruction-json1.md) | Optional | JSON object containing the exercise instructions in EditorJS format |

## Example (as JSON)

```json
{
  "exerciseCode": "BARBELL-BENCH-PRESS",
  "userId": "9fdd12f5-c7b9-82a8-f6cc-cceac14c13c1",
  "localeCode": "en-US",
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
```


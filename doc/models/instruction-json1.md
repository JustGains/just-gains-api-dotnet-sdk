
# Instruction JSON1

JSON object containing the exercise instructions in EditorJS format

## Structure

`InstructionJSON1`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Time` | `long?` | Optional | - |
| `Blocks` | [`List<InstructionBlock>`](../../doc/models/instruction-block.md) | Optional | - |
| `Version` | `string` | Optional | - |

## Example (as JSON)

```json
{
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
```


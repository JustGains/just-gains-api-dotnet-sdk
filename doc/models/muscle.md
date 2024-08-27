
# Muscle

## Structure

`Muscle`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MuscleCode` | `string` | Required | Unique identifier for the muscle |
| `MuscleName` | `string` | Optional | The name of the muscle in the default language (typically English) |
| `MuscleTranslations` | [`List<MuscleTranslation>`](../../doc/models/muscle-translation.md) | Optional | Array of translations for the muscle name in different languages. This is a write-only field used when creating or updating muscles. |

## Example (as JSON)

```json
{
  "muscleCode": "BICEPS_BRACHII",
  "muscleName": "Biceps Brachii",
  "muscleTranslations": [
    {
      "muscleCode": "muscleCode2",
      "localeCode": "localeCode4",
      "muscleName": "muscleName4"
    },
    {
      "muscleCode": "muscleCode2",
      "localeCode": "localeCode4",
      "muscleName": "muscleName4"
    }
  ]
}
```


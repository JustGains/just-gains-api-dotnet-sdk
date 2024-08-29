
# Pagination

## Structure

`Pagination`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CurrentPage` | `int?` | Optional | The current page number |
| `TotalPages` | `object` | Optional | The total number of pages |
| `PageSize` | `int?` | Optional | The number of items per page |
| `TotalCount` | `int?` | Optional | The total number of items across all pages |
| `HasPrevious` | `bool?` | Optional | Indicates if there is a previous page |
| `HasNext` | `bool?` | Optional | Indicates if there is a next page |

## Example (as JSON)

```json
{
  "currentPage": 1,
  "totalPages": {
    "key1": "val1",
    "key2": "val2"
  },
  "pageSize": 10,
  "totalCount": 75,
  "hasPrevious": false,
  "hasNext": true
}
```


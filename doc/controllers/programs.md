# Programs

Core program management functionality.

```csharp
ProgramsController programsController = client.ProgramsController;
```

## Class Name

`ProgramsController`

## Methods

* [Get Programs](../../doc/controllers/programs.md#get-programs)
* [Create Program](../../doc/controllers/programs.md#create-program)
* [Get Program](../../doc/controllers/programs.md#get-program)
* [Update Program](../../doc/controllers/programs.md#update-program)
* [Delete Program](../../doc/controllers/programs.md#delete-program)


# Get Programs

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetProgramsAsync(
    int? page = 1,
    int? pageSize = 20,
    string sortBy = null,
    Models.SortOrderEnum? sortOrder = Models.SortOrderEnum.Desc,
    string publishStatusCode = null,
    Guid? userId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `page` | `int?` | Query, Optional | **Default**: `1`<br>**Constraints**: `>= 1` |
| `pageSize` | `int?` | Query, Optional | **Default**: `20`<br>**Constraints**: `>= 1`, `<= 100` |
| `sortBy` | `string` | Query, Optional | - |
| `sortOrder` | [`SortOrderEnum?`](../../doc/models/sort-order-enum.md) | Query, Optional | **Default**: `SortOrderEnum.desc` |
| `publishStatusCode` | `string` | Query, Optional | - |
| `userId` | `Guid?` | Query, Optional | - |

## Response Type

[`Task<Models.ProgramListResponse>`](../../doc/models/program-list-response.md)

## Example Usage

```csharp
int? page = 1;
int? pageSize = 20;
SortOrderEnum? sortOrder = SortOrderEnum.Desc;
try
{
    ProgramListResponse result = await programsController.GetProgramsAsync(
        page,
        pageSize,
        null,
        sortOrder
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Create Program

```csharp
CreateProgramAsync(
    Models.Program body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Program`](../../doc/models/program.md) | Body, Required | - |

## Response Type

[`Task<Models.ProgramResponse>`](../../doc/models/program-response.md)

## Example Usage

```csharp
Program body = new Program
{
    ProgramId = 1001,
    UserId = new Guid("123e4567-e89b-12d3-a456-426614174000"),
    ProgramName = "12-Week Strength Builder",
    ProgramDescription = "A comprehensive strength training program designed for intermediate lifters looking to increase their overall strength in major compound lifts.",
    PublishStatusCode = "PUBLISHED",
    CreatedAt = DateTime.ParseExact("07/01/2023 09:00:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    UpdatedAt = DateTime.ParseExact("07/15/2023 14:30:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    DeletedAt = DateTime.ParseExact("08/01/2023 10:00:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    DeletedBy = new Guid("987e6543-e21b-12d3-a456-426614174000"),
};

try
{
    ProgramResponse result = await programsController.CreateProgramAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Get Program

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetProgramAsync(
    int programId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `programId` | `int` | Template, Required | - |

## Response Type

[`Task<Models.ProgramResponse>`](../../doc/models/program-response.md)

## Example Usage

```csharp
int programId = 126;
try
{
    ProgramResponse result = await programsController.GetProgramAsync(programId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Program not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Update Program

```csharp
UpdateProgramAsync(
    int programId,
    Models.Program body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `programId` | `int` | Template, Required | - |
| `body` | [`Program`](../../doc/models/program.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsResponse>`](../../doc/models/just-gains-response.md)

## Example Usage

```csharp
int programId = 126;
Program body = new Program
{
    ProgramId = 1001,
    UserId = new Guid("123e4567-e89b-12d3-a456-426614174000"),
    ProgramName = "12-Week Strength Builder",
    ProgramDescription = "A comprehensive strength training program designed for intermediate lifters looking to increase their overall strength in major compound lifts.",
    PublishStatusCode = "PUBLISHED",
    CreatedAt = DateTime.ParseExact("07/01/2023 09:00:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    UpdatedAt = DateTime.ParseExact("07/15/2023 14:30:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    DeletedAt = DateTime.ParseExact("08/01/2023 10:00:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    DeletedBy = new Guid("987e6543-e21b-12d3-a456-426614174000"),
};

try
{
    JustGainsResponse result = await programsController.UpdateProgramAsync(
        programId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad request | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |
| 404 | Program not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


# Delete Program

```csharp
DeleteProgramAsync(
    int programId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `programId` | `int` | Template, Required | - |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
int programId = 126;
try
{
    JustGainsBasicResponse result = await programsController.DeleteProgramAsync(programId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 404 | Program not found | [`JustGainsErrorResponseException`](../../doc/models/just-gains-error-response-exception.md) |


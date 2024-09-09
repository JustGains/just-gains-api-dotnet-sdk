# Programs Program Reviews

```csharp
ProgramsProgramReviewsController programsProgramReviewsController = client.ProgramsProgramReviewsController;
```

## Class Name

`ProgramsProgramReviewsController`

## Methods

* [Get Reviews Program](../../doc/controllers/programs-program-reviews.md#get-reviews-program)
* [Add Review Program](../../doc/controllers/programs-program-reviews.md#add-review-program)


# Get Reviews Program

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetReviewsProgramAsync(
    int programId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `programId` | `int` | Template, Required | - |

## Response Type

[`Task<Models.ProgramReviewResponse>`](../../doc/models/program-review-response.md)

## Example Usage

```csharp
int programId = 126;
try
{
    ProgramReviewResponse result = await programsProgramReviewsController.GetReviewsProgramAsync(programId);
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


# Add Review Program

```csharp
AddReviewProgramAsync(
    Models.ProgramReview body,
    int programId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`ProgramReview`](../../doc/models/program-review.md) | Body, Required | - |
| `programId` | `int` | Template, Required | - |

## Response Type

[`Task<Models.ProgramReviewResponse>`](../../doc/models/program-review-response.md)

## Example Usage

```csharp
ProgramReview body = new ProgramReview
{
    ReviewId = 20001,
    ProgramId = 1001,
    UserId = new Guid("123e4567-e89b-12d3-a456-426614174000"),
    Rating = 5,
    CreatedAt = DateTime.ParseExact("07/28/2023 18:45:00", "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK",
        provider: CultureInfo.InvariantCulture,
        DateTimeStyles.RoundtripKind),
    ReviewText = "This program significantly improved my strength. Highly recommended for intermediate lifters!",
};

int programId = 126;
try
{
    ProgramReviewResponse result = await programsProgramReviewsController.AddReviewProgramAsync(
        body,
        programId
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


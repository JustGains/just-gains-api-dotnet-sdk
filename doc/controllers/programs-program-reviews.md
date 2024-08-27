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

[`Task<Models.ProgramsReviewsResponse>`](../../doc/models/programs-reviews-response.md)

## Example Usage

```csharp
int programId = 126;
try
{
    ProgramsReviewsResponse result = await programsProgramReviewsController.GetReviewsProgramAsync(programId);
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
| 404 | Program not found | [`ProgramsReviews404ErrorException`](../../doc/models/programs-reviews-404-error-exception.md) |


# Add Review Program

```csharp
AddReviewProgramAsync(
    int programId,
    Models.ProgramReview body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `programId` | `int` | Template, Required | - |
| `body` | [`ProgramReview`](../../doc/models/program-review.md) | Body, Required | - |

## Response Type

[`Task<Models.ProgramsReviewsResponse1>`](../../doc/models/programs-reviews-response-1.md)

## Example Usage

```csharp
int programId = 126;
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

try
{
    ProgramsReviewsResponse1 result = await programsProgramReviewsController.AddReviewProgramAsync(
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
| 400 | Bad request | [`ProgramsReviews400ErrorException`](../../doc/models/programs-reviews-400-error-exception.md) |
| 404 | Program not found | [`ProgramsReviews404ErrorException`](../../doc/models/programs-reviews-404-error-exception.md) |


# Common Locales

```csharp
CommonLocalesController commonLocalesController = client.CommonLocalesController;
```

## Class Name

`CommonLocalesController`

## Methods

* [Get Locales](../../doc/controllers/common-locales.md#get-locales)
* [Create a New Locale](../../doc/controllers/common-locales.md#create-a-new-locale)
* [Get Locale](../../doc/controllers/common-locales.md#get-locale)
* [Update a Locale](../../doc/controllers/common-locales.md#update-a-locale)
* [Delete a Locale](../../doc/controllers/common-locales.md#delete-a-locale)


# Get Locales

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetLocalesAsync(
    bool showAll)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `showAll` | `bool` | Query, Required | - |

## Response Type

[`Task<Models.LocaleListResponse>`](../../doc/models/locale-list-response.md)

## Example Usage

```csharp
bool showAll = false;
try
{
    LocaleListResponse result = await commonLocalesController.GetLocalesAsync(showAll);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create a New Locale

```csharp
CreateANewLocaleAsync(
    Models.Locale body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`Locale`](../../doc/models/locale.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
Locale body = new Locale
{
    LocaleName = "English (United States)",
    Published = true,
};

try
{
    JustGainsBasicResponse result = await commonLocalesController.CreateANewLocaleAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get Locale

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetLocaleAsync(
    string localeCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `localeCode` | `string` | Template, Required | The locale code to retrieve.<br>**Constraints**: *Pattern*: `^[a-z]{2}-[A-Z]{2}$` |

## Response Type

[`Task<Models.LocaleResponse>`](../../doc/models/locale-response.md)

## Example Usage

```csharp
string localeCode = "localeCode2";
try
{
    LocaleResponse result = await commonLocalesController.GetLocaleAsync(localeCode);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Update a Locale

```csharp
UpdateALocaleAsync(
    string localeCode,
    Models.Locale body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `localeCode` | `string` | Template, Required | The locale code to update.<br>**Constraints**: *Pattern*: `^[a-z]{2}-[A-Z]{2}$` |
| `body` | [`Locale`](../../doc/models/locale.md) | Body, Required | - |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
string localeCode = "localeCode2";
Locale body = new Locale
{
    LocaleName = "English (United States)",
    Published = true,
};

try
{
    JustGainsBasicResponse result = await commonLocalesController.UpdateALocaleAsync(
        localeCode,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Delete a Locale

```csharp
DeleteALocaleAsync(
    string localeCode)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `localeCode` | `string` | Template, Required | The locale code to delete.<br>**Constraints**: *Pattern*: `^[a-z]{2}-[A-Z]{2}$` |

## Response Type

[`Task<Models.JustGainsBasicResponse>`](../../doc/models/just-gains-basic-response.md)

## Example Usage

```csharp
string localeCode = "localeCode2";
try
{
    JustGainsBasicResponse result = await commonLocalesController.DeleteALocaleAsync(localeCode);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


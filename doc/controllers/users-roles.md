# Users Roles

Manage User roles.

```csharp
UsersRolesController usersRolesController = client.UsersRolesController;
```

## Class Name

`UsersRolesController`

## Methods

* [Assign a Role to a User](../../doc/controllers/users-roles.md#assign-a-role-to-a-user)
* [Get User Roles](../../doc/controllers/users-roles.md#get-user-roles)
* [Get All Roles](../../doc/controllers/users-roles.md#get-all-roles)
* [Create a New Role](../../doc/controllers/users-roles.md#create-a-new-role)
* [Update a Role](../../doc/controllers/users-roles.md#update-a-role)
* [Delete a Role](../../doc/controllers/users-roles.md#delete-a-role)


# Assign a Role to a User

:information_source: **Note** This endpoint does not require authentication.

```csharp
AssignARoleToAUserAsync(
    Guid userId,
    List<string> body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `Guid` | Template, Required | - |
| `body` | `List<string>` | Body, Required | - |

## Response Type

[`Task<Models.UsersRolesResponse>`](../../doc/models/users-roles-response.md)

## Example Usage

```csharp
Guid userId = new Guid("000013ec-0000-0000-0000-000000000000");
List<string> body = new List<string>
{
    "body4",
    "body5",
};

try
{
    UsersRolesResponse result = await usersRolesController.AssignARoleToAUserAsync(
        userId,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get User Roles

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetUserRolesAsync(
    Guid userId)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `Guid` | Template, Required | - |

## Response Type

[`Task<Models.UsersRolesResponse1>`](../../doc/models/users-roles-response-1.md)

## Example Usage

```csharp
Guid userId = new Guid("000013ec-0000-0000-0000-000000000000");
try
{
    UsersRolesResponse1 result = await usersRolesController.GetUserRolesAsync(userId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Get All Roles

:information_source: **Note** This endpoint does not require authentication.

```csharp
GetAllRolesAsync()
```

## Response Type

[`Task<Models.RolesResponse>`](../../doc/models/roles-response.md)

## Example Usage

```csharp
try
{
    RolesResponse result = await usersRolesController.GetAllRolesAsync();
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Create a New Role

:information_source: **Note** This endpoint does not require authentication.

```csharp
CreateANewRoleAsync(
    Models.RoleCreateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `body` | [`RoleCreateRequest`](../../doc/models/role-create-request.md) | Body, Required | - |

## Response Type

[`Task<Models.RolesResponse1>`](../../doc/models/roles-response-1.md)

## Example Usage

```csharp
RoleCreateRequest body = new RoleCreateRequest
{
    RoleName = "roleName0",
};

try
{
    RolesResponse1 result = await usersRolesController.CreateANewRoleAsync(body);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Update a Role

:information_source: **Note** This endpoint does not require authentication.

```csharp
UpdateARoleAsync(
    string roleName,
    Models.RoleUpdateRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `roleName` | `string` | Template, Required | - |
| `body` | [`RoleUpdateRequest`](../../doc/models/role-update-request.md) | Body, Required | - |

## Response Type

[`Task<Models.RolesResponse1>`](../../doc/models/roles-response-1.md)

## Example Usage

```csharp
string roleName = "roleName6";
RoleUpdateRequest body = new RoleUpdateRequest
{
};

try
{
    RolesResponse1 result = await usersRolesController.UpdateARoleAsync(
        roleName,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Delete a Role

:information_source: **Note** This endpoint does not require authentication.

```csharp
DeleteARoleAsync(
    string roleName)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `roleName` | `string` | Template, Required | - |

## Response Type

[`Task<Models.JustGainsResponse>`](../../doc/models/just-gains-response.md)

## Example Usage

```csharp
string roleName = "roleName6";
try
{
    JustGainsResponse result = await usersRolesController.DeleteARoleAsync(roleName);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


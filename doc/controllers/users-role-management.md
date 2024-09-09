# Users Role Management

```csharp
UsersRoleManagementController usersRoleManagementController = client.UsersRoleManagementController;
```

## Class Name

`UsersRoleManagementController`

## Methods

* [Assign a Role to a User](../../doc/controllers/users-role-management.md#assign-a-role-to-a-user)
* [Get User Roles](../../doc/controllers/users-role-management.md#get-user-roles)
* [Remove a Role From a User](../../doc/controllers/users-role-management.md#remove-a-role-from-a-user)
* [Get All Roles](../../doc/controllers/users-role-management.md#get-all-roles)
* [Create a New Role](../../doc/controllers/users-role-management.md#create-a-new-role)
* [Update a Role](../../doc/controllers/users-role-management.md#update-a-role)
* [Delete a Role](../../doc/controllers/users-role-management.md#delete-a-role)


# Assign a Role to a User

:information_source: **Note** This endpoint does not require authentication.

```csharp
AssignARoleToAUserAsync(
    Guid userId,
    Models.RoleAssignmentRequest body)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `Guid` | Template, Required | - |
| `body` | [`RoleAssignmentRequest`](../../doc/models/role-assignment-request.md) | Body, Required | - |

## Response Type

[`Task<Models.UsersRolesResponse>`](../../doc/models/users-roles-response.md)

## Example Usage

```csharp
Guid userId = new Guid("000013ec-0000-0000-0000-000000000000");
RoleAssignmentRequest body = new RoleAssignmentRequest
{
    RoleId = 192,
};

try
{
    UsersRolesResponse result = await usersRoleManagementController.AssignARoleToAUserAsync(
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

[`Task<Models.UsersRolesResponse>`](../../doc/models/users-roles-response.md)

## Example Usage

```csharp
Guid userId = new Guid("000013ec-0000-0000-0000-000000000000");
try
{
    UsersRolesResponse result = await usersRoleManagementController.GetUserRolesAsync(userId);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


# Remove a Role From a User

:information_source: **Note** This endpoint does not require authentication.

```csharp
RemoveARoleFromAUserAsync(
    Guid userId,
    string roleName)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `userId` | `Guid` | Template, Required | - |
| `roleName` | `string` | Template, Required | - |

## Response Type

[`Task<Models.JustGainsResponse>`](../../doc/models/just-gains-response.md)

## Example Usage

```csharp
Guid userId = new Guid("000013ec-0000-0000-0000-000000000000");
string roleName = "roleName6";
try
{
    JustGainsResponse result = await usersRoleManagementController.RemoveARoleFromAUserAsync(
        userId,
        roleName
    );
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
    RolesResponse result = await usersRoleManagementController.GetAllRolesAsync();
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
    RolesResponse1 result = await usersRoleManagementController.CreateANewRoleAsync(body);
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
    RolesResponse1 result = await usersRoleManagementController.UpdateARoleAsync(
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
    JustGainsResponse result = await usersRoleManagementController.DeleteARoleAsync(roleName);
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```


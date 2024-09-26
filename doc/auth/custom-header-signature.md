
# Custom Header Signature



Documentation for accessing and setting credentials for userRoles.

## Auth Credentials

| Name | Type | Description | Setter | Getter |
|  --- | --- | --- | --- | --- |
| X-User-Role | `string` | User role required for the operation | `XUserRole` | `XUserRole` |



**Note:** Auth credentials can be set using `UserRolesCredentials` in the client builder and accessed through `UserRolesCredentials` method in the client instance.

## Usage Example

### Client Initialization

You must provide credentials in the client as shown in the following code snippet.

```csharp
JustGainsAPIClient client = new JustGainsAPIClient.Builder()
    .UserRolesCredentials(
        new UserRolesModel.Builder(
            "X-User-Role"
        )
        .Build())
    .Build();
```




# Data

The data returned by the operation.

## Structure

`Data`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `UserId` | `Guid?` | Optional | Unique identifier for the user. |
| `UserName` | `string` | Optional | The user's chosen username for the platform. |
| `Email` | `string` | Optional | The user's email address. |
| `Password` | `string` | Optional | The user's hashed password. This should never be exposed in API responses. |
| `FirstName` | `string` | Optional | The user's first name. |
| `LastName` | `string` | Optional | The user's last name. |
| `FullName` | `string` | Optional | The user's full name, typically a combination of first and last name. |
| `OAuthProvider` | `string` | Optional | The name of the OAuth provider if the user signed up using OAuth. |
| `Role` | `string` | Optional | The user's role in the system, determining their permissions. |
| `RefreshToken` | `string` | Optional | refreshToken value to get next accesstoken |
| `UserCreatorProfile` | [`CreatorProfile`](../../doc/models/creator-profile.md) | Optional | Represents a creator's profile information. |

## Example (as JSON)

```json
{
  "userId": "123e4567-e89b-12d3-a456-426614174000",
  "userName": "fitness_enthusiast_42",
  "email": "jane.doe@example.com",
  "password": "$2a$10$Ks6Qr5Yl.Y5iY5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5Z5",
  "firstName": "Jane",
  "lastName": "Doe",
  "fullName": "Jane Doe",
  "oAuthProvider": "Google",
  "role": "user"
}
```


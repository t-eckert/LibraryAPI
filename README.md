# Library API

> A practice API in ASP.Net Core using Entity Framework Core

## Behaviors

Models a set of libraries with various media including books, films, and newspapers. Allows users to

- borrow media
- search for media at their local library
- search for media at the nearest library
- see what a patron has borrowed

## Models

### Library

| Key                 | Type            | Description                       |
| ------------------- | --------------- | --------------------------------- |
| `LibraryId`         | `int`           | Unique identifier of the library  |
| `Name`              | `string`        | Common name of the library        |
| `City`              | `string`        | City where the library is located |
| `Media`             | `List<Media>`   | Media available at the library    |
| `Nearest Libraries` | `List<Library>` | Libraries closest to the library  |

### Media

| Key         | Type            | Description                    |
| ----------- | --------------- | ------------------------------ |
| `MediaId`   | `int`           | Unique identifier of the media |
| `MediaType` | `enum`          | `[Book, Film, Newspaper]`      |
| `Title`     | `string`        | Common title of the media      |
| `Authors`   | `List<Authors>` | Creators of the media          |

### Patron

| Key             | Type          | Description                            |
| --------------- | ------------- | -------------------------------------- |
| `PatronId`      | `int`         | Unique identifier of the patron        |
| `FirstName`     | `string`      | Given name of the patron               |
| `LastName`      | `string`      | Surname of the patron                  |
| `Name`          | `string`      | `FirstName` + `LastName` of the patron |
| `LocalLibrary`  | `Library`     | Nearest library to the patron          |
| `BorrowedMedia` | `List<Media>` | The media borrowed by a patron         |

### Author

| Key         | Type     | Description                            |
| ----------- | -------- | -------------------------------------- |
| `AuthorId`  | `int`    | Unique identifier of the author        |
| `FirstName` | `string` | Given name of the author               |
| `LastName`  | `string` | Surname of the author                  |
| `Name`      | `string` | `FirstName` + `LastName` of the author |

## Routes

### `GET` `/api/libraries`

### `GET` `/api/library/:library-name`

### `POST` `/api/library/`

``` json
{
    "name": "<string>",
    "media": [
        {}
    ]
}
```

## Notes

Have a user be able to check media out.

Have a user able to search for media.

If media is not available in the library, but is available elsewhere, allow for a transfer from the nearest library.

Each library knows about its closest neighbors.

## Open Questions

- How is the media going to look different when in possession of a patron versus the library? A patron could, in theory have a due date, etc.

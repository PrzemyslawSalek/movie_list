# MovieList

A simple web application built with **ASP.NET MVC** for managing a personal movie watchlist.

## Features

- Browse your movie list with name and watched status at a glance
- Add new movies with name, description, and genre
- Edit existing movie entries
- Delete movies from the list
- Mark movies as watched
- View detailed info for each movie

## Tech Stack

- **ASP.NET MVC** (.NET Framework)
- **C#**
- **Bootstrap 3** — responsive UI
- **jQuery** — client-side scripting
- **Razor** — server-side templating
- In-memory data store (static list, no database)

## Project Structure

```
MovieList/
├── Controllers/
│   └── MovieController.cs   # CRUD actions for movies
├── Models/
│   └── MovieModel.cs        # Movie entity (Name, Description, Genre, Watched)
├── Views/
│   └── Movie/               # Index, Create, Edit, Delete, Details, Contact
└── Content/                 # CSS (Bootstrap + custom)
```

## Screenshots

![MovieList app](https://i.imgur.com/sLRy5aw.png)

## Author

Przemysław Sałek

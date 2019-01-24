# GamesAPI

This is an API built using Asp.Net Core and Visual Studio that allows users to Post, Get, Update and Delete computer games.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development purposes.

### Running the API locally
Ensure that GamesAPI is selected in the dropdown at the top of Visual Studio and press CTRL + F5. This will start the server and connect to the local SQL database.

### Using the API

The following end points are served up by the api. Type the following urls into either a browser or postman to access the data.

```http
GET /api/games
# Serves up all the games
```

```http
GET /api/games/:game_id
# Returns a single game
# e.g: `/api/games/2`
```

```http
POST /api/games
# Adds a new game. This route requires a JSON body with name, releaseDate, rating and description key value pairs
# e.g: {	
  "name": "The Ledgend of Zelda: Ocarina of Time",
  "description": "As a young boy, Link is tricked by Ganondorf, the King of the Gerudo Thieves. The evil human uses Link to gain access to the Sacred Realm, where he places his tainted hands on Triforce and transforms the beautiful Hyrulean landscape into a barren wasteland.",
  "releaseDate": "1998-11-23T00:00:00",
  "rating": 9
}
```

```http
PUT /api/games/:game_id
# Updates the rating value of the game. This requires the full JSON body of the game containing the new rating value.
# e.g: {	
  "name": "The Ledgend of Zelda: Ocarina of Time",
  "description": "As a young boy, Link is tricked by Ganondorf, the King of the Gerudo Thieves. The evil human uses Link to gain access to the Sacred Realm, where he places his tainted hands on Triforce and transforms the beautiful Hyrulean landscape into a barren wasteland.",
  "releaseDate": "1998-11-23T00:00:00",
  "rating": 8
}
```

```http
DELETE /api/games/:game_id
# Deletes a game
```

### Front End
This API was designed to be used in conjunction with the GamesUI built in React using Visual Studio.
GamesUI is available at https://github.com/KWright16/GamesUI
Both projects can be run locally alongside one another.
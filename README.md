# Rover Navigation Software

Is a C# API Rest to Navigate a Rover

## Installation
Use the following commands in a terminal from the project root to 
Build and Run the Docker Image.

```bash
$ docker build -t rovernavigationcore .
$ docker run -d -p 8080:80 --name myapp rovernavigationcore
```

## Usage

Send a Request Json like next structure

Method: POST

URL: localhost:{port}/api/movement

```json
{
    "cube":{
        "x":10,
        "y":10
    },
    "position":{
        "x":1,
        "y":1, 
        "pole":"N"
    },
    "commands":"RAAALRRAA"
}

```

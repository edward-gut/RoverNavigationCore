# Rover Navigation Software

Is a C# API Rest to Navigate a Rover



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

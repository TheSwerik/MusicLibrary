# MusicLibrary ![Badge](https://ci.appveyor.com/api/projects/status/8j0g8ah3rlo32jbu?svg=true)
Play Music with the Beep of Windows or your Motherboard (if it supports it).

The Music Example is an Example Application with a Console Menu and 2 Example Songs.

Usage:
* Change BPM: `Player.Bpm = YOUR_BPM;`
* Play a note: `Player.PlayNote(Note.A.Frequency(3), Duration.Quarter);`
  - Note.X.Frequency(Y) -> Replace X with your desired Note and Y with your desired Octave (in the example: A3)
  - Duration.X -> Replace X with your desired Note-Duration (in the example: Quarter)
* Pause: `Player.Pause(Duration.Eighth);`

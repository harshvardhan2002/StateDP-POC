# StateDP-POC
State Design Pattern allows an object to change its behavior when its internal state changes.
The PlaylistPlayer class interacts with a state, represented by the IPlaylistState interface, and alters its behavior depending on the state. Users can select an initial mood, and the player will react according to that state with actions such as:
Play: Plays the songs associated with the current mood.
Skip: Skips to the next song within the same mood.
Pause: Pauses the playlist and changes to a new state.

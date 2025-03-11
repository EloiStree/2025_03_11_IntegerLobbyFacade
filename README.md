# Integer Lobby Facade

Scratch Cloud Variables are a great concept in Scratch.
They allow a hosted server to share integers between game clients, regardless of the underlying technology. 
This tool serves as an abstraction layer for sending and receiving integers.

It allows to easily make some type of unprotected multiplayer game.
If you send a integer, all the clients connected are going to received the integer.  

I have a WebSocket server that enables integer sharing between game clients. 
However, I could also use Mirror, Unity Network, or WebTransport.  
The stability of the underlying technology may change over time.  

What remains constant is the goal: to make it easy to send an integer that all the clients will received.
If we change the code behind that it won't brake your game.

# 2025_03_11_IntegerCloudVarFacade  

Scratch Cloud Variables are a great concept. 
They allow a hosted server to share integers between game clients, regardless of the underlying technology. 
This tool serves as an abstraction layer for sending and receiving integers.
(Without storing a name label here.)

If you send a integer, all the clients connected will received the integer.  

I have a WebSocket server that enables integer sharing between game clients. 
However, I could also use Mirror, Unity Network, or WebTransport.  
The stability of the underlying technology may change over time.  

What remains constant is the goal: to make it easy to send an integer that all the clients will received.
If we change the code behind that it won't brake your game.

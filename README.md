# 2025_03_11_IntegerCloudVarFacade  

Scratch Cloud Variables are a great concept. They allow a hosted server to share integers between game clients, regardless of the underlying technology. This tool serves as an abstraction layer for sending and receiving integers.  

I have a WebSocket server that enables integer sharing between game clients. However, I could also use Mirror, Unity Network, or WebTransport.  

The stability of the underlying technology may change over time.  

What remains constant is the goal: to make it easy to send an integer between multiplayer clients.  

Here, you'll find this abstract layer for sending and receiving integers, which you can later integrate with the system of your choice.

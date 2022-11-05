# Mini-Driver
### A one-level demo project made in Unity

Drive around and collect packages, which can then be delivered to customers. 
Collect yellow discs for a permanent speed boost and avoid crashing into stuff, which will make you slow down. 
These interactables will disappear once you've collected them, so make sure you get them all. 
The code is largely divided into the driver and delivery .cs files. FollowCamera.cs just serves to make the camera follow the player.
Delivery.cs will handle the desctruction and picking up of the customer and package tiles, as well as change the player tint if they have a package.
Driver.cs implements driving / movement controls, and also handles the effects of collecting speed boosts or crashing into the environment.

Level Layout:
<img width="766" alt="Screen Shot 2022-11-05 at 3 28 03 PM" src="https://user-images.githubusercontent.com/67356677/200143698-47c2189e-0b63-4ba8-b3bd-3c09a1d292ae.png">

Screen with all interactable objects
<img width="858" alt="Screen Shot 2022-11-05 at 3 30 13 PM" src="https://user-images.githubusercontent.com/67356677/200143743-e296df7c-5bc8-427a-bc98-54162e8232f3.png">

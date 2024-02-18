# DP_SingletonPattern

## What is Singleton Pattern?
Singleton pattern is one of the most controversial design pattern and people mostly try to avoid this as it has several drawbacks. It is a design pattern which restricts a class to instantiate its multiple objects. It is nothing but a way of defining a class. Class is defined in such a way that only one instance of the class is created in the complete execution of a program or project. It is mostly used when you want your class to be instantiated only once and exist throughout the gameplay.

![1_PyCPTI1r3B4yJhQ3zazBiA](https://github.com/iAmSidh108/DP_SingletonPattern/assets/63715240/5afb0a29-43ee-44f2-9930-bc57e1a7fa72)
![singleton](https://github.com/iAmSidh108/DP_ObserverPattern/assets/63715240/2819d15e-081c-4d5f-9f97-ce70d184696b)

## What are some examples of using the singleton pattern in game development?
The singleton pattern finds frequent application in game development, both within established games and in typical game design scenarios. For instance, a GameManager class has the role of overseeing the overall progression and status of the game, encompassing tasks like loading and unloading scenes, pausing and resuming gameplay, saving and loading data, and triggering various events and callbacks. Similarly, an AudioManager class is responsible for managing the audio aspects of the game, such as controlling audio settings and sources, playing and stopping sounds, adjusting volume and pitch, and smoothly fading in and out the music. Moreover, an InputManager class could be employed to handle input devices and events in the game, including reading inputs from the keyboard, mouse, joystick, or touch interfaces. Lastly, a NetworkManager class would be in charge of managing network communication and synchronization within the game, which involves tasks like connecting and disconnecting players, sending and receiving messages or data, as well as overseeing lobbies or matchmaking processes.

## How to implement Singleton Pattern?
Implementing the singleton pattern in game development may vary based on the programming language and game engine, but there are common steps and principles to follow. Firstly, establish a private constructor for the singleton class to prevent other classes from creating new instances. Additionally, define a private static field to store the sole instance of the class, and create a public static method to retrieve this instance. Lastly, ensure proper initialization and destruction of the singleton class in alignment with the game's lifecycle, utilizing methods like Awake, Start, OnDestroy, or Dispose.

## Drawbacks of using Single Pattern.
The singleton pattern comes with its share of drawbacks and limitations. One significant downside is its potential to introduce global state and coupling in the game, leading to code that is more challenging to test, debug, and maintain. For instance, if a singleton class is used to store player preferences like difficulty level, controls, and graphics, testing the game's behavior under diverse settings or scenarios may prove problematic. Altering or substituting the singleton class without impacting other game components dependent on it could also pose challenges. Another drawback is the potential violation of modularity and encapsulation principles, crucial for creating clean and reusable code. Take, for example, a singleton class managing the game's input and output, such as keyboard, mouse, and screen interactions. This setup may make it difficult to isolate and abstract the input and output logic from the rest of the game logic, and adapting or extending the singleton class to support different platforms or devices could present challenges.

## This is how I implemented Singleton Pattern in this project:
You can see in the first picture the singleton is not properly encapsulated. This is how people usually create but the second example shows how can we properly protect singleton so that other classes can't create other instances.

![image](https://github.com/iAmSidh108/DP_ObserverPattern/assets/63715240/ee5afe5f-773d-4dbe-8303-25cf0c30b5a7) 
![image](https://github.com/iAmSidh108/DP_ObserverPattern/assets/63715240/87a4fea6-1af6-4c41-9f60-79f89fcc90fb)

### Since people want to avoid this pattern there is another way to implement it. The whole reason of Singleton Pattern is to create class that exist all through the scene. So, other way to implement same functionality is to create persistent object and then use that to instantiate prefab of the class that you want to be on the scene.

See the code below:

![image](https://github.com/iAmSidh108/DP_ObserverPattern/assets/63715240/889aadd1-d4a1-4fc6-aa3f-8a6426b3c09f)

As we can see we instantiated a persistent object by creating a prefab of it and there is only one bool that is static.This way we can obtain same result without making whole class static.




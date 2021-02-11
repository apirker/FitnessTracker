# FitnessTracker

The FitnessTracker solution presents the main ingredients to ports-and-adapters architecutres and domain-driven design. It is a working example to support the two sub-domains from sports, and one from hardware:

* HIIT: High Intensity Interval Training - This sub-domain covers trainings in form of high intesity workouts, which consist of several rounds. Each round in turn comprises several exercises which the user performs for a definable amount of time.
* Endurance: Implemented only the running part of endurance sports - Supports the process of 
* Peripherals: Hardware abstraction for fitness tracker devices

In order to support these three domains, the solution follows hexagonal architecture and puts the business logic implementations of these three sub-domains at the center of the application. For that purpose, each business logic implementations comprises:

* A contracts assembly: This assembly contains the interfaces to interact with the domain assembly
* A bounded context assembly: This assembly implements the interfaces of the contracts assembly, thereby providing the business logic to the end user


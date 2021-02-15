# FitnessTracker

## Solution

The FitnessTracker solution presents the main ingredients to ports-and-adapters architecutres and domain-driven design. It is a working example to support the two sub-domains from sports, and one from a hardware perspective:

* HIIT: High Intensity Interval Training - This sub-domain covers trainings in form of high intesity workouts, which consist of several rounds. Each round in turn comprises several exercises which the user performs for a definable amount of time. Between exercises, and rounds, the athlete rests for a definable amount of time.
* Endurance: Implemented only the running part of endurance sports - Supports running activities by recording laps, getting heart rate data but also GPS coordinates. After stopping the activity the training computes a training effect, providing the user some feedback.
* Peripherals: Hardware abstraction for fitness tracker devices. In general, applications communicate with the fitness tracker peripheral via a wireless communication link, like e.g.  Bluetooth. The peripheral returns lap data, and heart rate data. The peripheral creates both of them using random number generators.

In order to support these three domains, the solution follows hexagonal architecture and puts the business logic implementations of these three sub-domains at the center of the application. In general, the solution comprises the following folders:

* Applications: Contains two applications, a desktop WPF application (SportsCompany.FitnessTracker.DesktopClient) in the sub-folder Desktop and a backend-service for Endurance (SportsCompany.FitnessTracker.Endurance.WebApi) in the folder Service

* Endurance: Contains contract assembly, the business logic assembly, a service client assembly and the windows environment implementation for the endurance bounded context.

* HIIT: Contains contract assembly, the business logic assembly, and the windows environment implementation for the HIIT bounded context.

* Peripherals: Contains contract assembly, and the business logic assembly.

## Bounded context implementations

Each bounded context implementations comprises two assemblies:

* A contracts assembly: This assembly contains the interfaces to interact with the domain assembly. The purpose of this assembly is that applications only depend on the interfaces of a sub-domain, bounded-context but not on concrete implementations thereof. This gives applications the possibility to move business logic into services, or somewhere else without breaking an application. Furthermore, it also contains the interfaces which define the ports the bounded-context requires, i.e. the environment ports.

* A bounded context assembly: This assembly implements the interfaces of the contracts assembly, thereby providing the business logic to the end user. It necessarily depend on the contracts assembly, and implements the interfaces specified in there. However, client applications only depend on the contracts assembly, and not on the implementation/bounded-context assembly.

* Environment folder: The environment folder contains assemblies which implement an environment of a particular bounded-context. For example, the environment sub-folder within the endurance bounded context contains an Windows environment implementation.

## How to use the solution

If you want to run the desktop application with a local bounded-context, you need to modify the MainWindowView.xaml.cs file accordingly to register the local implementations of the bounded-context within unity container. Within this file you can also choose to use the WebAPI project running the Endurance bounded-context as a service.

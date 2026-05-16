# Design Patterns

My notes and implementations from the [Dometrain](https://dometrain.com/) Design Patterns course.
Each pattern has a **theoretical (GoF)** example and a **real-world** example side by side.

## Creational Patterns

> _How objects are created._

**[Singleton](Creational/Singleton)** ([course](https://dometrain.com/course/design-patterns-singleton/)) - One instance, globally accessible.
Progressive implementations from naive to thread-safe, plus DI container approach.
_Learned: prefer DI-registered singletons over static Instance properties._

**[Factory Method](Creational/Factory)** ([course](https://dometrain.com/course/design-patterns-in-csharp-factory-method/)) - Let subclasses decide what to create.
`Creator` defines the interface, `ConcreteCreator` picks the product. Real-world: game level factory spawning different enemies.
_Learned: eliminates `new` scattered across client code; swap implementations without touching callers._

**[Abstract Factory](Creational/AbstractFactory)** ([course](https://dometrain.com/course/design-patterns-in-csharp-abstract-factory/)) - Create families of related objects.
One factory per theme producing matching enemies, weapons, and power-ups. Real-world: game engine with Cave vs Haunted House levels.
_Learned: guarantees consistency across product families; adding a new family = one new factory class._

**[Builder](Creational/Builder)** ([course](https://dometrain.com/course/design-patterns-in-csharp-builder/)) - Construct complex objects step by step.
Director drives the build sequence, Builder assembles the parts. Real-world: fluent Pizza builder with typed steps.
_Learned: step interfaces enforce build order at compile time; separates construction from representation._

**[Prototype](Creational/Prototype)** ([course](https://dometrain.com/course/design-patterns-in-csharp-prototype/)) - Clone instead of construct.
`IPrototype.Clone()` copies objects without knowing their concrete types. Real-world: shape cloning with shallow vs deep copy.
_Learned: shallow clone shares references (danger!), deep clone is independent; `record` types help but aren't automatic._

---

## Structural Patterns

> _How objects are composed into larger structures._

**[Adapter](Structural/Adapter)** ([course](https://dometrain.com/course/design-patterns-in-csharp-adapter/)) - Make incompatible interfaces work together.
Wraps an `Adaptee` behind the `ITarget` interface clients expect. Real-world: adapting a legacy rectangle API to a modern interface.
_Learned: lets you integrate third-party/legacy code without modifying it._

**[Proxy](Structural/Proxy)** ([course](https://dometrain.com/course/design-patterns-in-csharp-proxy/)) - Control access to another object.
Same interface as the real subject but adds logic (lazy loading, caching, access control). Real-world: lazy-loading images.
_Learned: client code doesn't know it's talking to a proxy; great for expensive resources._

**[Facade](Structural/Facade)** ([course](https://dometrain.com/course/design-patterns-in-csharp-facade/)) - Simplify a complex subsystem.
One entry point hides the wiring of multiple internal classes. Real-world: `CastingFacade` orchestrating device discovery, connection, and app launching.
_Learned: reduces coupling between clients and subsystem internals; doesn't prevent direct access when needed._

**[Decorator](Structural/Decorator)** ([course](https://dometrain.com/course/design-patterns-in-csharp-decorator/)) - Add behavior without modifying existing code.
Wraps components recursively, each layer adding functionality. Real-world: Tesla Model 3 with paint and battery decorators stacking price/range.
_Learned: composition over inheritance; decorators are interchangeable and stackable._

**[Flyweight](Structural/FlyWeight)** ([course](https://dometrain.com/course/design-patterns-in-csharp-flyweight/)) - Share common state across many objects.
Intrinsic state (shared) lives in the flyweight, extrinsic state (unique) is passed in. Real-world: text editor sharing glyph shapes across characters.
_Learned: massive memory savings when thousands of objects share most of their data._

**[Bridge](Structural/Bridge)** ([course](https://dometrain.com/course/design-patterns-in-csharp-bridge/)) - Separate abstraction from implementation.
Views and formatters vary independently through composition. Real-world: clothing views (compact/detailed/mini) x formatters (shoe/jeans/dress).
_Learned: prevents class explosion from M x N combinations; change either side without affecting the other._

**[Composite](Structural/Composite)** ([course](https://dometrain.com/course/design-patterns-in-csharp-composite/)) - Treat individual objects and groups uniformly.
`Component` base with `Leaf` and `Composite` nodes forming a tree. Real-world: course bundles containing courses or nested bundles.
_Learned: client code doesn't care if it's a single item or a tree; `GetPrice()` works the same way._

---

## Behavioral Patterns

> _How objects communicate and distribute responsibility._

**[Strategy](Behavioral/Strategy)** ([course](https://dometrain.com/course/design-patterns-in-csharp-strategy/)) - Swap algorithms at runtime.
`Context` holds an `IStrategy` reference and delegates work to it. Real-world: shopping cart switching between credit card, PayPal, and bank transfer.
_Learned: eliminates switch/if-else chains; new strategies = new classes, zero changes to existing code._

**[Mediator](Behavioral/Mediator)** ([course](https://dometrain.com/course/design-patterns-in-csharp-mediator/)) - Centralize complex communication.
Objects talk through a mediator instead of directly to each other. Real-world: chat room routing messages between regular and admin users.
_Learned: reduces N-to-N dependencies to N-to-1; objects stay decoupled._

**[Observer](Behavioral/Observer)** ([course](https://dometrain.com/course/design-patterns-in-csharp-observer/)) - Notify dependents of state changes.
Subject maintains a list of observers and notifies them on change. Real-world: game player notifying health bar, score UI, and game-over screen.
_Learned: publishers don't know their subscribers; adding new UI = new observer class, no changes to Player._

---

## How to Run

```
dotnet build "Design Patterns.sln"
dotnet run --project Creational/Factory
dotnet run --project Structural/Decorator
dotnet run --project Behavioral/Observer
```

## Folder Structure

```
PatternName/
  Program.cs        # Runs both theoretical and real-world demos
  Theoretical/      # GoF participants (Creator, Product, ConcreteCreator...)
  RealWorld/        # Domain-specific code (Pizza, ShoppingCart, Player...)
  Diagrams/         # Class diagram PNGs from the course
```

---

Thanks to [Dometrain](https://dometrain.com/) for these courses.

**Certificates of completion:**
- [Singleton](certificates/Singleton%20Design%20Pattern%20-%20Einav%20Haimovich.pdf)
- [Factory Method](certificates/Factory%20Design%20Pattern%20-%20Einav%20Haimovich.pdf)
- [Abstract Factory](certificates/Abstract%20Factory%20Design%20Pattern%20-%20Einav%20Haimovich.pdf)
- [Builder](certificates/Builder%20Design%20Pattern%20-%20Einav%20Haimovich.pdf)
- [Prototype](certificates/Prototype%20Design%20Pattern%20-%20Einav%20Haimovich.pdf)
- [Adapter](certificates/Adapter%20Design%20Pattern%20-%20Einav%20Haimovich.pdf)
- [Proxy](certificates/Proxy%20Design%20Pattern%20-%20Einav%20Haimovich.pdf)
- [Facade](certificates/Facade%20Design%20Pattern%20-%20Einav%20Hainovich.pdf)
- [Decorator](certificates/Decorator%20Design%20Pattern%20-%20Einav%20Haimovich.pdf)
- [Flyweight](certificates/FlyWeight%20Design%20Pattern%20-%20Einav%20Haimovich.pdf)
- [Bridge](certificates/Bridge%20Design%20Pattern%20-%20Einav%20Haimovich.pdf)
- [Composite](certificates/Composite%20Design%20Pattern%20-%20Einav%20Haimovich.pdf)
- [Strategy](certificates/Strategy%20Design%20Pattern%20-%20Einav%20Haimovich.pdf)
- [Mediator](certificates/Mediator%20Design%20Pattern%20-%20Einav%20Haimovich.pdf)
- [Observer](certificates/Observer%20Design%20Pattern%20-%20Einav%20Haimovich.pdf)

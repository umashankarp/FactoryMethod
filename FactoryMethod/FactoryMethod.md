The Factory method

The factory method is a creational pattern that delegates the responsibility of object instantiation to its concrete subclasses.

Motivation

Imagine a drive-thru where customers order meals by number, such as "Combo 1". Customers don't specify ingredients or preparation details; they trust the kitchen to handle that.

But how do we design this from a software perspective, such that we create a flexible and loosely coupled design?

Let's take a look at two candidate solutions:

1. Direct Instantiation by the client: At first glance, one way we can handle this is direct instantiation. Imagine creating burger objects based on multiple conditionals:

// ...
Burger burger;

if (TYPES.CHEESE) {
    burger = new CheeseBurger();
} else if (TYPES.DELUXE) {
    burger = new DeluxeCheeseBurger();
} else if (TYPES.VEGAN) {
    burger = new VeganBurger();
}
// 

This does work, but what happens when we introduce a new burger type or a limited-time special?

Each addition requires us to modify this logic. This isn't just tedious but also risks introducing errors, particularly if this decision-making code sprawls across the application.

We have discussed "program to an interface and not to an implementation" before, meaning that clients should remain unaware of the specific types of objects they use, as long as the objects adhere to the interface that they expect.

While the code above adheres to this principle, we are still limiting ourselves to the concrete implementation when we perform instantiation. This direct instantiation within the client code is brittle. It makes the system less adaptable to change and increases the chances of mistakes.

We also violate the single-responsibility principle because we are handling the logic of cooking, preparing the drink and the side, all together in one class. If we make a mistake updating any of the conditional code, we might end up taking down the entire burger class. In a real kitchen, the cashier does not decide how to cook the burger or what ingredients to use. The same should be the case with our code.

Taking into consideration the pitfalls of this approach, let's address them in the next candidate solution.

2. Encapsulate what varies using a simple factory: We know that the burger menu may evolve over time, but we would prefer not to directly modify all of the parts of code that instantiate a burger.
Taking the design principle, "encapsulate what varies" into consideration, we can create a class called SimpleBurgerFactory and isolate the burger creation logic to a method called createBurger.

enum BurgerType {
  CHEESEBURGER,
  DELUXE_CHEESEBURGER,
  VEGANBURGER,
}

class SimpleBurgerFactory {
  public Burger createBurger(BurgerType type) {
    Burger burger = null;
    switch (type) {
      case CHEESEBURGER:
        burger = new CheeseBurger();
        break;
      case DELUXE_CHEESEBURGER:
        burger = new DeluxeCheeseBurger();
        break;
      case VEGANBURGER:
        burger = new VeganBurger();
        break;
    }
    return burger;
  }
}

This is the essence of the simple factory pattern - a class dedicated to producing objects based on conditions.
The above solution still violates the open/closed principle but it also violates the dependency inversion principle. The simple factory has direct dependencies on the concrete classes that it is creating. And while the simple factory is abstracting away the creation process, the product type still needs to be provided to the factory.


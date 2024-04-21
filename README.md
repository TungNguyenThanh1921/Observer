## Observer Pattern Implementation

This is a basic implementation of the Observer pattern created by Nguyễn Thanh Tùng.

**Contact:** <br>
Nguyễn Thanh Tùng <br>
Email: tungnguyenthanh1921@gmail.com <br>

For more detailed information about the Observer pattern, please refer to the accompanying Word document.

### Overview

The Observer Pattern is a widely used behavioral design pattern in object-oriented programming. It facilitates establishing a one-to-many relationship between objects, where one object (the Subject) broadcasts notifications when its state changes, and other objects (the Observers) listen and respond to these notifications.

### Structure

- **Subject**: Represents an object that can change its state and broadcast notifications.
- **Observer**: Represents objects that want to receive notifications from the Subject.
- **Attach() & Detach() Methods**: Methods for Observers to register or unregister for notifications from the Subject.
- **Notify() Method**: Method that the Subject uses to send notifications to registered Observers.

### Benefits

- **Minimize dependencies**: Observers do not directly depend on the Subject, making it easier to change or add/remove Observers.
- **Increase flexibility**: Allows easy addition/removal of new Observers without affecting the Subject and other Observers.
- **Reusability**: Subjects and Observers can be reused in various different scenarios.

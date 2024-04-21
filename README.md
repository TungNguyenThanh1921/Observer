This is base Observer pattern design by me: Nguyễn Thanh Tùng
email: tungnguyenthanh1921@gmail.com
Please read Word document to get more information about Observer pattern.
  The Observer Pattern is a common behavioral design pattern in object-oriented programming. This pattern helps establish a one-to-many relationship between objects, where one object (Subject) broadcasts notifications when its state changes, and other objects (Observers) listen and respond to these notifications.
  Structure:
- Subject: Represents an object that can change its state and broadcast notifications.
- Observer: Represents objects that want to receive notifications from the Subject.
- Attach() & Detach() Methods: Methods for Observers to register or unregister for notifications from the Subject.
- Notify() Method: Method that the Subject uses to send notifications to registered Observers.
  Benefits:
- Minimize dependencies: Helps Observers not directly depend on the Subject, making it easier to change or add/remove Observers.
- Increase flexibility: Allows easy addition/removal of new Observers without affecting the Subject and other Observers.
- Reusability: Subjects and Observers can be reused in various different scenarios.

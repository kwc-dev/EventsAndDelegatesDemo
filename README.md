## 📌 Overview  
This project is a simple demonstration of events and delegates in C#.  
It shows how one object can notify another object when something happens — a classic example of the **observer pattern**.

The program defines a `Person` class that raises an event whenever its name changes, and a `Goverment` class that listens for that event.

## 🧱 Project Structure  
- Person — publishes the `NameChanged` event
- Goverment — subscribes to the event and reacts
- Program — wires everything together and runs the demo

## 👤 Person Class  
The `Person` class contains:
- A `Name` property
- A `changeName` method that:
  - Updates the name
  - Prints the change
  - Raises the `NameChanged` event
- An event declaration using the built‑in **EventHandler** delegate
- A protected `OnNameChanged` method that safely triggers the event

This class acts as the event publisher.

## 🏛️ Goverment Class  
The Goverment class defines a method:
```csharp
public void OnNameChanged(object source, EventArgs e)
```
This method matches the `EventHandler` signature and is used as the event subscriber.
When the event fires, it prints a message acknowledging the change.

## ▶️ Program Execution  
In `Main`:
1. A `Person` object is created
2. A `Goverment` object is created
3. The government subscribes to the person’s NameChanged event
4. The person’s name is changed, which triggers the event

Expected console output:
```Code
@Person: Name changed from Khai Wah Cheung to John Petrucci
@Goverment: Received name change event.
```

## 🎯 Purpose of This Demo  
This project illustrates:
- How to declare an event
- How to subscribe to an event
- How to raise an event safely
- The flow of the observer pattern in C#

It’s a great starting point for understanding how C# uses events to decouple components.

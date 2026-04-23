# C# Order Event Notification System

## Problem Statement

This project implements a Real-Time Order Notification System using C# delegates and events.
It processes orders and notifies multiple services (Email, SMS, Logging) using the Publisher-Subscriber model.

---

## Features

* Process customer orders
* Trigger multiple notifications using events
* Support dynamic subscribe/unsubscribe
* Use multicast delegates
* Maintain loose coupling between components

---

## Technologies Used

* C#
* .NET
* Delegates & Events

---

## Architecture

### Publisher

* `OrderProcessor` → Raises event when order is processed

### Subscribers

* `EmailService` → Sends email notification
* `SMSService` → Sends SMS notification
* `LoggerService` → Logs order details

---

## Key Concepts

* Delegate (`OrderPlacedHandler`)
* Multicast Delegate
* Event (`OnOrderPlaced`)
* Publisher-Subscriber Pattern
* Loose Coupling

---

## Functionality Overview

1. Create an order
2. Subscribe services to event
3. Process order → Event triggered
4. All subscribers receive notification
5. Unsubscribe SMS → Event triggers only remaining services

---

## Sample Output

Order Placed: 101

Email sent to customer

SMS sent to customer

Order logged successfully

After Unsubscribing SMS:

Order Placed: 101

Email sent to customer

Order logged successfully

---

## How to Run

1. Open the project in Visual Studio
2. Build the solution
3. Run the program (Ctrl + F5)

---

## Project Structure

OrderApp/

├── Program.cs

├── Order.cs

├── OrderProcessor.cs

├── EmailService.cs

├── SMSService.cs

├── LoggerService.cs

---


# 💸 Cash Transfer Simulator – Console App

This C# console application simulates **cash transfer** between two people, **Joe** and **Bob**, using simple object-oriented programming concepts.

The program allows the user to:
- Enter an amount of money
- Choose who gives money to whom
- See real-time updates of each person’s cash balance

---

## 📌 Features

- Two predefined users: **Joe** and **Bob**
- Transfer logic with:
  - Input validation
  - Preventing overdrafts
- Live tracking of each user's balance
- Uses a `Guy` class with encapsulated properties and methods

---

## 🧠 OOP Concepts Used

| Concept        | Implementation                                           |
|----------------|----------------------------------------------------------|
| Encapsulation  | Private fields with public getters and setters           |
| Object Behavior| `GiveCash()` and `ReceiveCash()` methods                 |
| Feedback       | Real-time messages for invalid or rejected transactions  |
| Loop Control   | Continuous prompt loop using `do...while(true)`          |

---

## 💬 Sample Output

My Name Is Joe And I have 50

My Name Is Bob And I have 100

Enter An Amount : 30

Who Should Give Money To Who ? 

Joe

My Name Is Joe And I have 20

My Name Is Bob And I have 130

Enter An Amount :

--- 

## 🚫 Input Handling

- Rejects non-positive or excessive amounts
- Prevents accepting negative money
- Warns user if giver name is invalid

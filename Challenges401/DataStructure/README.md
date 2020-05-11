# Singly Linked List
This is a small libary of functions to assist in the instantiation and traversal of linked lists for a code 401 project. 

#

## Challenge
- Create a Node class that has properties for the value stored in the Node, and a pointer to the next Node.
- Within your LinkedList class, include a head property. Upon instantiation, an empty Linked List should be created.
- Define a method called insert which takes any value as an argument and adds a new node with that value to the head of the list with an O(1) Time performance.
- Define a method called includes which takes any value as an argument and returns a boolean result depending on whether that value exists as a Node’s value somewhere within the list.
- Define a method called toString (or __str__ in Python) which takes in no arguments and returns a string representing all the values in the Linked List, formatted as:
"{ a } -> { b } -> { c } -> NULL"
- Any exceptions or errors that come from your code should be semantic, capturable errors. For example, rather than a default error thrown by your language, your code should raise/throw a custom, semantic error that describes what went wrong in calling the methods you wrote for this lab.
- Be sure to follow your language/frameworks standard naming conventions (e.g. C# uses PascalCasing for all method and class names).
###Structure and Testing
- Utilize the Single-responsibility principle: any methods you write should be clean, reusable, abstract component parts to the whole challenge. You will be given feedback and marked down if you attempt to define a large, complex algorithm in one function definition.

Write tests to prove the following functionality:

- Can successfully instantiate an empty linked list
- Can properly insert into the linked list
- The head property will properly point to the first node in the linked list
- Can properly insert multiple nodes into the linked list
- Will return true when finding a value within the linked list that exists
- Will return false when searching for a value in the linked list that does not exist
- Can properly return a collection of all the values that exist in the linked list

#

## Approach & Efficiency
The Big O notation for time is anywhere from O(1) to O(n), depending on the function. For instance, the Big O notation for the Includes method is O(n) and for the Insert feature it is O(1). The Big O notation for space is O(1). 

#

## API
- **Insert()** - takes in a value and inserts it at the *head* of a *Linked List*.
- **Includes()** - takes in a value and returns *true* if the value is located within a *Linked List* or *false* if it is not.
- **ToString()** - stringifys the output of the Insert() method and concatenates it with *{}* and an arrow.
- **Node** - instantiates a new *Node* to populate a *Linked List*.

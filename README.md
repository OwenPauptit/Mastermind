# Mastermind

Mastermind is a game that involves the use of several colours (Orange, blue, red, green, pink, white and yellow). Four of these colours are chosen by the computer and placed in a random order.

The player has ten guesses to find the order of the colours. Each time the player makes a guess, they are told how many are the correct colour and correct position, and how manya re the correct colour but incorrect position. For example...

If the code is

> **YPRB** *(Yellow Pink Red Blue)*

And the user guesses

> **YOBR** *(Yellow Orange Blue Red)*

the computer will output:

```
    Correct colour, correct position:     1
    Correct colour, incorrect position:   2
```

As you can see, the **Y** is in the correct position, but the **B** and **R** are both present in the code, but are not in the correct position.

The player wins when they guess the correct combination.

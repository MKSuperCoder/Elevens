Summary:
This is an card game where you have to choose cards that add up to 11. 
Challenge:
It was hard to write the logic of the game because I'm not familiar with card games. I tried to make it as simple as possible

Instructions:
1. Download the file onto your computer
2. Run the main.cs file
3. A menu will be displayed
4. Type a number to select options

Update
- Added a main menu with options
- When the user chooses "Play Turn", they now stay in that mode until:
  - They make a valid move (cards add up to 11), or
  - They fail 3 times (invalid attempts)
- Improved User Experience:
  - The main menu no longer shows up after each failed card selection.
  - The user is prompted to try again up to 3 times before being sent back to the menu.
- Code Adjustments:
  - PlayTurn() in ElevensGame now returns a bool to indicate if the move was valid.
  - A retry loop was added in the main menu's Play Turn option (case "2").
  - Input validation and friendly messages were added to guide the user.

--------------------------------------------------------------------------------------------------------------------------------------------------
Class: Card
Fields:

- name: string

- num: int

Constructor:

+ Card(): int

Properties:

+ Num: int

+ Name: string

Methods:

+ selectCard(): int
-----------------------------------------------------------------------------------------------------------------------------------------------------
Class: Board
Fields:

- numOfCards: int

- cardsRemaining: int

- card: Card[9]

- selectedCards: List<int>

Constructor:

+ Board(): int

Properties:

+ NumOfCards: int

+ CardsRemaining: int

Methods:

+ replaceCards()

+ checkRemainingCards()
------------------------------------------------------------------------------------------------------------------------------------------------------------------
Class: ElevensGame
Fields:

- deck: Deck

- board: Board

- isGameActive: bool

Constructor:

+ ElevensGame(): int

Properties:

+ IsGameActive: bool

Methods:

+ checkForValidPairs(): bool

+ startGame(): bool

+ endGame(): bool

+ updateGameStatus(): bool
--------------------------------------------------------------------------------------------------------------------------------------------------------------------
Class: Deck
Fields:

- cards: List<Card>

Constructor:

+ Deck()

Methods:

+ dealCard(): int

+ shuffle(): int

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

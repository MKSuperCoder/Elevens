UML

Class: Card

Fields:
-name:string
-num:int

+Card:int

Properties:
+Num:int
+Name:string

Methods:
+selectCard:int



Class: Board

Fields:
-numOfCards: int
-cardsRemaining: int
-Card[9] card
-List<int> selectedCards;

+Board:int

Properties
+NumOfCards: int
+CardsRemaining: int

Methods:
+replaceCards
+checkRemainingCards;

Class: ElevensGame
Fields:
-Deck deck;
-Board board
-isGameActive: bool

+ElevensGame: int

Properties:
+IsGameActive: bool

Methods:
+checkForValidPairs: bool
+startGame: bool
+endGame: bool
+updateGameStatus: bool


Class: Deck
Fields:
-List<Card> cards

+Deck

Methods:
+dealCard:int
+shuffle:int

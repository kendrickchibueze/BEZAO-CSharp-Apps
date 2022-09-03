#   WELCOME TO THE BEZAO  C# 👓👓 WORLD!!!
This repository contains three  C# console applications which explains the following demands:

* A program that prints the Next 20 leap years.
*  A number guessing game.
* A Program that translates from English to piglatin and back.


### 1.  A Program That Calculates  Next 20 Leap Years
  !["leap years"](https://github.com/kendrickchibueze/-Modern-Node-on-AWS/blob/main/aws-images/Screenshot%20(214).png?raw=true)

#### Algorithm for Next 20 leap years
* Step 1: Start
* Step 2: Read year
* Step 3: If the year is divisible by 4 then go to Step 4 else go to * Step 7
* Step 4: If the year is divisible by 100 then go to Step 5 else go to * Step 6
* Step 5: If the year is divisible by 400 then go to Step 6 else go to * Step 7
* Step 6: Print "Leap year"
* Step 7: Print "Not a leap year"
* Step 8: Stop

####  Explanation
We generalize that a year has 365 days (It takes the earth 365 days to revolve around the sun) but in reality it takes the earth approximately 365.2425 days to revolve around the sun.
As you noticed, there is an extra 0.2425 of a day taken to revolve around the sun, so, to compensate that extra 0.2425 we add an extra day every fourth year and we call it the leap year. But even that is not accurate because that would be over compensating it. 0.2425 x 4 = 0.97 which is not equal to 1 full day.
This means that every 400 years should exactly have 97 leap years and not 100. To adjust this over compensation we make sure that all the century years should be divisible by 400 to be leap years making the tally of total number of leap years in 400 years = 97.

###   2.  A number guessing Game
![guess-game](https://github.com/kendrickchibueze/-Modern-Node-on-AWS/blob/main/aws-images/Screenshot%20(213).png?raw=true)


#### Asumption
In this guessing game, the user has to guess a secret number. After every guess the program tells the user whether their number was too large or too small. At the end the number of tries needed is printed. It counts only as one try if they input the same number multiple times consecutively.


#### Algorithm
* Step 1: Start
* Step 2: guess a random number between 1  and 100
* Step 3: If guess > correctNumber then go to step 6
* Step 4: If guess < correctNumber then go to step 7
* Step 5: If guess = correctNumber then go to step 8
* Step 6: Print "guess too high"
* Step 7: Print "guess too low"
* Step 8: print "You Win"
* step 9: stop



###  3.  PigLatin Game
![PigLatin](https://github.com/kendrickchibueze/-Modern-Node-on-AWS/blob/main/aws-images/Screenshot%20(210).png?raw=true)

Pig Latin is a language game or argot in which words in English are altered, usually by adding a fabricated suffix or by moving the onset or initial consonant or consonant cluster of a word to the end of the word and adding a vocalic syllable to create such a suffix.

#### Asumption

In this game, Pig Latin takes the first __consonant__ (or consonant cluster) of an English word, moves it to the end of the word and suffixes an __"ay"__.
If a word begins with a __vowel__ you just add __"way"__ to the end.


####  Algorithm
* Step 1: Start.
* Step 2: Enter English word or sentence
* Step 3: If the word begins with a consonant, then go to step 5
* Step 4: If the word begins with a vowel, then go to step 6
* Step 5: move the first consonant letter to the end of the word and add -ay
* Step 6: move the first vowel letter to the end of the word and add -way
* Step 8: press **enter** key to translate piglatin back to English
* step 9: stop


__NOTE:__ You can clone this repository and run the console applications with **.exe** extension on your windows desktop or use vscode or visual studio to run it. You would visualize  these outputs on the  window terminal.

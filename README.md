# Mafia_Random_Generator

## Mafia (party game) roles random generator
During the Covid 19 crisis and the lockdowns in 2020, my friends and I often looked for different online hangouts. Often we talked in a group call on skype, but we didn't played anything. Before Covid 19 time, when we gathered more people, we often played the social game Mafia (which has different variations and names, you can read more on [wikipedia](https://en.wikipedia.org/wiki/Mafia_(party_game))).   

But we had never tried playing the game online. We agreed to play the game on Skype, where for each role we created a separate group and the storyteller called the corresponding group separately. Previously, we wrote the roles on slips of paper and everyone drew a slip to see in which team they would play. Now on Skype this was a problem for us, that's why my initial idea was to make a random generator that for a given list of names will distribute them in one of the four groups. But in a few days I "slightly" complicated the generator into a tool that the storyteller used while we were playing. So apart from the random distribution of the players, it also allowed the storyteller just by clicking to determine the actions of the mafia or the police or the doctor, and finally there was a log of how the game was going. So this way of playing mafia over skype with the newly invented tool turned out to be fun. The application was made in a short time, currently it is only in Macedonian and there are many messages that I wrote primarily so that the storyteller would have fun while learning how to use the tool :).   

## The application
The application was developed in .NET Framework 4.5 as a windows forms application. I used text files for generating the logs during the game. The few images that I used, I've found on the Internet, and I appologize that I didn't reference the authors here, because I have forgot from where I have downloaded.   

## Rules
In our version of Mafia that we've played we have 4 different groups:
- Mafia (the ones who could kill someone)
- Police (they have ability to check player if it is mafia or not)
- Doctor (has ability to heal someone if previously is shoot by the mafia)
- Ordinary people (they don't have any abilities, they can only vote at the end of the day)   

The storyteller must lead the game. The game starts at night when the mafia makes its first murder. The next day the storyteller breaks the news and the players start discussing to find out who the possible mobster is and vote him out of the game. After the vote, the city goes to sleep, and the mobsters wake up again and shoot at a player, then the police wakes up and can show one of the players (the storyteller is only obliged to confirm to them if he is really a mafia or not) and the doctor can heal himself or to heal someone else. The game ends when all the mobsters are voted out (then the town wins) or when the police and the doctor are voted out (then the mafia wins).   

## GIF demo of the application
![MafiaRandomGenerator](https://github.com/tashkoskim/Mafia_Random_Generator/blob/main/Mafia_random_generator/GifDemo/Mafia_Random_Generator.gif?raw=true)  


## Documentation
I have wrote a manual on Macedonian about the main functionality of the tool. Also there are a lot of screenshots about the different messages that pop up during the game.  
- [PDF_Manual](https://github.com/tashkoskim/Mafia_Random_Generator/blob/main/Mafia_random_generator/Manual/%D0%9C%D0%B0%D1%84%D0%B8%D1%98%D0%B0%20RANDOM%20%D0%B3%D0%B5%D0%BD%D0%B5%D1%80%D0%B0%D1%82%D0%BE%D1%80.pdf)


## Authors
- tashkoskim@yahoo.com



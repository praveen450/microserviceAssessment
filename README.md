# Microservice:
Microservice application is developed with the requirement from https://github.com/jwo/microservice-assessment </br>
</br>

1. Run the MatchResultWebApi solution which is developed with Asp.NetCore Web Api from MatchResultWebApi folder.
 </br>
2. Then run the LeaderBoardSummary solution which is developed with Asp.Net Core MVC. from LeaderBoardSummary folder.</br>
</br>
</br> <b> Web Api: </b> </br>
</br>GET: http://localhost:53773/api/leaderboard  "Return all the leaderboard details"</br>
</br>GET: http://localhost:53773/api/leaderboard/1  "Return id '1' leaderboard details" </br>
</br>GET: http://localhost:53773/api/match  "Return all matches"</br>
</br>POST : http://localhost:53773/api/leaderboard/reset  "To Clear Leaderboard Summary and All Matches</br>
</br>POST : http://localhost:55641/api/match  "To Start Match"</br>
</br>PUT : http://localhost:55641/api/match/[:id]  "To Choose the Winner"</br>


</br> <b> Leaderboard Summary and Matches:</b> </br>
![leaderboard-1](https://user-images.githubusercontent.com/43896941/46566844-eafb2f00-c8eb-11e8-99b7-097e31cb07b9.PNG)

</br> <b> Start the Match: </b> </br>
![play match](https://user-images.githubusercontent.com/43896941/46566850-0ebe7500-c8ec-11e8-94a0-f0491b1aeedc.PNG)

</br> <b> Choose Winner: </b> </br>
![choose winner](https://user-images.githubusercontent.com/43896941/46566854-2dbd0700-c8ec-11e8-99d7-6dbdd3a2b6eb.PNG)

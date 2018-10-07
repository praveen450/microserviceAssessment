# Microservice:
Microservice application is developed with the requirement from https://github.com/jwo/microservice-assessment </br>
</br>
1. Run the MatchResultWebApi solution which is developed with Asp.NetCore Web Api from MatchResultWebApi folder.</br>
2. Then run the LeaderBoardSummary solution which is developed with Asp.Net Core MVC. from LeaderBoardSummary folder.</br>
</br>
</br> <b> Web Api: </b> </br>

</br><b>GET: http://localhost:53773/api/leaderboard </b> "Return all the leaderboard details" </br>

![capturems1](https://user-images.githubusercontent.com/43896941/46577315-64f1ed80-c9aa-11e8-944c-3d5261742efd.PNG)

</br><b>GET: http://localhost:53773/api/leaderboard/1 </b> "Return id '1' leaderboard details" </br>
![capturems2](https://user-images.githubusercontent.com/43896941/46577282-11cb6b00-c9a9-11e8-9c9f-27bcdff626ee.PNG)

</br><b>GET: http://localhost:53773/api/match </b> "Return all matches"</br>
![capturems3](https://user-images.githubusercontent.com/43896941/46577286-2871c200-c9a9-11e8-9055-7167468485c6.PNG)

</br><b>POST : http://localhost:55641/api/match </b> "To Start Match"</br>
![capturems4](https://user-images.githubusercontent.com/43896941/46577289-4b03db00-c9a9-11e8-980b-37adf8c0ca05.PNG)

</br><b>PUT : http://localhost:55641/api/match/[:id] </b> "To Choose the Winner"</br>
![capturems5](https://user-images.githubusercontent.com/43896941/46577294-5bb45100-c9a9-11e8-9fd0-9e5ba86a5340.PNG)

</br><b>POST : http://localhost:53773/api/leaderboard/reset </b> "To Clear Leaderboard Summary and All Matches</br>
![capturems6](https://user-images.githubusercontent.com/43896941/46577296-6a026d00-c9a9-11e8-8705-acf2cea07541.PNG)

</br> <b> Leaderboard UI:</b> </br>
</br> <b> Leaderboard Summary and Matches:</b> </br>
![leaderboard-1](https://user-images.githubusercontent.com/43896941/46566844-eafb2f00-c8eb-11e8-99b7-097e31cb07b9.PNG)

</br> <b> Start the Match: </b> </br>
![play match](https://user-images.githubusercontent.com/43896941/46566850-0ebe7500-c8ec-11e8-94a0-f0491b1aeedc.PNG)

</br> <b> Choose Winner: </b> </br>
![choose winner](https://user-images.githubusercontent.com/43896941/46566854-2dbd0700-c8ec-11e8-99d7-6dbdd3a2b6eb.PNG)

</br><b> After Leaderboard and Matches Reset: </b> </br>
![after reset](https://user-images.githubusercontent.com/43896941/46577303-91593a00-c9a9-11e8-9637-01e61114bc47.PNG)

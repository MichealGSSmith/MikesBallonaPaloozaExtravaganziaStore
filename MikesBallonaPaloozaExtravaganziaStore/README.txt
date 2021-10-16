Mikes Readme


2021-10-14

1111am - Just created the project
1112am- Just add this readme.txt file to application and add comments in READMe on GIthub to let people know about this readme
1113am- Doing the test run on the application to see if it starts up for the first time correctly
1115am-Tested the App and it worked, so now its time to really be creating some stuff!!!
1118am- Going to create the controllers needed
1135am- just finished the controller, i think we will see how that works out from here on, now we are moving on to the View section.
1136- smoke break....
1149am- back from my smoke break...hope the boss doesnt get mad i took longer for my smoke....
1150am- now its time to get the View done
1152am- Changed the Index code in the BallonsController file to return Veiw()
1220pm- That took way longer than i was trying to have that take, i had an issue because i named the Views/Ballons abd it was looking for View/Ballon since thats how i had it written in controller...
1246pm- We finished the view, and i am starting to realize that i spelt something wrong creating this...Balloons not Ballon... this is causing me a bunch of errors, now im starting to see the issue now, but it was hard to see at first.
1247-Smoke break then we moving on to model LETS GOOOOOOO!!
1255- We beack its time for the model!!
1322- We have been working on the model adding the nuget packages but got an error More than one DbContext was found. Specify which one to use. Use the '-Context' parameter for PowerShell commands and the '--context' parameter for dotnet commands.
it says the build was suyccessful but has that error after... asking andrew...
1327- emailed andrew for some advice about that weird issue i was having, but i went ahead and tried to run the app and it worked, clicked the sites name and it went to the BALLOONS are HERE page....
1354- we have came to a roadblock i cant get past, when i got to the SQL observation tabs, it only shows my last project Movie but not this project
1354-waiting for email back from Andrew, we will go for a shower right now instead..
1433- going to get my student card brb!
1533- and we are back, still no response from andrew, maybe he used teams, ill try him on that!
1615- So.... we are dumb.... We figured it had to do something with the migration step, and we did mess it up bad. Add-Migration InitialCreate -Context [name of the app] in my case i had to add MikeBallonaPaloozaExtravaganziaStoreContext.
1615- Con't: When we updat the DB we have to add the same -Context as well.
1616- No we are doing th e Database step, i am able to see the Database using the Server Object Explorer!
1617- time to continue!!!!!
1618- Made the SeedData Class in the Models folder
1619- Starting to seed the database.
1625- VS19 is acting up everytime i copy and paste a new Balloons it acts up and makes it look nested to the other one...
1645- Smoke breakk seeding is taking for every but we good! 4 more to go , thanks for asking for 10!!!!
1945- we are finding some sweet jams to listen to!
2000- we got some beats now lets finish seeding the data
2013- Finished Seeding the Data no on to the seed initializer
2032- well we were almost there but i am having an issue inmy Ihostbuilder, down in the UseStartup<StartUp> the startup is not found... on the hunt
 
2021-10-15

1705- in php but im going to work on this. I am going to check what i have done, and keep going.
1710- i have checked my folder, and i just finished seeding the database, now im moving onto the controller methods and views.
1811- we have been working on the search functionality. I have gotten to the point where im going to add some UI so the client can just search instead of using URL.
2045- back from class ready to keep going, i think we are getting close to setting up the css and finishing touches!
2113- i just added a css file in my css folder and linked it in the _layout.cshtml file, i hope now i can write some css and it show up.
2233- I spent way to much time doing css, and getting the second page made, but we are up and rolling got some new fonts and added an about us page.
2234- back to the actual steps of finishing this assignment!
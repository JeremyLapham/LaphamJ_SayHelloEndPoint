# LaphamJ_SayHelloEndPoint

//Jeremy Lapham
//10-25-22
//Say Hello -Endpoint
//This program says what's up to the user
//Peer review: Reed Goodwin- Functions as ntended with no errors, good UI and nicely coded!

So if you want to run this program we will be using Postman and you will be I assume at least if you're seeing this that you're also on my GitHub so you'll go to the green code button and copy the URL down

So once you have it copied down go to a new VS code. Once it is open click on the thingy that says "Clone Git repository..." now a place to put a URL will open and you will copy the link from GitHub to there

Then hit enter. 
Now it'll open up your files. If you have a folder for things like this perfect, if not create a new folder and then select that folder for your location of github stuff.
A thing will pop up just click open and it'll open up all the code.

Once the code is open go to the top of your screen and go to the run thing at the top. Click on run and then click on Start Debugging

Now it should have opened up a tab saying local host not found. Go to the URL and copy it 

Now go to post man and paste that local host thing into where you put a URL in Postman

Now go to the code and look at the controller name and the Route.
after the local host type in the controller name without the word "controller" after the name there will be a backslash.
after the backslash it should be the route name followed by another backslash then after you should be able to type in whatever you want and the program will run as long as there are no more backslashes.
                                          
should look like:         https://localhost:7031/sayhello/sayhello/jeremy
                                                 /\       (Route)  (anyword)
                                                 |
                                        (controller name)

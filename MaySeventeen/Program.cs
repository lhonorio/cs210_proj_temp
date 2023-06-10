Player neymar = new Player("Neymar Jr.", 10, "Forward");

// neymar._name = "Neymar Jr.";
// neymar._position = "Forward";
// neymar._jerseyNumber = 10;

Player kobe = new Player("Kobe Bryant", 24);

kobe.SetPosition("Shooting Guard");

Console.WriteLine(neymar.Display());

Team awesomeSauce = new Team("Awesome Sauce");

awesomeSauce.AddPlayer(kobe);
awesomeSauce.AddPlayer(neymar);

awesomeSauce.AddWin();
awesomeSauce.AddLoss();


awesomeSauce.DisplayRoster();

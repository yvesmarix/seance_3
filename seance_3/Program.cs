using seance_3;

var voiture1 = new Voiture();
var voiture2 = new Voiture("Rouge");
var voitur3 = new Voiture("Voiture", 200, 100);

Console.WriteLine(voiture1.Couleur);
voiture1.AddTrajet(100);
voiture1.Trajet("100miles");
Console.WriteLine(DateTime.Now.Date);

using TownBestiaryApi.Models.Animals;

namespace TownBestiaryApi.Generators;

public static class AnimalGenerator {
	public static List<Animal> Animals { get; set; }

	static AnimalGenerator() {
		Animals = new List<Animal> {
			new Animal {
				Id = 1,
				Name = "Wiewiórka szara",
				Description =
					"Występuje we wschodniej i środkowo-wschodniej części Stanów Zjednoczonych oraz na " +
					"południowo-wschodnim obszarze Kanady. Introdukowana we Włoszech, Irlandii i Wielkiej Brytanii. Gatunek inwazyjny",
				Environment = "Nizinne lasy liściaste",
				Feeding = "",
				Photo = "https://upload.wikimedia.org/wikipedia/commons/a/a1/Black_squirrel_in_Santa_Clara_CA.jpg",
				Population = Population.Medium
			},
			new Animal {
				Id = 2,
				Name = "Wiewiórka pospolita",
				Description = "Sciurus vulgaris - Tułów wraz z głową wiewiórki pospolitej osiągają łącznie długość 20–24 cm, ogona 17–20 cm, przy masie ciała 200–300 gramów. Zwierzę charakteryzuje się ubarwieniem zmiennym.",
				Environment = "",
				Feeding = "",
				Photo = "https://upload.wikimedia.org/wikipedia/commons/0/02/Eichh%C3%B6rnchen_D%C3%BCsseldorf_Hofgarten_edit.jpg",
				Population = Population.Medium
			},
			new Animal {
				Id = 3,
				Name = "Kuna domowa",
				Description = "Martes foina – synantropijny gatunek niewielkiego ssaka drapieżnego z rodziny łasicowatych. " +
				              "Występuje w niemal całej Europie oraz w strefie klimatu umiarkowanego Azji, aż po Himalaje i Chiny.",
				Environment = "W Polsce występuje na całym obszarze kraju, zwykle w okolicach ludzkich siedzib, ruinach, lasach, a także w centrach dużych miast. ",
				Feeding = "",
				Photo = "https://upload.wikimedia.org/wikipedia/commons/thumb/a/a0/Beech_Marten.jpg/1280px-Beech_Marten.jpg",
				Population = Population.Small
			},
			new Animal {
				Id = 4,
				Name = "Kaczka krzyżówka",
				Description = "Anas platyrhynchos – gatunek dużego ptaka wodnego z rodziny kaczkowatych. Jest to " +
				              "najpospolitszy i najszerzej rozpowszechniony gatunek kaczki[7]. Zasiedla większość półkuli " +
				              "północnej, ale została introdukowana do południowo-wschodniej Australii oraz na Nową Zelandię. " +
				              "Nie jest zagrożona.",
				Environment = "Ptak wodny",
				Feeding = "",
				Photo = "https://zwierzeta.geographicforall.com/wp-content/uploads/2021/04/kaczka-krzyzowka.jpg",
				Population = Population.Large
			},
			new Animal {
				Id = 5,
				Name = "Bóbr europejski",
				Description = "Castor fiber – gatunek ziemno-wodnego gryzonia z rodziny bobrowatych (Castoridae). " +
				              "Uważa się go za największego gryzonia Eurazji: masa ciała dorosłego osobnika dochodzi do " +
				              "29 kg, a długość ciała do 110 cm. Jest zwierzęciem silnie terytorialnym, rodzinnym i " +
				              "zasadniczo monogamicznym; wiedzie nocny tryb życia.",
				Environment = "Gatunek ziemno-wodny",
				Feeding = "",
				Photo = "https://upload.wikimedia.org/wikipedia/commons/9/9e/Castor_fiber_vistulanus2.jpg",
				Population = Population.Large
			},
			new Animal {
				Id = 6,
				Name = "Jeż",
				Description = "Jeż jest samotnikiem łączącym się w pary tylko na okres godów. " +
				              "Jest świetnym pływakiem i wspinaczem. Podobno kiedyś znaleziono jeża w kieszeni spodni " +
				              "powieszonych na sznurku kilkadziesiąt centymetrów nad ziemią. Ale jego główną domeną są nocne wędrówki." +
				              " Potrafi przebyć nawet 2 kilometry w ciągu jednej nocy.",
				Environment = "Gatunek ziemno-wodny",
				Feeding = "",
				Photo = "https://upload.wikimedia.org/wikipedia/commons/e/e1/Erinaceus_europaeus_LC0119.jpg",
				Population = Population.Medium
			},
			new Animal {
				Id = 7,
				Name = "Sowa",
				Description = "Sowy to ciągle mało znane, tajemnicze i niezwykłe ptaki. Choć nie cieszą się specjalną" +
				              " sympatią ludzi, są jedną z najciekawszych grup ptasiego świata. Mają szereg subtelnych " +
				              "barw, kształtów i imponujących przystosowań do widzenia w nocy, doskonałego słyszenia" +
				              " czy bezszelestnego latania.",
				Environment = "Ptak",
				Feeding = "",
				Photo = "https://upload.wikimedia.org/wikipedia/commons/9/97/Waldohreule_in_freier_Wildbahn.jpg",
				Population = Population.Medium
			},
		};
	}
}
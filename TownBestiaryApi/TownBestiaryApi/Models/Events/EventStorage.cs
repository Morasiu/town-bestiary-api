namespace TownBestiaryApi.Models.Events;

public class EventStorage {
	public static ICollection<Event> CityEvents { get; } = new List<Event> {
		new() {
			Title = "Zbiórka na karminiki dla kaczek!",
			Description = "I Ty możesz pomóc kaczkom przetrwać zimę! Kaczki nie lubią chleba. Powinno się je karmić " +
			              "najlepiej specjalną karmą. Pomóż nam zebrać 2000 zł!",
			PhotoUrl = "https://d-art.ppstatic.pl/kadry/k/r/1/4f/bd/5e3540a40d4af_o_large.jpg"
		},
		new() {
			Title = "Marsz jamników 2021",
			Description = "Miłośnicy i sympatycy jamników już po raz 25. spotkaja się w Krakowie, aby w samo " +
			              "południe przejść w radosnym i rozmerdanym pochodzie spod Barbakanu na Rynek Główny. 26 " +
			              "„Marsz jamników zorganizowany przez Radio Kraków i Krakowskie Biuro Festiwalowe, wyruszy " +
			              "w samo południe wraz z pierwszymi dźwiękami hejnału, a na Rynek poprowadzi go marszowym " +
			              "krokiem Orkiestra Wieniawa.",
			PhotoUrl = "https://www.radiokrakow.pl/data/article/1121767/43fbb059e7e9ed3c1ae12fc79d65b042.jpg"
		},
		new() {
			Title = "Parada smoków",
			Description =
				"Spektakularne widowisko, podczas którego można zobaczyć unoszące się nad rzeką i pływające " +
				"na barkach wielkie smoki, od lat gromadzi tłumy krakowian i gości. Tegoroczne widowisko " +
				"odbędzie się po rocznej przerwie spowodowanej pandemią i będzie miało wyjątkowy, jubileuszowy charakter." +
				" Smoki zawładnęły Krakowem 11 września. 21. Wielką Paradę Smoków uatrakcyjnią pokazy laserowe, " +
				"a także specjalna oprawa muzyczna.",
			PhotoUrl = "https://plikimpi.krakow.pl/zalacznik/397155/4.jpg",
		},
		new() {
			Title = "Kto pocieszy pechowego nosorożca?",
			Description =
				"Lech Walicki na podstawie opowiadania „Kto z was chciałby rozweselić pechowego nosorożca?” Leszka Kołakowskiego. Reżyser Lech Walicki sięgnął po bajkę napisaną w latach 60. XX wieku przez wybitnego polskiego filozofa Leszka Kołakowskiego dla jego kilkuletniej wówczas córki Agnieszki. Pełna humoru historia nosorożca, który bardzo chciał latać, bawi do łez, a zarazem uczy, że nie tylko warto stawiać czoła własnym niedoskonałościom, ale i należy brać odpowiedzialność za własne marzenia.",
			PhotoUrl = "https://s.lubimyczytac.pl/upload/books/60000/60607/352x500.jpg",
		},
		new() {
			Title = "Kantor tu jest – spacer dźwiękowy po Krakowie",
			Description =
				"Kantor tu jest” to dźwiękowy spacer, w którym po Krakowie prowadzą nas komentarze Tadeusza Kantora. Wojciech Kiwer stworzył kompozycję na elektronikę, dźwięki miasta i dwa głosy. Kompozycję rozpisaną na tkankę miejską, ulice Krakowa i kroki przechodniów. Punktem wyjścia do utworu było Archiwum Cricoteki. Wybrane z niego wywiady i konferencje prasowe Tadeusza Kantora (głównie z lat 80.) stały się bazą do przygotowania dźwiękowej opowieści o Krakowie tu i teraz. ",
			PhotoUrl =
				"https://bi.im-g.pl/im/6b/7b/16/z23574891V,Rodzinny-spacer-dzwiekowy-w-Ogrodzie-Saskim--Z-pra.jpg",
		},
		new() {
			Title = "Świat gadów",
			Description =
				"Wystawa łączy w sobie świat gadów kopalnych z żyjącymi współcześnie. Tą interesującą gromadę zwierząt zaprezentowano w kilku modułach wystawowych, w podziale na obszary występowania, w scenerii znakomicie oddającej ich środowisko naturalne.",
			PhotoUrl = "http://www.bialystokonline.pl/gfx_prezentacje/kat/16545/15243_16545.jpg",
		},
		new() {
			Title = "Ogród Nadziei",
			Description =
				"Ogród Nadziei na Bulwarach Wiślanych przy ul. Podgórskiej powstał w 2017 roku dzięki Hedvie Ser, urodzonej w Izraelu francuskiej malarce i rzeźbiarce uhonorowanej w 2011 roku tytułem Artystki UNESCO na rzecz Pokoju. Uroczyste otwarcie odbędzie się podczas trwającej w Krakowie 41. sesji Komitetu Światowego Dziedzictwa UNESCO.",
			PhotoUrl = "https://bi.im-g.pl/im/07/06/15/z22047239V,Otwarcie-Ogrodu-Nadziei.jpg",
		},
		new() {
			Title = "Świat łowców mamutów. Paleolit – przyroda i sztuka",
			Description =
				"Ekspozycja stała przedstawiająca kopalne szczątki wymarłych zwierząt należących do tzw. megafauny plejstoceńskiej. Na wystawie można zobaczyć jedynego na świecie zachowanego w całości, wraz ze skórą i tkankami miękkimi nosorożca włochatego liczącego ok. 30 tysięcy lat. Obok prezentowane są również kopalne szczątki mamutów i niedźwiedzia jaskiniowego. W sąsiedniej sali zaprezentowano Stanowisko Kraków Spadzistą. Jest to jedno z najważniejszych stanowisk archeologicznych w Europie i na świecie pod względem ilości nagromadzonych kości i zębów mamuta. Powstałe około 25 tysięcy lat temu jest dla archeologów także jednym z najważniejszych stanowisk kultury graweckiej w Europie. Całość ekspozycji wzbogacono w oprawę multimedialną.",
			PhotoUrl = "http://media.krakow.travel/photos/27728/xxl.jpg",
		}
	};
}
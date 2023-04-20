using Microsoft.Win32.SafeHandles;
using Negozio;


Shop negozioBologna = new Shop("Negozio Bologna", "Bologna", "Italia", "Via Zanardi", 33, "Pino La Lavatrice");

Shop negozioMilano = new Shop("Negozio Milano", "Milano", "Italia", "Via Aldo Rossi", 8, "Jerry Cardinale");




Prodotti bottigliaAcqua = new Prodotti("Bottiglia d'acqua naturale", "Bevanda", "Bottiglia d'acqua semplice", 2);



Bevande acquaLilia = new Bevande("Bottiglietta d'acqua Lilia", "Bevande", "Bottiglietta d'acqua da 0,5L naturale", 1, 0.5f, 7, "Rubinetto", "Lilia", "Naturale", "Plastica");
Bevande cocaCola = new Bevande("Lattina Coca Cola", "Bevande", "Lattina Coca Cola piccola", 3, 0.33f, 9999, "ahahaha", "Coca Cola", "Frizzante", "Alluminio");



Frutta sacchettoFrutta = new Frutta("Sacchetto di Frutta", "Cibo", "Sacchetto di Frutta in pezzi", 3);



Elettrodomestico frigorifero = new Elettrodomestico("Frigorifero Indesit", "Elettrodomestici", "Frigorifero grande", 299, "Indesit", 100, 2023);
Elettrodomestico televisore = new Elettrodomestico("Televisore Samsung", "Elettrodomestici", "Televisore 4K 50 pollici Oled Samsung", 499, "Samsung", 8, 2023);



CiboInScatola fagioliInScatola = new CiboInScatola("Fagioli borlotti", "Cibo", "Lattina di fagioli borlotti", 4, 200, "Saclà");



List<Prodotti> prodottiNegozioBologna = new List<Prodotti> { bottigliaAcqua, acquaLilia, fagioliInScatola };
List<Prodotti> prodottiNegozioMilano = new List<Prodotti> { cocaCola, sacchettoFrutta, frigorifero, televisore };


negozioBologna.productToAdd(prodottiNegozioBologna);
negozioMilano.productToAdd(prodottiNegozioMilano);


Console.WriteLine(negozioBologna.ShopInfoList());
Console.WriteLine(negozioMilano.ShopInfoList());





fagioliInScatola.MangiaCibo();
fagioliInScatola.SvuotaScatola();
fagioliInScatola.RiempiScatola();


cocaCola.Bevi();
cocaCola.Riempi();
cocaCola.SvuotaBevanda();


sacchettoFrutta.MangiaFrutta();
sacchettoFrutta.SvuotaSacchetto();
sacchettoFrutta.RiempiSacchetto();

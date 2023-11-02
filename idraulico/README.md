Questo programma usa le function per gestire un vettore di structure.

NOTE IMPORTANTI: 

se una function usa esclusivamente il vettore non deve visualizzare messaggi
le function accedono al vettore come variabile globali (niente parametri).
Problema: Un idraulico registra ogni giorno gli interventi e i totali incassati nei vari giorni del mese, ad esempio:

Giorno     Intervento                    Incasso
1               Riparazione                   150
1               Installazione boiler         320
2               Riparazione                   120
e così via.

Il programma permette di eseguire le seguenti operazioni:

inserire una registrazione, chiamando:
- una function datiCorretti che restituisce true se tutti i dati sono corretti, oppure false se almeno uno è errato; in questo caso visualizza il messaggio di errore corrispondente
- una function leggiDati che legge i dati dal form (già controllati con datiCorretti) e li copia in una structure (la structure è il parametro)
- una function inserisci che inserisce la structure nel vettore (sono solo 2 istruzioni e la structure è il parametro);

dato un tipo di intervento, visualizzare l'incasso massimo per quel tipo di intervento e i giorni (possono essere più d'uno) in cui è stato ottenuto, chiamando:
- una function incassoMassimo che restituisce il valore dell'incasso massimo (che succede se il vettore è vuoto?)
- una function visRegistrazioni che riceve come parametro il valore di un incasso e visualizza in una combobox le registrazioni corrispondenti;

dato un tipo di intervento visualizzare la media degli incassi per quel tipo, chiamando una function che riceve come parametro il tipo di intervento e restituisce la media;

dato un giorno, visualizzare in una combobox tutti gli interventi di quel giorno, chiamando una function appropriata.

Aggiunta: il programma dovrebbe controllare che quando si registra un intervento il giorno sia maggiore o uguale dell'ultimo inserito.
Fate un ipotesi su come si potrebbe eseguire il controllo. Idea: scrivere una function?

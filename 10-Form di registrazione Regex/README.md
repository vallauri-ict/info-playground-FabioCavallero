# info-playground-fabio-cavallero

_Stud. Fabio Cavallero_

###### Regex

Realizzare una Form di registrazione gestita con le regex contenente i seguenti campi:
-cognome
-nome
-indirizzo
-città
-cap (5 caratteri numerici)
-mail (formato mail)
-cod fisc (formato corretto)
-user
-pwd (almeno 8 caratteri con almeno 1 numero e almeno 1 maiuscola) Al click sul pulsante registra se è tutto ok allora salvo i dati su un file in formato json

Integrazione della form:
per creare la stringa in formato Json utilizzare l’override del metodo ToString().
creare una classe Utenti istanziabile una volta sola (singleton) contenente una Lista che viene valorizzata con i dati contenuti nel file.
Le nuove registrazioni possono avvenire solo se l’utente (campo user) non è presente nella lista. Per realizzare il punto precedenteè stato costruito un metodo bool presente() che ricerca se lo user esiste già e restituisce un bool.

# info-playground-fabio-cavallero

_Stud. Fabio Cavallero_

###### Join
- Inizialmente sono state create due tabelle **Continenti** (ID e nome) e **Nazioni** (nome e codContinente)
- Con una prima **query: SELECT * FROM Continenti,Nazioni** è stato fatto un prodotto tra le due tabelle. E' stata creata una terza tabella con tutte le possibili combinazioni tra nazioni e continenti
- Per ottenere il risultato voluto (associare ad una nazione il rispettivo continente) è stata usata la **query: SELECT * FROM Nazioni,Continenti WHERE Continenti.nome = Nazioni.codContinente**
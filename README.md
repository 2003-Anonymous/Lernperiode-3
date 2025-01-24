# Lernperiode-3

Datum

## Grob-Planung

Ich möchte ein kleines WinForms-Programm erstellen, in dem man TicTacToe spielen kann.

- [x] Ein Feld aus Buttons erstellen
- [x] Wenn man einen Button anklickt, erscheint ein X
- [x] Hinzufügen, dass jedes zweite mal ein O kommt
- [x] Hinzufügen, dass ein Fenster erscheint, wenn man gewonnen hat

Ich habe ein TicTacToe Feld erstellt mit Buttons. Wenn man einen Button anklickt, erscheint ein X und jedes zweite mal ein O. Oben am Feld wird der Spieler, welcher gerade am Zug ist, angezeigt. Ich habe noch 2 Buttons gemacht. Mit dem einten kann man das Spiel schliesen und mit dem anderen die Runde neu starten.

## 17.01.25

- [ ] Den Code verkürzen
- [ ] Flexible Felder programmieren
- [ ] Den ganzen Code Flexibel machen

Heute habe ich die einzelnen Buttonfunktionen auf eine einzige Funktion reduziert, die bei allen Buttons aufgerufen wird. Dann habe ich noch hinzugefügt, dass man das Spielfeld auf 4x4 und 5x5 vergrössern kann. Auf diesen Feldern kann man schon spielen aber es wird noch nicht erkannt, ob man gewonnen hat. Das muss ich noch hinzufügen.

## 24.01.25

- [ ] Die Funktion, welche schaut, ob man gewonnen hat, noch erweitern, sodass sie bei allen grössen funktioniert.
- [ ] So erweitern, dass es egal ist, wie gross das Feld ist. (Gewinnkombinationen selbst ermitteln)
- [ ] Das Dessign verbessern, weil wenn man das Feld vergrössert, ist es nicht in der Mitte.

Heute habe ich die CheckWin-Funktion erweitert, sodass sie jetzt funktioniert. Zudem habe ich noch hhinzugefügt, dass man am Anfach eine Feldgrösse auswählt. Während der Auswahl von der Grösse sind die Buttons in der Mitte und gehen nach der Auswahl nach ausen. Dann werden auch noch die Anderen Buttons sichtbar. Jetzt kann man auch die Feldgrösse auch wieder verkleinern z.B. von 5x5 auf 3x3.

# Beschreibung Projekt

Ich habe ein TicTacToe programmiert. Zuerst gelangt man in eine Benutzeroberfläche, wo man einen Button mit der Aufschrift "TicTacToe" klicken kann. Dieser öffnet ein neues Fenster, wo man die Feldgrösse auswählen kann. 3x3, 4x4 oder 5x5. Nach der Auswahl erscheint ein Spielfeld mit der gewählten grösse. Die Grösse kann man links mit Buttons später auch noch verändern. Dort hat es auch noch einen Button, um das Spiel zurückzusetzten und einen, um wieder zur Startseite zurückzukehren. Oben steht immer, welcher Spieler am Zug ist und das Programm merkt automatisch, wann ein Spieler gewonnen hat oder das gesammte Feld ausgefüllt ist. Dann ploppt ein Fenster auf, in dem der Gewinner steht oder das Unentschieden ist.



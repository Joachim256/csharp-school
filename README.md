# Úkol 3
> ... budou vytištěna všechna tři čísla v pořadí od největšího po nejmenší ...

Nakonec jsem implementoval řadicí algoritmus, který lze vyhledat pod názvem *Max sort*.

Funguje na principu, kdy z vstupního pole je vždy nalezen prvek s nejvyšší hodnotou a je zařazen nakonec výstupního pole. 
(Pro zjednodušení jsem daný prvek ve vstupním poli nahradil hodnoutou `int.MinValue`, která bude vždy přeskočena jako `≤ nejvetsi`)

Co se týče jednoduchosti, řekl bych, že jde o jeden z nejjednodušších řadicích algoritmů co do pochopení i implementace.
Naopak efektivitou je zaručeně mezi nejhoršími (když nepočítáme Bogosort):

O(n²), Ω(n²)

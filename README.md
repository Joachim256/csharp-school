# Úkol 5
> ... budou vytištěna všechna tři čísla v pořadí od největšího po nejmenší ...
> ... aby měl co nejméně podmínek (méně než 5) ...

Tentokrát jsem implementoval bezcyklovou variantu řadicího algoritmu, který je známý pod názvem *Bubble sort*.

Funguje tak, že porovnáváme první a druhé číslo, a pokud jsou v nesprávném pořadí, tak je prohodíme. Následně provedeme to stejné s druhým a třetím číslem. Jako poslední porovnáme a popř. prohodíme opět první a druhé číslo. Tímto docílíme seřazení 3 čísel. 

Prohození čísel v mém programu dosáhnu algoritmem zvaným *XOR swap*. Využívá bitové operace XOR a na rozdíl od tradičního prohazování nevyžaduje dočasnou proměnnou. 

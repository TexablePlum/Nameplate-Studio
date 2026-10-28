# Nameplate Studio

![C#](https://img.shields.io/badge/C%23-.NET-512BD4?logo=dotnet&logoColor=white)
![WPF](https://img.shields.io/badge/UI-WPF-0C54C2?logo=windows&logoColor=white)
![Status](https://img.shields.io/badge/status-in%20progress-orange)

## Wprowadzenie do tematu

W branży zajmującej się produkcją stolarki aluminiowej każdy wyrób o deklarowanych właściwościach przeciwpożarowych musi być wyposażony w dedykowaną tabliczkę znamionową, zawierającą jego charakterystyczne cechy i parametry. Tabliczki te muszą być odporne na uszkodzenia mechaniczne i chemiczne, a przede wszystkim na długotrwałe oddziaływanie wysokiej temperatury. Muszą też zawierać jasno określone informacje o produkcie wymagane prawem krajowym i unijnym. Jedną z metod wytwarzania takich tabliczek jest grawerowanie wymaganych informacji na metalowych blaszkach wykonanych z aluminium, mosiądzu lub stali nierdzewnej.

## Problem i potrzeba

Firma, dla której powstaje ta aplikacja, do tej pory zlecała produkcję tabliczek zewnętrznemu wykonawcy. Takie rozwiązanie działało, ale miało kilka istotnych wad takich jak: wysokie koszty, długi czas oczekiwania, brak jakiejkolwiek standaryzacji procesu oraz samych tabliczek wewnątrz firmy.

Dane do produkcji były przygotowywane ad hock w formie tabelki w Wordzie. W efekcie wygląd kolejnych tabliczek zależał od tego, jak została narysowana dana tabela. Poszczególne produkty różniły się układem, wielkością tekstu i sposobem prezentowania informacji. Taki proces determinował błędy takie jak literówki czy braki oraz przekłamania wymaganych danych.

Rozpoczęto poszukiwania rozwiązania, które pozwoliłoby całkowicie przenieść ich produkcję do firmy i ostatecznie wybrano grawer laserowy IR. Rozwiązało to problem zależności od zewnętrznego wykonawcy, ale jednocześnie stworzyło następny, ponieważ każdą tabliczkę oraz całą matrycę produkcyjną trzeba od tej pory przygotować samemu. Przy zamówieniu obejmującym dziesiątki albo setki podobnych elementów, różniących się numerami i wybranymi parametrami, ręczne wykonywanie tej pracy jest nieakceptowalne.

## Rozwiązanie

Nameplate Studio powstaje po to, aby ten proces uporządkować, mocno zautomatyzować i zunifikować. Aplikacja ma pozwolić przygotowywać spójne tabliczki znamionowe, generować całe numerowalne serie, kontrolować kompletność i czytelność danych, a następnie tworzyć gotowe do druku projekty w sposób dopasowany do materiału oraz pola roboczego grawera. Dodatkowo ma być łatwa i intuicyjna w obsłudze, tak aby osoby nie techniczne mogły bez problemowo poradzić sobie z jej obsługą.

## Technologia i status

Aplikacja powstaje w języku C# z interfejsem użytkownika opartym na WPF. Projekt znajduje się obecnie na etapie planowania i projektowania funkcjonalności.

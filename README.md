# Nameplate Studio

![C#](https://img.shields.io/badge/C%23-.NET-512BD4?logo=dotnet&logoColor=white)
![WPF](https://img.shields.io/badge/UI-WPF-0C54C2?logo=windows&logoColor=white)
![Status](https://img.shields.io/badge/status-w%20budowie-orange)

## Wprowadzenie do tematu

W branży zajmującej się produkcją stolarki aluminiowej każdy wyrób o deklarowanych właściwościach przeciwpożarowych musi być wyposażony w dedykowaną tabliczkę znamionową, zawierającą jego charakterystyczne cechy i parametry. Tabliczki te muszą być odporne na uszkodzenia mechaniczne i chemiczne, a przede wszystkim na długotrwałe oddziaływanie wysokiej temperatury. Jedną z metod wytwarzania takich tabliczek jest grawerowanie wymaganych informacji na metalowych blaszkach wykonanych z aluminium, mosiądzu lub stali nierdzewnej.

## Problem i potrzeba

Firma, dla której powstaje ta aplikacja, do tej pory zlecała produkcję tabliczek zewnętrznemu wykonawcy. Takie rozwiązanie działało, ale miało kilka istotnych wad takich jak: wysokie koszty, czas oczekiwania, brak jakiejkolwiek standaryzacji procesu oraz samych tabliczek wewnątrz firmy.

Dane do produkcji były przygotowywane ad hock w formie tabelki w Wordzie. W efekcie wygląd kolejnych tabliczek zależał od tego, jak akurat została narysowana dana tabela. Poszczególne produkty różniły się układem, wielkością tekstu i sposobem prezentowania informacji. Taki proces determinował błędy takie jak literówki czy braki oraz przekłamania wymaganych danych.

Ostatecznym powodem rezygnacji z takiego rozwiązania okazało się duże i kosztowne zamówienie, które zawierało błędy popełnione jeszcze na etapie projektowania. Ze względu na jego skalę oznaczało to znaczne straty finansowe, zmarnowane zasoby i czas. Rozpoczęto poszukiwania rozwiązania, które pozwoliłoby całkowicie przenieść ich produkcję do firmy i ostatecznie wybrano grawer laserowy IR. Rozwiązało to problem zależności od zewnętrznego wykonawcy, ale jednocześnie stworzyło następny, ponieważ każdą tabliczkę oraz całą matrycę produkcyjną trzeba od tej pory przygotować samemu. Przy zamówieniu obejmującym dziesiątki albo setki podobnych elementów, różniących się numerami i wybranymi parametrami, ręczne wykonywanie tej pracy jest nieakceptowalne.

## Rozwiązanie

Nameplate Studio powstaje po to, aby ten proces uporządkować, mocno zautomatyzować i zunifikować. Aplikacja ma pozwolić przygotowywać spójne tabliczki znamionowe, generować całe numerowalne serie, kontrolować kompletność i czytelność danych, a następnie tworzyć gotowe do druku projekty w sposób dopasowany do materiału oraz pola roboczego grawera. Dodatkowo ma być łatwa i intuicyjna w obsłudze, tak aby osoby nie techniczne mogły bez problemowo poradzić sobie z jej obsługą.

## Planowane funkcjonalności

1. **Tworzenie tabliczek o dowolnym wymiarze** - fizyczny rozmiar tabliczki będzie podstawą całego projektu i nie będzie mógł zostać przekroczony przez żaden element.
2. **Konfigurowalny układ tabliczki** - dzielenie projektu na niesymetryczne pola, łączenie i rozdzielanie komórek, zmiana ich wymiarów oraz kontrola obramowań, marginesów i wyrównania zawartości.
3. **Pola wbudowane i własne** - dodawanie, usuwanie i modyfikowanie pól takich jak producent, rok produkcji, klasa odporności ogniowej, itd. a także tworzenie własnych niestandardowych pól.
4. **Obsługa tekstu i oznaczeń graficznych** - możliwość umieszczania logotypów jednostek i organizacji certyfikacyjnych .
5. **Szablony tabliczek** - zapisywanie gotowych układów dla konkretnych rodzajów wyrobów i ponowne wykorzystywanie ich w następnych zamówieniach.
6. **Tworzenie zamówień i całych serii** - przygotowywanie wielu tabliczek na podstawie jednego szablonu, z danymi wspólnymi dla całego zamówienia oraz wartościami indywidualnymi dla każdej sztuki.
7. **Automatyczna numeracja** - generowanie numerów ze wskazanego zakresu z możliwością ustawienia kroku, liczby cyfr, zer wiodących, prefiksu, sufiksu oraz własnego formatu numeru.
8. **Kontrola poprawności projektu** - sprawdzanie, czy wszystkie wymagane dane zostały uzupełnione, tekst mieści się w polach, zachowano minimalną czytelność, a elementy nie nachodzą na krawędzie lub otwory montażowe.
9. **Profile grawera i materiału** - jeżeli wybrany format projektu na to pozwala to program będzie umożliwiał zarządzanie urządzeniami wraz z ich polem roboczym oraz tworzeniem gotowych profili obróbki dla konkretnych materiałów. Profil będzie mógł przechowywać parametry grawerowania, a także rozmiary używanych arkuszy blachy; ustawienia zostaną zapisane razem z matrycą i będą gotowe do użycia po otwarciu jej w oprogramowaniu grawera.
10. **Automatyczne tworzenie matryc produkcyjnych** - automatyczne rozmieszczanie tabliczek gotowego zamówienia na jednym lub wielu arkuszach uwzględniając ograniczanie odpadu.
11. **Konfiguracja cięcia i odstępów** - możliwość dodania lub wyłączenia linii cięcia, ustawienia odstępów pomiędzy tabliczkami, marginesów od krawędzi oraz korzystania ze wspólnych linii podziału.
12. **Podgląd tabliczek i całej matrycy** - możliwość sprawdzenia każdego pojedynczego elementu, wszystkich wygenerowanych numerów oraz ostatecznego układu matrycy przed rozpoczęciem produkcji.
13. **Zapisywanie projektów i zamówień** - możliwość powrotu do wcześniejszych projektów, ponownego generowania plików oraz wykorzystania istniejących zasobów jako podstawy nowego projektu.
14. **Eksport gotowych projektów** - generowanie pojedynczych tabliczek lub kompletnych matryc do formatów uniwersalnych, takich jak SVG, a także do formatów używanych bezpośrednio przez oprogramowanie laserów.

## Dalszy rozwój
1. **Automatyczne aktualizacje** - sprawdzanie dostępności nowej wersji programu oraz instalowanie aktualizacji.
2. **Licencjonowanie** - aktywacja programu i możliwość kontrolowania liczby stanowisk korzystających z aplikacji.

## Technologia i status

Aplikacja powstaje w języku C# z interfejsem użytkownika opartym na WPF. Projekt znajduje się obecnie na etapie planowania i projektowania funkcjonalności.

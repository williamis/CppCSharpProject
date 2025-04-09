# CppCSharpProject

**C++-kirjasto (DLL), jota käytetään C#-sovelluksessa**

Tämä ohjelma demonstroi, kuinka C++:lla tehty ohjelmakirjasto (DLL) voidaan käyttää C#:ssa.

## Mitä tämä tekee?

Yksinkertaisesti:
- C++ hoitaa laskennan tai muun toiminnon
- C# kutsuu C++-funktioita ikään kuin ne olisivat sen omia

## Käytännössä

1. **C++-koodi käännetään** DLL-tiedostoksi (`Backend.dll`)
2. **C#-sovellus käyttää** `DllImport`-määritystä ottaakseen sen käyttöön
3. C# voi sitten **kutsua C++-funktioita** suoraan

---

## Projektin rakenne

- **Backend/** – C++-koodi, josta luodaan DLL
- **Frontend_HtmlCss/** – (valinnainen) käyttöliittymän HTML/CSS
- **MyProject.sln** – Visual Studio -ratkaisutiedosto

---

## Käyttöohjeet

### 1. Käännä C++-DLL

- Avaa `Backend` Visual Studiossa
- Käännä (Debug/Release)
- Tulos: `Backend.dll`

### 2. Käytä DLL:ää C#-sovelluksessa

- Kopioi `Backend.dll` C#-projektin `bin/Debug`-kansioon
- Lisää C#-koodiin:

```csharp
[DllImport("Backend.dll")]
private static extern int YourFunctionName();

3. Suorita ohjelma
* Avaa MyProject.sln
* Aseta C#-projekti käynnistetväksi
* Suorita ja testaa.
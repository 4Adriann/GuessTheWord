# Guess the Word

Ett ordspel i konsolen skrivet i C#. Spelaren ska gissa ett slumpat ord med hjälp av ordets bokstäver i blandad ordning.

## Så funkar spelet

- Ett ord slumpas fram ur en ordlista.
- Du ser bokstäverna i blandad ordning, och en bokstav i ordet är redan avslöjad.
- Du har 5 försök på dig. Vid varje fel gissning visas en ny bokstav som ledtråd.
- Gissar du rätt vinner du. Tar försöken slut visas det rätta ordet.

## Tekniker

- C# och .NET 10
- Objektorienterad programmering med klasser och inkapsling
- `WordGame` sköter spellogiken: försök, ledtrådar och jämförelse av gissningar oavsett stora eller små bokstäver
- `WordStorage` håller ordlistan och slumpar fram ett ord
- Fisher–Yates-algoritmen blandar bokstäverna

## Kör projektet

Du behöver [.NET 10 SDK](https://dotnet.microsoft.com/download).

```bash
git clone https://github.com/4Adriann/GuessTheWord.git
cd GuessTheWord/GuessTheWord
dotnet run
```

## Möjliga förbättringar

- Låta spelaren spela igen efter en runda
- Kontrollera tom inmatning
- Fler ord eller svårighetsgrader

---
Skolprojekt, Fullstackutvecklare .NET, Chas Academy (2026)

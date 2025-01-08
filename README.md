# Online Store

Online Store to aplikacja webowa zaprojektowana w technologii ASP.NET Core 8.

## Funkcjonalności

### Dla użytkowników niezalogowanych i zalogowanych
- Przeglądanie listy dostępnych produktów.
- Podgląd szczegółowych informacji o wybranym produkcie.

### Dla administratorów
- Rozbudowane narzędzia do zarządzania asortymentem:
  - Dodawanie nowych produktów.
  - Modyfikowanie istniejących produktów.
  - Usuwanie produktów z bazy.
  - Organizowanie produktów w kategorie.

## Jak uruchomić projekt

### Wymagania wstępne

- Zainstalowany .NET SDK 8
- Dostęp do Microsoft SQL Server
- Visual Studio 2022 lub inny kompatybilny edytor

### Instrukcja instalacji

1. **Pobierz projekt**:

   ```bash
   git clone https://github.com/yourusername/OnlineStoreZaliczenie.git
   cd OnlineStoreZaliczenie
   ```

2. **Pobierz potrzebne biblioteki**:

   Wejdź w zarządzanie pakietami NuGet i tam dodaj nastepujące biblioteki:
   - Microsoft.AspNetCore.Identity.EntityFrameworkCore
   - Microsoft.AspNetCore.Identity.UI
   - Microsoft.EntityFrameworkCore.SqlServer
   - Microsoft.EntityFrameworkCore.Tools


3. **Skonfiguruj bazę danych**:

   Edytuj plik `appsettings.json` i wprowadź dane połączenia do bazy w sekcji `ConnectionStrings`:

   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=your_server;Database=OnlineStore;Trusted_Connection=True;MultipleActiveResultSets=true"
   }
   ```

4. **Zainicjuj bazę danych**:

   Wykonaj poniższe polecenia w menedżerze pakietów:

   ```bash
   ADD-MIGRATION "Initial"
   UPDATE-DATABASE
   ```

5. **Uruchom aplikację**:

   W Visual Studio wybierz "Run".

## Korzystanie z aplikacji

### Role użytkowników

- **Administrator**:
  - Login: `admin@gmail.com`
  - Hasło: `zaq1@WSX`

- **Zwykły użytkownik**: W celu uzyskania dostępu, załóż nowe konto poprzez formularz rejestracji.

### Dostępne funkcje

- Administratorzy mają pełny dostęp do narzędzi zarządzania, w tym dodawania, edytowania i usuwania produktów oraz konfiguracji kategorii.

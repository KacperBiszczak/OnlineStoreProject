# Online Store

Online Store to aplikacja webowa zaprojektowana w technologii ASP.NET Core 8.

## Funkcjonalności

### Dla użytkowników niezalogowanych i zalogowanych
- Przeglądanie listy dostępnych produktów.
- Podgląd szczegółowych informacji o wybranym produkcie.

### Dla użytkowników zalogowanych
- Dostęp do wszystkich funkcji dostępnych dla niezalogowanych użytkowników.

### Dla administratorów
- Rozbudowane narzędzia do zarządzania asortymentem:
  - Dodawanie nowych produktów.
  - Modyfikowanie istniejących produktów.
  - Usuwanie produktów z bazy.
  - Organizowanie produktów w kategorie.

## Technologie

- **Backend**: ASP.NET Core 8
- **Frontend**: Razor Pages, Bootstrap 5
- **Baza danych**: Microsoft SQL Server z obsługą przez Entity Framework Core
- **System uwierzytelniania**: ASP.NET Core Identity

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

2. **Skonfiguruj bazę danych**:

   Edytuj plik `appsettings.json` i wprowadź dane połączenia do bazy w sekcji `ConnectionStrings`:

   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=your_server;Database=OnlineStore;Trusted_Connection=True;MultipleActiveResultSets=true"
   }
   ```

3. **Zainicjuj bazę danych**:

   Wykonaj poniższe polecenia w terminalu:

   ```bash
   dotnet ef migrations add InitialMigration
   dotnet ef database update
   ```

4. **Uruchom aplikację**:

   W Visual Studio wybierz "Run" lub wpisz w terminalu:

   ```bash
   dotnet run
   ```

## Korzystanie z aplikacji

### Role użytkowników

- **Administrator**:
  - Login: `admin@example.com`
  - Hasło: `Admin123!`

- **Zwykły użytkownik**: W celu uzyskania dostępu, załóż nowe konto poprzez formularz rejestracji.

### Dostępne funkcje

- Administratorzy mają pełny dostęp do narzędzi zarządzania, w tym dodawania, edytowania i usuwania produktów oraz konfiguracji kategorii.
- Zarejestrowani użytkownicy mogą przeglądać ofertę sklepu.

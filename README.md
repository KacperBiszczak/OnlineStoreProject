# Online Store

Online Store to aplikacja webowa stworzona przy użyciu ASP.NET Core 8, która umożliwia zarządzanie sklepem internetowym. Aplikacja posiada funkcjonalności takie jak rejestracja użytkowników, logowanie, role administracyjne oraz możliwość przeglądania, dodawania, edytowania i usuwania produktów.
## Funkcjonalności

### Użytkownik niezalogowany
- Możliwość przeglądania listy produktów.
- Szczegóły produktu (widok "Details").

### Zarejestrowany użytkownik
- Możliwość przeglądania produktów i ich szczegółów.

### Administrator
- Pełny dostęp do zarządzania produktami:
  - Dodawanie produktów.
  - Edytowanie produktów.
  - Usuwanie produktów.
  - Zarządzanie kategoriami produktów.

## Technologie

- **Backend**: ASP.NET Core 8
- **Frontend**: Razor Pages, Bootstrap
- **Baza danych**: Microsoft SQL Server z wykorzystaniem Entity Framework Core
- **Autoryzacja i uwierzytelnianie**: ASP.NET Core Identity

## Instalacja

### Wymagania wstępne

- .NET SDK 8
- Microsoft SQL Server
- Visual Studio 2022 (lub inny edytor obsługujący .NET)

### Kroki instalacji

1. **Klonowanie repozytorium**:

   ```bash
   git clone https://github.com/yourusername/OnlineStoreZaliczenie.git
   cd OnlineStoreZaliczenie
   ```

2. **Konfiguracja bazy danych**:

   Otwórz plik `appsettings.json` i ustaw parametry połączenia z bazą danych w sekcji `ConnectionStrings`:

   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=your_server;Database=OnlineStore;Trusted_Connection=True;MultipleActiveResultSets=true"
   }
   ```

3. **Migracje bazy danych**:

   W terminalu wykonaj polecenia:

   ```bash
   ADD-MIGRATION "Initial"
   UPDATE-DATABASE
   ```

## Użytkowanie

### Role użytkowników

- **Administrator**:
  - E-mail: `admin@example.com`
  - Hasło: `Admin123!`

- **Zwykły użytkownik**: Zarejestruj się, aby korzystać z aplikacji.

### Funkcjonalności
- Administrator może zarządzać produktami, kategoriami i użytkownikami.
- Użytkownicy mają możliwość przeglądania produktów i oglądania ich szczegółów.

## Struktura projektu

- **Controllers**: Zawiera kontrolery MVC obsługujące żądania.
- **Models**: Definicje klas modelu, w tym encje dla Entity Framework.
- **Views**: Widoki Razor Pages dla aplikacji.
- **Data**: Kontekst bazy danych i konfiguracje EF Core.
- **Helpers**: Implementacja initializacji bazy danych.

## Funkcje dodatkowe

- Walidacja danych po stronie klienta i serwera.


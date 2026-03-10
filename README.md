# 🛒 BookShop

[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-11.0-green.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![HTML](https://img.shields.io/badge/HTML-5-orange.svg)](https://developer.mozilla.org/en-US/docs/Web/HTML)
[![CSS](https://img.shields.io/badge/CSS-3-blue.svg)](https://developer.mozilla.org/en-US/docs/Web/CSS)
[![License](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

> Projekt demonstracyjny sklepu internetowego z książkami, stworzony w ramach przedmiotu Internet Technologies and Usage Patterns in Programming Technologies na kierunku Informatyka w Społecznej Akademii Nauk w Łodzi.

## 📋 Spis treści
- [Opis projektu](#opis-projektu)
- [Technologie](#technologie)
- [Funkcjonalności](#funkcjonalności)
- [Instalacja i uruchomienie](#instalacja-i-uruchomienie)
- [Użycie](#użycie)
- [Zrzuty ekranu](#zrzuty-ekranu)
- [Autor](#autor)

## 📖 Opis projektu
Celem tego projektu jest stworzenie funkcjonalnego sklepu internetowego z książkami, który demonstruje integrację nowoczesnych technologii webowych. Aplikacja składa się z dwóch głównych części: backendu opartego na ASP.NET Web API oraz frontendu zbudowanego w Blazor WebAssembly.

Projekt został zrealizowany jako praca egzaminacyjna na studiach magisterskich.

## 🛠 Technologie

### Backend (BookShop.Api)
- **ASP.NET Core Web API** (.NET 8.0) - framework do budowy API REST
- **Entity Framework Core** - ORM dla dostępu do bazy danych SQL Server
- **AutoMapper** - biblioteka do mapowania obiektów
- **Dependency Injection** - wzorzec wstrzykiwania zależności
- **Bogus** - biblioteka do generowania fałszywych danych testowych
- **Swagger/OpenAPI** - dokumentacja API

### Frontend (BookShop.Web)
- **Blazor WebAssembly** - framework do budowy aplikacji webowych po stronie klienta
- **Bootstrap** - framework CSS do responsywnego designu
- **Blazored Local Storage** - zarządzanie pamięcią lokalną przeglądarki
- **Blazored Toast** - wyświetlanie powiadomień
- **Newtonsoft.Json** - serializacja/deserializacja JSON

## ✨ Funkcjonalności
- ✅ Przeglądanie listy dostępnych książek
- ✅ Wyświetlanie szczegółowych informacji o książce
- ✅ Dodawanie książek do koszyka zakupów
- ✅ Edycja ilości książek w koszyku
- ✅ Usuwanie pozycji z koszyka
- ✅ Dynamiczne komunikaty statusu (toast notifications)
- ✅ Integracja z zewnętrznym API cytatów dnia ([API-Ninjas](https://api-ninjas.com/))

## 🚀 Instalacja i uruchomienie

### Wymagania wstępne
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (lub LocalDB dla deweloperów)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) lub dowolne IDE obsługujące .NET

### Kroki instalacji
1. **Sklonuj repozytorium:**
   ```bash
   git clone https://github.com/Rumcajs121/BookShop.git
   cd BookShop
   ```

2. **Przywróć zależności:**
   ```bash
   dotnet restore BookShop.sln
   ```

3. **Uruchom migracje bazy danych (dla API):**
   ```bash
   cd BookShop.Api
   dotnet ef database update
   ```

4. **Uruchom aplikację API:**
   ```bash
   dotnet run
   ```
   API będzie dostępne pod adresem: `http://localhost:5129` (Swagger: `http://localhost:5129/swagger`)

5. **Uruchom aplikację frontendową (w nowym terminalu):**
   ```bash
   cd ../BookShop.Web
   dotnet run
   ```
   Aplikacja będzie dostępna pod adresem: `http://localhost:5095`

### Konfiguracja
- Upewnij się, że porty `5129` (API) i `5095` (Web) są dostępne.
- W przypadku problemów z połączeniem do bazy danych, sprawdź ustawienia w `BookShop.Api/appsettings.json`.

## 📱 Użycie
1. Otwórz przeglądarkę i przejdź do `http://localhost:5095`
2. Przeglądaj dostępne książki na stronie głównej
3. Kliknij na książkę, aby zobaczyć szczegóły
4. Dodaj książki do koszyka i zarządzaj ilościami
5. Korzystaj z dynamicznych powiadomień o akcjach

## 📸 Zrzuty ekranu

### 🏠 Strona główna
![Strona główna](https://github.com/Rumcajs121/BookShop/assets/116017854/59d4f48e-1151-427f-ba35-f56525327e4f)
![Cytat dnia](https://github.com/Rumcajs121/BookShop/assets/116017854/2f8e10a3-14ae-40fe-af8f-6eba1d437054)

### 📚 Lista książek
![Lista książek](https://github.com/Rumcajs121/BookShop/assets/116017854/1cdf7973-f1f2-4d53-a82a-466174819807)

### 📖 Szczegóły książki
![Szczegóły książki](https://github.com/Rumcajs121/BookShop/assets/116017854/2aafa4c9-3bf7-45ca-b601-02fdc56d49fc)

### 🛍️ Koszyk
![Koszyk](https://github.com/Rumcajs121/BookShop/assets/116017854/8747f804-f786-44c6-bc39-29d384bc9ecf)

### 🔧 API (Swagger)
![API](https://github.com/Rumcajs121/BookShop/assets/116017854/de428385-b063-4830-a158-da53792f3f45)

### 💾 Baza danych
![Baza danych](https://github.com/Rumcajs121/BookShop/assets/116017854/06b1d382-8aa8-4b92-91fb-e4435c8245fc)

### 🌐 Pamięć lokalna przeglądarki
![Pamięć lokalna](https://github.com/Rumcajs121/BookShop/assets/116017854/068c456e-77b9-4adb-ad90-bbb6225a571a)

## 👨‍💻 Autor
**Rumcajs121** - Student Informatyki, Społeczna Akademia Nauk w Łodzi

---
*Projekt zrealizowany w ramach przedmiotu Internet Technologies and Usage Patterns in Programming Technologies*

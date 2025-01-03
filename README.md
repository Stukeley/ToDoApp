# ToDoApp

Prosta aplikacja MVVM, proces tworzenia której jest opisany w książce "WPF i MaterialDesign - Od podstaw do tworzenia praktycznych aplikacji", ISBN: 978-83-289-2398-0, autor: Rafał Klinowski.

## Rozszerzenia


- Implementacja powiadomień o wybranej przez użytkownika godzinie - wybranie czasu (zdarzenie SelectedTimeChanged) powinno ustawiać stoper, który pokaże użytkownikowi powiadomienie (np. prosty MessageBox) o wybranej godzinie.s Implementowaliśmy już podobny system podczas opisywania kontrolki TimePicker.
- Funkcjonalność przełączania wykonanych zadań - można do klasy MainViewModel dodać drugą kolekcję, która będzie przechowywać elementy oznaczone jako zakończone. Podczas przełączania kontrolki CheckBox (zdarzenia Checked i Uncheched) można zaimplementować przeniesienie kontrolki z jednej kolekcji do drugiej, która z kolei będzie połączona z drugim elementem ListBox i będzie wyświetlany w osobnej części okna głównego. Implementację tej funkcjonalności należy zaimplementować z poziomu ViewModel.

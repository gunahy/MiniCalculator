# MiniCalculator

## Задание 1
Создайте консольный мини-калькулятор, который будет подсчитывать сумму двух чисел. Определите интерфейс для функции сложения числа и реализуйте его.
Дополнительно: добавьте конструкцию Try/Catch/Finally для проверки корректности введённого значения.

## Задание 2
Реализуйте механизм внедрения зависимостей: добавьте в мини-калькулятор логгер, используя материал из скринкаста юнита 10.1.
Дополнительно: текст ошибки, выводимый в логгере, окрасьте в красный цвет, а текст события — в синий цвет.

## Описание

Этот проект является версией консольного мини-калькулятора, который выполняет сложение двух чисел. Логирование событий и ошибок происходит через класс `Logger`.

## Основные компоненты

- **ILogger**: Интерфейс для логгера, содержащий методы `Event()` и `Error()`.
- **Logger**: Класс, реализующий интерфейс `ILogger`. Сообщения логгируются в консоль с цветовой индикацией:
  - Синий цвет для событий.
  - Красный цвет для ошибок.
- **IAdder<in T>** и **IResult<out T>**: Интерфейсы для выполнения арифметических операций.
- **Calculator**: Класс калькулятора, который принимает логгер через конструктор и логирует операции сложения.

## Использование

1. При запуске программы пользователю предлагается ввести два числа.
2. Программа выполняет сложение и выводит результат на экран.
3. Все события и ошибки логгируются в консоль:
   - Успешные операции выводятся в синем цвете.
   - Ошибки (например, некорректный ввод) выводятся в красном цвете.

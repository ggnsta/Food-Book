# Улучшение UX

## Содержание.

1. [Оценка разрабатываемого программного обеспечения](#1)
   1. [Распознаваемость соответствия](#1.1)
   2. [Обучаемость](#1.2)
   3. [Используемость](#1.3)
   4. [Защита от ошибок пользователя](#1.4)
   5. [Эстетика GUI](#1.5)
   6. [Доступность](1.6)
2. [Выбор пути улучшения UX](#2)

<a name = "1">
</a>

### 1. Оценка разрабатываемого программного обеспечения

<a name = "1.1">
</a>

#### 1.1 Распознаваемость соответствия
Распознаваемость соответствия (Appropriateness recognizibility) - степень, с которой пользователи понимают, подходит продукт или система для их нужд.<br>
__Оценка__: Пользователь с легкостью могут определить, подходит наша система для их нужд или нет.

<a name = "1.2">
</a>

#### 1.2 Обучаемость
Обучаемость (learnability) – степень (скорость), с которой продукт или система могут быть начаты использованы конкретными пользователями с эффективностью, результативностью и удовлетворенностью и без риска в определенном контексте.<br>
__Оценка__: Пользователи могут быстро обучиться работе с продуктом FoodBook, поскольку в нем реализовано все самое необходимое.

<a name = "1.3">
</a>

#### 1.3 Используемость
Используемость (operability) – степень простоты, с которой можно использовать продукт и управлять им (производить какие-либо настройки).<br>
__Оценка__: Продукт FoodBook является крайне простым в использовании.

<a name = "1.4">
</a>

#### 1.4 Защита от ошибок пользователя
Защита от ошибок пользователя (user-error protection) – степень, с которой система защищает пользователя от совершения ошибок.
__Оценка__: У приложения есть минимальная защита от ошибок пользователя, таких как попытка добавить рецепт без регистрации/входа в систему. При этом ошибка - создание рецепта без названия и/или без описания - никак не отслеживается.

<a name = "1.5">
</a>

#### 1.5 Эстетика графического интерфейса пользователя (GUI)
Эстетика GUI (user interface aesthetics) – степень, с которой система обеспечивает приятное и удовлетворяющее взаимодействие с пользователем.<br>
__Оценка__: Основная цель проекта FoodBook - создать удобное и простое web-приложение для обмена рецептами, ввиду этого при проектировании дизайна нашего приложения мы ограничились довольно простым графическим интерфейсом пользователя.

<a name = "1.6">
</a>

#### 1.6 Доступность
Доступность (Accessibility) – степень, с которой продукт или система могут быть использованы пользователями с определенными особенностями, ограниченными возможностями для достижения цели в определенном контексте использования.<br>
__Оценка__: Данная возможность к сожалению не предусмотрена в приложении FoodBook.

<a name = "2">
</a>

### 2. Выбор пути улучшения UX

1. Добавить проверку всех действий пользователя на адекватность (создание пустых/полупустых рецептов, и т.д.).
2. Использование компонентов в стиле Material Design при разработке графического интерфейса пользователя (GUI).
3. Добавить функцию изменения графического интерфейса пользователя для людей со сниженной способностью или полной неспособностью различать все или некоторые цвета, что подразумевает использование особой цветовой гаммы при разработке графического интерфейса.
4. Добавить функцию изменения графического интерфейса пользователя для людей с нарушениями зрения, что подразумевает значительное увеличение элементов графического интерфейса.
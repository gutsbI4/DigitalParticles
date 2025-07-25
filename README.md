# **Цифровые частицы**

"Цифровые частицы" — это уникальный интерактивный веб\-сайт, который превращает экран в живую, дышащую композицию из движущихся частиц. Это не просто сайт, а скорее интерактивный арт-объект, создающий завораживающий визуальный опыт, который реагирует на каждое движение мыши пользователя.

## **О проекте**

Проект "Цифровые частицы" демонстрирует возможности современных веб\-технологий для создания динамичных и эстетически привлекательных пользовательских интерфейсов без использования Canvas API для основных эффектов частиц. Он идеально подходит для тех, кто ищет вдохновение в интерактивном дизайне или хочет изучить методы создания сложных визуальных эффектов с помощью чистого CSS и JavaScript.

## **Ключевые особенности**

* **Интерактивные частицы**: 100 цветных частиц разных размеров, плавающих по экрану, создавая ощущение глубины и движения.  
* **Реакция на мышь**: Частицы динамически притягиваются к курсору мыши, увеличиваясь в размере по мере приближения, что создает эффект "живого" взаимодействия.  
* **Динамические соединения**: Автоматически генерируемые линии появляются между близко расположенными частицами, подчеркивая их взаимосвязь и создавая сложные узоры.  
* **Эффект ряби при клике**: При каждом клике мыши на экране генерируется анимированная рябь, добавляющая еще один слой интерактивности.  
* **Градиентный фон**: Темный, космический градиентный фон с плавными переходами, который служит идеальным холстом для ярких частиц.  
* **Волновые линии**: Дополнительные анимированные элементы, которые добавляют динамику и глубину общему дизайну.  
* **Пользовательский курсор**: Стандартный системный курсор заменяется светящимся пользовательским курсором, который гармонично вписывается в общую эстетику сайта.

## **Технические детали**

* **Бэкенд**: ASP.NET Core с использованием паттерна MVC для структурирования проекта.  
* **Фронтенд**:  
  * **CSS3**: Интенсивное использование CSS3 для анимаций, переходов и создания градиентного фона.  
  * **JavaScript**: Основная логика интерактивности, включая отслеживание движений мыши, расчеты расстояний между частицами и управление эффектами.  
  * **"Canvas-like" эффекты без Canvas API**: Достижение сложных визуальных эффектов, обычно ассоциирующихся с Canvas, с помощью манипуляций с DOM-элементами и CSS.  
* **Адаптивный дизайн**: Сайт разработан с учетом адаптивности, обеспечивая оптимальное отображение и взаимодействие на различных размерах экранов.

## **Запуск проекта**

Для запуска проекта "Цифровые частицы" на вашей локальной машине:

1. **Клонируйте репозиторий**:  
   git clone https://github.com/gutsbI4/DigitalParticles.git
   
   cd \[название папки репозитория\]
3. **Запустите проект**:  
   dotnet run
   
## **Будущие улучшения и идеи**

Мы всегда открыты для новых идей и улучшений\! Вот несколько предложений, которые могли бы еще больше расширить функциональность и визуальную привлекательность "Цифровых частиц":

* **Настраиваемые параметры**: Добавление пользовательского интерфейса (например, небольшой панели настроек) для изменения количества частиц, их размера, скорости движения, цвета или силы притяжения.  
* **Различные режимы взаимодействия**: Реализация других типов взаимодействия, таких как отталкивание частиц от курсора, или создание вихревых эффектов.  
* **Звуковые эффекты**: Добавление тонких звуковых эффектов при взаимодействии с частицами или при кликах.  
* **Интеграция с API**: Возможность загрузки данных из внешних API для динамического изменения поведения или внешнего вида частиц (например, визуализация данных).  
* **Эффекты постобработки**: Добавление эффектов постобработки, таких как свечение, размытие или хроматическая аберрация, для усиления визуального воздействия.  
* **Поддержка сенсорного экрана**: Оптимизация для сенсорных устройств, чтобы эффекты реагировали на касания и жесты.  
* **Оптимизация производительности**: Дальнейшая оптимизация JavaScript и CSS для обеспечения максимально плавной работы на более широком спектре устройств.

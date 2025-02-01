# AddGEHistorianArhives

Программа для добавления архивов из файлов в GE Proficy Historian (Program for adding archives from files to GE Proficy Historian).

Кратко для чего проект. В общем, у GE есть Client API, который оказывается не умеет добавлять архивы из файла, которые до этого были отсоединены. Чтобы это сделать придётся прибегнуть к Historian SDK, который работает через COM. Поэтому приложение x86, потому что привязка только для этой архитектуры.

### Инструкция в картинках

В имя сервера стоит локальное имя компьютера, поэтому сразу жмем "Connect".

<img src="https://raw.githubusercontent.com/OlegBezverhii/AddGEHistorianArhives/refs/heads/main/Pictures/1.PNG"/>

В случае успеха выйдет окно с следующим текстом:

<img src="https://raw.githubusercontent.com/OlegBezverhii/AddGEHistorianArhives/refs/heads/main/Pictures/2.PNG"/>

Надпись "Состояние" напротив "Имя сервера" изменится на "Подключено" в синем цвете. В "Data Store Name" появятся текущие хранилища данных на данном сервере:

<img src="https://raw.githubusercontent.com/OlegBezverhii/AddGEHistorianArhives/refs/heads/main/Pictures/3.PNG"/>

По умолчанию у меня указан путь, где хранятся архивы, если у вас другая папка, то жмем кнопку "Выбрать путь до файла":

<img src="https://raw.githubusercontent.com/OlegBezverhii/AddGEHistorianArhives/refs/heads/main/Pictures/4.PNG"/>

В поле "Именование файлов (маска)" указываем, какие конкретно архивы нам нужно добавить. В поле "Data store Name" указываем хранилище, в которое будут добавляться архивы:

<img src="https://raw.githubusercontent.com/OlegBezverhii/AddGEHistorianArhives/refs/heads/main/Pictures/5.PNG"/>

Для выполнения работы жмем кнопку "Приступить!" и по логу программы смотрим, какие файлы добавляются. Используемые файлы в конфигурацию не добавляются.
После окончания работы жмем кнопку "Disconnect".

<img src="https://raw.githubusercontent.com/OlegBezverhii/AddGEHistorianArhives/refs/heads/main/Pictures/6.PNG"/>

После отключения надпись меняется на "Отключено" и изменяет цвет на красный:

<img src="https://raw.githubusercontent.com/OlegBezverhii/AddGEHistorianArhives/refs/heads/main/Pictures/7.PNG"/>


Если вам нужно периодически бэкапить архивы, то обратитесь уже к этому проекту - [BackuperGEArchives](https://github.com/OlegBezverhii/BackuperGEArchives).

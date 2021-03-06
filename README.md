## Описание и функционал:
1. Программа представляет собой WPF приложение, которое занимается дешифровкой и шифровкой  информациию.
2. Программа имеет возможность как для передачи и чтения файла формата txt или docx (по выбору), так и прямого ввода в поле программы. Знаки препинания, и прочие элементы не относящиеся к алфавиту сообщения не изменяются. В сообщении используется десятичная система счисления и русский алфавит.
3. Программа имеет возможность вывода информации на экран 
(шифрование/дешифрование поле "Вывод"), а так же ее сохранения в отдельный файл формата txt или docx (по выбору), с указанием его названия и директории для сохранения.
4. Программа имеет возможность для ввода ключа как для дешифрования так и для шифрования информации.
5. Основной функционал программы покрыт автоматическими Unit тестами, с использованием стандартных возможностей MSTest и .NET
6. Программа имеет  интерфейс для взаимодействия с пользователем, а также меню для управления функциональными возможностями программы.

## Интерфейс
**Интефрейс делится на две зоны: меню и вывод.**
В зону меню входит:
- Блок для отрытия документов: кнопка "Открыть" дает пользователю выбрать документ формата txt, кнопка "Открыть DOCX" дает пользователю выбрать документ формата docx. После выбора файла информация выводится на экран 
- Блок для работы с шифром Виженера: кнопка "Дешифровать" производит дешифровку информации, находящейся в поле "Ввода, и последющий вывод информации в поле "Вывод", кнопка "Зашифровать" производит обратное действие соответственно. Для выполнения данных дейсвий необходимо ввести ключ.
- Блок для сохранение информации в файл: кнопка "Сохранить" дает пользователю возможность сохранить информациюю в формате txt, кнопка "Сохранить DOCX" дает пользователю возможность сохранить информациюю в формате docx.

В зону вода/вывода входит:
- Поле для ввода ключа шифрования/дешифрования.
- Поле для ввода информации с клавиатуры или отображения информации из файла.
- Поле для вывода информации после шифрования/дешифрования.

## Краткая инструкция:
1. Введите информацию в поле "Ввод" с клавиатуры или загрузите файл одной из кнопок "Открыть".
2. Введите ключ 
3. Дешифруйте или зашифруйте сообщение
4. Результат будет отображен в поле "Вывод"
5. Сохраните результат с помощью одной из кнопок "Сохранить"

## Программа имеет ограничения:
1) Нельзя произвести дешифровку/шифровку без ключа. Необходимо сначала ввести ключ
2) Нельзя ничего вводить в поле вывода. Поле не кликабельно. Заполнение поля производится программно, при нажатии кнопок для шифра.
3) Нельзя сохранить пустое поле вывода. 
4) Можно открывать и сохранять только указанные форматы txt и docx. В программе предусмотрен фильтр.
 

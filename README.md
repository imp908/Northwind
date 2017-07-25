# Northwind
Northwind db test project
Тестовый MVC проект для базы Northwind с возможностью регистрации пользователя и обновления количества продуктов в заказе 
для авторизованного работника.В проекате база Northwind перенесена на code first.
Для запуска проекта :

connection string "NorthwindConn" в web.cnfig в корне проекта нужно заменить data source на адресс сервера.

После зупуска проекта, при попытке регистрации нового пользователя, будут проинициализированны объекты базы.

Данные загружаются скриптом из корня папки проекта NorthwindPlainInsert.sql

Стартовая страница Views\Validation\Login, регистрация осуществляется только для FirstName и LastName из таблицs Employees, почты и пароля.
На момент регистрации данные должны быть в базе. Аутентификация по почте и паролю. Аккаунты подключены через OWIN forms, 
удаление аккаунтов не предусмотрено.

После регистрации переводит на Edit/Orders со списком продуктов для данного Работника. 
При нажатии на ссылку Edit переводит на Edit/Change, где можно поменять объем, >=0 и кнопкой Save сохранить. 

Разлогиниться можно сслыкой SignOut в правом верхнем улгу navbar.

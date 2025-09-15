# Credit Total Cost

Приложение для расчета полной стоимости аннуитетного кредита с переменным платежным периодом, в соответствии с указаниями ЦБ РФ.

Полная стоимость кредита (ПСК) используется для оценки затрат, связанных с получением кредита, и для сравнения различных кредитных предложений.

ПСК - это число, выраженное в процентах годовых. Оно отражает фактическую доходность банка, и учитывает не только номинальную процентную ставку, но и все дополнительные затраты, комиссии и платежи, связанные с кредитом.

Application for calculating the total cost of an annuity loan with a variable payment period, in accordance with the guidelines of the Bank of Russia.  

The total loan cost (APR-equivalent) is used to estimate the real expenses of obtaining a loan and to compare different credit offers.  

It reflects the bank’s effective annual yield, taking into account not only the nominal interest rate but also all additional fees and charges.  

## Features / Возможности
- Корректный расчет полной стоимости аннуитетного кредита с переменным платежным периодом / Accurate calculation of the total cost of an annuity loan with a variable payment period
- Вывод графика погашения кредита / Loan repayment schedule generation  
- Расчет ежемесячного платежа / Monthly payment calculation  
- Расчет переплаты / Total loan overpayment calculation  

## Installation / Установка

### Русский:
1. Клонируйте репозиторий  
2. Откройте решение или проект в Visual Studio или аналогичной IDE  
3. Соберите проект  

### English:
1. Clone the repository  
2. Open the solution or project in Visual Studio (or similar IDE)  
3. Build the project  

## Usage / Использование

### Русский:
Запустите приложение `PSK.exe`  

### English:
Run the application `PSK.exe`

## Technologies / Технологии
- C#  
- .NET Framework 4.7.2

## Application structure / Структура приложения
Приложение состоит из 6 модулей / The application consists of 6 modules:
1. Интерфейс / Interface  
2. Расчет дат платежей / Payment date calculation  
3. Расчет ежемесячного платежа / Monthly payment calculation  
4. Формирование графика погашения / Repayment schedule generation  
5. Расчет ПСК / Total loan cost calculation  
6. Расчет переплаты / Overpayment calculation  

![Диаграмма кооперации](images/Диаграмма_кооперации.png)

![Диаграмма последовательности](images/Диаграмма_последовательности.png)

![Диаграмма классов](images/Диаграмма_классов.png)

Для более полного понимания алгоритмов в папке `images` представлены схемы в методологиях IDEF0 и IDEF3 / Diagrams and flowcharts in IDEF0/IDEF3 methodology are available in the `images` folder.

## License
This project is licensed under the MIT License – see the LICENSE file for details.
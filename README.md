Створи повний набір класів VBA для представлення структури IFC-об'єктів відповідно до наведеної діаграми:
1.	Створи клас IfcProject, що містить поля:
•	ProjectId
•	Name
2.	Створи клас IfcCostSchedule, що включає:
•	ScheduleId
•	Name
•	Пов'язаний IfcProject
•	Методи для агрегування об'єктів IfcCostItem
3.	Створи клас IfcCostItem, що має:
•	CostItemId
•	Identification
•	Name
•	Пов'язані підпозиції (вкладені об'єкти типу IfcCostItem)
•	Колекцію об'єктів типу IfcCostValue
•	Колекцію кількісних показників (IfcQuantityArea, IfcQuantityVolume)
4.	Створи класи кількісних характеристик:
•	IfcQuantityArea (Unit, AreaValue)
•	IfcQuantityVolume (Unit, VolumeValue)
5.	Створи клас IfcCostValue з:
•	AppliedValue
•	CostType (наприклад, Material, Labor, Tax)
6.	Створи клас IfcElementQuantity, що містить поля:
•	QuantityId
•	Quantities (Area, Volume)
7.	Створи клас IfcWallStandardCase, що пов'язується з:
•	ElementId
•	Пов'язаний об'єкт IfcElementQuantity
8.	Реалізуй класи-зв'язки для управління зв'язками між сутностями:
•	IfcRelNests (для вкладення CostItem)
•	IfcRelAssignsToControl (для прив'язки CostItem до IFC-елементів)
•	IfcRelDefinesByProperties (для прив'язки властивостей кількостей до елементів)
Включи методи валідації для перевірки коректності зв'язків між сутностями та їхніх атрибутів. Використовуй колекції для управління списками вкладених об'єктів та забезпеч обробку nullable полів відповідно до логіки діаграм IFC.

# .NET-SpaceShipTaskProject
C# .NET Project Task


DevOcean Academy Task
The year – 2345 AD, the earthlings have inhabited half of the galaxy. It’s very important that
everyone is able to calculate exactly how much tax they need to pay Big Sister. The used currency is
DevOceanit (DVS)
1. There are two types of spaceships – Cargo and Family
• Cargo – initial tax 10_000 DVS
• Family – initial tax 5_000 DVS
2. The more light miles a spaceship travels, the more the tax increases:
• Cargo – for every 1_000 light miles traveled, the tax increases by 1_000 DVS
• Family – for every 1_000 light miles traveled, the tax increases by 100 DVS
3. For every year the spaceship is used, the tax declines:
• Cargo – declines every year by 736 DVS
• Family – declines every year by 355 DVS
Create a console application that accepts input values for spaceship type, year of purchase, year of
tax calculation, and light miles traveled. Big Sister only takes money and if the calculation is not
done correctly gives red cards, which is why it’s good to write tests.
Tips & Tricks from the kitchen:
*
*
*
*
*
*
*
You must follow the SOLID principles and the OOP principles. The lack of SRP or DI will be
punished by death.
You must use correct naming and write clean, self-documenting code.
You must use .NET Core 3.1 +
You must use services for the business logic.
You must apply proper server-side data validation.
You must apply proper error handling.
You must write unit tests for the business layer.
Examples:
1. Family spaceship bought in 2300 has traveled 2_344 light miles, so in 2307 owes:
5_000 + 2* 100 - 7*355
2. Cargo spaceship bought in 2332 has traveled 344_789 light miles, so in 2369 owes:
10_000 + 344*1_000 - (2369 - 2332)*736

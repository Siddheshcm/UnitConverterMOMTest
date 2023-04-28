# UnitConverterMOMTest

1. Take latest of the Project to local
2. Open project in VS 2022 
3. set up database from Sqlscript/sqldbscript.txt file from project
4. Update connection string in appsetting as per datasource currently it is SQL express
5. Execute the application on Swagger ui 
6. Open Convert endpoint wth post verb
7. Pass Input values as follows 
{
  "unit": "string",   --> From Unit name 
  "outputUnit": "string", --> To unit name
  "inputvalue": 0, --> Value to convert
  "metricORImperial": "string" --> to conver into Metric or Imperial
}

8. One of the Outputunit or MetricsorImperial will be mandatory to get desired output.

9. Paramaters values as below

Unit/Outputunit Values ==> ,Meter,Millimeter,Centimeter,Decimeter,Decameter,Hectometer,Kilometer,Inch,Foot,Yard,Miles,Milligram,Gram,Kilogram
		,Tonne,Pound,Ounces,Celsius,Fahrenheit
    
InputValue ==> Decimal value
MetricORImperial ==> Metric, Imperial

10. Testcases project has been added in solution with two testcases using fake / mocking service.
11. In database two conversion tables created and one storedprocedure to calculate conversion.
12. Conversion can be done from any unit to any unit with respect to types i.e. Length, Mass, Temperature.

using System;
using System.Numerics;

PerformCalculationsWithLongs();
Console.WriteLine();
PerformCalculationsWithDoubles();
Console.WriteLine();
PerformCalculationsWithDecimals();
Console.WriteLine();
PerformCalculationsWithBigInteger();
Console.WriteLine();
ParseTotalAtoms();
Console.WriteLine();
AddTwoFloatingPoints();
Console.WriteLine();
PerformCalculationsWithInts();

// https://docs.microsoft.com/en-us/dotnet/api/system.int64
static void PerformCalculationsWithLongs()
{
	Console.WriteLine(nameof(PerformCalculationsWithLongs));
	var house = 350_000_000L;
	var salary = 219_000_000_000L;

	var numberOfHouses = salary / house;

	Console.WriteLine(numberOfHouses);
}

// https://docs.microsoft.com/en-us/dotnet/api/system.double
static void PerformCalculationsWithDoubles()
{
	Console.WriteLine(nameof(PerformCalculationsWithDoubles));
	var house = 350_000_000d;
	var salary = 219_000_000_000d;

	var numberOfHouses = salary / house;

	Console.WriteLine(numberOfHouses);
}

// https://docs.microsoft.com/en-us/dotnet/api/system.decimal
// "The Decimal value type is appropriate for financial calculations
// that require large numbers of significant integral and fractional digits and no round-off errors."
static void PerformCalculationsWithDecimals()
{
	Console.WriteLine(nameof(PerformCalculationsWithDecimals));
	var house = 350_000_000M;
	var salary = 219_000_000_000M;

	var numberOfHouses = salary / house;

	Console.WriteLine(numberOfHouses);
}

// https://docs.microsoft.com/en-us/dotnet/api/system.numerics.biginteger
static void PerformCalculationsWithBigInteger()
{
	Console.WriteLine(nameof(PerformCalculationsWithBigInteger));
	var house = new BigInteger(350_000_000L);
	var salary = new BigInteger(219_000_000_000L);

	var numberOfHouses = salary / house;

	Console.WriteLine(numberOfHouses);
}

static void ParseTotalAtoms()
{
	Console.WriteLine(nameof(ParseTotalAtoms));
	var atoms = BigInteger.Parse("100000000000000000000000000000000000000000000000000000000000000000000000000000000");
	Console.WriteLine(atoms);

	var doubleAtoms = 1.0E80;
	Console.WriteLine(doubleAtoms);

	doubleAtoms = 1.068742959837859731897589371895738917498731894789317849731897E80;
	Console.WriteLine(doubleAtoms);
}

// https://0.30000000000000004.com/
static void AddTwoFloatingPoints()
{
	Console.WriteLine(nameof(AddTwoFloatingPoints));
	Console.WriteLine(0.1 + 0.2);
	Console.WriteLine(0.1M + 0.2M);
}

static void PerformCalculationsWithInts()
{
	Console.WriteLine(nameof(PerformCalculationsWithInts));
	var numberOfHouses = 505;
	var house = 350_000_000;

	var salary = numberOfHouses * house;

	Console.WriteLine(salary);
}
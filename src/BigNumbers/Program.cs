using System;
using System.Numerics;

PerformCalculationsWithLongs();
Console.Out.WriteLine();
PerformCalculationsWithDoubles();
Console.Out.WriteLine();
PerformCalculationsWithDecimals();
Console.Out.WriteLine();
PerformCalculationsWithBigInteger();
Console.Out.WriteLine();
ParseTotalAtoms();
Console.Out.WriteLine();
AddTwoFloatingPoints();
Console.Out.WriteLine();
PerformCalculationsWithInts();

// https://docs.microsoft.com/en-us/dotnet/api/system.int64?view=net-5.0#remarks
static void PerformCalculationsWithLongs()
{
	Console.Out.WriteLine(nameof(PerformCalculationsWithLongs));
	var house = 350_000_000L;
	var salary = 177_000_000_000L;

	var numberOfHouses = salary / house;

	Console.Out.WriteLine(numberOfHouses);
}

// https://docs.microsoft.com/en-us/dotnet/api/system.double?view=net-5.0#remarks
static void PerformCalculationsWithDoubles()
{
	Console.Out.WriteLine(nameof(PerformCalculationsWithDoubles));
	var house = 350_000_000d;
	var salary = 177_000_000_000d;

	var numberOfHouses = salary / house;

	Console.Out.WriteLine(numberOfHouses);
}

// https://docs.microsoft.com/en-us/dotnet/api/system.decimal?view=net-5.0#remarks
// "The Decimal value type is appropriate for financial calculations
// that require large numbers of significant integral and fractional digits and no round-off errors."
static void PerformCalculationsWithDecimals()
{
	Console.Out.WriteLine(nameof(PerformCalculationsWithDecimals));
	var house = 350_000_000M;
	var salary = 177_000_000_000M;

	var numberOfHouses = salary / house;

	Console.Out.WriteLine(numberOfHouses);
}

// https://docs.microsoft.com/en-us/dotnet/api/system.numerics.biginteger?view=net-5.0#remarks
static void PerformCalculationsWithBigInteger()
{
	Console.Out.WriteLine(nameof(PerformCalculationsWithBigInteger));
	var house = new BigInteger(350_000_000L);
	var salary = new BigInteger(177_000_000_000L);

	var numberOfHouses = salary / house;

	Console.Out.WriteLine(numberOfHouses);
}

static void ParseTotalAtoms()
{
	Console.Out.WriteLine(nameof(ParseTotalAtoms));
	var atoms = BigInteger.Parse("100000000000000000000000000000000000000000000000000000000000000000000000000000000");
	Console.Out.WriteLine(atoms);

	var decimalAtoms = 1.0E80;
	Console.Out.WriteLine(decimalAtoms);

	decimalAtoms = 1.068742959837859731897589371895738917498731894789317849731897E80;
	Console.Out.WriteLine(decimalAtoms);
}

// https://0.30000000000000004.com/
static void AddTwoFloatingPoints()
{
	Console.Out.WriteLine(nameof(AddTwoFloatingPoints));
	Console.Out.WriteLine(0.1 + 0.2);
	Console.Out.WriteLine(0.1M + 0.2M);
}

static void PerformCalculationsWithInts()
{
	Console.Out.WriteLine(nameof(PerformCalculationsWithInts));
	var numberOfHouses = 505;
	var house = 350_000_000;

	var salary = numberOfHouses * house;

	Console.Out.WriteLine(salary);
}
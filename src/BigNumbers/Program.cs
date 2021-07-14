using System;
using System.Numerics;

PerformCalculationsWithLongs();
PerformCalculationsWithDoubles();
PerformCalculationsWithDecimals();
PerformCalculationsWithBigInteger();
ParseTotalAtoms();
AddTwoDoubles();
PerformCalculationsWithInts();

static void PerformCalculationsWithLongs()
{
	Console.Out.WriteLine(nameof(PerformCalculationsWithLongs));
	var house = 350_000_000L;
	var salary = 177_000_000_000L;

	var numberOfHouses = salary / house;

	Console.Out.WriteLine(numberOfHouses);
}

static void PerformCalculationsWithDoubles()
{
	Console.Out.WriteLine(nameof(PerformCalculationsWithDoubles));
	var house = 350_000_000d;
	var salary = 177_000_000_000d;

	var numberOfHouses = salary / house;

	Console.Out.WriteLine(numberOfHouses);
}

static void PerformCalculationsWithDecimals()
{
	Console.Out.WriteLine(nameof(PerformCalculationsWithDecimals));
	var house = 350_000_000M;
	var salary = 177_000_000_000M;

	var numberOfHouses = salary / house;

	Console.Out.WriteLine(numberOfHouses);
}

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
}

// https://0.30000000000000004.com/
static void AddTwoDoubles()
{
	Console.Out.WriteLine(nameof(AddTwoDoubles));
	Console.Out.WriteLine(0.1 + 0.2);
}

static void PerformCalculationsWithInts()
{
	Console.Out.WriteLine(nameof(PerformCalculationsWithInts));
	var numberOfHouses = 505;
	var house = 350_000_000;

	var salary = numberOfHouses * house;

	Console.Out.WriteLine(salary);
}
namespace CodeKatas.Tests;

using NUnit.Framework;
using System;

[TestFixture]
public class MeanSquareErrorTests
{
    [Test]
    public void TestMeanSquareError()
    {
        Assert.That(MeanSquareError.Solution(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }), Is.EqualTo(9));
        Assert.That(MeanSquareError.Solution(new int[] { 10, 20, 10, 2 }, new int[] { 10, 25, 5, -2 }), Is.EqualTo(16.5));
        Assert.That(MeanSquareError.Solution(new int[] { 0, -1 }, new int[] { -1, 0 }), Is.EqualTo(1));
    }
}
namespace CodeKatas.Tests;

using System;
using NUnit.Framework;

[TestFixture]
public static class MumblingTests
{
    [Test]
    public static void TestMumbling()
    {
        Assert.That(Mumbling.Accum("ZpglnRxqenU"), Is.EqualTo("Z-Pp-Ggg-Llll-Nnnnn-Rrrrrr-Xxxxxxx-Qqqqqqqq-Eeeeeeeee-Nnnnnnnnnn-Uuuuuuuuuuu"));
        Assert.That(Mumbling.Accum("NyffsGeyylB"), Is.EqualTo("N-Yy-Fff-Ffff-Sssss-Gggggg-Eeeeeee-Yyyyyyyy-Yyyyyyyyy-Llllllllll-Bbbbbbbbbbb"));
        Assert.That(Mumbling.Accum("MjtkuBovqrU"), Is.EqualTo("M-Jj-Ttt-Kkkk-Uuuuu-Bbbbbb-Ooooooo-Vvvvvvvv-Qqqqqqqqq-Rrrrrrrrrr-Uuuuuuuuuuu"));
        Assert.That(Mumbling.Accum("EvidjUnokmM"), Is.EqualTo("E-Vv-Iii-Dddd-Jjjjj-Uuuuuu-Nnnnnnn-Oooooooo-Kkkkkkkkk-Mmmmmmmmmm-Mmmmmmmmmmm"));
        Assert.That(Mumbling.Accum("HbideVbxncC"), Is.EqualTo("H-Bb-Iii-Dddd-Eeeee-Vvvvvv-Bbbbbbb-Xxxxxxxx-Nnnnnnnnn-Cccccccccc-Ccccccccccc"));
    }
}


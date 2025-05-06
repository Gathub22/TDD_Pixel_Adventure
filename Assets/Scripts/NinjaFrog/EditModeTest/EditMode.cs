using NUnit.Framework;
using UnityEngine;

[TestFixture]
public class NinjaFrog
{
    private NinjaFrogStats stats;
    [SetUp]
    public void SetUp()
    {
        stats = new NinjaFrogStats();
    }

    [Test]
		[TestCase(1)]
		[TestCase(5)]
		[TestCase(0)]
    public void EstaVivo(int vidas)
    {
			bool vivo = stats.IsAlive(vidas);
			Assert.AreEqual(true, vivo, "El personaje no esta vivo");
    }


    public void AttackPower_Cases(bool expected, int attackPower, int attackRange)
    {
        bool actual = stats.CanAttack(attackPower, attackRange);
        Assert.AreEqual(expected, actual, "The expected value should be " + expected + " but was " + actual);
    }
}

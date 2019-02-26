﻿using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class CardModel_Test {

    [Test]
    public void CardModel_TestSimplePasses() {
        // Use the Assert class to test conditions.
        CardModel cardModel = new CardModel(CardValue.Ace, CardSuit.Clubs);

        Assert.AreEqual(CardSuit.Clubs, cardModel.Suit);
        Assert.AreEqual(CardValue.Ace, cardModel.Value);
       
    }

    [Test]
    public void CardModel_CanDescribeACard()
    {
        CardModel cardModel = new CardModel(CardValue.Ace, CardSuit.Clubs);

        Assert.AreEqual("Ace of Clubs", cardModel.ToString());
    }

    [Test]
    public void IsEqualTest()
    {
        CardModel cardModel_1 = new CardModel(CardValue.Ace, CardSuit.Clubs);
        CardModel cardModel_2 = new CardModel(CardValue.Ace, CardSuit.Clubs);

        Assert.True(cardModel_1.isEqual(cardModel_2), "Two card objects should be equal!");
    }

    [Test]
    public void IsNotEqualTest()
    {
        CardModel cardModel_1 = new CardModel(CardValue.Ace, CardSuit.Clubs);
        CardModel cardModel_2 = new CardModel(CardValue.Ace, CardSuit.Hearts);

        Assert.False(cardModel_1.isEqual(cardModel_2), "Two card objects should not be equal!");
    }

    // A UnityTest behaves like a coroutine in PlayMode
    // and allows you to yield null to skip a frame in EditMode
    [UnityTest]
    public IEnumerator CardModel_TestWithEnumeratorPasses() {
        // Use the Assert class to test conditions.
        // yield to skip a frame
        yield return null;
    }
}

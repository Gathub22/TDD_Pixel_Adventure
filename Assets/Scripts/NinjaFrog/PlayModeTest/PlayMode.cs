using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor.SceneManagement;

public class NinjaFrogMovementTest
{
    private GameObject NinjaFrog;
    private GameObject Ground;

    [SetUp]
    public void SetUp()
    {
        EditorSceneManager.LoadScene("SampleScene");
        Debug.Log("Scene Loaded");
    }
    [UnityTest]
    public IEnumerator EstaCayendo()
    {
        yield return new WaitForSeconds(1);
        NinjaFrog = GameObject.Find("NinjaFrog");
        Rigidbody2D rb = NinjaFrog.GetComponent<Rigidbody2D>();

        Assert.That(rb.linearVelocityY < 0);

    }


    [TearDown]
    public void TearDown()
    {
        EditorSceneManager.UnloadSceneAsync("SampleScene");
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

/// <summary>
/// A container for the configuration data
/// </summary>
public class ConfigurationData
{
    #region Fields

    const string ConfigurationDataFileName = "ConfigurationData.csv";

    // configuration data
    float playerMoveUnitsPerSecond = 6.5f;
    float jumpForce = 6.5f;
    float playerBulletSpeed = 15f;
    float enemyBulletSpeed = 15f;
    int playerHealth = 100;
    int playerLives = 2;
    int enemyHealth = 4;
    int playerBulletDamage = 1;
    int enemyBulletDamage = 10;
    float playerCooldownFire = 0.6f;
    float shieldEffect = 4.5f;
    float doubleDamageEffect = 4.5f;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the player move units per second
    /// </summary>
    /// <value>player move units per second</value>
    public float PlayerMoveUnitsPerSecond
    {
        get { return playerMoveUnitsPerSecond; }
    }

    /// <summary>
    /// Gets the jump value
    /// </summary>
    public float JumpForce
    {
        get { return jumpForce; }
    }

    /// <summary>
    /// Gets the player bullet speed value
    /// </summary>
    public float PlayerBulletSpeed
    {
        get { return playerBulletSpeed; }
    }

    /// <summary>
    /// Gets the enemy bullet speed value
    /// </summary>
    public float EnemyBulletSpeed
    {
        get { return enemyBulletSpeed; }
    }

    /// <summary>
    /// Gets the player health value
    /// </summary>
    public int PlayerHealth
    {
        get { return playerHealth; }
    }

    /// <summary>
    /// Gets the player lives value
    /// </summary>
    public int PlayerLives
    {
        get { return playerLives; }
    }

    /// <summary>
    /// Gets the enemy health value
    /// </summary>
    public int EnemyHealth
    {
        get { return enemyHealth; }
    }

    /// <summary>
    /// Gets the player bullet damage value
    /// </summary>
    public int PlayerBulletDamage
    {
        get { return playerBulletDamage; }
    }

    /// <summary>
    /// Gets the enemy bullet damage value
    /// </summary>
    public int EnemyBulletDamage
    {
        get { return enemyBulletDamage; }
    }

    /// <summary>
    /// Gets the player fire cooldown value
    /// </summary>
    public float PlayerCooldownFire
    {
        get { return playerCooldownFire; }
    }

    /// <summary>
    /// Gets the shield effect duration value
    /// </summary>
    public float ShieldEffect
    {
        get { return shieldEffect; }
    }

    /// <summary>
    /// Gets the double damage duration value
    /// </summary>
    public float DoubleDamageEffect
    {
        get { return doubleDamageEffect; }
    }

    #endregion

    #region Constructor

    /// <summary>
    /// Constructor
    /// Reads configuration data from a file. If the file
    /// read fails, the object contains default values for
    /// the configuration data
    /// </summary>
    public ConfigurationData()
    {
        // read and save configuration data from file
        StreamReader input = null;
        try
        {
            // create stream reader object
            input = File.OpenText(Path.Combine(
                Application.streamingAssetsPath, ConfigurationDataFileName));

            // read in names and values
            string names = input.ReadLine();
            string values = input.ReadLine();

            // set configuration data fields
            SetConfigurationDataFields(values);
        }
        catch (Exception e)
        {
        }
        finally
        {
            // always close input file
            if (input != null)
            {
                input.Close();
            }
        }
    }

    #endregion

    /// <summary>
    /// Sets the configuration data fields from the provided
    /// csv string
    /// </summary>
    /// <param name="csvValues">csv string of values</param>
    void SetConfigurationDataFields(string csvValues)
    {
        // the code below assumes we know the order in which the values appear in the string.
        string[] values = csvValues.Split(',');
        playerMoveUnitsPerSecond = float.Parse(values[0]);
        jumpForce = float.Parse(values[1]);
        playerBulletSpeed = float.Parse(values[2]);
        enemyBulletSpeed = float.Parse(values[3]);
        playerHealth = int.Parse(values[4]);
        playerLives = int.Parse(values[5]);
        enemyHealth = int.Parse(values[6]);
        playerBulletDamage = int.Parse(values[7]);
        enemyBulletDamage = int.Parse(values[8]);
        playerCooldownFire = float.Parse(values[9]);
        shieldEffect = float.Parse(values[10]);
        doubleDamageEffect = float.Parse(values[11]);
    }
}
